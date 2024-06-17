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
        }

        OrderBLL OrderBLL = new OrderBLL();
        OrderDetailsBLL Order = new OrderDetailsBLL();
        

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
                  List<OrderDetails> orderDet =  Order.GetOrderDetailsByOrderId(OrderForSendToUpdate.Id);

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
            using (var form = new Create_Edit_Order(OrderForSendToUpdate, true))
            {
                form.ShowDialog();
                SetAllRelatedsToDataGrid();
            }
            
        }

        private void DG_RelatedOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            var selectedItem = DG_RelatedOrders.SelectedRows[0].DataBoundItem as GetRelatedOrders;

            MessageBox.Show(selectedItem.PersonName);

            var order =  OrderBLL.GetOrderObjByNumber(selectedItem.OrderNumber);

            OrderForSendToUpdate = order; 


        }


        //private methods

        private void SetAllRelatedsToDataGrid()
        {
            List<GetRelatedOrders> relatedRes = OrderBLL.GetListOffRelatedsToOrder();


            DG_RelatedOrders.DataSource = null;
            DG_RelatedOrders.DataSource = relatedRes;
        }

       
    }
}
