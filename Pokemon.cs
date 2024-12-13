using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Pokemon
    {
        private string nom;
        private int prix;
        private List<string> types;
        private int pointsDeVie;
        private int niveau;
        private int attaque;
        private int attaqueSpeciale;
        private int defense;
        private int defenseSpeciale;
        private int vitesse;
        private List<Attaque> attaques;

        public string Nom { get => nom; }
        public int Prix { get => prix; }
        public List<string> Types { get => types; }
        public int PointsDeVie { get => pointsDeVie; set => pointsDeVie = value; }
        public int Niveau { get => niveau; }
        public int Attaque { get => attaque; }
        public int AttaqueSpeciale { get => attaqueSpeciale; }
        public int Defense { get => defense; }
        public int DefenseSpeciale { get => defenseSpeciale; }
        public int Vitesse { get => vitesse; }
        public List<Attaque> Attaques { get => attaques; }

        public Pokemon(string nom, int prix, List<string> types, int pointsDeVie, int niveau, int attaque, int attaqueSpeciale, int defense, int defenseSpeciale, int vitesse)
        {
            this.nom = nom;
            this.prix = prix;
            this.types = types;
            this.pointsDeVie = pointsDeVie;
            this.niveau = niveau;
            this.attaque = attaque;
            this.attaqueSpeciale = attaqueSpeciale;
            this.defense = defense;
            this.defenseSpeciale = defenseSpeciale;
            this.vitesse = vitesse;
            this.attaques = new List<Attaque>();
        }

        public void AjouterAttaque(Attaque attaque)
        {
            this.attaques.Add(attaque);
        }

        public void Attaquer(Pokemon enemi, Attaque attaqueUtilisee)
        {
            int degats = attaqueUtilisee.CalculerDegats(this, enemi);
            enemi.PointsDeVie -= degats;
            Console.WriteLine($"{this.nom} attaque {enemi.Nom} avec {attaqueUtilisee.Nom} et lui inflige {degats} points de dégats.");

            attaqueUtilisee.Pp -= 1;
        }

        public bool EstKO()
        {
            Console.WriteLine($"{this.nom} est KO.");
            return this.pointsDeVie <= 0;
        }

        //Ca cest une methode que j'ai ajoute volontairement
        public bool ADesPPDisponibles()
        {
            foreach (Attaque attaque in this.attaques)
            {
                if (attaque.Pp > 0)
                {
                    return true;
                }
            }
            return false;
        }

        public void AfficherAttaques()
        {
            Console.WriteLine("Attaques de " + this.nom + " :");
            foreach (Attaque attaque in this.attaques)
            {
                Console.WriteLine("-----------");
                attaque.Afficher();
                Console.WriteLine("-----------");
            }
        }

        public void Afficher()
        {
            Console.WriteLine("Infos Pokemon : ");
            Console.WriteLine("Nom : " + this.nom);
            Console.WriteLine("Prix : " + this.prix);
            Console.WriteLine("Types : ");
            foreach (string type in this.types)
            {
                Console.WriteLine(type);
            }
            Console.WriteLine("Points de vie : " + this.pointsDeVie);
            Console.WriteLine("Niveau : " + this.niveau);
            Console.WriteLine("Attaque : " + this.attaque);
            Console.WriteLine("Attaque speciale : " + this.attaqueSpeciale);
            Console.WriteLine("Defense : " + this.defense);
            Console.WriteLine("Defense speciale : " + this.defenseSpeciale);
            Console.WriteLine("Vitesse : " + this.vitesse);
        }
    }
}
