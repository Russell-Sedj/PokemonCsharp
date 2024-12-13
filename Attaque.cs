using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Attaque
    {
        private  string nom;
        private string type;
        private string categorieAttaque;
        private int precision;
        private int puissance;
        private int pp;

        public string Nom { get => nom; }
        public int Pp { get => pp; set => pp = value; }

        public Attaque(string nom, string type, string categorieAttaque, int precision, int puissance, int pp)
        {
            this.nom = nom;
            this.type = type;
            this.categorieAttaque = categorieAttaque;
            this.precision = precision;
            this.puissance = puissance;
            this.pp = pp;
        }

        public int CalculerDegats (Pokemon attaquant, Pokemon defensseur)
        {
            //pvPerdus = ((((niv * 0.4 + 2) * att * pui) / (def * 50)) + 2) * (CM = stab * precision)
            int degats = 0;
            double STAB = 1;
            if (attaquant.Types.Contains(this.type))
            {
                STAB = 1.5;
            }

            if (this.categorieAttaque.Equals("physique"))
            {
                degats = (int)(((((attaquant.Niveau * 0.4 + 2) * attaquant.Attaque * this.puissance) / (defensseur.Defense * 50)) + 2) * (STAB * (this.precision / 100)));
            }
            else
            {
                degats = (int)(((((attaquant.Niveau * 0.4 + 2) * attaquant.AttaqueSpeciale * this.puissance) / (defensseur.DefenseSpeciale * 50)) + 2) * (STAB * (this.precision / 100)));
            }

            return degats;
        }

        public void Afficher ()
        {
            Console.WriteLine("Nom : " + this.nom);
            Console.WriteLine("Type : " + this.type);
            Console.WriteLine("Categorie : " + this.categorieAttaque);
            Console.WriteLine("Precision : " + this.precision);
            Console.WriteLine("Puissance : " + this.puissance);
            Console.WriteLine("PP : " + this.pp);
        }
    }
}
