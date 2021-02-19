using System;

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
            
            Console.WriteLine("Les jours de la semaine sont:");
            //Boucle permettant pour chaque entrée de l'énum, d'écrire la valeur de l'énum grâce à GetNames
            foreach (string day in week.GetNames(typeof(week)))
            {
                Console.WriteLine(day);
            }
            

        }
    }
}
