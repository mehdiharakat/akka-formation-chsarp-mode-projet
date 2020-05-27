using System;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection.Emit;
using System.Text;

namespace BEL.Entites
{
    public class Personnage
    {
        #region Attributs

        // Nom du personnage.
        public string Nom { get; set; }

        // Clans du personnage.
        public string Clans { get; set; }

        // Point de vie du personnage.
        public int Point_Vie { get; set; }

        // Nombre de pas autorisé pour le personnage.
        public int Nb_Pas { get; set; }

        // la position du personnage.
        public Point position { get; set; }

        #endregion

        #region Constructeurs

        /// <summary>
        /// Constructeur sans params.
        /// </summary>
        public Personnage()
        {

        }

        /// <summary>
        /// Constructeur avec params.
        /// </summary>
        /// <param name="Hauteur"></param>
        /// <param name="Largeur"></param>
        public Personnage(int Hauteur, int Largeur, string clans)
        {
            if (clans == "Ennemie")
            {
                Clans = "Ennemie";
                Random aleatoire = new Random();
                position = new Point(aleatoire.Next(0, Hauteur), aleatoire.Next(0, Largeur));
                Nb_Pas = 3;
            }
            else 
            {
                Clans = "Joueur";
                position = new Point(0, 0);
                Nb_Pas = 3;
            }
        }
        #endregion

        #region Methodes

        /// <summary>
        /// Methode pour deplasser les personnages du jeux. 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public void Deplassement(ConsoleKey? consoleKey, int Hauteur , int Largeur)
        {
            if(this.Clans == "Ennemie")
            {
                
                    for (int j = 0; j < Nb_Pas; j++)
                    {
                        
                            if ((Hauteur - 1) > position.X || position.X == 0)
                            {
                        position = new Point(position.X + 1, position.Y);
                    }
                            else
                            {
                        position = new Point(position.X - 1, position.Y);
                    }

                            if ((Largeur - 1) > position.Y || position.Y == 0)
                            {
                        position = new Point(position.X, position.Y + 1);
                    }
                            else
                            {
                        position = new Point(position.X, position.Y - 1);
                    }


                        
                    }
                
            }
            else
            {
                switch (consoleKey)
                {
                    case ConsoleKey.RightArrow:
                        position = new Point(position.X, position.Y+1);
                        break;
                    case ConsoleKey.LeftArrow:
                        position = new Point(position.X, position.Y - 1);
                        break;
                    case ConsoleKey.UpArrow:
                        position = new Point(position.X - 1, position.Y);
                        break;
                    case ConsoleKey.DownArrow:
                        position = new Point(position.X + 1, position.Y);
                        break;
                }

                Nb_Pas--;
            }
            
        }

        /// <summary>
        /// Methode pour attaquer les ennemies 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public void Attaque(float x, float y)
        {

        }
        /// <summary>
        /// Methode pour se defendre 
        /// </summary>
        public void Defense()
        {

        }
        #endregion
    }
}
