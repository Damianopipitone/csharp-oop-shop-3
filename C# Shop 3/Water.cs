using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
            setPH(pH);
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

        public void SetCapacity(float capacity)
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
            if (pH < 0)
            {
                throw new ArgumentException("Non esiste un'acqua con un pH negativo!");
            }
            else if (pH > 10)
            {
                throw new ArgumentException("Non esiste un'acqua con un pH superiore a 10!");
            }
            else
            {
                this.ph = pH;
            }
        }
        // METODI

        public void Bevi(float LitriDaBere)
        {
            double acquaRimanente = MaxCapacity - LitriDaBere;
            if (MaxCapacity < LitriDaBere)
            {
                throw new ArgumentException("L'acqua è insufficiente!");
            }
            else
            {
                Console.WriteLine("Hai bevuto " + LitriDaBere + "L");
                Console.WriteLine("Ti rimane da bere: " + acquaRimanente.ToString("F") + "L");
            }

            if (acquaRimanente == 0)
            {
               this.MaxCapacity = 0f;
               throw new ArgumentException("Hai finito l'acqua! Riempila se vuoi bere ancora.");
            }

        

        }

        public void Riempi(float LitriDaRiempire)
        {
            double acquaRiempita = MaxCapacity + LitriDaRiempire;
            
            if (LitriDaRiempire > 1.5f)
            {
                throw new ArgumentException("Hai superato il limite di capacità");
            } else
            {
                Console.WriteLine("Hai riempito " + LitriDaRiempire + "L");
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