using System;
using System.Collections.Generic;
using System.Text;
using Mercalibre15;
using MenuesConsola;
using NETCore.Encrypt;

namespace ConsolaUsuario
{
    class MenuAltaUsuario : MenuCompuesto
    {

        public Usuario usuario { get; set; }
        public override void mostrar()
        {
            base.mostrar();

            var dni = Convert.ToInt32(prompt("Ingrese DNI"));
            var nombre = prompt("Ingrese nombre cajero");
            var apellido = prompt("Ingrese apellido");
            //Uso la libreria System.ReadLine para leer una contraseña
            var pass = ReadPassword("Ingrese contraseña: ");
            pass = EncryptProvider.Sha256(pass);

            usuario = new Usuario()
            {
                Apellido = apellido,
                Nombre = nombre,
                Contrasenia = pass
            };

            try
            {
                AdoUsuario.ADO.altaCajero(usuario);
                Console.WriteLine("Cajero dada de alta con exito");
            }
            catch (Exception e)
            {
                Console.WriteLine($"No se pudo dar de alta: {e.Message}");
            }
            Console.ReadKey();
        }
    }
}
