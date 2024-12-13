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
        public int MancheGagnee { get => mancheGagnee; set => mancheGagnee = value; }
        public int Argent { get => argent; }
        public List<Pokemon> Pokemons { get => pokemons; }

        public Joueur(string nom)
        {
            this.nom = nom;
            this.mancheGagnee = 0;
            this.argent = 500;
            this.pokemons = new List<Pokemon>();
        }

        public void ChoisirPokemon()
        {
            List<Pokemon> pokemonsDisponibles = new List<Pokemon>();

            // Création des attaques
            Attaque eclair = new Attaque("Éclair", "Électrique", "spéciale", 100, 40, 30);
            Attaque fouetLianes = new Attaque("Fouet Lianes", "Plante", "physique", 100, 45, 25);
            Attaque flammeche = new Attaque("Flammèche", "Feu", "spéciale", 100, 40, 25);
            Attaque pistoletAO = new Attaque("Pistolet à O", "Eau", "spéciale", 100, 40, 25);
            Attaque charge = new Attaque("Charge", "Normal", "physique", 100, 50, 35);
            Attaque morsure = new Attaque("Morsure", "Ténèbres", "physique", 100, 60, 25);

            // Création des Pokémon
            Pokemon pikachu = new Pokemon("Pikachu", 100, new List<string> { "Électrique" }, 35, 5, 55, 50, 40, 50, 90);
            pikachu.AjouterAttaque(eclair);

            Pokemon bulbizarre = new Pokemon("Bulbizarre", 150, new List<string> { "Plante", "Poison" }, 45, 5, 49, 65, 49, 65, 45);
            bulbizarre.AjouterAttaque(fouetLianes);

            Pokemon salameche = new Pokemon("Salamèche", 200, new List<string> { "Feu" }, 39, 5, 52, 60, 43, 50, 65);
            salameche.AjouterAttaque(flammeche);

            Pokemon carapuce = new Pokemon("Carapuce", 150, new List<string> { "Eau" }, 44, 5, 48, 50, 65, 64, 43);
            carapuce.AjouterAttaque(pistoletAO);

            Pokemon rattata = new Pokemon("Rattata", 50, new List<string> { "Normal" }, 30, 5, 56, 25, 35, 35, 72);
            rattata.AjouterAttaque(charge);

            Pokemon evoli = new Pokemon("Évoli", 100, new List<string> { "Normal" }, 55, 5, 55, 45, 50, 65, 55);
            evoli.AjouterAttaque(morsure);

            // Ajout des Pokémon à la liste des Pokémon disponibles
            pokemonsDisponibles.Add(pikachu);
            pokemonsDisponibles.Add(bulbizarre);
            pokemonsDisponibles.Add(salameche);
            pokemonsDisponibles.Add(carapuce);
            pokemonsDisponibles.Add(rattata);
            pokemonsDisponibles.Add(evoli);

            Console.WriteLine("Choisissez 3 Pokémon parmi la liste suivante :");
            for (int i = 0; i < pokemonsDisponibles.Count; i++)
            {
                //donne le nom et le prix du pokemon
                Console.WriteLine($"{i + 1}. {pokemonsDisponibles[i].Nom} - {pokemonsDisponibles[i].Prix} Poké Dollars");
            }
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Choix n°" + (i+1));
                int choix = int.Parse(Console.ReadLine()) - 1;
                if (choix >= 0 && choix <= pokemonsDisponibles.Count)
                {
                    AjouterPokemon(pokemonsDisponibles[choix]);
                    this.argent -= pokemonsDisponibles[choix].Prix;
                    Console.WriteLine($"Vous avez choisi {pokemonsDisponibles[choix].Nom}");
                    Console.WriteLine("Il vous reste " + this.argent + " pieces");
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

        public Attaque ChoisirAttaque(Pokemon pokemon)
        {
            for (int i = 0; i < pokemon.Attaques.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {pokemon.Attaques[i].Nom}");
            }
            int choix = int.Parse(Console.ReadLine()) - 1;
            while (choix < 0 || choix >= pokemon.Attaques.Count)
            {
                Console.WriteLine("Choix de numero d'attaque invalide.");
                choix = int.Parse(Console.ReadLine()) - 1;
            }
            return pokemon.Attaques[choix];
        }

        public Pokemon RecupererPokemon(int numeroPokemon)
        {
            return this.pokemons[numeroPokemon];
        }

        public void AfficherPokemons()
        {
            Console.WriteLine("Pokémons de " + this.nom + " :");
            foreach (Pokemon pokemon in this.pokemons)
            {
                Console.WriteLine("-----------");
                pokemon.Afficher();
                Console.WriteLine("-----------");
            }
        }

        public void Afficher()
        {
            Console.WriteLine("Infos Joueur : ");
            Console.WriteLine("Nom : " + this.nom);
            Console.WriteLine("Manche gagnée : " + this.mancheGagnee);
            Console.WriteLine("Argent : " + this.argent + " Poké Dollars");
        }
    }
}