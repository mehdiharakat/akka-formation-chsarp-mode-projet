using System;
using System.Collections.Generic;
using System.Text;
using BEL.Entites.Grille;

namespace BLL
{
    public class Jeux
    {
        #region Methodes

        /// <summary>
        /// Jouer un pas.
        /// </summary>
        /// <param name="grille"></param>
        public void jouer(Grille grille, ConsoleColor Perso_color)
        {
            ConsoleKey consoleKey;
            do
            {
                Console.BackgroundColor = ConsoleColor.Black;
                do
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    grille.DessinerGrille(Perso_color);

                    consoleKey = Console.ReadKey().Key;
                    grille.Nbperso[0].Deplassement(consoleKey, grille.Hauteur, grille.Largeur);
                    Console.Clear();
                } while (grille.Nbperso[0].Nb_Pas != 0);
                if (grille.Nbperso.Count > 1)
                {
                    for (int i = 1; i < grille.Nbperso.Count; i++)
                    {
                        grille.Nbperso[i].Deplassement(consoleKey, grille.Hauteur, grille.Largeur);
                    }

                }

                grille.DessinerGrille(Perso_color);
                Console.SetCursorPosition(20, 20);
                grille.Nbperso[0].Nb_Pas = 3;

            } while (grille.Nbperso.Count > 1);


        }

        #endregion
    }
}
