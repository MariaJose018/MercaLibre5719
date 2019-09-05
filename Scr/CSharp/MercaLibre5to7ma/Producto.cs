using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace Mercalibre15
{

    [Table("Producto")]
    public class Producto
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key, Column("idproducto")]

        public byte Id { get; set; }

        [ForeignKey("idusuariovendedor"), Required]
        public Compraventa Compraventa { get; set; }

        [Column("Producto"), StringLength(45), Required]
        public string Nombre { get; set; }

        [Column("Precio"), Required]
        public float PrecioUnitario { get; set; }

        [Column("cantidad"), Required]
        public int cantidad { get; set; }

        [Column("fechapublicacion"), Required]
        public DateTime fechapublicacion { get; set; }

        public List<Compraventa> ventas { get; set; }
        



        public Producto() { }


        public Producto(string nombre, int precio, int cantidades, DateTime fecha, Compraventa compraventa)
        {
            fechapublicacion = fecha;
            cantidad = cantidades;
            PrecioUnitario = precio;
            Nombre = nombre;
            Compraventa = compraventa;

        }
<<<<<<< HEAD
        public float recaudacionpara(DateTime inicio, DateTime fin)
        {
           
            return ventas.FindAll(h => h.entre(inicio, fin)).Sum(l => l.Precio);
        }
=======
        public void decrementarCantidad(short unidades)
        {
            cantidad -= unidades;
        }

        public void cambiarPrecio(float precio)
        {
            PrecioUnitario = precio;           
        }

>>>>>>> 2b5c306441b37700876c67ea5ae2fbf51db43b08





    }
}
