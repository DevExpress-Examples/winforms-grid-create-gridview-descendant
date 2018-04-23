using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MyXtraGrid {
    public partial class Form1 : Form {
        BindingList<Customer> customers;
        public Form1() {
            InitializeComponent();
            FillGridDataSource();
        }

        private void FillGridDataSource()
        {
            customers = new BindingList<Customer>();
            for (int i = 0; i < 50; i++)
            {
                Customer customer = new Customer();
                customer.Name = "Mike";
                if (i % 2 == 0)
                    customer.Name = "John";                
                customer.Age = 70 - i;
                customer.Weight = 50 + i;
                customer.Height = 150 + i;
                customers.Add(customer);
            }
            myGridControl1.DataSource = customers;
        }
    }
}