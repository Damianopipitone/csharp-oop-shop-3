
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Composizione_Shop
{
    public class itemShop
    {
        private string name;
        private List<Category> categories;
        // COSTRUTTORE

        public itemShop(string name)
        {
            this.name = name;
            this.categories = new List<Category>();
        }

        // GETTERS 

        public string GetName()
        {
            return this.name;
        }

        public List<Category> GetCategoriesList()
        {
            return this.categories;
        }


        public virtual string GetItemString()
        {
            string rapprString = "Nome prodotto: " + this.name + "\n";
            rapprString += "\t Categorie prodotto: \n";
            foreach (Category categoriaScansionata in categories)
            {
                rapprString += "\t - " + categoriaScansionata.GetName() + "\n";
                rapprString += "\t" + categoriaScansionata.GetDescription() + "\n";
                rapprString += "\t" + categoriaScansionata.GetCode();
            }

            return rapprString;

        }

        public void addCaetogy(Category newCategory)
        {
            this.categories.Add(newCategory);
        }
    }
}
