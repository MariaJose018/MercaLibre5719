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

        public short Id { get; set; }

        [ForeignKey ("idvendedor") , Required]

        public Usuario usuario { get; set; }

        [Column("Producto"), StringLength(45), Required]
        public string Nombre { get; set; }

        [Column("Precio"), Required]
        public float PrecioUnitario { get; set; }

        [Column("cantidad"), Required]
        public int cantidad { get; set; }

        [Column("fechapublicacion"), Required]
        public DateTime fechapublicacion { get; set; }

        public List<Compraventa> productosEnVentas { get; set; }
        
        public Producto() { }

        public void agregarventas (Compraventa compraventa)
        {
            productosEnVentas.Add(compraventa);
        }

        public Producto(string nombre, int precio, int cantidades, DateTime fecha)
        {
            fechapublicacion = fecha;
            cantidad = cantidades;
            PrecioUnitario = precio;
            Nombre = nombre;
        }
        public float recaudacionpara(DateTime inicio, DateTime fin)
        {          
            return productosEnVentas.FindAll(h => h.entre(inicio, fin)).Sum(l => l.Precio);
        }
        public void DecrementarCantidad(int unidades)
        {
            cantidad -= unidades;
        }

        public void cambiarPrecio(float precio)
        {
            PrecioUnitario = precio;           
        }

        public bool stockSuficiente(int cantidad)
        {
            return cantidad <= this.cantidad;
        }


        public void eliminarventa(Compraventa compraventa)
        {
           cantidad = + compraventa.Cantunidades;
           productosEnVentas.Remove(compraventa);
           
        }


    }
}
