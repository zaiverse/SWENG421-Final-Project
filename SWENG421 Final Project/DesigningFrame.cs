using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SWENG421_Final_Project
{
    public partial class DesigningFrame : Form
    {
        Facade facade = Facade.GetInstance();
        public DesigningFrame()
        {
            InitializeComponent();

            var types = AppDomain.CurrentDomain.GetAssemblies().SelectMany(s => s.GetTypes()).Where(t => t.BaseType == typeof(DesignABS) && !t.IsAbstract && !(t is DesignABS));
            List<DesignABS> subClassNames = new List<DesignABS>();
            foreach (var type in types)
            {
                DesignABS instance = (DesignABS)Activator.CreateInstance(type);
                subClassNames.Add(instance);
            }
            foreach (DesignABS d in subClassNames)
            {
                DesignListBox.Items.Add(d);
            }
            DesignListBox.DisplayMember = "designName";
            CategoryListBox2.DataSource = facade.createdProducts;
            CreatedProductListBox2.DataSource = facade.createdProducts;
        }

        private void BuildButton2_Click(object sender, EventArgs e)
        {
            var facade = Facade.GetInstance();
            facade.changeState(new Creating());
            facade.Request();
        }

        private void DesignButton2_Click(object sender, EventArgs e)
        {
            var facade = Facade.GetInstance();
            facade.changeState(new Designing());
            facade.Request();
        }

        private void SearchButton2_Click(object sender, EventArgs e)
        {
            var facade = Facade.GetInstance();
            facade.changeState(new Search());
            facade.Request();
        }

        private void CartButton2_Click(object sender, EventArgs e)
        {
            var facade = Facade.GetInstance();
            facade.changeState(new Payment());
            facade.Request();
        }

        private void AddButton2_Click(object sender, EventArgs e)
        {
            facade.products.Add(facade.createdProducts[CreatedProductListBox2.SelectedIndex]);
        }

        private void AddDesignButton_Click(object sender, EventArgs e)
        {
            facade.createDecoratedProduct((DesignABS)DesignListBox.SelectedItem, facade.createdProducts[CategoryListBox2.SelectedIndex]);
        }
    }
}
