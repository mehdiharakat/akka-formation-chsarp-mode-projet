using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL
{
    public class DAO
    {
        #region Methods

        /// <summary>
        /// Recuperer la derniere partie sauvgardée.
        /// </summary>
        /// <returns></returns>
        public TblGrille RecupererGrillePartie()
        {
            TblPartie partie = new TblPartie();
            TblGrille grille = new TblGrille();

            using (StarWarsDBContext DB = new StarWarsDBContext())
            {
                try
                {
                    partie = DB.parties.Where(x => x.Finie == false).FirstOrDefault();
                    grille = DB.grilles.Where(x => x.ID_Grille == partie.ID_Grille).FirstOrDefault();

                }
                catch(Exception ex)
                {
                    throw ex;
                }

                return grille;
            }
        }

        /// <summary>
        /// Sauvgarder la partie.
        /// </summary>
        public void SauvgarderPartie(TblPartie partie)
        {
            TblPartie partie_prec = new TblPartie();
            using (StarWarsDBContext DB = new StarWarsDBContext())
            {
                try
                {
                    partie_prec = DB.parties.Where(x => x.Finie == false).FirstOrDefault();
                    partie_prec.Finie = true;
                    DB.parties.Add(partie);
                    DB.SaveChanges();

                }
                catch (Exception ex)
                {
                    throw ex;
                }

            }
        }

        #endregion
    }
}
