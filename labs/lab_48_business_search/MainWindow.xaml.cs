using System;
using System.Collections.Generic;
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

namespace lab_48_business_search
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Customer> customers;
        List<Product> products;
        List<decimal?> prices;
        List<Customer> customerFound;
        List<Product> productFound;
        List<String> countries;

        EventHandler listBoxItems;
        bool listBoxLayoutUpdate = true;

        Customer customer;
        Product product;

        public MainWindow()
        {
            InitializeComponent();
            Initialise();
            //listBoxItems = new EventHandler(listBoxItems_Rearranged);

        }

        void Initialise()
        {
            using (var db = new NorthwindEntities())
            {
                customers = db.Customers.ToList();
                products = db.Products.ToList();
                countries = (from c in db.Customers select c.Country).Distinct().ToList();
                prices = (from p in db.Products select p.UnitPrice).ToList();
            }
            Customers.DisplayMemberPath = "ContactName";
            //ListBoxCustomers.ItemsSource = customers;
            Customers.ItemsSource = customers;

            Products.DisplayMemberPath = "ProductName";
            Products.ItemsSource = products;

            CountryBox.ItemsSource = countries;
        }

        private void Search_KeyUp(object sender, KeyEventArgs e)
        {
            
        } 

        private void Search_IsMouseDirectlyOverChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            //int index = 0;
            //string temp = Search.Text;
            Search.Text = " ";
            /*Search.Text = temp;
            while (index < Search.Text.LastIndexOf(Customers.Items.ToString()))
            {
                Search.SelectionBrush = Brushes.Aqua;
            }*/
        }

        private void Search_TextChanged(object sender, TextChangedEventArgs e)
        {
            
            using (var db = new NorthwindEntities())
            {
                // Find customer from database
                customerFound = db.Customers.Where(c => c.ContactName.Contains(Search.Text)).ToList();
            }
            Customers.ItemsSource = null;
            Customers.ItemsSource = customerFound;
            
        }

        private void CountryBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var country = CountryBox.SelectedItem;
            //MessageBox.Show($"You chose this country {country}");
            using (var db = new NorthwindEntities())
            {
                customerFound = db.Customers.Where(c => c.Country == country.ToString()).ToList();
            }
            Customers.ItemsSource = null;
            Customers.ItemsSource = customerFound;
        }

        private void PriceRange_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            var price = PriceRange.Value;

            decimal? priceMin = (decimal?)PriceRange.Minimum;
            decimal? priceMax = (decimal?)PriceRange.Maximum;

            // MessageBox.Show($"You chose this country {price}");
            using (var db = new NorthwindEntities())
            {
                productFound = db.Products.Where(p => p.UnitPrice > priceMin).ToList();
            }
            Customers.ItemsSource = null;
            Customers.ItemsSource = customerFound;
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            if (ProductTab.IsSelected)
            {
                using (var db = new NorthwindEntities())
                {
                    productFound = db.Products.Where(p => p.ProductName.Contains(Search.Text)).ToList();
                }
                //Products.ItemsSource = null;
                //listBoxLayoutUpdate = true;
                //Products.LayoutUpdated -= new EventHandler(listBoxItems);
                //Products.LayoutUpdated += new EventHandler(listBoxItems);

                Products.ItemsSource = productFound;
            }
        }
    }
}
