
using System;
 
namespace Autocar
{
    public class Autocar
    {
        /*Fonction qui renvoie la durée en minutes choisit par l'utilisateur*/
        static public int MenuDuree() {    
            Console.WriteLine("Choisissez votre temps de trajet maximal:");
            Console.WriteLine("1) 3h");
            Console.WriteLine("2) 3h30");
            Console.WriteLine("3) 4h");
            Console.WriteLine("4) Quitter");
            var result = Console.ReadLine();
            if (result == "1")
                return 180;
            else if (result == "2") 
                return 210;
            else if (result == "3")
                return 240;
            else if (result == "4")
            {
                Environment.Exit(0);
                return -1;
            }
            else
                return 0;
        }

        /*Fonction qui renvoie le budget max de l'utilisateur*/
        static public int MenuBudget()
        {
            Console.WriteLine("Choisissez votre budget maximal:");
            Console.WriteLine("1) 10€");
            Console.WriteLine("2) 8€");
            Console.WriteLine("3) 6€");
            Console.WriteLine("4) Quitter");
            var result = Console.ReadLine();
            if (result == "1")
                return 10;
            else if (result == "2")
                return 8;
            else if (result == "3")
                return 6;
            else if (result == "4")
            {
                Environment.Exit(0); 
                return -1;
            }
            else
                return 0;
        }

        /* Fonction qui renvoie les solutions en fonction de la duree et du budget */
        static public string Algo(int duree, int budget)
        {
            string reponse = "";
            if (budget == 10 && duree == 240)
                reponse += "Lille - Paris\nLille - Arras - Paris\nLille - Compiegne - Paris\nLille - Arras - Compiegne - Paris";
            else if (budget == 8 && duree == 240)
                reponse += "Lille - Arras - Paris\nLille - Compiegne - Paris\nLille - Arras - Compiegne - Paris";
            else if (budget == 6 && duree == 240)
                reponse += "Lille - Arras - Compiegne - Paris";
            else if (budget == 10 && duree == 210)
                reponse += "Lille - Paris\nLille - Arras - Paris\nLille - Compiegne - Paris";
            else if (budget == 8 && duree == 210)
                reponse += "Lille - Arras - Paris\nLille - Compiegne - Paris";
            else if (budget == 10 && duree == 180)
                reponse += "Lille - Paris";
            else
                reponse += "Pas de solution";
            return reponse;
        }

        static public void Main(string[] args)
        {
            while (true)
            {
                int budget = 0;
                int duree = 0;
                string reponse = "";
                budget = MenuBudget();
                duree = MenuDuree();
                reponse = Algo(duree, budget);
                Console.WriteLine(reponse);
            }
        }
    }
}