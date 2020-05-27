using System;
using System.Collections.Generic;
using System.Text;
using BEL.Entites.Grille;

namespace BLL
{
    public class Menus
    {
        #region Methodes
        /// <summary>
        /// Dessiner le menu principale 
        /// </summary>
        public void DessinerMenuPrincipale(Grille grille)
        {
            ConsoleKey choix;
            Console.WriteLine("╔══════════════ Menu principale ════════════════╗");
            Console.WriteLine("║                                               ║");
            Console.WriteLine("║             1 > Choix de joueur               ║");
            Console.WriteLine("║                                               ║");
            Console.WriteLine("║             2 > Quitter le jeu                ║");
            Console.WriteLine("║                                               ║");
            Console.WriteLine("║                                               ║");
            Console.WriteLine("╚═══════════════════════════════════════════════╝");
            int ch = 2;
            Console.SetCursorPosition(14, 2);
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine("1 > Choix de joueur");
            Console.SetCursorPosition(14, 2);
            Console.BackgroundColor = ConsoleColor.Black;
            Boolean top = true;
            do
            {
                choix = Console.ReadKey().Key;
                switch (choix)
                {
                    case ConsoleKey.DownArrow:
                        Console.SetCursorPosition(14, 4);
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("2 > Quitter le jeu");
                        Console.SetCursorPosition(14, 2);
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.WriteLine("1 > Choix de joueur");
                        Console.SetCursorPosition(14, 2);
                        ch = 1;
                        break;
                    case ConsoleKey.UpArrow:
                        Console.SetCursorPosition(14, 2);
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("1 > Choix de joueur");
                        Console.SetCursorPosition(14, 4);
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.WriteLine("2 > Quitter le jeu");
                        Console.SetCursorPosition(14, 4);
                        ch = 2;
                        break;
                    case ConsoleKey.Enter:
                        if (ch == 2)
                        {
                            Console.Clear();
                            DessinerMenuChoixJoueur(grille);
                            top = false;

                        }
                        else if (ch == 1)
                        {
                            Environment.Exit(0);
                        }
                        break;
                }
            } while (top);
        }

        public void DessinerMenuChoixJoueur(Grille grille)
        {
            Jeux jx = new Jeux();
            int choix;
            Console.WriteLine("╔══════════════ Menu principale ════════════════╗");
            Console.WriteLine("║                                               ║");
            Console.WriteLine("║             1 > ANAKIN SKYWALKER              ║");
            Console.WriteLine("║                                               ║");
            Console.WriteLine("║             2 > BOBA FETT                     ║");
            Console.WriteLine("║                                               ║");
            Console.WriteLine("║             3 > CAL KESTIS                    ║");
            Console.WriteLine("║                                               ║");
            Console.WriteLine("║             4 > STORMTROOPERS                 ║");
            Console.WriteLine("║                                               ║");
            Console.WriteLine("║             5 > Retour                        ║");
            Console.WriteLine("║                                               ║");
            Console.WriteLine("║             6 > Quitter le jeux               ║");
            Console.WriteLine("║                                               ║");
            Console.WriteLine("║                                               ║");
            Console.WriteLine("╚═══════════════════════════════════════════════╝");
            Console.SetCursorPosition(14, 2);
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine("1 > ANAKIN SKYWALKER");
            Console.SetCursorPosition(14, 2);
            choix = 1;
            Console.BackgroundColor = ConsoleColor.Black;
            ConsoleKey consoleKey;
            bool top = true;

            do
            {
                consoleKey = Console.ReadKey().Key;
                switch (consoleKey)
                {
                    case ConsoleKey.DownArrow:
                        if (choix <= 5)
                        {
                            choix++;
                        }
                        switch (choix)
                        {
                            case 1:
                                Console.SetCursorPosition(14, 2);
                                Console.BackgroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("1 > ANAKIN SKYWALKER");
                                Console.SetCursorPosition(13, 2);
                                Console.BackgroundColor = ConsoleColor.Black;
                                break;
                            case 2:
                                Console.SetCursorPosition(14, 4);
                                Console.BackgroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("2 > BOBA FETT");
                                Console.SetCursorPosition(14, 2);
                                Console.BackgroundColor = ConsoleColor.Black;
                                Console.WriteLine("1 > ANAKIN SKYWALKER");
                                Console.SetCursorPosition(13, 2);

                                break;
                            case 3:
                                Console.SetCursorPosition(14, 6);
                                Console.BackgroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("3 > CAL KESTIS");
                                Console.SetCursorPosition(14, 4);
                                Console.BackgroundColor = ConsoleColor.Black;
                                Console.WriteLine("2 > BOBA FETT");
                                Console.SetCursorPosition(13, 4);

                                break;
                            case 4:
                                Console.SetCursorPosition(14, 8);
                                Console.BackgroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("4 > STORMTROOPERS");
                                Console.SetCursorPosition(14, 6);
                                Console.BackgroundColor = ConsoleColor.Black;
                                Console.WriteLine("3 > CAL KESTIS");
                                Console.SetCursorPosition(13, 6);
                                choix = 4;
                                break;
                            case 5:
                                Console.SetCursorPosition(14, 10);
                                Console.BackgroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("5 > Retour");
                                Console.SetCursorPosition(14, 8);
                                Console.BackgroundColor = ConsoleColor.Black;
                                Console.WriteLine("4 > STORMTROOPERS");
                                Console.SetCursorPosition(13, 8);

                                break;
                            case 6:
                                Console.SetCursorPosition(14, 12);
                                Console.BackgroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("6 > Quitter le jeux ");
                                Console.SetCursorPosition(14, 10);
                                Console.BackgroundColor = ConsoleColor.Black;
                                Console.WriteLine("5 > Retour");
                                Console.SetCursorPosition(13, 10);

                                break;


                        }

                        break;
                    case ConsoleKey.UpArrow:
                        if (choix >= 1)
                        {
                            choix--;
                        }
                        switch (choix)
                        {
                            case 1:
                                Console.SetCursorPosition(14, 2);
                                Console.BackgroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("1 > ANAKIN SKYWALKER");
                                Console.SetCursorPosition(14, 4);
                                Console.BackgroundColor = ConsoleColor.Black;
                                Console.WriteLine("2 > BOBA FETT");
                                Console.SetCursorPosition(13, 4);
                                break;
                            case 2:
                                Console.SetCursorPosition(14, 4);
                                Console.BackgroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("2 > BOBA FETT");
                                Console.SetCursorPosition(14, 6);
                                Console.BackgroundColor = ConsoleColor.Black;
                                Console.WriteLine("3 > CAL KESTIS");
                                Console.SetCursorPosition(13, 6);

                                break;
                            case 3:
                                Console.SetCursorPosition(14, 6);
                                Console.BackgroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("3 > CAL KESTIS");
                                Console.SetCursorPosition(14, 8);
                                Console.BackgroundColor = ConsoleColor.Black;
                                Console.WriteLine("4 > STORMTROOPERS");
                                Console.SetCursorPosition(13, 8);

                                break;
                            case 4:
                                Console.SetCursorPosition(14, 8);
                                Console.BackgroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("4 > STORMTROOPERS");
                                Console.SetCursorPosition(14, 10);
                                Console.BackgroundColor = ConsoleColor.Black;
                                Console.WriteLine("5 > Retour");
                                Console.SetCursorPosition(13, 10);
                                choix = 4;
                                break;
                            case 5:
                                Console.SetCursorPosition(14, 10);
                                Console.BackgroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("5 > Retour");
                                Console.SetCursorPosition(14, 12);
                                Console.BackgroundColor = ConsoleColor.Black;
                                Console.WriteLine("6 > Quitter le jeux ");
                                Console.SetCursorPosition(13, 12);

                                break;
                            case 6:
                                Console.SetCursorPosition(14, 12);
                                Console.BackgroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("6 > Quitter le jeux ");
                                Console.SetCursorPosition(13, 10);
                                Console.BackgroundColor = ConsoleColor.Black;
                                break;


                        }

                        break;
                    case ConsoleKey.Enter:
                        Console.Clear();
                        top = false;
                        switch (choix)
                        {
                            case 1:
                                jx.jouer(grille, ConsoleColor.Cyan);
                                break;
                            case 2:
                                jx.jouer(grille, ConsoleColor.White);
                                break;
                            case 3:
                                jx.jouer(grille, ConsoleColor.Yellow);
                                break;
                            case 4:
                                jx.jouer(grille, ConsoleColor.Green);
                                break;
                            case 5:
                                Console.Clear();
                                DessinerMenuPrincipale(grille);
                                break;
                            case 6:
                                Environment.Exit(0);
                                break;

                        }
                        break;
                }

                Console.BackgroundColor = ConsoleColor.Black;
            } while (top);
            
        }
        #endregion

    }
}
