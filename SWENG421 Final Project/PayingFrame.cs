using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SWENG421_Final_Project
{
    public partial class PayingFrame : Form
    {
        Facade facade = Facade.GetInstance();
        public PayingFrame()
        {
            InitializeComponent();

            CartListBox.DataSource = facade.products;
            CartListBox.DisplayMember = "ToString";
        }

        private void BuildButton4_Click(object sender, EventArgs e)
        {
            var facade = Facade.GetInstance();
            facade.changeState(new Creating());
            facade.Request();
        }

        private void DesignButton4_Click(object sender, EventArgs e)
        {
            var facade = Facade.GetInstance();
            facade.changeState(new Designing());
            facade.Request();
        }

        private void SearchButton4_Click(object sender, EventArgs e)
        {
            var facade = Facade.GetInstance();
            facade.changeState(new Search());
            facade.Request();
        }

        private void CartButton4_Click(object sender, EventArgs e)
        {
            var facade = Facade.GetInstance();
            facade.changeState(new Payment());
            facade.Request();
        }

        private void PayingFrame_Load(object sender, EventArgs e)
        {

        }

        public void updatePrice()
        {
            double price = 0;
            foreach (ProductABS p in facade.products)
            {
                price += p.getPrice();
            }
            PriceLabel.Text = price.ToString();
        }

        private void PayingFrame_VisibleChanged(object sender, EventArgs e)
        {
            updatePrice();
        }
    }
}
