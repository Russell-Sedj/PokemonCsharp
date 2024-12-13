using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Joueur
    {
        private string nom;
        private int mancheGagnee;
        private int argent;
        List<Pokemon> pokemons;

        public string Nom { get => nom; }
        public int MancheGagnee {  get => mancheGagnee; }
        public int Argent { get => argent; }
        public List<Pokemon> Pokemons { get => pokemons; }

        public Joueur(string nom, int mancheGagnee, int argent)
        {
            this.nom = nom;
            this.mancheGagnee = mancheGagnee;
            this.argent = argent;
            this.pokemons = new List<Pokemon>();
        }

        public void ChoisirPokemon()
        {
            List<Pokemon> pokemonsDisponibles = new List<Pokemon>
            {
                new Pokemon("Pikachu", 100, new List<string> { "Électrique" }, 35, 5, 55, 50, 40, 50, 90, 
                    new List<Attaque> { new Attaque("Éclair", "Électrique", "spéciale", 100, 40, 30) }),
                new Pokemon("Bulbizarre", 150, new List<string> { "Plante", "Poison" }, 45, 5, 49, 65, 49, 65, 45, 
                    new List<Attaque> { new Attaque("Fouet Lianes", "Plante", "physique", 100, 45, 25) }),
                new Pokemon("Salamèche", 200, new List<string> { "Feu" }, 39, 5, 52, 60, 43, 50, 65, 
                    new List<Attaque> { new Attaque("Flammèche", "Feu", "spéciale", 100, 40, 25) }),
            };

            Console.WriteLine("Choisissez 3 Pokémon parmi la liste suivante :");
            for (int i = 0; i < pokemonsDisponibles.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {pokemonsDisponibles[i].Nom}");
            }
            for (int i = 0; i < 3; i++)
            {
                int choix = int.Parse(Console.ReadLine()) - 1;
                if (choix >=0 & choix <= pokemonsDisponibles.Count)
                {
                    AjouterPokemon(pokemonsDisponibles[choix]);
                }
                else
                {
                    Console.WriteLine("Choix invalide.");
                    i--;
                }
            }
        }

        public void AjouterPokemon(Pokemon pokemon)
        {
            this.pokemons.Add(pokemon);
        }
}
