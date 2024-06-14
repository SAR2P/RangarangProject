using BuisnesEntityLayer.Entities;
using BuisnesLogicLayer.Product;
using UI.Utility;

namespace UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ProductBLL bLL = new ProductBLL();

            List<ProductE> products = bLL.GetAll();

            UtilityOne.utilityProduct = products;
            dataGridView1.DataSource = UtilityOne.utilityProduct;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateOrder form2 = new CreateOrder();
            form2.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
          
        }
    }
}
