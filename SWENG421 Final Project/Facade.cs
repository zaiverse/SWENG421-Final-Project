using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace SWENG421_Final_Project
{
    internal class Facade
    {
        private Form currentForm;
        private ABSOrderState currentState;
        private static Facade instance;
        public List<Form> forms = new List<Form>();
        public Director director = new Director();
        public BindingList<ProductABS> products = new BindingList<ProductABS>();
        public BindingList<ProductABS> createdProducts = new BindingList<ProductABS>();

        public Facade()
        {
            instance = this;
            currentForm = new CreatingFrame();
            RegisterForm();
        }

        public Facade(ABSOrderState state)
        {
            changeState(state);
        }

        private void RegisterForm()
        {
            forms.Add(new CreatingFrame());
            forms.Add(new DesigningFrame());
            forms.Add(new SearchingFrame());
            forms.Add(new PayingFrame());
        }

        public Form getCurrentForm() { return currentForm; }

        public static Facade GetInstance() 
        {
            return instance;
        }

        public void changeState(ABSOrderState state) 
        {
            currentState = state;
        
        }

        public void Request()
        {
            currentState?.handle(this);
        }

        public void SwitchToForm(Form newForm)
        {
            Debug.WriteLine("Attempting to switch to a new form.");

            if (currentForm != null)
            {
                Debug.WriteLine($"Hiding current form: {currentForm.Name}");
                currentForm.Hide();
            }

            foreach (var form in forms)
            {
                if (form.GetType() == newForm.GetType())
                {
                    Debug.WriteLine($"Showing new form: {form.Name}");
                    form.Show();
                    currentForm = form;
                    break;
                }
            }

            if (currentForm == null)
            {
                Debug.WriteLine("No current form is set.");
            }

        }

        public void buildProduct(String s, String color)
        {
            switch (s.ToLower())
            {
                case "tshirt":
                    ShirtBuilder sb = new ShirtBuilder();
                    director.makeShirt(sb, color);
                    createdProducts.Add(sb.getProduct());
                    break;
                case "jeans":
                    JeansBuilder jb = new JeansBuilder();
                    director.makePants(jb, color);
                    createdProducts.Add(jb.getProduct());
                    break;
                case "hats":
                    HatBuilder hb = new HatBuilder();
                    director.makeHats(hb, color);
                    createdProducts.Add(hb.getProduct());
                    break;
                default:
                    break;
            }
        }

        public void createDecoratedProduct(DesignABS d, ProductABS p)
        {
            createdProducts.Add(new ProductDecorator(p, d));
        }
    }
}
