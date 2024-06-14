using BuisnesEntityLayer.Entities;
using BuisnesLogicLayer.view;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Utility;

namespace UI
{
    public partial class CreateOrder : Form
    {
        private List<OrderDetails> _orderDetailsList;
        public CreateOrder()
        {
            InitializeComponent();
            _orderDetailsList = new List<OrderDetails>();
        }

        PersonBLL personBLL = new PersonBLL();


        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void CreateFactorForm_Load(object sender, EventArgs e)
        {

            List<Person> people = personBLL.GetAll();
            foreach (var item in people)
            {
                comboBox1.Items.Add(item.Name);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
           
            dataGridView1.DataSource = UtilityOne.utilityViewsForDataGrid;
            MessageBox.Show(UtilityOne.utilityViewsForDataGrid.SingleOrDefault().ProductName);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Person> people = personBLL.GetAll();
            foreach (var item in people)
            {
                if (item.Name == comboBox1.Text)
                {
                    MessageBox.Show(item.Id.ToString());
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //CreateOrderDetails form3 = new CreateOrderDetails();
            //form3.Show();
            using (var form = new CreateOrderDetails(_orderDetailsList))
            {
                form.ShowDialog();
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = _orderDetailsList;
            }
        }
    }
}
