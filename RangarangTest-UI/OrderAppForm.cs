using BuisnesEntityLayer.Entities;
using BuisnesEntityLayer.ViewModel;
using BuisnesLogicLayer.Product;
using DataAccessLayer.Models;
using System.Windows.Forms;

namespace RangarangTest_UI
{
    public partial class OrderAppForm : Form
    {
        private Order OrderForSendToUpdate;

     
        public OrderAppForm()
        {
            InitializeComponent();
            OrderForSendToUpdate = new Order();
         
        }

        OrderBLL OrderBLL = new OrderBLL();
        OrderDetailsBLL Order = new OrderDetailsBLL();
        PersonBLL PersonBll = new PersonBLL();

        private void btnCreate_Click(object sender, EventArgs e)
        {
            using (var form = new Create_Edit_Order())
            {
                form.ShowDialog();
                SetAllRelatedsToDataGrid();
            }


        }

        private void OrderAppForm_Load(object sender, EventArgs e)
        {
            var perRes = PersonBll.GetAll();

            foreach (var item in perRes)
            {
                ComboPersonBox.Items.Add(item.Name);
            }

            SetAllRelatedsToDataGrid();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (OrderForSendToUpdate.Id <= 0)
            {
                MessageBox.Show("please select your order");
                return;
            }

            try
            {
                if (OrderBLL.DeleteOrder(OrderForSendToUpdate.Id))
                {
                    List<OrderDetails> orderDet = Order.GetOrderDetailsByOrderId(OrderForSendToUpdate.Id);

                    foreach (var item in orderDet)
                    {
                        Order.deleteOrderDetails(item.Id);
                    }
                    MessageBox.Show("Order and it`s reletiv order details deleted");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("error ocurd while deleting order");
            }

            SetAllRelatedsToDataGrid();

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (OrderForSendToUpdate.Id <= 0)
                {
                    MessageBox.Show("please first select a Order");
                    return;
                }
                using (var form = new Create_Edit_Order(OrderForSendToUpdate, true))
                {
                    form.ShowDialog();
                    Application.Restart();
                    SetAllRelatedsToDataGrid();
                    
                }
            }
            catch (Exception)
            {
                MessageBox.Show("update Faild");
            }
        }

        private void DG_RelatedOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            var selectedItem = DG_RelatedOrders.SelectedRows[0].DataBoundItem as GetRelatedOrders;

            var order = OrderBLL.GetOrderObjByNumber(selectedItem.OrderNumber);
            OrderForSendToUpdate = order;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (ComboPersonBox.SelectedItem == null)
            {
                MessageBox.Show("please first select a person");
                return;
            }
            SetRelatedsToDataGridBySearchPanel();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
              Application.Exit();
        }

        //private methods

        private void SetAllRelatedsToDataGrid()
        {
             List<GetRelatedOrders> relatedRes = OrderBLL.GetListOffRelatedsToOrder();

            DG_RelatedOrders.DataSource = null;
            DG_RelatedOrders.DataSource = relatedRes;
            

        }

        private void SetRelatedsToDataGridBySearchPanel()
        {

            try
            {
                List<GetRelatedOrders> getRelateds = OrderBLL.GetListOffRelatedsToOrder();
                

                List<GetRelatedOrders> relatedresu = new List<GetRelatedOrders>();
                foreach (var relate in getRelateds)
                {
                    if (ComboPersonBox.SelectedItem.ToString() == relate.PersonName && relate.OrderDate.Date >= StartdateTimePicker.Value && relate.OrderDate.Date <= EndTimePicker.Value)
                    {
                        relatedresu.Add(relate);
                    }
                }
                if (relatedresu.Count > 0)
                {
                    DG_RelatedOrders.DataSource = null;
                    DG_RelatedOrders.DataSource = relatedresu;
                }
                else
                {
                    MessageBox.Show("this person don`t have order");
                }

            }
            catch (Exception)
            {
                MessageBox.Show("error ocurd while fetchin data By Search");
            }

        }


        private void SetDataGridAfterUpdate()
        {
            List<GetRelatedOrders> relatedRes = OrderBLL.GetListOffRelatedsToOrder();


            var od = Order.GetOrderDetailsByOrderId(OrderForSendToUpdate.Id);
            long newTotalPrice = 0;
            foreach (var item in od)
            {
                newTotalPrice += item.SumPrice;
            }
            var orderFromDb = OrderBLL.GetOrderObjByNumber(OrderForSendToUpdate.Number);
            var getPerson = PersonBll.GetPersonById(orderFromDb.PersonId);
            foreach (var item in relatedRes)
            {
                if (item.OrderNumber == OrderForSendToUpdate.Number)
                {
                    item.TotalPrice = newTotalPrice;
                    item.OrderDate = orderFromDb.Date.Date;
                    item.PersonName = getPerson.Name;
                } 
            }
            DG_RelatedOrders.DataSource = null;
            DG_RelatedOrders.DataSource = relatedRes;
        }


    }
}
