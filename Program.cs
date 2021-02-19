using System;
using System.Linq;

namespace CSHARP_Listes_Exo6
{
    class Program
    {
        //création de l'énumération
        enum week
                { 
                    Lundi,
                    Mardi,
                    Mercredi,
                    Jeudi,
                    Vendredi,
                    Samedi,
                    Dimanche
                }
        static void Main(string[] args)
        {
            
            Console.WriteLine("\nBOUCLE ForEach : Les jours de la semaine sont:");
            //Boucle permettant pour chaque entrée de l'énum, d'écrire la valeur de l'énum grâce à GetNames
            foreach (string day in week.GetNames(typeof(week)))
            {
                Console.WriteLine(day);
            }

            Console.WriteLine("\nSTRING JOIN : Les jours de la semaine sont:");
            //Boucle permettant pour chaque entrée de l'énum, d'écrire la valeur de l'énum grâce à GetNames
            string weekDays = String.Join("\n", week.GetNames(typeof(week)));
            Console.WriteLine(weekDays);

            //Afficher le jour en valeur 4
            var fourth = (week)4;
            Console.WriteLine($"\nLe jour en valeur 4 est : {fourth} ");

        }
    }
}
/*
Créer une énumération week  contenant les éléments suivants :

    Lundi
    Mardi
    Mercredi
    Jeudi
    Vendredi
    Samedi
    Dimanche

Afficher tous les éléments de week dans la console.
Dans une nouvelle ligne, afficher la valeur 4 de l’énumération week.
*/