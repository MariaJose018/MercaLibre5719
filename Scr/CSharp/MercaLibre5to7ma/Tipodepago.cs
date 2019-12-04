using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;


namespace Mercalibre15
{
    [Table("Producto")]
    public class Tipodepago
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key, Column("idtipodepago")]
        public short Id { get; set; }

        [ForeignKey("idvendedor"), Required]
        public Usuario usuario { get; set; }

        [ForeignKey("idcomprador"), Required]
        public Compraventa Compraventa { get; set; }

        [Column("Tipo de Pago"), StringLength(45), Required]
        public string Nombre { get; set; }

        [Column("fechadepago"), Required]
        public DateTime fechadepago { get; set; }

        


    }
}
