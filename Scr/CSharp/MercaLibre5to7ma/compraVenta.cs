using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MercaLibre5to7ma
{
    
    
        [Table("Compraventa")]
        public class Compraventa
        {

            [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            [Key, Column("id")]

            public byte Id { get; set; }

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



            public Compraventa()
            {

            }


            public Compraventa(Producto producto, Usuario usuario, int cantunidades, float precio, DateTime fechayhora)
            {
                Producto = producto;
                Usuario = usuario;
                Cantunidades = cantunidades;
                Precio = precio;
                Fechayhora = fechayhora;
            }

        }
}
