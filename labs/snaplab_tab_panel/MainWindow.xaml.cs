using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace snaplab_tab_panel
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Customer> customers;
        List<Product> products;
        List<Region> regions;

        Customer customer;
        Customer customerFound;
        Product product;
        Region region;

        public MainWindow()
        {
            InitializeComponent();
            Initialise();
        }

        void Initialise()
        {
            using (var db = new NorthwindEntities())
            {
                customers = db.Customers.ToList();
                products = db.Products.ToList();
                regions = db.Regions.ToList();
            }
            //ListBoxCustomers.DisplayMemberPath = "ContactName";
            //ListBoxCustomers.ItemsSource = customers;
            Customers.ItemsSource = customers;
            
            //Products.DisplayMemberPath = "ProductName";
            Products.ItemsSource = products;

            Regions.DisplayMemberPath = "RegionDescription";
            Regions.ItemsSource = regions;

            ListViewCustomers.ItemsSource = customers;
        }

        // customer = db.Customers.Find("ALFKI")
        // customer = db.Customers.Find(selectedCustomer.CustomerID)

            // On selected item change (list box)
            // cuustomer = (Customer) sender
        private void Search_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            if (Customer.IsChecked == true)
            {
                // SearchButton.Is;
            }
            foreach(var cust in customers)
            {
                if (!String.IsNullOrWhiteSpace(Search.Text))
                {
                    using (var db = new NorthwindEntities())
                    {
                        SqlConnection sqlCon = new SqlConnection();
                        customerFound = db.Customers.Find(cust.ContactName);
                    }
                    //ShowCustomer.Items.Insert(0, " ");
                    //ShowCustomer.Items.Insert(0, $"{customerFound.CustomerID,-10}, {customerFound.ContactName,-10}, {customerFound.City}");
                    //ShowCustomer.Items.Insert(0, " ");
                }
            }
            
        }
    }
}
