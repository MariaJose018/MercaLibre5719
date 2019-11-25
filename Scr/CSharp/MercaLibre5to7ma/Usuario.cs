using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using NETCore.Encrypt;

namespace Mercalibre15
{

    [Table("Usuario")]
    public class Usuario
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key, Column("idusuario")]

        public short Id { get; set; }

        [Column("Nombre"), StringLength(45), Required]
        public string Nombre { get; set; }

        [Column("Apellido"), StringLength(45), Required]
        public string Apellido { get; set; }

        [Column("Telefono"), Required]
        public int Telefono { get; set; }

        [Column("Nombredeusuario"), StringLength(45), Required]
        public string Nombredeusuario { get; set; }

        [Column("Email"), StringLength(45), Required]
        public string Email { get; set; }

        [Column("contrasenia"), StringLength(64), Required]
        public string Contrasenia { get; set; }
        public List<Compraventa> compras { get; set; }
        public List<Producto> ventas {get; set ;}




        public Usuario()
        {
            compras = new List<Compraventa>();
            ventas = new List<Producto>();
        }
        public void agregarCompraVenta(Compraventa compraventa)
        {
            compras.Add(compraventa);
        }
        public void agregarproducto(Producto producto)
        {
            ventas.Add(producto);
            producto.usuario = this;
        }

        public Usuario(string nombre, string apellido, int telefono, string nombredeusuario, string email, string contrasenia)
        {
            Nombre = nombre;
            Apellido = apellido;
            Telefono = telefono;
            Nombredeusuario = nombredeusuario;
            Email = email;
            Contrasenia = contrasenia;
            
        }
        public double recaudacionTotal(DateTime inicio, DateTime fin)
        {
            return ventas.Sum(P => P.recaudacionpara(inicio ,fin ));
        }
        public void eliminarcompra(Compraventa compraventa)
        {
            compras.Remove(compraventa);
            
        }

        public void comprar(Producto producto, int cantidad)
        {
            if (producto.stockSuficiente(cantidad))
            {
                Compraventa compraVenta = new Compraventa(producto, this, cantidad);
                producto.DecrementarCantidad(cantidad);
                
            }
        }
    }

}
