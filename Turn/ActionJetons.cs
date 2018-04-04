using System;
using System.Collections.Generic;
using System.Text;

namespace Turn
{
    /// <summary>
    /// Fonctions correspondant aux différentes actions possibles avec les jetons
    /// </summary>
    public class ActionJetons
    {
        public void TournerCase()
        {
            Console.WriteLine("Rotation effectuée");
        }

        public void DeplacerCase()
        {
            Console.WriteLine("Cases interverties");
        }

        public void PiocherCarte()
        {
            Console.WriteLine("Carte piochée");
        }

        public void Sherlock()
        {
            Random rnd = new Random();
            int nb = rnd.Next(1, 3);
            Console.WriteLine("Sherlock a avancé de " + nb + " case/s");
        }

        public void Watson()
        {
            Random rnd = new Random();
            int nb = rnd.Next(1, 3);
            Console.WriteLine("Watson a avancé de " + nb + " case/s");
        }

        public void ChienToby()
        {
            Random rnd = new Random();
            int nb = rnd.Next(1, 3);
            Console.WriteLine("Toby a avancé de " + nb + " case/s");
        }

        public void Joker()
        {
            string detective = "";
            Random rnd = new Random();
            int result = rnd.Next(1, 4);
            if (result == 1)
                detective = "Sherlock";
            if (result == 2)
                detective = "Watson";
            if (result == 3)
                detective = "Toby";

            int nb = rnd.Next(0, 2);
            Console.WriteLine(detective + " a avancé de " + nb + " case");
        }
    }
}
