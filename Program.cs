namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Tester classe pokemon, creer un pokemon ajoute attaque, afficher liste attaques
            Pokemon p = new Pokemon("Pikachu", 100, new List<string> { "electrique" }, 100, 50, 50, 50, 50, 50, 50, new List<Attaque>());
            Attaque a = new Attaque("eclair", "electrique", "speciale", 100, 100, 10);
            Attaque b = new Attaque("danse lames", "normal", "physique", 100, 100, 10);
            Attaque c = new Attaque("lance flamme", "feu", "speciale", 100, 100, 10);
            p.AjouterAttaque(a);
            p.AjouterAttaque(b);
            p.AjouterAttaque(c);
            p.Afficher();
        }
    }
}
