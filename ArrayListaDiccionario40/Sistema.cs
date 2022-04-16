using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListaDiccionario40
{
    public class Sistema
    {
        public void MenuPrincipal()
        {
            Validador.Bienvenida();

            string frase = Validador.PedirString("\n Ingrese una frase");
            
            Console.WriteLine("\n Usted ingreso la frase: *" + frase + "*.");

            char delimitador = ' ';

            string[] valores = frase.Split(delimitador);

            Validador.MostrarListado(valores);


            Validador.Despedida();

        }

        public const int cantidad = 3;

        public void Iniciar()
        {
            MenuPrincipal();
        }
    }
}
