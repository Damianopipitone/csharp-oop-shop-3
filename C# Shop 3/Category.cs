using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Composizione_Shop
{
    public class Category
    {
        private string name;
        private string description;
        private int code;

        // COSTRUTTORE

        public Category(string name, string description)
        {
            this.name = name;
            this.description = description;
            this.code = RandomNumber();
        }
        // GETTERS

        public string GetName()
        {
            return this.name;
        }

        public string GetDescription()
        {
            return this.description;
        }

        public int GetCode()
        {
            return this.code;
        }

        //METODI 

        private int RandomNumber()
        {
            Random randomGenerator = new Random();
            int randomNumber = randomGenerator.Next(10000000);

            return randomNumber;
        }

        public string GetCateogriesString()
        {
            string rapprString = "La categoria è: " + this.name + "\n";
            rapprString += this.description + "\n";
            rapprString += "Codice prodotto: " + this.code + "\n";
            return rapprString;
        }


    }


}
