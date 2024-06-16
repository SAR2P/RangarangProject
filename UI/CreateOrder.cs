using BuisnesEntityLayer.Entities;
using BuisnesEntityLayer.ViewModel;
using BuisnesLogicLayer.Product;
using DataAccessLayer.Models;
using System.Globalization;
using System.Runtime.Serialization;

namespace UI
{
    public partial class CreateOrder : Form
    {
        private List<AddProductOrderDetailsViewModel> _orderDetailsList;
        private AddProductOrderDetailsViewModel _OneProductorderDetail;
       
        private OverAllFactorViewModel _OverAllFactorDetail;

        public CreateOrder(OverAllFactorViewModel overAllFactor)
        {
            InitializeComponent();
            _orderDetailsList = new List<AddProductOrderDetailsViewModel>();
            _OneProductorderDetail = new AddProductOrderDetailsViewModel();
            
            _OverAllFactorDetail = overAllFactor;
        }

        PersonBLL personBLL = new PersonBLL();
        OrderBLL orderBLL = new OrderBLL();
        OrderDetailsBLL detailsBLL = new OrderDetailsBLL();

        private Person _Person = new Person();


        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_OverAllFactorDetail.EditStatus == false)
            {
                try
                {
                    var newNum = orderBLL.GetNewNumberForOrder();

                    Order order = new Order()
                    {
                        PersonId = _Person.Id,
                        Date = dateTimePicker1.Value,
                        Number = newNum + 1,

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
                    this.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("error ocurd");
                }
            }
            else
            { //edit
                var newNum = orderBLL.GetNewNumberForOrder();

                Order order = new Order()
                {
                    Id = _OverAllFactorDetail.OrderId,
                    PersonId = _Person.Id,
                    Date = dateTimePicker1.Value,
                    Number = newNum

                };

                if (orderBLL.UpdateProduct(_OverAllFactorDetail.OrderId, order))
                {
                    var orderI = order.Id;
                    foreach (var item in _orderDetailsList)
                    {
                        OrderDetails details = new OrderDetails()
                        {
                            Id= item.ProductId,
                            ProductEId = item.ProductId,
                            Count = item.Count,
                            Price = item.OneProductPrice,
                            OrderId = orderI,
                            SumPrice = item.Price
                        };
                        detailsBLL.UpdateOrderDetails(details.Id, details);
                    }
                }
                MessageBox.Show("Updated");
                this.Close();
               
            }
        

        }

        private void CreateFactorForm_Load(object sender, EventArgs e)
        {
            if (_OverAllFactorDetail.EditStatus == false)
            {
                List<Person> people = personBLL.GetAll();
                foreach (var item in people)
                {
                    comboBox1.Items.Add(item.Name);
                }
            }
            else
            {
                _orderDetailsList.Add(new AddProductOrderDetailsViewModel()
                {
                    ProductName = _OverAllFactorDetail.ProductName,
                    ProductId = _OverAllFactorDetail.ProductId,
                    OneProductPrice = _OverAllFactorDetail.ProductPrice,
                    Price = _OverAllFactorDetail.OrderDetailsSumPrice,
                    Count = _OverAllFactorDetail.OrderDetailsCount,

                });

                
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = _orderDetailsList;//add to datagrid
                                                           

                List<Person> people = personBLL.GetAll();
                foreach (var item in people)
                {
                    comboBox1.Items.Add(item.Name);
                }
                comboBox1.SelectedItem = _OverAllFactorDetail.PersonName;
                dateTimePicker1.Value = _OverAllFactorDetail.OrderDate;
                _Person.Name = comboBox1.SelectedItem.ToString();
                _Person.Id = personBLL.getpersonIdByName(_OverAllFactorDetail.PersonName);

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

            using (var form = new CreateOrderDetails(_orderDetailsList, new AddProductOrderDetailsViewModel { EditStatus = false }))
            {
                form.ShowDialog();
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = _orderDetailsList;//add to datagrid
                dataGridView1.Columns["ProductId"].Visible = false;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var selectedOrderDetail = dataGridView1.SelectedRows[0].DataBoundItem as AddProductOrderDetailsViewModel;
                _OneProductorderDetail.ProductId = selectedOrderDetail.ProductId;
                _OneProductorderDetail.ProductName = selectedOrderDetail.ProductName;
                _OneProductorderDetail.Count = selectedOrderDetail.Count;
                _OneProductorderDetail.OneProductPrice = selectedOrderDetail.OneProductPrice;
                _OneProductorderDetail.Price = selectedOrderDetail.Price;
                _OneProductorderDetail.EditStatus = true;

                button4.Enabled = true;
                button5.Enabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show("click clean");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            foreach (AddProductOrderDetailsViewModel item in _orderDetailsList.ToList())
            {
                if (item.ProductName == _OneProductorderDetail.ProductName && item.ProductId == _OneProductorderDetail.ProductId)
                {
                    _orderDetailsList.Remove(item);
                }
            }
            using (var form = new CreateOrderDetails(_orderDetailsList, _OneProductorderDetail))
            {

                form.ShowDialog();
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = _orderDetailsList;//add to datagrid
                dataGridView1.Columns["ProductId"].Visible = false;
            }


        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (var item in _orderDetailsList.ToList())
                {
                    if (item.ProductName == _OneProductorderDetail.ProductName && item.ProductId == _OneProductorderDetail.ProductId)
                    {
                        _orderDetailsList.Remove(item) ;
                        _OneProductorderDetail = new AddProductOrderDetailsViewModel { EditStatus = false };
                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = _orderDetailsList;//add to datagrid
                        button4.Enabled = false;
                        button5.Enabled = false;
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
