
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Composizione_Shop
{
    public class Shop
    {
        // ATTRIBUTI 

        private string name;
        private string city;
        private string address;
        private int civicNumber;
        private string type;
        private List<itemShop> itemsInShop;

        // COSTRUTTORE

        public Shop(string name, string city, string address, int civicNumber, string type)
        {
            this.name = name;
            this.city = city;
            this.address = address;
            this.civicNumber = civicNumber;
            this.type = type;
            this.itemsInShop = new List<itemShop>();
        }

        // GETTERS

        public string getName()
        {
            return this.name;
        }

        public string getCity()
        {
            return this.city;
        }

        public string getAddress()
        {
            return this.address;
        }

        public int getCivicNumber()
        {
            return this.civicNumber;
        }

        public List<itemShop> GetShopList()
        {
            return this.itemsInShop;
        }

        // SETTERS

        public void SetType(string type)
        {
            this.type = type;
        }

        // METODI

        public void addItem(itemShop newItemShop)
        {
            itemsInShop.Add(newItemShop);
        }

        public void AddListItems(List<itemShop> newItems)
        {
            //itemShop = (List<itemShop>)itemShop.Concat(newItems);

            foreach (itemShop itemScansionato in newItems)
            {
                itemsInShop.Add(itemScansionato);
            }
        }

        public string InfoShop()
        {
            string rapprInfoShop = "Il nome del negozio è: " + this.name + "\n";
            rapprInfoShop += "La città in cui si trova è: " + this.city + "\n";
            rapprInfoShop += "All'indirizzo: " + this.address + "\n";
            rapprInfoShop += "Numero civico: " + this.civicNumber + "\n";
            rapprInfoShop += "Lista prodotti trattati: " + "\n";
            foreach (itemShop itemScansionato in itemsInShop)
            {
                rapprInfoShop += " - " + itemScansionato.GetItemString() + "\n";
            }
            return rapprInfoShop;

        }
    }



}
