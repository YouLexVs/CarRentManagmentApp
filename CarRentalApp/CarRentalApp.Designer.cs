
namespace CarRentalApp
{
    partial class CarRentalApp
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainTabs = new System.Windows.Forms.TabControl();
            this.customers = new System.Windows.Forms.TabPage();
            this.addCustomerButton = new System.Windows.Forms.Button();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.birthDateTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listCustomerListBox = new System.Windows.Forms.ListBox();
            this.cars = new System.Windows.Forms.TabPage();
            this.carAddButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.carPowerTextBox = new System.Windows.Forms.TextBox();
            this.carModelTextBox = new System.Windows.Forms.TextBox();
            this.carLicensePlateTextBox = new System.Windows.Forms.TextBox();
            this.listCarListBox = new System.Windows.Forms.ListBox();
            this.rentCar = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.cancelRent = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.activeCustomersComboBox = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.rentThisCar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.carListComboBox = new System.Windows.Forms.ComboBox();
            this.customerListComboBox = new System.Windows.Forms.ComboBox();
            this.mainTabs.SuspendLayout();
            this.customers.SuspendLayout();
            this.cars.SuspendLayout();
            this.rentCar.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTabs
            // 
            this.mainTabs.Controls.Add(this.customers);
            this.mainTabs.Controls.Add(this.cars);
            this.mainTabs.Controls.Add(this.rentCar);
            this.mainTabs.Location = new System.Drawing.Point(9, 10);
            this.mainTabs.Margin = new System.Windows.Forms.Padding(2);
            this.mainTabs.Name = "mainTabs";
            this.mainTabs.SelectedIndex = 0;
            this.mainTabs.Size = new System.Drawing.Size(582, 346);
            this.mainTabs.TabIndex = 0;
            // 
            // customers
            // 
            this.customers.Controls.Add(this.addCustomerButton);
            this.customers.Controls.Add(this.lastNameTextBox);
            this.customers.Controls.Add(this.birthDateTextBox);
            this.customers.Controls.Add(this.firstNameTextBox);
            this.customers.Controls.Add(this.label6);
            this.customers.Controls.Add(this.label5);
            this.customers.Controls.Add(this.label4);
            this.customers.Controls.Add(this.listCustomerListBox);
            this.customers.Location = new System.Drawing.Point(4, 22);
            this.customers.Margin = new System.Windows.Forms.Padding(2);
            this.customers.Name = "customers";
            this.customers.Padding = new System.Windows.Forms.Padding(2);
            this.customers.Size = new System.Drawing.Size(574, 320);
            this.customers.TabIndex = 0;
            this.customers.Text = "Klienci";
            this.customers.UseVisualStyleBackColor = true;
            this.customers.Click += new System.EventHandler(this.customers_Click);
            // 
            // addCustomerButton
            // 
            this.addCustomerButton.Location = new System.Drawing.Point(360, 248);
            this.addCustomerButton.Name = "addCustomerButton";
            this.addCustomerButton.Size = new System.Drawing.Size(209, 68);
            this.addCustomerButton.TabIndex = 9;
            this.addCustomerButton.Text = "Dodaj klienta";
            this.addCustomerButton.UseVisualStyleBackColor = true;
            this.addCustomerButton.Click += new System.EventHandler(this.addCustomerButton_Click);
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(169, 272);
            this.lastNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(186, 20);
            this.lastNameTextBox.TabIndex = 7;
            // 
            // birthDateTextBox
            // 
            this.birthDateTextBox.Location = new System.Drawing.Point(169, 296);
            this.birthDateTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.birthDateTextBox.Name = "birthDateTextBox";
            this.birthDateTextBox.Size = new System.Drawing.Size(186, 20);
            this.birthDateTextBox.TabIndex = 8;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(169, 248);
            this.firstNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(186, 20);
            this.firstNameTextBox.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 299);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Data Urodzenia (YYYY-MM-DD):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(106, 275);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nazwisko: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(133, 251);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Imię: ";
            // 
            // listCustomerListBox
            // 
            this.listCustomerListBox.FormattingEnabled = true;
            this.listCustomerListBox.Location = new System.Drawing.Point(3, 5);
            this.listCustomerListBox.Name = "listCustomerListBox";
            this.listCustomerListBox.Size = new System.Drawing.Size(569, 238);
            this.listCustomerListBox.TabIndex = 2;
            // 
            // cars
            // 
            this.cars.Controls.Add(this.carAddButton);
            this.cars.Controls.Add(this.label3);
            this.cars.Controls.Add(this.label2);
            this.cars.Controls.Add(this.label1);
            this.cars.Controls.Add(this.carPowerTextBox);
            this.cars.Controls.Add(this.carModelTextBox);
            this.cars.Controls.Add(this.carLicensePlateTextBox);
            this.cars.Controls.Add(this.listCarListBox);
            this.cars.Location = new System.Drawing.Point(4, 22);
            this.cars.Margin = new System.Windows.Forms.Padding(2);
            this.cars.Name = "cars";
            this.cars.Padding = new System.Windows.Forms.Padding(2);
            this.cars.Size = new System.Drawing.Size(574, 320);
            this.cars.TabIndex = 1;
            this.cars.Text = "Samochody";
            this.cars.UseVisualStyleBackColor = true;
            this.cars.Click += new System.EventHandler(this.cars_Click);
            // 
            // carAddButton
            // 
            this.carAddButton.Location = new System.Drawing.Point(365, 247);
            this.carAddButton.Name = "carAddButton";
            this.carAddButton.Size = new System.Drawing.Size(204, 69);
            this.carAddButton.TabIndex = 8;
            this.carAddButton.Text = "Dodaj samochód";
            this.carAddButton.UseVisualStyleBackColor = true;
            this.carAddButton.Click += new System.EventHandler(this.carAddButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 275);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Moc samochodu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 299);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tablica rejestracyjna";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 251);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Model samochodu";
            // 
            // carPowerTextBox
            // 
            this.carPowerTextBox.Location = new System.Drawing.Point(113, 272);
            this.carPowerTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.carPowerTextBox.Name = "carPowerTextBox";
            this.carPowerTextBox.Size = new System.Drawing.Size(247, 20);
            this.carPowerTextBox.TabIndex = 3;
            // 
            // carModelTextBox
            // 
            this.carModelTextBox.Location = new System.Drawing.Point(113, 248);
            this.carModelTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.carModelTextBox.Name = "carModelTextBox";
            this.carModelTextBox.Size = new System.Drawing.Size(247, 20);
            this.carModelTextBox.TabIndex = 2;
            // 
            // carLicensePlateTextBox
            // 
            this.carLicensePlateTextBox.Location = new System.Drawing.Point(113, 296);
            this.carLicensePlateTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.carLicensePlateTextBox.Name = "carLicensePlateTextBox";
            this.carLicensePlateTextBox.Size = new System.Drawing.Size(247, 20);
            this.carLicensePlateTextBox.TabIndex = 1;
            // 
            // listCarListBox
            // 
            this.listCarListBox.FormattingEnabled = true;
            this.listCarListBox.Location = new System.Drawing.Point(4, 4);
            this.listCarListBox.Margin = new System.Windows.Forms.Padding(2);
            this.listCarListBox.Name = "listCarListBox";
            this.listCarListBox.Size = new System.Drawing.Size(565, 238);
            this.listCarListBox.TabIndex = 0;
            // 
            // rentCar
            // 
            this.rentCar.Controls.Add(this.label10);
            this.rentCar.Controls.Add(this.cancelRent);
            this.rentCar.Controls.Add(this.label12);
            this.rentCar.Controls.Add(this.activeCustomersComboBox);
            this.rentCar.Controls.Add(this.label9);
            this.rentCar.Controls.Add(this.rentThisCar);
            this.rentCar.Controls.Add(this.label8);
            this.rentCar.Controls.Add(this.label7);
            this.rentCar.Controls.Add(this.carListComboBox);
            this.rentCar.Controls.Add(this.customerListComboBox);
            this.rentCar.Location = new System.Drawing.Point(4, 22);
            this.rentCar.Name = "rentCar";
            this.rentCar.Size = new System.Drawing.Size(574, 320);
            this.rentCar.TabIndex = 2;
            this.rentCar.Text = "Wypożycz";
            this.rentCar.UseVisualStyleBackColor = true;
            this.rentCar.Click += new System.EventHandler(this.rentCar_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(259, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Usuń wypożyczenie";
            // 
            // cancelRent
            // 
            this.cancelRent.Location = new System.Drawing.Point(262, 136);
            this.cancelRent.Name = "cancelRent";
            this.cancelRent.Size = new System.Drawing.Size(219, 32);
            this.cancelRent.TabIndex = 10;
            this.cancelRent.Text = "Anuluj wynajem";
            this.cancelRent.UseVisualStyleBackColor = true;
            this.cancelRent.Click += new System.EventHandler(this.cancelRent_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(259, 40);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(183, 13);
            this.label12.TabIndex = 8;
            this.label12.Text = "Lista klientów z naszym samochodem";
            // 
            // activeCustomersComboBox
            // 
            this.activeCustomersComboBox.FormattingEnabled = true;
            this.activeCustomersComboBox.Location = new System.Drawing.Point(262, 56);
            this.activeCustomersComboBox.Name = "activeCustomersComboBox";
            this.activeCustomersComboBox.Size = new System.Drawing.Size(219, 21);
            this.activeCustomersComboBox.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Wypożycz pojazd";
            // 
            // rentThisCar
            // 
            this.rentThisCar.Location = new System.Drawing.Point(6, 136);
            this.rentThisCar.Name = "rentThisCar";
            this.rentThisCar.Size = new System.Drawing.Size(219, 32);
            this.rentThisCar.TabIndex = 4;
            this.rentThisCar.Text = "Wypożycz!";
            this.rentThisCar.UseVisualStyleBackColor = true;
            this.rentThisCar.Click += new System.EventHandler(this.rentThisCar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Wybierz samochód";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Wybierz klienta";
            // 
            // carListComboBox
            // 
            this.carListComboBox.FormattingEnabled = true;
            this.carListComboBox.Location = new System.Drawing.Point(6, 105);
            this.carListComboBox.Name = "carListComboBox";
            this.carListComboBox.Size = new System.Drawing.Size(219, 21);
            this.carListComboBox.TabIndex = 1;
            // 
            // customerListComboBox
            // 
            this.customerListComboBox.FormattingEnabled = true;
            this.customerListComboBox.Location = new System.Drawing.Point(6, 56);
            this.customerListComboBox.Name = "customerListComboBox";
            this.customerListComboBox.Size = new System.Drawing.Size(219, 21);
            this.customerListComboBox.TabIndex = 0;
            // 
            // CarRentalApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.mainTabs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "CarRentalApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wypożyczalnia samochodów";
            this.mainTabs.ResumeLayout(false);
            this.customers.ResumeLayout(false);
            this.customers.PerformLayout();
            this.cars.ResumeLayout(false);
            this.cars.PerformLayout();
            this.rentCar.ResumeLayout(false);
            this.rentCar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl mainTabs;
        private System.Windows.Forms.TabPage customers;
        private System.Windows.Forms.TabPage cars;
        private System.Windows.Forms.ListBox listCustomerListBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox carPowerTextBox;
        private System.Windows.Forms.TextBox carModelTextBox;
        private System.Windows.Forms.TextBox carLicensePlateTextBox;
        private System.Windows.Forms.ListBox listCarListBox;
        private System.Windows.Forms.Button carAddButton;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox birthDateTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button addCustomerButton;
        private System.Windows.Forms.TabPage rentCar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox carListComboBox;
        private System.Windows.Forms.ComboBox customerListComboBox;
        private System.Windows.Forms.Button rentThisCar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button cancelRent;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox activeCustomersComboBox;
        private System.Windows.Forms.Label label9;
    }
}

