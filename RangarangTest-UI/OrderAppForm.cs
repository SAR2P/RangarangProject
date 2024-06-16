using BuisnesEntityLayer.Entities;
using BuisnesEntityLayer.ViewModel;
using DataAccessLayer.Models;
using System.Windows.Forms;

namespace RangarangTest_UI
{
    public partial class OrderAppForm : Form
    {
        public OrderAppForm()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            using (var form = new Create_Edit_Order())
            {
                form.ShowDialog();
               
            }
           
            
        }
    }
}
