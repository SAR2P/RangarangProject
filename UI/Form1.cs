using BuisnesEntityLayer.Entities;
using BuisnesEntityLayer.ViewModel;
using BuisnesLogicLayer.Product;
using DataAccessLayer.Models;

namespace UI
{
    public partial class Form1 : Form
    {
        private OverAllFactorViewModel _ViewFormOne;
        public Form1()
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
                var selectedOrderDetail = dataGridView1.SelectedRows[0].DataBoundItem as OverAllFactorViewModel;

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
                button2.Enabled = true;
                button3.Enabled = true;
            }
            catch (Exception)
            {

                throw;
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

            var si = orderDetailsBLL.GetOverAllDataGridData();

            dataGridView1.DataSource = si;
            dataGridView1.Columns["OrderDetailsId"].Visible = false;
            dataGridView1.Columns["OrderId"].Visible = false;

            button2.Enabled = false;
            button3.Enabled = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var form = new CreateOrder(new OverAllFactorViewModel { EditStatus = false }))
            {
                form.ShowDialog();
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = orderDetailsBLL.GetOverAllDataGridData();//add to datagrid
                dataGridView1.Columns["OrderDetailsId"].Visible = false;
                dataGridView1.Columns["OrderId"].Visible = false;
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
            dataGridView1.DataSource = orderDetailsBLL.GetOverAllDataGridData();//add to datagrid
            dataGridView1.Columns["OrderDetailsId"].Visible = false;
            dataGridView1.Columns["OrderId"].Visible = false;

            button2.Enabled = false;
            button3.Enabled = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {


            using (var form = new CreateOrder(_ViewFormOne))
            {
                form.ShowDialog();
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = orderDetailsBLL.GetOverAllDataGridData();//add to datagrid
                dataGridView1.Columns["OrderDetailsId"].Visible = false;
                dataGridView1.Columns["OrderId"].Visible = false;
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

           

            dataGridView1.DataSource = model;
            dataGridView1.Columns["OrderDetailsId"].Visible = false;
            dataGridView1.Columns["OrderId"].Visible = false;
        }
    }
}
