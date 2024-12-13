using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Jeu
    {
        private List<Joueur> joueurs;
        private int nombreRounds;

        public Jeu()
        {
            this.joueurs = new List<Joueur>();
            this.nombreRounds = 3;
        }

        public void Jouer()
        {
            Console.WriteLine("Entrez le nom du joueur :");
            string nom = Console.ReadLine();
            joueurs.Add(new Joueur(nom));
            Console.WriteLine("Choisissez vos pokemons :");
            joueurs[0].ChoisirPokemon();
            Console.WriteLine("Entrez le nom du joueur 2 :");
            nom = Console.ReadLine();
            joueurs.Add(new Joueur(nom));
            Console.WriteLine("Choisissez vos pokemons :");
            joueurs[1].ChoisirPokemon();


        }
    }
}
