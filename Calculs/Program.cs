/**
 * Application "Calculs" v01 (b5 a218)
 * author : Emds
 * date : 24/05/2020
 */
using System;

namespace Calculs
{
    class Program
    {
        static void Main(string[] args)
        {
            // variables 
            Random rand = new Random(); // outil de génération de nombre aléatoire
            int val1, val2; // mémorisation de nombres aléatoires
            int solution; // calcul de la solution
            int reponse; // saisie de la réponse de l'utilisateur
            int choix; // saisie du choix de l'utilsiateur
            bool cpavrè = false;
            bool pabon = true;

            // boucle sur le menu
            choix = 1;
            while (choix!=0)
            {
                while (pabon)
                {
                    // affiche le menu et saisi le choix
                    Console.WriteLine("Addition ....................... 1");
                    Console.WriteLine("Multiplication ................. 2");
                    Console.WriteLine("Quitter ........................ 0");
                    Console.Write("Choix :                          ");
                    choix = int.Parse(Console.ReadLine());
                    if (choix < 0 && choix > 2)
                    {
                        Console.WriteLine("Erreur dans le choix de la fonctionnalité");
                    }
                    else
                    {
                        pabon = false;
                    }
                }
                if (choix != 0)
                {
                    if (choix == 1)
                    {
                        // choix de l'addition
                        val1 = rand.Next(1, 10);
                        val2 = rand.Next(1, 10);
                        while (!cpavrè)
                        {
                            try
                            {
                                // saisie de la réponse
                                Console.Write(val1 + " + " + val2 + " = ");
                                reponse = int.Parse(Console.ReadLine());
                                // comparaison avec la bonne réponse
                                solution = val1 + val2;
                                cpavrè = true;
                                if (reponse == solution)
                                {
                                    Console.WriteLine("Bravo !");
                                }
                                else
                                {
                                    Console.WriteLine("Faux : " + val1 + " + " + val2 + " = " + solution);
                                }
                            }
                            catch
                            {
                                Console.WriteLine("Erreur de valeur");
                            }

                        }

                    }
                    else
                    {
                        while (!cpavrè)
                        {
                            // choix de la multiplication
                            val1 = rand.Next(1, 10);
                            val2 = rand.Next(1, 10);
                            try
                            {

                                // saisie de la réponse
                                Console.Write(val1 + " x " + val2 + " = ");
                                reponse = int.Parse(Console.ReadLine());
                                // comparaison avec la bonne réponse
                                solution = val1 * val2;

                                if (reponse == solution)
                                {
                                    Console.WriteLine("Bravo !");
                                }
                                else
                                {
                                    Console.WriteLine("Faux : " + val1 + " x " + val2 + " = " + solution);
                                }
                                cpavrè = true;
                            }
                            catch
                            {
                                Console.WriteLine("Erreur de valeur");
                            }
                        
                        }
                    }
                }
            }
        }
    }
}
