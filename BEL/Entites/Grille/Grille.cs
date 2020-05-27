using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;


namespace BEL.Entites.Grille
{
    public class Grille
    {

        #region Atrubuts

        // la Hauteur de la grille.
        public int Hauteur { get; set; }

        // la largeur de la grille.
        public int Largeur { get; set; }

        // le nombre de personnages dans grille.
        public List<Personnage> Nbperso { get; set; }

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
        /// <param name="Haut"></param>
        /// <param name="Larg"></param>
        /// <param name="Nbpalyer"></param>
        public Grille(int Haut, int Larg, int Nbpalyer)
        {
            this.Hauteur = Haut;
            this.Largeur = Larg;
            Personnage Perso = new Personnage(0, 0, "Joueur");
            Nbperso = new List<Personnage>();
            Nbperso.Add(Perso);
            for (int ii = 1; ii < Nbpalyer; ii++)
            {
                Perso = new Personnage(Hauteur, Largeur, "Ennemie");
                Nbperso.Add(Perso);
            }
            
            
        }

        #endregion

        #region Methodes
        /// <summary>
        /// Dessiner la grille 
        /// </summary>
        public void DessinerGrille(ConsoleColor color)
        {
            Grille_Case[,] Case = new Grille_Case[Hauteur, Largeur];
            Case[0, 0] = new Grille_Case();
            Case[0, 0].Posx = 0;
            Case[0, 0].Posy = 0;
            Personnage del = null;
            int test = 0;
            foreach (Personnage i in Nbperso)
            {
                if (Nbperso[0].position.X == i.position.X && test != 0)
                {
                    if (Nbperso[0].position.Y == i.position.Y)
                    {
                        del = i;
                    }
                }
                test++;

            }
            if (del != null)
            {
                Nbperso.Remove(del);
            }

            for (int i = 0; i < Hauteur; i++)
            {
                for (int j = 0; j < Largeur; j++)
                {

                    Case[i, j] = new Grille_Case();
                    Console.BackgroundColor = ConsoleColor.Black;
                    Case[i, j].DessinerCase();
                    for (int ii = 0; ii < Nbperso.Count; ii++)
                    {

                        if (i == Nbperso[ii].position.X && j == Nbperso[ii].position.Y)
                        {
                            Console.BackgroundColor = ConsoleColor.Red;
                            Case[i, j].DessinerPersonnage("Ennemie");

                        }
                    }
                    if (i == Nbperso[0].position.X && j == Nbperso[0].position.Y)
                    {
                        Console.BackgroundColor = color;
                        Case[i, j].DessinerPersonnage("Joueur");
                    }


                    Case[i, j].Posx += 4;
                }

                Case[i, 0].Posy += 3;
                Case[i, 0].Posx = 0;
            }
            Console.BackgroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(0,20);
            Console.WriteLine("veuillez utiliser les fleches pour se deplasser.");
            Console.WriteLine("pour tuer un ennemie il faut se mettre en dessous de lui.");
        }



        #endregion


    }
}
