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
        public string Nom { get; set; }

        public string Clans { get; set; }

        public int Point_Vie { get; set; }

        public int Nb_Pas { get; set; }

        public PointF position { get; set; }

        #endregion

        #region Methodes

        /// <summary>
        /// Methode pour deplasser le personnage 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public void deplassement(float x, float y)
        {
            position = new PointF(x, y);
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
