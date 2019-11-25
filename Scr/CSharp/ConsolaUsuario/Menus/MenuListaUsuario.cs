using System;
using System.Collections.Generic;
using System.Text;
using Mercalibre15;
using MenuesConsola;

namespace ConsolaUsuario
{
    public class MenuListaUsuario : MenuListador<Usuario>
    {
        private Usuario usuario;

        public MenuListaUsuario(Usuario usuario)
        {
            this.usuario = usuario;
        }

        public override void imprimirElemento(Usuario usuario)
        {
            Console.WriteLine(usuario);
        }

        public override List<Usuario> obtenerLista() => AdoUsuario.ADO.obtenerUsuarios();

    }
}


