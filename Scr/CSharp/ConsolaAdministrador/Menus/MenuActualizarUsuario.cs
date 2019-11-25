using MenuesConsola;
using Mercalibre15;
using NETCore.Encrypt;
using System;
using System.Collections.Generic;

namespace ConsolaAdministrador.Menus
{
    public class MenuActualizarUsuario : MenuComponente
    {
        public Usuario usuario { get; set; }
        public List<Usuario> usuarios { get; set; }
        public menuListaUsuario MenuListaUsuario { get; set; }


        public override void mostrar()
        {
            base.mostrar();
            bool cambio = false;
                                          
            var usuario = MenuListaUsuario.seleccionarElemento();

            var usuarioid = Convert.ToInt32(prompt("ingrese id del usuario"));
            if (usuario.Id == usuarioid)
            {
                usuario.Nombre = prompt("Ingrese nuevo nombre:");
                usuario.Apellido = prompt("Ingrese nuevo apellido:");
                usuario.Email = prompt("Ingrese nuevo email:");
                usuario.Contrasenia = EncryptProvider.Sha256(prompt("Ingrese nuevo contrasenia:"));
                usuario.Nombredeusuario = prompt("Ingrese nuevo nombre de usuario:");
            }
            cambio = true;

            if (cambio)
            {
                try
                {
                    AdoAdministrador.ADO.mUsuario(usuario);
                    Console.WriteLine("Información actualizada con exito");
                }
                catch (Exception e)
                {
                    Console.WriteLine($"No se pudo modificar por: {e.InnerException.Message}");
                }
            }
            Console.ReadKey();
        }
    }
}

