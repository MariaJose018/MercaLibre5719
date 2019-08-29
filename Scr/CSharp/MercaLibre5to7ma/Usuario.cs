using System;
using System.Collections.Generic;
using System.Text;using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mercalibre15
{
    
        [Table("Usuario")]
        public class Usuario
        {

            [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            [Key, Column("idusuario")]

            public byte Id { get; set; }

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

            [Column("contrasenia"), StringLength(45), Required]
            public string Contrasenia { get; set; }




            public Usuario() { }

            public Usuario(string nombre, string apellido, int telefono, string nombredeusuario, string email, string contrasenia)
            {
                Nombre = nombre;
                Apellido = apellido;
                Telefono = telefono;
                Nombredeusuario = nombredeusuario;
                Email = email;
                Contrasenia = contrasenia;

            }
        }
    
}
