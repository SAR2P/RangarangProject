using BuisnesEntityLayer.Entities;
using BuisnesEntityLayer.ViewModel;
using BuisnesLogicLayer.Product;
using DataAccessLayer.Models;

namespace UI
{
    public partial class Orde : Form
    {
        private OverAllFactorViewModel _ViewFormOne;
        public Orde()
        {
            InitializeComponent();
            _ViewFormOne = new OverAllFactorViewModel();
        }


        OrderDetailsBLL orderDetailsBLL = new OrderDetailsBLL();
        PersonBLL PersonBLL = new PersonBLL();

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var selectedOrderDetail = OnlydataGridView.SelectedRows[0].DataBoundItem as OverAllFactorViewModel;

                _ViewFormOne.PersonName = selectedOrderDetail.PersonName;
                _ViewFormOne.OrderDetailsSumPrice = selectedOrderDetail.OrderDetailsSumPrice;
                _ViewFormOne.ProductPrice = selectedOrderDetail.ProductPrice;
                _ViewFormOne.ProductId = selectedOrderDetail.ProductId;
                _ViewFormOne.ProductName = selectedOrderDetail.ProductName;
                _ViewFormOne.OrderDetailsCount = selectedOrderDetail.OrderDetailsCount;
                _ViewFormOne.OrderNumber = selectedOrderDetail.OrderNumber;
                _ViewFormOne.OrderDate = selectedOrderDetail.OrderDate;
                _ViewFormOne.OrderDetailsId = selectedOrderDetail.OrderDetailsId;
                _ViewFormOne.OrderId = selectedOrderDetail.OrderId;
                _ViewFormOne.EditStatus = true;

                MessageBox.Show(_ViewFormOne.PersonName);
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;
            }
            catch (Exception)
            {

                throw;
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

            var si = orderDetailsBLL.GetOverAllDataGridData();

            OnlydataGridView.DataSource = si;
            OnlydataGridView.Columns["OrderDetailsId"].Visible = false;
            OnlydataGridView.Columns["OrderId"].Visible = false;

            btnEdit.Enabled = false;
            btnDelete.Enabled = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var form = new CreateOrder(new OverAllFactorViewModel { EditStatus = false }))
            {
                form.ShowDialog();
                OnlydataGridView.DataSource = null;
                OnlydataGridView.DataSource = orderDetailsBLL.GetOverAllDataGridData();//add to datagrid
                OnlydataGridView.Columns["OrderDetailsId"].Visible = false;
                OnlydataGridView.Columns["OrderId"].Visible = false;
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OrderBLL orderBLL = new OrderBLL();
            //delete
            if (orderBLL.DeleteOrder(_ViewFormOne.OrderId))
            {
                if (orderDetailsBLL.deleteOrderDetails(_ViewFormOne.OrderDetailsId))
                {
                    MessageBox.Show("Deleted succesfuly");
                }
            }
            OnlydataGridView.DataSource = orderDetailsBLL.GetOverAllDataGridData();//add to datagrid
            OnlydataGridView.Columns["OrderDetailsId"].Visible = false;
            OnlydataGridView.Columns["OrderId"].Visible = false;

            btnEdit.Enabled = false;
            btnDelete.Enabled = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {


            using (var form = new CreateOrder(_ViewFormOne))
            {
                form.ShowDialog();
                OnlydataGridView.DataSource = null;
                OnlydataGridView.DataSource = orderDetailsBLL.GetOverAllDataGridData();//add to datagrid
                OnlydataGridView.Columns["OrderDetailsId"].Visible = false;
                OnlydataGridView.Columns["OrderId"].Visible = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var result = PersonBLL.searchPersonByString(textBox1.Text);

            var si = orderDetailsBLL.GetOverAllDataGridData();

            List<OverAllFactorViewModel> model = new List<OverAllFactorViewModel>();

            foreach (var item in si)
            {
                foreach (var k in result)
                {
                    if (item.PersonName == k.Name )
                    {
                        model.Add(item);
                    }
                }
            }

           

            OnlydataGridView.DataSource = model;
            OnlydataGridView.Columns["OrderDetailsId"].Visible = false;
            OnlydataGridView.Columns["OrderId"].Visible = false;
        }
    }
}
