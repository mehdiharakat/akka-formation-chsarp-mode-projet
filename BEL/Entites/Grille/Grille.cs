using System;
using System.Collections.Generic;
using System.Text;

namespace BEL.Entites.Grille
{
    public class Grille
    {

        #region Atrubuts

        public int Hauteur { get; set; }

        public int Largeur { get; set; }

        #endregion

        #region costructeurs
        /// <summary>
        /// Constructeur sans paramètres
        /// </summary>
        public Grille()
        {

        }
        /// <summary>
        /// Constructeur avec paramètres
        /// </summary>
        /// <param name="haut"></param>
        /// <param name="larg"></param>
        public Grille(int haut, int larg)
        {
            this.Hauteur = haut;
            this.Largeur = larg;
        }

        #endregion

        #region Methodes
        /// <summary>
        /// Dessiner la grille 
        /// </summary>
        public void dessiner_grille()
        {
            Grille_Case[,] a = new Grille_Case[Hauteur, Largeur];


            for (int i = 0; i < Hauteur; i++)
            {
                for (int j = 0; j < Largeur; j++)
                {

                    a[i, j] = new Grille_Case();
                    a[i, j].Dessiner_Case();
                    a[i, j].Posx += 4;
                }

                a[i, 0].Posy += 3;
                a[i, 0].Posx = 0;
            }
        }

        #endregion


    }
}
