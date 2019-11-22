using System;
using System.Collections.Generic;
using System.Text;

namespace ConsolaUsuario
{
    public class Program
    {
        static void Main(string[] args)
        {
            var login = new Login() { Nombre = "Inicio Usuario" };
            login.mostrar();
        }
    }
}
