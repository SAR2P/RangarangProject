using BuisnesEntityLayer.Entities;
using BuisnesLogicLayer.Product;
using Microsoft.Identity.Client.NativeInterop;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RangarangTest_UI
{
    public partial class Create_Edit_OrderDetails : Form
    {
        List<OrderDetails> orderDetailsList = new List<OrderDetails>();

        public Create_Edit_OrderDetails()
        {
            InitializeComponent();
        }
        public Create_Edit_OrderDetails(List<OrderDetails> orderDetails)
        {
            InitializeComponent();
            orderDetailsList = orderDetails;

        }

        ProductBLL productBLL = new ProductBLL();
        List<ProductE> productEs = new List<ProductE>();

        private void Create_Edit_OrderDetails_Load(object sender, EventArgs e)
        {
            try
            {
                productEs = productBLL.GetAll();

                if (productEs.Count <= 0)
                {
                    MessageBox.Show("Product From Database is Empty");
                }
                foreach (ProductE product in productEs)
                {
                    productComboBox.Items.Add(product.Name);
                }

                foreach (var item in orderDetailsList)
                {
                    if (item.EditState == true)
                    {
                        //if update status is true fetch that obj to elements

                        foreach (ProductE product in productEs)
                        {

                            if (product.Id == item.ProductEId)
                            {
                                productComboBox.SelectedItem = product.Name;
                                txtPPrice.Text = item.Price.ToString();
                                productNumericBox.Value = item.Count;
                                txtTotalPrice.Text = item.SumPrice.ToString();
                            }
                        }

                    }

                }
            }
            catch (Exception)
            {
                MessageBox.Show("error ocurd whil fetching data");
            }


        }

        private void productComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                foreach (var item in productEs)
                {
                    if (productComboBox.SelectedItem == item.Name)
                    {
                        txtPPrice.Text = item.Price.ToString();
                        productNumericBox.Value = 1;
                        txtTotalPrice.Text = item.Price.ToString();

                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void productNumericBox_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                txtTotalPrice.Text = (Convert.ToInt64(txtPPrice.Text) * productNumericBox.Value).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("value is to long");
            }

        }

        private void txtPPrice_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtTotalPrice.Text = (Convert.ToInt64(txtPPrice.Text) * productNumericBox.Value).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("value is to long");
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var NewOrderDFromForm = new OrderDetails();

            foreach (var item in productEs)
            {
                if (item.Name == productComboBox.SelectedItem)
                {
                    NewOrderDFromForm.ProductEId = item.Id;
                    NewOrderDFromForm.Price = Convert.ToInt64(txtPPrice.Text);
                    NewOrderDFromForm.Count = (Int32)productNumericBox.Value;
                    NewOrderDFromForm.SumPrice = Convert.ToInt64(txtTotalPrice.Text);
                    NewOrderDFromForm.EditState = false;
                }
            }


            foreach (var item in orderDetailsList)
            {
                if (item.EditState == true)
                {
                   if (item.Id > 0)
                        NewOrderDFromForm.Id = item.Id;

                    orderDetailsList.Remove(item);
                    orderDetailsList.Add(NewOrderDFromForm);
                    MessageBox.Show("updated succesfully");
                    this.Close();
                    return;
                }
            }
            //add
            orderDetailsList.Add(NewOrderDFromForm);
            MessageBox.Show(NewOrderDFromForm.Count.ToString());
            this.Close();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
