using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace Mercalibre15
{


    [Table("Compraventa")]
    public class Compraventa
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key, Column("id")]

        public short Id { get; set; }

        [ForeignKey("idproducto"), Required]
        public Producto Producto { get; set; }

        [ForeignKey("idusuarioCompra"), Required]
        public Usuario Usuario { get; set; }

        [Column("Cantunidades"), Required]
        public int Cantunidades { get; set; }

        [Column("Precio"), Required]
        public float Precio { get; set; }

        [Column("fechayhora"), Required]
        public DateTime Fechayhora { get; set; }



        public Compraventa(){}


        public Compraventa(Producto producto, Usuario comprador, int cantunidades)
        {
            Producto = producto;
            Usuario = comprador;
            Cantunidades = cantunidades;
            Precio = producto.PrecioUnitario;
            Fechayhora = DateTime.Now;
        }
        public bool entre(DateTime inicio, DateTime fin)
        {
            return inicio <= Fechayhora && Fechayhora <= fin;
        }
        public void eliminarusuariodelaventa ()
        {
            Usuario = null;
        }

        [NotMapped]
        public double total => Cantunidades * Precio;
    }
}
