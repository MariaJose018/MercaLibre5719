using System;
using System.Collections.Generic;
using System.Text;
using Mercalibre15;
using ConsolaAdministrador.Menus;
using MenuesConsola;

namespace ConsolaAdministrador.Menus
{
    public class MenuActualizarUsuario : MenuComponente
    {
        public Usuario usuario { get; set; }

        public void menuActualizarInformacion()
        {
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

            if (preguntaCerrada("¿Cambiar apellido?"))
            {
                usuario.Apellido = prompt("Ingrese apellido:");
                cambio = true;
            }

            if (preguntaCerrada("¿Cambiar teléfono?"))
            {
                usuario.Telefono = int.Parse("Ingrese un teléfono:");
                cambio = true;
            }
            if (preguntaCerrada("¿Cambiar contraseña?"))
            {
                usuario.Contrasenia = prompt("Ingrese una contraseña nueva:");
                cambio = true;
            }

            if (cambio)
            {
                try
                {
                    AdoAdministrador.ADO.Ausuario(usuario);
                    Console.WriteLine("Información actualizada con exito");
                }
                catch (Exception e)
                {
                    Console.WriteLine($"No se pudo modificar por: {e.InnerException.Message}");
                }
                Console.ReadKey();
            }
        }
        private bool preguntaCerrada(string v)
        {
            throw new NotImplementedException();
        }
    }
}
