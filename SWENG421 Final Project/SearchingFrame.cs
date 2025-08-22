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
    public partial class SearchingFrame : Form
    {
        private Facade facade;
        public SearchingFrame()
        {
            InitializeComponent();
            facade = Facade.GetInstance();
            // Populate the search type dropdown with options 'Category', 'Design', and 'Price'
            comboBox1.DataSource = new List<string> { "Category", "Design", "Price" };
        }

        private void SearchingFrame_Load(object sender, EventArgs e)
        {

        }

        private void BuildButton3_Click(object sender, EventArgs e)
        {
            var facade = Facade.GetInstance();
            facade.changeState(new Creating());
            facade.Request();

        }

        private void DesignButton3_Click(object sender, EventArgs e)
        {
            var facade = Facade.GetInstance();
            facade.changeState(new Designing());
            facade.Request();
        }

        private void SearchButton3_Click(object sender, EventArgs e)
        {
            var facade = Facade.GetInstance();
            facade.changeState(new Search());
            facade.Request();
        }

        private void CartButton3_Click(object sender, EventArgs e)
        {
            var facade = Facade.GetInstance();
            facade.changeState(new Payment());
            facade.Request();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            String selectedSearchType = comboBox1.SelectedItem.ToString();
            comboBox2.Items.Clear();

            comboBox2.Enabled = selectedSearchType == "Category" || selectedSearchType == "Design";

            FilterABS filter = null;

            //if (selectedSearchType == "Category")
            //{
            //    filter = new ByCategory(facade.products, );
            //}
            //else if (selectedSearchType == "Design")
            //{
            //    filter = new ByDesign(facade.products);
            //}
            //else if (selectedSearchType == "Price")
            //{
            //    filter = new ByPrice(facade.products);
            //    comboBox2.Enabled = false;
            //}

            //if (filer != null)
            //{
            //    var filterData = filter.getData();
            //    comboBox1.DataSource = filterData;
            //}
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
