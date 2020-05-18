using System;
using BEL;
using BEL.Entites.Grille;

namespace Jeux_StarWars
{
    class Program
    {
        static void Main(string[] args)
        {
            // test dessiner grille
            Grille grille = new Grille(10,10) ;
            grille.dessiner_grille();
        }
    }
}
