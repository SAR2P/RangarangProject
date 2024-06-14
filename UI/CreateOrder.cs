using BuisnesEntityLayer.Entities;
using BuisnesLogicLayer.Product;
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
        private List<AddProductViewModel> _orderDetailsList;
        public CreateOrder()
        {
            InitializeComponent();
            _orderDetailsList = new List<AddProductViewModel>();
        }

        PersonBLL personBLL = new PersonBLL();
        OrderBLL orderBLL = new OrderBLL();
        OrderDetailsBLL detailsBLL = new OrderDetailsBLL();

        private Person _Person = new Person();

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(orderBLL.GetNewNumberForOrder().ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                var newNum = orderBLL.GetNewNumberForOrder();

                Order order = new Order()
                {
                    PersonId = _Person.Id,
                    Date = dateTimePicker1.Value,
                    Number = newNum,

                };

                if (orderBLL.CreateOrder(order))
                {
                    var orderI = orderBLL.getOrederIdByNumber(order.Number);
                    foreach (var item in _orderDetailsList)
                    {
                        OrderDetails details = new OrderDetails()
                        {
                            ProductEId = item.ProductId,
                            Count = item.Count,
                            Price = item.OneProductPrice,
                            OrderId = orderI,
                            SumPrice = item.Price
                        };
                        detailsBLL.createOrderDetails(details);
                    }
                }

                MessageBox.Show("success");
            }
            catch (Exception)
            {
                MessageBox.Show("error ocurd");
            }
            
        }

        private void CreateFactorForm_Load(object sender, EventArgs e)
        {

            List<Person> people = personBLL.GetAll();
            foreach (var item in people)
            {
                comboBox1.Items.Add(item.Name);
            }
        }

        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Person> people = personBLL.GetAll();
            foreach (var item in people)
            {
                if (item.Name == comboBox1.Text)
                {
                    _Person = item;
                    MessageBox.Show(_Person.Id.ToString());
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            using (var form = new CreateOrderDetails(_orderDetailsList))
            {
                form.ShowDialog();
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = _orderDetailsList;//add to datagrid
            }
        }
    }
}
