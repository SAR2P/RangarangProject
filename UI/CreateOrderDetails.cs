using BuisnesEntityLayer.Entities;
using BuisnesEntityLayer.ViewModel;
using BuisnesLogicLayer.Product;


namespace UI
{
    public partial class CreateOrderDetails : Form
    {
        private List<AddProductOrderDetailsViewModel> _orderDetailsList;
        private AddProductOrderDetailsViewModel _OneOrderDetailsForEdit;

        public CreateOrderDetails(List<AddProductOrderDetailsViewModel> orderDetailsList, AddProductOrderDetailsViewModel oneorderDetails)
        {
            InitializeComponent();
            _orderDetailsList = orderDetailsList;
            _OneOrderDetailsForEdit = oneorderDetails;
        }


        AddProductOrderDetailsViewModel PviewModel = new AddProductOrderDetailsViewModel();

        ProductBLL productBLL = new ProductBLL();


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_OneOrderDetailsForEdit.EditStatus == false)
            {

                var res = comboBox1.SelectedItem;
                var products = productBLL.GetAll();

                foreach (var product in products)
                {
                    if (product.Name == res)
                    {

                        PviewModel.ProductId = product.Id;
                        PviewModel.ProductName = product.Name;
                        PviewModel.OneProductPrice = product.Price;
                        PviewModel.Price = product.Price;
                        PviewModel.Count = (int)numericUpDown1.Value;
                        textBox1.Text = product.Price.ToString();
                        textBox2.Text = product.Price.ToString();
                    }
                }


            }
            else
            {

                var res = comboBox1.SelectedItem;
                var products = productBLL.GetAll();

                foreach (var product in products)
                {
                    if (product.Name == res)
                    {

                        PviewModel.ProductId = product.Id;
                        PviewModel.ProductName = product.Name;
                        PviewModel.OneProductPrice = product.Price;
                        PviewModel.Price = product.Price;
                        PviewModel.Count = (int)numericUpDown1.Value;
                        textBox1.Text = product.Price.ToString();
                        textBox2.Text = product.Price.ToString();
                    }
                }




            }

        }

        private void AddProductToFactorForm_Load(object sender, EventArgs e)
        {
            if (_OneOrderDetailsForEdit.EditStatus == false)
            {

                var products = productBLL.GetAll();

                foreach (var product in products)
                {
                    comboBox1.Items.Add(product.Name);
                }
            }
            else
            {
                PviewModel = _OneOrderDetailsForEdit;


                var products = productBLL.GetAll();

                foreach (var product in products)
                {
                    comboBox1.Items.Add(product.Name);
                }
                comboBox1.SelectedItem = _OneOrderDetailsForEdit.ProductName;
                textBox1.Text = _OneOrderDetailsForEdit.OneProductPrice.ToString();
                numericUpDown1.Value = _OneOrderDetailsForEdit.Count;
                textBox2.Text = _OneOrderDetailsForEdit.Price.ToString();

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
            if (_OneOrderDetailsForEdit.EditStatus == false)
            {
                _orderDetailsList.Add(PviewModel);
                this.Close();
            }
            else
            {
                _orderDetailsList.Add(PviewModel);
             
                this.Close();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
