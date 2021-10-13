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
            int reponse = 0; // saisie de la réponse de l'utilisateur
            int choix; // saisie du choix de l'utilsiateur
            bool correct = false;

            // boucle sur le menu
            choix = 1;
            while (choix != 0)
            {
                // affiche le menu et saisi le choix
                Console.WriteLine("Addition ....................... 1");
                Console.WriteLine("Multiplication ................. 2");
                Console.WriteLine("Quitter ........................ 0");

                while (!correct)
                {
                    try
                    {
                        Console.Write("Choix :                          ");
                        choix = int.Parse(Console.ReadLine());
                        correct = true;
                    }
                    catch
                    {
                        Console.WriteLine("Erreur de saisie, veuillez choisir une des options proposes");
                    }
                }
                // traitement des choix
                correct = false;
                if (choix != 0)
                {
                    if (choix == 1)
                    {
                        // choix de l'addition
                        val1 = rand.Next(1, 10);
                        val2 = rand.Next(1, 10);
                        // saisie de la réponse
                        while (!correct)
                        {
                            try
                            {
                                Console.Write(val1 + " + " + val2 + " = ");
                                reponse = int.Parse(Console.ReadLine());
                                correct = true;
                                     
                            }
                            catch
                            { 
                                Console.WriteLine("Erreur de saisie,Entrez un nombre entier");
                            }
                        }// comparaison avec la bonne réponse
                        correct = false;
                        solution = val1 + val2;
                        if (reponse == solution)
                        {
                            Console.WriteLine("Bravo !");
                        }
                        else
                        {
                            Console.WriteLine("Faux : " + val1 + " + " + val2 + " = " + solution);
                        }
                    }
                    else
                    {
                        while (choix > 2)
                        {
                            try
                            {
                                Console.WriteLine("Erreur de saisie, choix invalide");
                                choix = int.Parse(Console.ReadLine());
                            }
                            catch
                            {
                                Console.WriteLine("Erreur de saisie,Veuillez choisir une des options proposes");
                            }
                        }
                        while (choix <= 0)
                        {
                            try
                            {
                                Console.WriteLine("Erreur de saisie, choix invalide");
                                choix = int.Parse(Console.ReadLine());
                            }
                            catch
                            {
                                Console.WriteLine("Erreur de saisie,Veuillez choisir une des options proposes");
                            }
                        }
                        // choix de la multiplication
                        val1 = rand.Next(1, 10);
                        val2 = rand.Next(1, 10);
                        // saisie de la réponse
                        while(!correct)
                         {
                            try
                            {
                                Console.Write(val1 + " x " + val2 + " = ");
                                reponse = int.Parse(Console.ReadLine());
                                correct = true;
                            }
                            catch
                            { Console.WriteLine("Erreur de saisie,Entrez un nombre entier");
                            }
                        }
                        correct = false;
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
                    }
                }
            }
        }
    }
} 
