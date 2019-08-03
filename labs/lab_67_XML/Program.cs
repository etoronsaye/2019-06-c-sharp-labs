using System;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace lab_67_XML
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First XML Example");
            var xml01 = new XElement("testData", 1);
            Console.WriteLine(xml01);

            Console.WriteLine("\n\n=== Add Sub-Element ===\n");
            var xml02 = new XElement("XMLRoot", new XElement("XMLData",100));
            Console.WriteLine(xml02);

            Console.WriteLine("\n\n=== Multiple Elements + Save as File  ===\n");
            var xml03 = new XElement("XMLRoot",
                new XElement("XMLData", 100),
                new XElement("XMLData", 200),
                new XElement("XMLData", 300),
                new XElement("XMLData", 400));
            Console.WriteLine(xml03);
            // Write to XML Document
            var doc03 = new XDocument(xml03);
            doc03.Save("doc03.xml");
            Console.WriteLine(File.ReadAllText("doc03.xml"));

            // ELement is the <TAG>
            // Attribute is VALUE INSIDE TAG
            // <TAG item=500>
            Console.WriteLine("\n\n=== Add Attributes ===\n");
            var xml04 = new XElement("XMLRoot",
                new XElement("XMLData", new XAttribute("height", 300), 100),
                new XElement("XMLData", new XAttribute("height", 400), 200),
                new XElement("XMLData", new XAttribute("height", 500), 300),
                new XElement("XMLData", new XAttribute("height", 600), 400));
            Console.WriteLine(xml04);
            var doc04 = new XDocument(xml04);
            doc04.Save("doc04.xml");
            // Think of your data in EXcel spreadsheet
            // XMLRoot is name of SHEET
            // XMLAttribute is the name of a field with the value
            // XMLData is individual entry in database

            Console.WriteLine("\n\n=== Revison ===\n");
            // Create 'Products' root XML
            // Have 2 'Product' items Populate with ProductID, ProductName, CategoryID, UnitPRice
            var xmlProd = new XElement("Products",
                new XElement("Product",
                    new XElement("ProductID", 1),
                    new XElement("ProductName", "Chai"),
                    new XElement("UnitPrice", 18.00)
                ),
                new XElement("Product",
                    new XElement("ProductID", 2),
                    new XElement("ProductName", "Chang"),
                    new XElement("UnitPrice", 19.00)
                ));//,
                //new XElement("Product", new XAttribute("ProductID", 2), new XAttribute("ProductName", "Chang"), new XAttribute("UnitPrice", 19), "Chang"));
            Console.WriteLine(xmlProd);
            var doc05 = new XDocument(xmlProd);
            doc05.Save("doc05.xml");

            // DESCENDANTS
            Console.WriteLine("\n\n====Playing with Descendants===\n");
            XDocument doc = XDocument.Load("doc04.xml");
            var xmlProdList = xmlProd.Descendants("Product").Select(node => new
                { ProductID = node.Element("ProductID").Value,
                  ProductName = node.Element("ProductName").Value,
                  UnitPrice = node.Element("UnitPrice").Value }).ToArray();
            foreach (var item in xmlProdList)
            {
                Console.WriteLine($"{item.ProductID} has value {item.ProductName}{item.UnitPrice}");
            }

            // USING LINQ
            foreach (var i in doc.Descendants("XMLRoot"))
            {
                Console.WriteLine($"{i.Value}\n");
                Console.WriteLine("Value \t Attributes");
                foreach (var j in i.Descendants("XMLData"))
                {
                    Console.WriteLine($"{j.Value}");
                    Console.WriteLine($"\t{j.Attribute("height").Value}\n");
                }
            }


            

            Console.WriteLine("\n\n===  ===\n");
            Console.WriteLine("\n\n===  ===\n");
            Console.WriteLine("\n\n===  ===\n");
            Console.WriteLine("\n\n===  ===\n");
            Console.WriteLine("\n\n===  ===\n");
            Console.WriteLine("\n\n===  ===\n");
        }
    }
}
