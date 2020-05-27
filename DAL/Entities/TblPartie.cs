using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace DAL.Entities
{
    [Table("Partie")]
    public class TblPartie
    {
        // Id de la partie.
        [Key]
        public int ID_Partie { get; set; }

        // Id de la grille.
        [ForeignKey("Grille")]
        public int ID_Grille { get; set; }
        public TblGrille Grille { get; set;}

        // Indicateur si la partie est terminée ou pas.
        public bool Finie { get; set; }
    }
}
