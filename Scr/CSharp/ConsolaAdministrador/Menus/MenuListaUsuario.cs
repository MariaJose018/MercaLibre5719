using System;
using System.Collections.Generic;
using System.Text;
using Mercalibre15;
using MenuesConsola;

namespace ConsolaAdministrador.Menus
{ 
        public class menuListaUsuario : MenuListador<Usuario>
        {
            public override void imprimirElemento(Usuario usuario)
            {
                Console.WriteLine($"ID :{usuario.Id} Nombre : {usuario.Nombre} Apellido :{usuario.Apellido}");
            }

            public override List<Usuario> obtenerLista() =>AdoAdministrador.ADO.obtenerUsuarios();

        }
    
}
