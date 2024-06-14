using BuisnesEntityLayer.Entities;
using BuisnesLogicLayer.Product;
using BuisnesLogicLayer.view;
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
    public partial class CreateOrderDetails : Form
    {
        private List<AddProductViewModel> _orderDetailsList;
        public CreateOrderDetails(List<AddProductViewModel> orderDetailsList)
        {
            InitializeComponent();
            _orderDetailsList = orderDetailsList;
        }

        AddProductViewModel PviewModel = new AddProductViewModel();

        ProductBLL productBLL = new ProductBLL();

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var s = comboBox1.SelectedItem;

            var products = productBLL.GetAll();

            foreach (var product in products)
            {
                if (product.Name == s)
                {

                    PviewModel.ProductId = product.Id;
                    PviewModel.ProductName = product.Name;
                    PviewModel.OneProductPrice = product.Price;
                    PviewModel.Price= product.Price;
                    PviewModel.Count = (int)numericUpDown1.Value;
                    textBox1.Text = product.Price.ToString();
                    textBox2.Text = product.Price.ToString();
                }
            }

            MessageBox.Show(s.ToString());

        }
      
        private void AddProductToFactorForm_Load(object sender, EventArgs e)
        {
            var products = productBLL.GetAll();

            foreach (var product in products)
            {
                comboBox1.Items.Add(product.Name);
            }


        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

            PviewModel.Price = PviewModel.OneProductPrice * (int)numericUpDown1.Value;
            PviewModel.Count = (int)numericUpDown1.Value;
            textBox2.Text = PviewModel.Price.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            _orderDetailsList.Add(PviewModel);

            MessageBox.Show(_orderDetailsList.FirstOrDefault().ProductName);
            this.Close();
        }
    }
}
