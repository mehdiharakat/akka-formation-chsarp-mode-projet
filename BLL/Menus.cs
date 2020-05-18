using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public class Menus
    {
        #region Methodes
        /// <summary>
        /// Dessiner le menu principale 
        /// </summary>
        public void Dessiner_Menu_Principale()
        {
            string choix;
            Console.WriteLine("*************** Menu principale *****************");
            Console.WriteLine("|                                               |");
            Console.WriteLine("|             1 > Choix de joueur               |");
            Console.WriteLine("|                                               |");
            Console.WriteLine("|             2 > Quitter le jeu                |");
            Console.WriteLine("|                                               |");
            Console.WriteLine("|                                               |");
            Console.WriteLine("*************************************************");
            choix = Console.ReadLine() ;

            switch (choix)
            {
                case "1":
                    Console.Clear();
                    Dessiner_Menu_Choix_Joueur();
                    
                    break;
                case "2":
                    Environment.Exit(0);
                    break;      
            }
        }

        public void Dessiner_Menu_Choix_Joueur()
        {
            string choix;
            Console.WriteLine("*************** Menu principale *****************");
            Console.WriteLine("|                                               |");
            Console.WriteLine("|             1 > ANAKIN SKYWALKER              |");
            Console.WriteLine("|                                               |");
            Console.WriteLine("|             2 > BOBA FETT                     |");
            Console.WriteLine("|                                               |");
            Console.WriteLine("|             3 > CAL KESTIS                    |");
            Console.WriteLine("|                                               |");
            Console.WriteLine("|             4 > STORMTROOPERS                 |");
            Console.WriteLine("|                                               |");
            Console.WriteLine("|             5 > Retour                        |");
            Console.WriteLine("|                                               |");
            Console.WriteLine("|             6 > Quitter le jeux               |");
            Console.WriteLine("|                                               |");
            Console.WriteLine("|                                               |");
            Console.WriteLine("*************************************************");
            choix = Console.ReadLine();

            switch (choix)
            {
                case "1":

                    break;
                case "2":

                    break;
                case "3":

                    break;
                case "4":

                    break;
                case "5":
                    Console.Clear();
                    Dessiner_Menu_Principale();
                    break;
                case "6":
                    Environment.Exit(0);
                    break;
          
            }
        }
        #endregion

    }
}
