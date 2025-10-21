namespace Listas
{
    namespace Listas
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                Pila pila = new Pila();
                Cola cola = new Cola();

                int opcionPrincipal;
                do
                {
                    Console.Clear();
                    Console.WriteLine("Seleccione una estructura:");
                    Console.WriteLine("1. Pila");
                    Console.WriteLine("2. Cola");
                    Console.WriteLine("0. Salir");
                    Console.Write("Opción: ");
                    if (!int.TryParse(Console.ReadLine(), out opcionPrincipal)) opcionPrincipal = -1;

                    switch (opcionPrincipal)
                    {
                        case 1:
                            SubmenuPila(pila);
                            break;
                        case 2:
                            SubmenuCola(cola);
                            break;
                        case 0:
                            Console.WriteLine("Saliendo...");
                            break;
                        default:
                            Console.WriteLine("Opción inválida. Presiona Enter para continuar.");
                            Console.ReadLine();
                            break;
                    }
                } while (opcionPrincipal != 0);
            }

            static void SubmenuPila(Pila pila)
            {
                int opcion;
                do
                {
                    Console.Clear();
                    Console.WriteLine("PILA - Seleccione una operación:");
                    Console.WriteLine("1. Agregar");
                    Console.WriteLine("2. Eliminar");
                    Console.WriteLine("3. Ver elementos");
                    Console.WriteLine("0. Volver al menú principal");
                    Console.Write("Opción: ");
                    if (!int.TryParse(Console.ReadLine(), out opcion)) opcion = -1;

                    switch (opcion)
                    {
                        case 1:
                            Console.Write("Ingrese el dato a agregar: ");
                            string datoPila = Console.ReadLine();
                            pila.Agregar(datoPila);
                            break;
                        case 2:
                            try
                            {
                                pila.Eliminar();
                                Console.WriteLine("Elemento eliminado.");
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("ERROR: " + ex.Message);
                            }
                            break;
                        case 3:
                            Console.WriteLine("Elementos en la pila:");
                            Console.WriteLine(pila.Imprimir());
                            break;
                        case 0:
                            break;
                        default:
                            Console.WriteLine("Opción inválida.");
                            break;
                    }
                    if (opcion != 0)
                    {
                        Console.WriteLine("Presione Enter para continuar...");
                        Console.ReadLine();
                    }
                } while (opcion != 0);
            }

            static void SubmenuCola(Cola cola)
            {
                int opcion;
                do
                {
                    Console.Clear();
                    Console.WriteLine("COLA - Seleccione una operación:");
                    Console.WriteLine("1. Agregar");
                    Console.WriteLine("2. Eliminar");
                    Console.WriteLine("3. Ver elementos");
                    Console.WriteLine("0. Volver al menú principal");
                    Console.Write("Opción: ");
                    if (!int.TryParse(Console.ReadLine(), out opcion)) opcion = -1;

                    switch (opcion)
                    {
                        case 1:
                            Console.Write("Ingrese el dato a agregar: ");
                            string datoCola = Console.ReadLine();
                            cola.Agregar(datoCola);
                            break;
                        case 2:
                            try
                            {
                                cola.Eliminar();
                                Console.WriteLine("Elemento eliminado.");
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("ERROR: " + ex.Message);
                            }
                            break;
                        case 3:
                            Console.WriteLine("Elementos en la cola:");
                            Console.WriteLine(cola.Imprimir());
                            break;
                        case 0:
                            break;
                        default:
                            Console.WriteLine("Opción inválida.");
                            break;
                    }
                    if (opcion != 0)
                    {
                        Console.WriteLine("Presione Enter para continuar...");
                        Console.ReadLine();
                    }
                } while (opcion != 0);
            }
        }
    }

}





