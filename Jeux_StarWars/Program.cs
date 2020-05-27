using System;
using System.Collections.Generic;
using System.Linq;
using BEL;
using BEL.Entites.Grille;
using BLL;
using DAL;
using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace Jeux_StarWars
{
    class Program
    {
        static void Main(string[] args)
        {
            // test dessiner grille
<<<<<<< HEAD
            //Grille grille = new Grille(10,10) ;
            //grille.dessiner_grille();

            // recuperer la partie.

            DAO dao = new DAO();
            TblGrille partie_grille = dao.RecupererGrillePartie();

            Grille grille = new Grille(partie_grille.Hauteur, partie_grille.Largeur, partie_grille.Nb_Personnages);
            
            // afficher le menu pricipale.

            Menus m = new Menus();
            m.DessinerMenuPrincipale(grille);

            
=======
            Grille grille = new Grille(10,10) ;
            grille.dessiner_grille();
>>>>>>> e9a4769a4045ecb7196c7509c709d3c37ab121db
        }
    }
}
