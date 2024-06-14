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
        private List<OrderDetails> _orderDetailsList;
        public CreateOrderDetails(List<OrderDetails> orderDetailsList)
        {
            InitializeComponent();
            _orderDetailsList = orderDetailsList;
        }

        AddProductViewModel PviewModel = new AddProductViewModel();

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var s = comboBox1.SelectedItem;

            foreach (var product in UtilityOne.utilityProduct)
            {
                if (product.Name == s)
                {

                    PviewModel.ProductId = product.Id;
                    PviewModel.ProductName = product.Name;
                    PviewModel.OneProductPrice = product.Price;
                    PviewModel.code = product.Code;
                    PviewModel.Count = (int)numericUpDown1.Value;
                    textBox1.Text = product.Price.ToString();
                    textBox2.Text = product.Price.ToString();
                }
            }

            MessageBox.Show(s.ToString());

        }

        private void AddProductToFactorForm_Load(object sender, EventArgs e)
        {
            foreach (var product in UtilityOne.utilityProduct)
            {
                comboBox1.Items.Add(product.Name);
            }


        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

            PviewModel.Price = PviewModel.OneProductPrice * (int)numericUpDown1.Value;
            textBox2.Text = PviewModel.Price.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            UtilityOne.utilityViewsForDataGrid.Add(PviewModel);
           

            MessageBox.Show(UtilityOne.utilityViewsForDataGrid.FirstOrDefault().ProductName);
            this.Close();
        }
    }
}
