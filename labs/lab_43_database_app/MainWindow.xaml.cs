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

namespace lab_43_database_app
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Customer> customers;
        Customer customer;
        public int listID;
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
            //ListBoxCostumers.DisplayMemberPath = "ContactName";
            ListBoxCostumers.ItemsSource = customers;
        }

        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {
            customer = (Customer)ListBoxCostumers.SelectedItem;
            // if content = Clear then clear all textboxes out and set the content back to 'add'
            if (ButtonAdd.Content == "Clear")
            {
                TextBoxID.Text = "";
                TextBoxName.Text = "";
                TextBoxCompany.Text = "";
                TextBoxCity.Text = "";
                TextBoxCountry.Text = "";
                ButtonAdd.Content = "Add";
            }
            else if (TextBoxID != null && TextBoxCompany != null)
            {
                using (var db = new NorthwindEntities())
                {
                    var newCustomer = new Customer() { };
                    newCustomer.CustomerID = TextBoxID.Text;
                    newCustomer.ContactName = TextBoxName.Text;
                    newCustomer.CompanyName = TextBoxCompany.Text;
                    newCustomer.City = TextBoxCity.Text;
                    newCustomer.Country = TextBoxCountry.Text;

                    // unbind listbox
                    ListBoxCostumers.ItemsSource = null;
                    customers.Insert(0, newCustomer);
                    ListBoxCostumers.ItemsSource = customers;
                    db.SaveChanges();
                    customers = db.Customers.ToList();
                    
                }
                
            }

            /*using (var db = new NorthwindEntities())
            {
                customers = db.Customers.ToList();
                db.SaveChanges();
            }*/
        }

        private void ButtonEdit_Click(object sender, RoutedEventArgs e)
        {
            customer = (Customer)ListBoxCostumers.SelectedItem;
            if (ButtonEdit.Content.ToString() == "Edit")
            {               
                TextBoxID.IsEnabled = true;
                TextBoxName.IsEnabled = true;
                TextBoxCompany.IsEnabled = true;
                TextBoxCity.IsEnabled = true;
                TextBoxCountry.IsEnabled = true;
                TextBoxID.Background = Brushes.White;
                TextBoxName.Background = Brushes.White;
                TextBoxCompany.Background = Brushes.White;
                TextBoxCity.Background = Brushes.White;
                TextBoxCountry.Background = Brushes.White;
                ButtonEdit.Content = "Save";
            }
            else if(ButtonEdit.Content.ToString() == "Save")
            {
                if (customer != null)
                {
                    using (var db = new NorthwindEntities())
                    {
                        var customerToEdit = db.Customers.Where(c => c.CustomerID == customer.CustomerID).FirstOrDefault();
                        MessageBox.Show($"customer ready to edit {customerToEdit}");
                        customerToEdit.ContactName = TextBoxName.Text;
                        customerToEdit.CompanyName = TextBoxCompany.Text;
                        customerToEdit.City = TextBoxCity.Text;
                        customerToEdit.Country = TextBoxCountry.Text;
                        db.SaveChanges();
                        // refresh list
                        ListBoxCostumers.ItemsSource = null;     // disconnet listbox from formal customer list because we are about to change it
                        customers = db.Customers.ToList();
                        ListBoxCostumers.ItemsSource = customers;
                    }  
                }
                //MessageBox.Show($"about to commit changes");
            }      
        }

        private void ButtonDelete_Click(object sender, RoutedEventArgs e)
        {
            customer = (Customer)ListBoxCostumers.SelectedItem;
            if (ButtonDelete.Content.ToString() == "Delete")
            {
                if (customer == null)
                {
                    MessageBox.Show("no customer selected");
                    return;
                }
                ButtonDelete.Content = "Confirm";
                ButtonDelete.Background = Brushes.Red; 
            }
            else if(ButtonDelete.Content.ToString() == "Confirm")
            {
                // find record by ID and delete it
                using (var db = new NorthwindEntities())
                {
                    var customerToDelete = db.Customers.Find(customer.CustomerID);
                    db.Customers.Remove(customerToDelete);
                    db.SaveChanges();
                    // refresh
                    ListBoxCostumers.ItemsSource = null;     // disconnet listbox from formal customer list because we are about to change it
                    customers = db.Customers.ToList();
                    ListBoxCostumers.ItemsSource = customers;
                }

            }
        }

        private void ListBoxCostumers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ButtonAdd.Content = "Clear";

            customer = (Customer)ListBoxCostumers.SelectedItem;
            if (customer != null)
            {
                ListBoxLog.Items.Insert(0, " ");
                ListBoxLog.Items.Insert(0, DateTime.Now);
                ListBoxLog.Items.Insert(0, "Customer Selected");
                ListBoxLog.Items.Insert(0, $"{customer.CustomerID, -7}, {customer.ContactName} from {customer.City}");

                // fill text boxes
                TextBoxID.Text = customer.CustomerID;
                TextBoxName.Text = customer.ContactName;
                TextBoxCompany.Text = customer.CompanyName;
                TextBoxCity.Text = customer.City;
                TextBoxCountry.Text = customer.Country;
            }

            // set to read only
            TextBoxID.IsEnabled = false;
            TextBoxName.IsEnabled = false;
            TextBoxCompany.IsEnabled = false;
            TextBoxCity.IsEnabled = false;
            TextBoxCountry.IsEnabled = false;
        }
    }
}
