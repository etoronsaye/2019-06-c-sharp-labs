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
using MahApps.Metro.Controls;

namespace snap_lab_WPF_CRUD
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        List<Customer> customers;
        Customer customer;

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
            }
            CustomerList.DisplayMemberPath = "ContactName";
            CustomerList.ItemsSource = customers;
            //Customers.ItemsSource = customers;
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            var newCustomer = new Customer()
            {
               CustomerID = NewTextBoxID.Text,
               ContactName = NewTextBoxName.Text,
               CompanyName = NewTextBoxCompany.Text,
               City = NewTextBoxCity.Text,
               Country = NewTextBoxCountry.Text,
            };

            using (var db = new NorthwindEntities())
            {
                db.Customers.Add(newCustomer);
                // unbind listbox
                CustomerList.ItemsSource = null;
                customers.Insert(0, newCustomer);
                CustomerList.ItemsSource = customers;
                db.SaveChanges();
                MessageBox.Show($"New Customer Added");
                customers = db.Customers.ToList();

            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            customer = (Customer)CustomerList.SelectedItem;
            if (customer != null)
            {
                using (var db = new NorthwindEntities())
                {
                    var customerUpdate = db.Customers.Find(customer.CustomerID);
                    customerUpdate.ContactName = TextBoxName.Text;
                    customerUpdate.CompanyName = TextBoxCompany.Text;
                    customerUpdate.City = TextBoxCity.Text;
                    customerUpdate.Country = TextBoxCountry.Text;
                    db.SaveChanges();
                    MessageBox.Show($"Updated");
                    CustomerList.ItemsSource = null;     // disconnet listbox from formal customer list because we are about to change it
                    customers = db.Customers.ToList();
                    CustomerList.ItemsSource = customers;
                }
            }  
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            customer = (Customer)CustomerList.SelectedItem;
            if (customer == null)
            {
                MessageBox.Show("no customer selected");
                
            }
            else if(customer != null)
            {
                using (var db = new NorthwindEntities())
                {
                    var customerToDelete = db.Customers.Find(customer.CustomerID);
                    db.Customers.Remove(customerToDelete);
                    db.SaveChanges();
                    MessageBox.Show($"Deleted");
                    CustomerList.ItemsSource = null;     // disconnet listbox from formal customer list because we are about to change it
                    customers = db.Customers.ToList();
                    CustomerList.ItemsSource = customers;
                }
            }
        }

        private void CustomerList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
            customer = (Customer)CustomerList.SelectedItem;
            if (customer != null)
            {
                TextBoxID.Text = customer.CustomerID;
                TextBoxName.Text = customer.ContactName;
                TextBoxCompany.Text = customer.CompanyName;
                TextBoxCity.Text = customer.City;
                TextBoxCountry.Text = customer.Country;

                Flydata.IsOpen = true;

            }
        }

        
    }
}
