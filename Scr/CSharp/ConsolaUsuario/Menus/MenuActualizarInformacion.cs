
using System;
using System.Collections.Generic;
using System.Text;
using Mercalibre15;
using MenuesConsola;
using NETCore.Encrypt;

namespace ConsolaUsuario
{
    public class MenuActualizarInformacion : MenuComponente
    {
        public MenuActualizarInformacion(Usuario usuario)
        {
            this.usuario = usuario;
        }

        public Usuario usuario { get; set; }

        public override void mostrar()
        {

            base.mostrar();
            bool cambio = false;

            if (preguntaCerrada("¿Cambiar nombre?"))
            {
                usuario.Nombre = prompt("Ingrese nombre");
                cambio = true;
            }

            if (preguntaCerrada("¿Cambiar apellido?"))
            {
                usuario.Apellido = prompt("Ingrese apellido:");
                cambio = true;
            }

            if (preguntaCerrada("¿Cambiar nombre de usuario?"))
            {
                usuario.Nombredeusuario = prompt("Ingrese nombre de usuario:");
                cambio = true;
            }

            if (preguntaCerrada("¿Cambiar teléfono?"))
            {
                usuario.Telefono =int.Parse(prompt("Ingrese un teléfono:"));
                cambio = true;
            }
            if (preguntaCerrada("¿Cambiar contraseña?"))
            {
                usuario.Contrasenia = EncryptProvider.Sha256(prompt("Ingrese una contraseña nueva:"));
                cambio = true;
            }

            if (cambio)
            {
                try
                {
                    AdoUsuario.ADO.mUsuario(usuario);
                    Console.WriteLine("Información actualizada con exito");
                }
                catch (Exception e)
                {
                    Console.WriteLine($"No se pudo modificar por: {e.InnerException.Message}");
                }
                Console.ReadKey();


            }

        }
    }
}