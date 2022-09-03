using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalApp
{
    public partial class CarRentalApp : Form
    {
        List<CustomerModel> people = new List<CustomerModel>();
        List<CarModels> allCars = new List<CarModels>();
        List<RentCarModel> carCBIndexes = new List<RentCarModel>();
        List<RentCustomerModel> customerCBIndexes = new List<RentCustomerModel>();
        public CarRentalApp()
        {
            InitializeComponent();
            LoadCustomerList();
            LoadCarList();

            WireUpCarsList();
            WireUpCustomerList();
            WireCarComboBox();
            WireCustomerComboBox();
        }
        private void LoadCustomerList()
        {
            people = SqliteDataAccess.LoadCustomers();           
        }
        private void LoadCarList()
        {
            allCars = SqliteDataAccess.LoadCars();
        }
        private void WireUpCarsList()
        {
            listCarListBox.DataSource = null;
            listCarListBox.DataSource = allCars;
            listCarListBox.DisplayMember = "FullInfo";
        }
        private void WireUpCustomerList()
        {
            listCustomerListBox.DataSource = null;
            listCustomerListBox.DataSource = people;
            listCustomerListBox.DisplayMember = "FullInfo";
        }

        private void carAddButton_Click(object sender, EventArgs e)
        {
            CarModels c = new CarModels();
            c.CarModel = carModelTextBox.Text;
            c.Power = carPowerTextBox.Text;
            c.LicensePlate = carLicensePlateTextBox.Text;
            c.InRent = 0;

            SqliteDataAccess.SaveCar(c);

            carModelTextBox.Text = "";
            carPowerTextBox.Text = "";
            carLicensePlateTextBox.Text = "";

            LoadCarList();
            WireUpCarsList();
            WireCarComboBox();
        }

        private void customers_Click(object sender, EventArgs e)
        {
            LoadCustomerList();
            WireUpCustomerList();
        }

        private void cars_Click(object sender, EventArgs e)
        {
            LoadCarList();
            WireUpCarsList();
        }

        private void addCustomerButton_Click(object sender, EventArgs e)
        {
            CustomerModel c = new CustomerModel();
            c.FirstName = firstNameTextBox.Text;
            c.LastName = lastNameTextBox.Text;
            c.BirthDate = birthDateTextBox.Text;

            SqliteDataAccess.SaveCustomer(c);

            firstNameTextBox.Text = "";
            lastNameTextBox.Text = "";
            birthDateTextBox.Text = "";

            LoadCustomerList();
            WireUpCustomerList();
            WireCustomerComboBox();
        }
        private void WireCarComboBox()
        {
            foreach (var car in allCars)
            {
                if (car.InRent == 0 && !carListComboBox.Items.Contains(car.ShortInfo))
                {
                    RentCarModel c = new RentCarModel();
                    c.CarID = car.Id;
                    c.LicensePlate = car.LicensePlate;
                    c.CarCBIndex = carListComboBox.Items.Count;
                    c.cancelRent = "rent";

                    carListComboBox.Items.Add(car.ShortInfo);
                    carCBIndexes.Add(c);

                } else if (car.InRent == 1)
                {
                    RentCarModel c = new RentCarModel();
                    c.CarID = car.Id;
                    c.LicensePlate = car.LicensePlate;
                    c.cancelRent = "cancel";
                    carCBIndexes.Add(c);
                }
            }
        }
        private void WireCustomerComboBox()
        {
            foreach (var customer in people)
            {
                if (customer.CurrentCar == null && !customerListComboBox.Items.Contains(customer.ShortInfo))
                {
                    RentCustomerModel c = new RentCustomerModel();
                    c.CustomerID = customer.Id;
                    c.CustomerCBIndex = customerListComboBox.Items.Count;
                    c.cancelRent = "rent";
                    c.CustomerLP = customer.CurrentCar;

                    customerListComboBox.Items.Add(customer.ShortInfo);
                    customerCBIndexes.Add(c);
                } else if (customer.CurrentCar != null && !activeCustomersComboBox.Items.Contains(customer.ShortInfo))
                {
                    RentCustomerModel c = new RentCustomerModel();
                    c.CustomerID = customer.Id;
                    c.CustomerCBIndex = activeCustomersComboBox.Items.Count;
                    c.cancelRent = "cancel";
                    c.CustomerLP = customer.CurrentCar;

                    activeCustomersComboBox.Items.Add(customer.ShortInfo);
                    customerCBIndexes.Add(c);
                }
            }
        }
        private void rentCar_Click(object sender, EventArgs e)
        {
            LoadCarList();
            LoadCustomerList();

            WireCarComboBox();
            WireCustomerComboBox();
        }

        private void rentThisCar_Click(object sender, EventArgs e)
        {
            int customerID = 0;
            int carID = 0;
            string carLP = "";

            foreach (var item in customerCBIndexes)
            {
                if(item.CustomerCBIndex == customerListComboBox.SelectedIndex && item.cancelRent == "rent")
                {
                    customerID = item.CustomerID;
                }
            }

            foreach (var item in carCBIndexes)
            {
                if (item.CarCBIndex == carListComboBox.SelectedIndex && item.cancelRent == "rent")
                {
                    carID = item.CarID;
                    carLP = item.LicensePlate;
                }
            }

            if (carID != 0 && customerID != 0)
            {
                SqliteDataAccess.UpdateCar(carID, "rent");
                SqliteDataAccess.UpdateCustomer(customerID, carLP, "rent");

                people.Clear();
                allCars.Clear();

                carListComboBox.Items.Clear();
                carListComboBox.ResetText();

                customerListComboBox.Items.Clear();
                customerListComboBox.ResetText();

                LoadCustomerList();
                LoadCarList();

                WireCarComboBox();
                WireCustomerComboBox();
                WireUpCarsList();
                WireUpCustomerList();
            } else
            {
                MessageBox.Show("Proszę uzupełnić oba parametry");
            }
        }

        private void cancelRent_Click(object sender, EventArgs e)
        {
            int customerID = 0;
            int carID = 0;
            string carLP = "";
            string customerLP = "";

            foreach (var item in customerCBIndexes)
            {
                if (item.CustomerCBIndex == activeCustomersComboBox.SelectedIndex && item.cancelRent == "cancel")
                {
                    customerID = item.CustomerID;
                    customerLP = item.CustomerLP;
                }
            }

            foreach (var item in carCBIndexes)
            {
                if (item.cancelRent == "cancel" && customerLP == item.LicensePlate)
                {
                    carID = item.CarID;
                    carLP = item.LicensePlate;
                }
            }

            SqliteDataAccess.UpdateCar(carID, "free");
            SqliteDataAccess.UpdateCustomer(customerID, carLP, "free");


            activeCustomersComboBox.Items.Clear();           
            activeCustomersComboBox.ResetText();

            people.Clear();
            allCars.Clear();

            LoadCustomerList();
            LoadCarList();

            WireCarComboBox();
            WireCustomerComboBox();
            WireUpCarsList();
            WireUpCustomerList();
        }
    }
}
