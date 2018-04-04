using System;

namespace Turn
{
    class Program
    {
        static void Main(string[] args)
        {
            Turn turn = new Turn();
            string playertype = Console.ReadLine();
            
            

            if (turn.IsDetectiveStart())
            {
                turn.CurrentPlayer = PlayerType.Sherlock;
                Console.WriteLine("C'est au tour de " + turn.CurrentPlayer);
            }
            else
            {
                turn.CurrentPlayer = PlayerType.MrJack;
                Console.WriteLine("C'est au tour de " + turn.CurrentPlayer);
            }
            Console.WriteLine($"Nb de jetons récupérés: {turn.NbJetonAPiocher()}");

            turn.actions++;

            //turn.CurrentTurn++;
        }
        
        /*
         * Si tour impair   => on lance les jetons      => Le détective commence
         * Si tour pair     => on retourne les jetons   => Le criminel commence
         * on prend 1 jeton et on effectue son action
         * l'adversaire prend 2 jetons et effectue les actions
         * on prend le dernier jeton et on fait l'action
         * On regarde si les détectives ont repéré des suspects:
         *      -   Criminel non visible    => suspects visibles innocentés     => le criminel gagne un sablier
         *      -   Criminel visible        => suspects invisibles innocentés   => le détective gagne le jeton
         * On compte les sabliers du criminel
         */
    }
}
