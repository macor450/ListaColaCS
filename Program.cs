using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaColaCS
{
    class Program
    {
        static void Main(string[] args)
        {
            Cola c = new Cola();

            int opcionMenu = 0;

            do
            {
                System.Console.WriteLine("\n|-------------------------------|");
                System.Console.WriteLine("|     * Concepto de Cola *      |");
                System.Console.WriteLine("|---------------|---------------|");
                System.Console.WriteLine("| 1. Encolar    | 4. Desencolar |");
                System.Console.WriteLine("| 2. Buscar     | 5. Mostrar    |");
                System.Console.WriteLine("| 3. Modificar  | 6. Salir      |");
                System.Console.WriteLine("|---------------|---------------|");
                System.Console.WriteLine("|     Selecciona una Opcion     |");
                opcionMenu = int.Parse(Console.ReadLine());
                switch (opcionMenu)
                {
                    case 1:
                        System.Console.WriteLine("\n\n Encolar un nodo en la cola \n");
                        c.Encolar();
                        break;
                    case 2:
                        System.Console.WriteLine("\n\n Buscar un nodo en la cola \n");
                        c.buscarNodo();
                        break;
                    case 3:
                        System.Console.WriteLine("\n\n Modificar un nodo en la cola \n");
                        c.modificarNodo();
                        break;
                    case 4:
                        System.Console.WriteLine("\n\n Desencolar un nodo en la cola \n");
                        c.Desencolar();
                        break;
                    case 5:
                        System.Console.WriteLine("\n\n Mostrar cola de nodos \n");
                        c.Mostrar();
                        break;
                    case 6:
                        System.Console.WriteLine("\n\n Programa Finalizado.... \n");
                        break;
                    default:
                        System.Console.WriteLine("\n\n Opcion No Valida.... \n");
                        break;
                }
            } while (opcionMenu != 6);
            c.Guardar("ListaCola.txt");
        }

    }
}
