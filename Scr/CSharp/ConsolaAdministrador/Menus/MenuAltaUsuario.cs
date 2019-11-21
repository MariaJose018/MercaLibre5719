using System;
using System.Collections.Generic;
using System.Text;
using MenuesConsola;
using Mercalibre15;
using static System.ReadLine;
using NETCore.Encrypt;

namespace ConsolaAdministrador
{
    class MenuAltaUsuario : MenuComponente
    {
        public Usuario usuario { get; set; }
        public override void mostrar()
        {
            base.mostrar();

            var nombre = prompt("Ingrese nombre del usuario");
            var apellido = prompt("Ingrese apellido");
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
                AdoAdministrador.ADO.altaUsuario(usuario);
                Console.WriteLine("usuario dada de alta con exito");
            }
            catch (Exception e)
            {
                Console.WriteLine($"No se pudo dar de alta: {e.Message}");
            }
            Console.ReadKey();
        }
    }
}
