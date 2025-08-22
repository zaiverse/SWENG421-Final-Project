using System.Diagnostics;

namespace SWENG421_Final_Project
{
    public partial class CreatingFrame : Form
    {
        Facade facade = Facade.GetInstance();
        public CreatingFrame()
        {
            InitializeComponent();
            var types = AppDomain.CurrentDomain.GetAssemblies().SelectMany(s => s.GetTypes()).Where(t => t.BaseType == typeof(ProductABS) && !t.IsAbstract && t != typeof(ProductDecorator));
            List<String> subClassNames = new List<string>();
            foreach (var type in types)
            {
                subClassNames.Add(type.Name);
            }
            foreach (String s in subClassNames)
            {
                CategoryListBox1.Items.Add(s);
            }
            ColorListBox.Items.Add("Red");
            ColorListBox.Items.Add("Blue");
            ColorListBox.Items.Add("Green");

            CategoryListBox1.SetSelected(0, true);
            ColorListBox.SetSelected(0, true);
            CreatedProductListBox.DataSource = facade.createdProducts;
        }

        private void CreatingFrame_Load(object sender, EventArgs e)
        {

        }

        private void BuildButton1_Click(object sender, EventArgs e)
        {
            //var facade = Facade.GetInstance();
            facade.changeState(new Creating());
            facade.Request();
        }

        private void DesignButton1_Click(object sender, EventArgs e)
        {
            //var facade = Facade.GetInstance();
            facade.changeState(new Designing());
            facade.Request();
        }

        private void SearchButton1_Click(object sender, EventArgs e)
        {
            //var facade = Facade.GetInstance();
            facade.changeState(new Search());
            facade.Request();
        }

        private void CartButton1_Click(object sender, EventArgs e)
        {
            //var facade = Facade.GetInstance();
            facade.changeState(new Payment());
            facade.Request();
        }

        private void CreateButton1_Click(object sender, EventArgs e)
        {
            String s = CategoryListBox1.SelectedItem.ToString();
            String c = ColorListBox.SelectedItem.ToString();
            facade.buildProduct(s, c);
            updateCreatedItems();
        }

        private void updateCreatedItems()
        {
            CreatedProductListBox.DataSource = facade.createdProducts;
            CreatedProductListBox.DisplayMember = "ToString";
            CreatedProductListBox.Update();

        }

        private void AddButton1_Click(object sender, EventArgs e)
        {
            facade.products.Add(facade.createdProducts[CreatedProductListBox.SelectedIndex]);
            foreach( ProductABS p in facade.products)
            {
                Debug.WriteLine(p.ToString());
            }
        }
    }
}
