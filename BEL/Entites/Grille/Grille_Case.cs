using System;
using System.Collections.Generic;
using System.Text;

namespace BEL.Entites.Grille
{
    public class Grille_Case
    {
        #region Atributs

        // position X de la case dans la grille.
        public static int _posx = 0;

        // position Y de la case dans la grille.
        public static int _posy = 0;

        // etat de la case vide/remplie.
        public bool _etat_case;

        // le personnage dans la case.
        public Personnage personnage { get; set; }

        // Proprieté de l'etat de la case.
        public bool Etat_case { get => _etat_case; set => _etat_case = value; }

        // Proprieté de la position X de la case dans la grille.
        public int Posx { get => _posx; set => _posx = value; }

        // Proprieté de la position Y de la case dans la grille.
        public int Posy { get => _posy; set => _posy = value; }

        #endregion

        #region Methodes
        /// <summary>
        /// Dessiner un caratcter dans une position x,y
        /// </summary>
        /// <param name="s"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public static void DessinerCaractere(string s, int x, int y)
        {
            try
            {
                Console.OutputEncoding = System.Text.Encoding.Unicode;
                Console.SetCursorPosition(_posx + x, _posy + y);
                Console.Write(s);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.Clear();
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Dessiner la case de la grille
        /// </summary>
        public void DessinerCase()
        {

            // Dessinez le côté gauche, du bas en haut.
            DessinerCaractere("╬", 0, 0);
            DessinerCaractere("║", 0, 1);
            DessinerCaractere("║", 0, 2);
            DessinerCaractere("╬", 0, 3);

            // Dessinez le côté inférieur, de la gauche à la droite.
            DessinerCaractere("═", 1, 3);
            DessinerCaractere("═", 2, 3);
            DessinerCaractere("═", 3, 3);
            DessinerCaractere("╬", 4, 3);

            // Dessinez le côté droit, du bas en haut.
            DessinerCaractere("║", 4, 2);
            DessinerCaractere("║", 4, 1);
            DessinerCaractere("╬", 4, 0);

            //  Dessinez le côté supérieur, de la droite à la gauche.
            DessinerCaractere("═", 3, 0);
            DessinerCaractere("═", 2, 0);
            DessinerCaractere("═", 1, 0);
        }

        /// <summary>
        /// Methode pour dessiner un personnage dans la case de la grille.
        /// </summary>
        public void DessinerPersonnage(string Clans)
        {
            if(Clans == "Ennemie")
            {
                DessinerCaractere("☻", 2, 1);
                DessinerCaractere("⁞", 2, 2);
            }
            else 
            {
                DessinerCaractere("\x263A", 2, 1);
                DessinerCaractere("⁞", 2, 2);
            }

        }

        #endregion

    }
}
