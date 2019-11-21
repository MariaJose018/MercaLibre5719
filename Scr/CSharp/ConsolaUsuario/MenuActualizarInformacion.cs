using System;
using System.Collections.Generic;
using System.Text;
using Mercalibre15;
using MenuesConsola;

namespace ConsolaUsuario
{
    public class MenuActualizarInformacion : MenuComponente
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
        }
  
    }
}
