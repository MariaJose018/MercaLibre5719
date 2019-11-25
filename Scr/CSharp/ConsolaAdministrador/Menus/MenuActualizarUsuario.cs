using System;
using System.Collections.Generic;
using System.Text;
using Mercalibre15;
using Mercalibre15.ADO;
using ConsolaAdministrador.Menus;
using MenuesConsola;

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



            if (preguntaCerrada("¿actualizar usuario?"))
            {
                var usuario = MenuListaUsuario.seleccionarElemento();

                    var usuarioid = Convert.ToInt32(prompt("ingrese id del usuario"));
                    if (usuario.Id == usuarioid)
                    {
                        usuario.Nombre = prompt("Ingrese nuevo nombre:");
                        usuario.Apellido = prompt("Ingrese nuevo apellido:");
                        usuario.Email = prompt("Ingrese nuevo email:");
                        usuario.Contrasenia = prompt("Ingrese nuevo contrasenia:");
                        usuario.Nombredeusuario = prompt("Ingrese nuevo nombre de usuario:");

                    }
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
            }
            Console.ReadKey();
        }
    }
}

