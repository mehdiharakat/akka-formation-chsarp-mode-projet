using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace DAL.Entities
{
    [Table("Grille")]
    public class TblGrille
    {
        // l'ID de la grille
        [Key]
        public int ID_Grille { get; set; }

        // la Hauteur de la grille.
        public int Hauteur { get; set; }

        // la largeur de la grille.
        public int Largeur { get; set; }

        // le nombre de personnages dans grille.
        public int Nb_Personnages { get; set; }

        List<TblPartie> parties { get; set; }
        
    }
}
