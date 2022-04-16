using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListaDiccionario40
{
    public class Validador
    {
        public static string PedirString(string mensaje)
        {
            string valor;
            bool valido = false;
            string mensajeError = "\n El valor no puede ser vacio y tiene que estar dentro del rango solicitado. ";

            do
            {
                Console.WriteLine(mensaje);
                valor = Console.ReadLine();

                if (valor == "")
                {
                    Console.Clear();
                    Console.WriteLine(mensajeError);
                }
                else
                {
                    valido = true;
                }

            } while (!valido);
            return valor;

        }
        /*
        public static void RegistrarNumero(ref int[] arregloNumero)
        {
            for (int i = 0; i < arregloNumero.Length; i++)
            {
                int numero;

                /*Este Do while verifica que el dato número "x" no se vuelva a ingresar dos veces
                  porque la funcion BuscarNumero verifica que ya hay una posicion para "x"  */
             /*   do
                {

                    numero = PedirS("\n Ingrese el número " + (i + 1).ToString() + ": ");
                    Console.Clear();
                    if (!(BuscarNumero(arregloNumero, numero) == -1))
                    {
                        Console.Clear();
                        Console.WriteLine("El elemento *" + numero + "* ya existe. Utilice otra forma de nombrarlo");
                    }

                } while (BuscarNumero(arregloNumero, numero) != -1);
                arregloNumero[i] = numero;

            }

        }
        */
        public static int BuscarNumero(int[] arregloNumeros, int numero)
        {
            int posicion = -1;
            for (int i = 0; i < arregloNumeros.Length; i++)
            {
                /*Si el nombre ingresado por el usuario coincide con alguno del arreglo se retorna la posicion valida*/
                if (arregloNumeros[i] == numero)
                {
                    posicion = i;
                }


            }
            return posicion;
        }

        public static void MostrarListado(string[] arregloNumero)
        {
            /*Console.Clear();*/
            Console.WriteLine("\n Listado de elementos en el Arreglo");
            for (int i = 0; i < arregloNumero.Length; i++)
            {
                Console.WriteLine(" " + arregloNumero[i]);
            }
        }

        public static void Bienvenida()
        {
            Console.WriteLine("\n Bienvenido al Programa");
        }

        public static void Despedida()
        {

            Console.WriteLine("\n Gracias por usar nuestro Sistema presione cualquier teclar para finalizar");
            Console.ReadKey();
        }
    }
}
