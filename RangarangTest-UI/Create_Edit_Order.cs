using BuisnesEntityLayer.Entities;
using BuisnesEntityLayer.ViewModel;
using BuisnesLogicLayer.Product;
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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace RangarangTest_UI
{
    public partial class Create_Edit_Order : Form
    {

        private List<OrderDetails> _OrderDetailsList;

        public Create_Edit_Order()
        {
            InitializeComponent();
            _OrderDetailsList = new List<OrderDetails>();
        }


        PersonBLL PersonBLL = new PersonBLL();
        ProductBLL ProductBLL = new ProductBLL();
        OrderBLL OrderBLL = new OrderBLL();
        OrderDetailsBLL orderDetailBLL = new OrderDetailsBLL();

        private void Create_Edit_Order_Load(object sender, EventArgs e)
        {
            List<Person> people = PersonBLL.GetAll();
            foreach (Person item in people)
            {
                customerComboBox.Items.Add(item.Name);
            }

            setDataG(_OrderDetailsList);

        }

        private void btnCreateOD_Click(object sender, EventArgs e)
        {
            foreach (OrderDetails item in _OrderDetailsList)
            {//all states turn false becuse it`s create state
                item.EditState = false;
            }
            using (var form = new Create_Edit_OrderDetails(_OrderDetailsList))
            {
                form.ShowDialog();
                setDataG(_OrderDetailsList);

            }


        }

        private void OD_DataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           

            var selectedItem = OD_DataGrid.SelectedRows[0].DataBoundItem as FormOrderDataGridViewModel;

            SetAllOrderDetailsEditStatesFalse();//private void

            foreach (var item in _OrderDetailsList)
            {
                if (selectedItem.ProductEId == item.ProductEId)
                {
                    item.EditState = true;
                    MessageBox.Show(item.ProductEId.ToString() + " is selected fro update");
                }
            }

        }

        private void btnEditOD_Click(object sender, EventArgs e)
        {
            using (var form = new Create_Edit_OrderDetails(_OrderDetailsList))
            {
                form.ShowDialog();
                setDataG(_OrderDetailsList);
            }
        }


        private void btnRegister_Click(object sender, EventArgs e)
        {

            var newnum = OrderBLL.GetMaxNumberProperty();
            var personId = PersonBLL.getpersonIdByName(customerComboBox.SelectedItem.ToString());

            var order = new Order()
            {

                Number = newnum,
                PersonId = personId,
                Date = createOrder_dateTimePicker.Value,

            };

            if (OrderBLL.CreateOrder(order))
            {
                var getOrderIdByNumber = OrderBLL.getOrederIdByNumber(order.Number);
                foreach (var item in _OrderDetailsList)
                {
                    OrderDetails details = new OrderDetails()
                    {
                        ProductEId = item.ProductEId,
                        Count = item.Count,
                        Price = item.Price,
                        OrderId = getOrderIdByNumber,
                        SumPrice = item.SumPrice
                    };
                    orderDetailBLL.createOrderDetails(details);
                }
            }

            MessageBox.Show("success");
            this.Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDeleteOD_Click(object sender, EventArgs e)
        {
            foreach (var item in _OrderDetailsList)
            {
                if (item.EditState == true)
                {//firs we check if it`s in database we delete it from there and then we deleted from list
                    var checkexistInDB = orderDetailBLL.GetOrderDetailsByID(item.OrderId);
                    if (checkexistInDB == null)
                    {// delete just from list
                        _OrderDetailsList.Remove(item);
                        MessageBox.Show("just deleted from list");
                        SetAllOrderDetailsEditStatesFalse();
                        setDataG(_OrderDetailsList);
                        return;
                    }
                    else
                    {
                        orderDetailBLL.deleteOrderDetails(item.Id);
                        _OrderDetailsList.Remove(item);
                        MessageBox.Show("deleted from database and list");
                        SetAllOrderDetailsEditStatesFalse();
                        setDataG(_OrderDetailsList);
                        return;
                    }
                }
            }
        }

        //private method

        private void setDataG(List<OrderDetails> orderDetails)
        {
            List<FormOrderDataGridViewModel> formOrderDataGridViewModels = new List<FormOrderDataGridViewModel>();

            foreach (var item in orderDetails)
            {
                var resP = ProductBLL.GetProductById(item.ProductEId);

                formOrderDataGridViewModels.Add(new FormOrderDataGridViewModel()
                {
                    ProductEId = item.ProductEId,
                    ProductName = resP.Name,
                    ProductCode = resP.Code,
                    count = item.Count,
                    PPrice = item.Price,
                    TotalPrice = item.SumPrice
                });
            }
            OD_DataGrid.DataSource = null;
            OD_DataGrid.DataSource = formOrderDataGridViewModels;
            OD_DataGrid.Columns["ProductEId"].Visible = false;
        }

        private void SetAllOrderDetailsEditStatesFalse()
        {
            foreach (var item in _OrderDetailsList)
            {
                item.EditState = false;
            }
        }

    }
}
