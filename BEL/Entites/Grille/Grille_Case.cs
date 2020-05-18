using System;
using System.Collections.Generic;
using System.Text;

namespace BEL.Entites.Grille
{
    public class Grille_Case
    {
        #region Atributs

        public static int _posx = 0;

        public static int _posy = 0;

        public bool _etat_case;

        public Personnage personnage { get; set; }

        public bool Etat_case { get => _etat_case; set => _etat_case = value; }
        public int Posx { get => _posx; set => _posx = value; }
        public int Posy { get => _posy; set => _posy = value; }

        #endregion

        #region Methodes
        /// <summary>
        /// Dessiner un caratcter dans une position x,y
        /// </summary>
        /// <param name="s"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public static void Dessiner_caractere(string s, int x, int y)
        {
            try
            {
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
        public void Dessiner_Case()
        {

            // Dessinez le côté gauche, du bas en haut.
            Dessiner_caractere("+", 0, 0);
            Dessiner_caractere("|", 0, 1);
            Dessiner_caractere("|", 0, 2);
            Dessiner_caractere("+", 0, 3);

            // Dessinez le côté inférieur, de la gauche à la droite.
            Dessiner_caractere("-", 1, 3);
            Dessiner_caractere("-", 2, 3);
            Dessiner_caractere("-", 3, 3);
            Dessiner_caractere("+", 4, 3);

            // Dessinez le côté droit, du bas en haut.
            Dessiner_caractere("|", 4, 2);
            Dessiner_caractere("|", 4, 1);
            Dessiner_caractere("+", 4, 0);

            //  Dessinez le côté supérieur, de la droite à la gauche.
            Dessiner_caractere("-", 3, 0);
            Dessiner_caractere("-", 2, 0);
            Dessiner_caractere("-", 1, 0);
        }
        #endregion

    }
}
