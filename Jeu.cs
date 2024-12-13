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
            Jouer();
        }

        public void Jouer()
        {
            this.nombreRounds = 0;
            this.joueurs.Clear();

            Console.WriteLine("Entrez le nom du joueur :");
            string nom = Console.ReadLine();
            joueurs.Add(new Joueur(nom));
            Console.WriteLine($"Vous avez {joueurs[0].Argent} pieces");
            joueurs[0].ChoisirPokemon();

            Console.WriteLine("Entrez le nom du joueur 2 :");
            nom = Console.ReadLine();
            joueurs.Add(new Joueur(nom));
            Console.WriteLine($"Vous avez {joueurs[1].Argent} pieces");
            joueurs[1].ChoisirPokemon();

            while (nombreRounds < 3)
            {
                nombreRounds++;

                Console.WriteLine("-----------Round " + nombreRounds + "-----------");
                
                Pokemon pokemon1 = joueurs[0].RecupererPokemon(nombreRounds - 1);
                Pokemon pokemon2 = joueurs[1].RecupererPokemon(nombreRounds - 1);

                while (pokemon1.PointsDeVie > 0 && pokemon2.PointsDeVie > 0)
                {
                    // Choix des attaques
                    Console.WriteLine($"{joueurs[0].Nom} choisissez une attaque :");
                    Attaque attaque1 = joueurs[0].ChoisirAttaque(pokemon1);
                    Console.WriteLine($"{joueurs[1].Nom} choisissez une attaque :");
                    Attaque attaque2 = joueurs[1].ChoisirAttaque(pokemon2);

                    // Debut des hostilités
                    if (pokemon1.Vitesse >= pokemon2.Vitesse)
                    {
                        pokemon1.Attaquer(pokemon2, attaque1);
                        if (!pokemon2.EstKO())
                        {
                            pokemon2.Attaquer(pokemon1, attaque2);
                        }
                    }
                    else
                    {
                        pokemon2.Attaquer(pokemon1, attaque2);
                        if (!pokemon1.EstKO())
                        {
                            pokemon1.Attaquer(pokemon2, attaque1);
                        }
                    }
                }

                // Verification du vainqueur
                if (pokemon1.EstKO() || !pokemon1.ADesPPDisponibles())
                {
                    joueurs[1].MancheGagnee++;
                }
                if (pokemon2.EstKO() || !pokemon2.ADesPPDisponibles())
                {
                    joueurs[0].MancheGagnee++;
                }

                Console.WriteLine("--------Statut des joueurs---------");
                joueurs[0].Afficher();
                Console.WriteLine("-----------");
                joueurs[1].Afficher();
            }

            //Determiner le gagnant
            Console.WriteLine("-----------Fin du jeu-----------");
            if (joueurs[0].MancheGagnee > joueurs[1].MancheGagnee)
            {
                Console.WriteLine($"{joueurs[0].Nom} a gagne le jeu");
            }
            else
            {
                Console.WriteLine($"{joueurs[1].Nom} a gagne le jeu");
            }

            // Demander si les joueurs veulent rejouer
            Console.WriteLine("Voulez-vous rejouer ? (oui/non)");
            string reponse = Console.ReadLine();
            if (reponse.ToLower() == "oui")
            {
                Jouer();
            }
        }
    }
}
