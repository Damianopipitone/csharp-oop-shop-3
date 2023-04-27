using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Composizione_Shop
{
    // SOTTOCLASSE
    public class Water : itemShop
    {
        private string ph;
        private float capacity;
        private float MaxCapacity = 1.5f;

        // COSTRUTTORE
        public Water(string name, string pH) : base(name)
        {
            this.ph = pH;

        }

        // GETTERS

        public string GetWaterName()
        {
            return this.ph;
        }

        public float GetCapacity()
        {
            return this.MaxCapacity;
        }

        //SETTERS

        public void SetRefill(float capacity)
        {

            if (capacity > MaxCapacity)
            {
                Console.WriteLine("La capacità massima della bottiglia è di 1,5L");
            }
            else
            {
                this.MaxCapacity = capacity;
            }
        }
        // METODI

        public void Bevi(float LitriDaBere)
        {
            double acquaRimanente = MaxCapacity - LitriDaBere;
            if (MaxCapacity < LitriDaBere)
            {
                Console.WriteLine("L'acqua è insufficiente");
            }
            else
            {
                Console.WriteLine("Hai bevuto " + LitriDaBere + "L");
                Console.WriteLine("Ti rimane da bere: " + acquaRimanente.ToString("F") + "L");
            }

        }
        public override string GetItemString()
        {
            string rapprString = "Nome Prodotto : " + this.GetName() + "\n";
            rapprString += "\t Marca: " + this.GetWaterName() + "\n";
            rapprString += "\t Capacità massima: " + this.GetCapacity() + "\n";
            return rapprString;
        }
    }
}