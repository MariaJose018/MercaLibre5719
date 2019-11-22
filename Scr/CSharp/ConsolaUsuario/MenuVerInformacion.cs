using System;
using System.Collections.Generic;
using System.Text;
using Mercalibre15;
using MenuesConsola;

namespace ConsolaUsuario
{
    public class MenuVerInformacion : MenuListador<Usuario>
    {
        private Usuario usuario;

        public MenuVerInformacion(Usuario usuario)
        {
            this.usuario = usuario;
        }

        public override void imprimirElemento(Usuario elemento)
        {
            Console.WriteLine($"{elemento.Nombre}\t\t{elemento.Nombredeusuario}");
        }

        public override List<Usuario> obtenerLista() => AdoUsuario.ADO.obtenerUsuarios();
       
    }
}
}
