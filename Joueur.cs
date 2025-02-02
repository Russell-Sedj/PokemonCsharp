﻿using System;
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
            this.argent = 1000;
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
            Attaque griffe = new Attaque("Griffe", "Normal", "physique", 100, 40, 30);
            Attaque attaqueCharge = new Attaque("Attaque Charge", "Normal", "physique", 100, 30, 40);
            Attaque psyko = new Attaque("Psyko", "Psychique", "spéciale", 100, 70, 20);
            Attaque lueur = new Attaque("Lueur", "Fée", "spéciale", 100, 50, 30);
            Attaque morsureAcier = new Attaque("Morsure Acier", "Acier", "physique", 100, 80, 25);

            // Création des Pokémon
            Pokemon pikachu = new Pokemon("Pikachu", 100, new List<string> { "Électrique" }, 35, 5, 55, 50, 40, 50, 90);
            pikachu.AjouterAttaque(eclair);
            pikachu.AjouterAttaque(charge);
            pikachu.AjouterAttaque(morsure);

            Pokemon bulbizarre = new Pokemon("Bulbizarre", 150, new List<string> { "Plante", "Poison" }, 45, 5, 49, 65, 49, 65, 45);
            bulbizarre.AjouterAttaque(fouetLianes);
            bulbizarre.AjouterAttaque(griffe);
            bulbizarre.AjouterAttaque(pistoletAO);

            Pokemon salameche = new Pokemon("Salamèche", 200, new List<string> { "Feu" }, 39, 5, 52, 60, 43, 50, 65);
            salameche.AjouterAttaque(flammeche);
            salameche.AjouterAttaque(griffe);
            salameche.AjouterAttaque(charge);

            Pokemon carapuce = new Pokemon("Carapuce", 150, new List<string> { "Eau" }, 44, 5, 48, 50, 65, 64, 43);
            carapuce.AjouterAttaque(pistoletAO);
            carapuce.AjouterAttaque(charge);
            carapuce.AjouterAttaque(morsure);

            Pokemon rattata = new Pokemon("Rattata", 50, new List<string> { "Normal" }, 30, 5, 56, 25, 35, 35, 72);
            rattata.AjouterAttaque(charge);
            rattata.AjouterAttaque(griffe);
            rattata.AjouterAttaque(morsure);

            Pokemon evoli = new Pokemon("Évoli", 100, new List<string> { "Normal" }, 55, 5, 55, 45, 50, 65, 55);
            evoli.AjouterAttaque(morsure);
            evoli.AjouterAttaque(griffe);
            evoli.AjouterAttaque(lueur);

            Pokemon tyranocif = new Pokemon("Tyranocif", 300, new List<string> { "Roche", "Ténèbres" }, 100, 10, 134, 110, 90, 100, 61);
            tyranocif.AjouterAttaque(morsureAcier);
            tyranocif.AjouterAttaque(flammeche);
            tyranocif.AjouterAttaque(psyko);

            Pokemon dracolosse = new Pokemon("Dracolosse", 350, new List<string> { "Dragon", "Vol" }, 91, 10, 134, 95, 80, 105, 100);
            dracolosse.AjouterAttaque(flammeche);
            dracolosse.AjouterAttaque(psyko);
            dracolosse.AjouterAttaque(pistoletAO);

            Pokemon joliscar = new Pokemon("Joliscar", 220, new List<string> { "Insecte", "Poison" }, 70, 10, 100, 75, 70, 80, 85);
            joliscar.AjouterAttaque(fouetLianes);
            joliscar.AjouterAttaque(psyko);
            joliscar.AjouterAttaque(morsure);

            Pokemon aquali = new Pokemon("Aquali", 200, new List<string> { "Eau" }, 65, 10, 95, 65, 65, 85, 110);
            aquali.AjouterAttaque(pistoletAO);
            aquali.AjouterAttaque(lueur);
            aquali.AjouterAttaque(charge);

            Pokemon arcanin = new Pokemon("Arcanin", 250, new List<string> { "Feu" }, 90, 10, 110, 100, 80, 90, 95);
            arcanin.AjouterAttaque(flammeche);
            arcanin.AjouterAttaque(griffe);
            arcanin.AjouterAttaque(morsure);

            Pokemon tyranitar = new Pokemon("Tyranitar", 400, new List<string> { "Roche", "Ténèbres" }, 100, 10, 134, 110, 90, 100, 61);
            tyranitar.AjouterAttaque(morsureAcier);
            tyranitar.AjouterAttaque(flammeche);
            tyranitar.AjouterAttaque(psyko);

            // Ajout des Pokémon à la liste des Pokémon disponibles
            pokemonsDisponibles.Add(pikachu);
            pokemonsDisponibles.Add(bulbizarre);
            pokemonsDisponibles.Add(salameche);
            pokemonsDisponibles.Add(carapuce);
            pokemonsDisponibles.Add(rattata);
            pokemonsDisponibles.Add(evoli);
            pokemonsDisponibles.Add(tyranocif);
            pokemonsDisponibles.Add(dracolosse);
            pokemonsDisponibles.Add(joliscar);
            pokemonsDisponibles.Add(aquali);

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
                    if (this.argent < 0)
                    {
                        this.argent = 0;
                    }
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