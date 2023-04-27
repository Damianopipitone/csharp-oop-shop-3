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
        private int ph;
        private float MaxCapacity = 1.5f;

        // COSTRUTTORE
        public Water(string name, int pH) : base(name)
        {   
            if (pH < 0)
            {
                throw new ArgumentException("Non esiste un'acqua con un pH negativo!");
            } else if (pH > 10)
            {
                throw new ArgumentException("Non esiste un'acqua con un pH superiore a 10!");
            } else
            {
                this.ph = pH;
            }
        }

        // GETTERS

        public int GetWaterName()
        {
            return this.ph;
        }

        public float GetCapacity()
        {
            return this.MaxCapacity;
        }

        public int GetPH()
        {
            return this.ph;
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

        public void setPH(int pH)
        {
            this.ph = pH;
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
            rapprString += "\t Capacità massima: " + this.GetCapacity() + "\n";
            rapprString += "\t pH: " + this.GetPH() + "\n";
            return rapprString;
        }
    }
}