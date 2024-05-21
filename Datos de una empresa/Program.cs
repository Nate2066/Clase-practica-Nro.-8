//By Nate :D

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos_de_una_empresa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nombres = new string[]
            {
            "Ana", "Bruno", "Carlos", "Diana", "Elena", "Felipe", "Gabriela", "Hector", "Isabel", "Jorge",
            "Karla", "Luis", "Marta", "Nestor", "Olga", "Pablo", "Queta", "Roberto", "Sandra", "Tomas",
            "Ursula", "Victor", "Wendy", "Ximena", "Yolanda", "Zacarias", "Andrea", "Benjamin", "Camila", "David",
            "Eva", "Federico", "Gloria", "Hernan", "Ines", "Jaime", "Laura", "Manuel", "Nina", "Oscar"
            };

            string[] direcciones = new string[]
            {
            "Calle A #1", "Calle B #2", "Calle C #3", "Calle D #4", "Calle E #5", "Calle F #6", "Calle G #7", "Calle H #8", "Calle I #9", "Calle J #10",
            "Calle K #11", "Calle L #12", "Calle M #13", "Calle N #14", "Calle O #15", "Calle P #16", "Calle Q #17", "Calle R #18", "Calle S #19", "Calle T #20",
            "Calle U #21", "Calle V #22", "Calle W #23", "Calle X #24", "Calle Y #25", "Calle Z #26", "Calle AA #27", "Calle BB #28", "Calle CC #29", "Calle DD #30",
            "Calle EE #31", "Calle FF #32", "Calle GG #33", "Calle HH #34", "Calle II #35", "Calle JJ #36", "Calle KK #37", "Calle LL #38", "Calle MM #39", "Calle NN #40"
            };

            string[] telefonos = new string[]
            {
            "555-0101", "555-0102", "555-0103", "555-0104", "555-0105", "555-0106", "555-0107", "555-0108", "555-0109", "555-0110",
            "555-0111", "555-0112", "555-0113", "555-0114", "555-0115", "555-0116", "555-0117", "555-0118", "555-0119", "555-0120",
            "555-0121", "555-0122", "555-0123", "555-0124", "555-0125", "555-0126", "555-0127", "555-0128", "555-0129", "555-0130",
            "555-0131", "555-0132", "555-0133", "555-0134", "555-0135", "555-0136", "555-0137", "555-0138", "555-0139", "555-0140"
            };

            string[] nivelesEstudio = new string[]
            {
            "Primaria", "Secundaria", "Bachillerato", "Universidad", "Maestría", "Doctorado", "Primaria", "Secundaria", "Bachillerato", "Universidad",
            "Maestría", "Doctorado", "Primaria", "Secundaria", "Bachillerato", "Universidad", "Maestría", "Doctorado", "Primaria", "Secundaria",
            "Bachillerato", "Universidad", "Maestría", "Doctorado", "Primaria", "Secundaria", "Bachillerato", "Universidad", "Maestría", "Doctorado",
            "Primaria", "Secundaria", "Bachillerato", "Universidad", "Maestría", "Doctorado", "Primaria", "Secundaria", "Bachillerato", "Universidad"
            };

            double[] dinero = new double[]
            {
            1200.50, 850.75, 950.00, 1250.30, 1020.90, 1600.40, 750.60, 890.50, 1100.00, 1150.20,
            1300.15, 1400.45, 1500.55, 920.80, 980.95, 1350.70, 1440.10, 1550.85, 1650.20, 1050.00,
            1750.35, 1850.50, 1950.75, 2050.90, 2150.65, 2250.80, 2350.95, 2450.10, 2550.25, 2650.40,
            2750.55, 2850.70, 2950.85, 3050.00, 3150.15, 3250.30, 3350.45, 3450.60, 3550.75, 3650.90
            };

            //Declaracion de variables principales
            bool OpcionSalir = false;
            bool OpcionVolver = false;

            try
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine("*-----------------Menu----------------*");
                    Console.WriteLine("                                       ");
                    Console.WriteLine("1.   Buscar datos de un cliente        ");
                    Console.WriteLine("2.   Mostrar cliente con mayor gasto   ");
                    Console.WriteLine("3.   Mostrar cliente con menor gasto   ");
                    Console.WriteLine("                                       ");
                    Console.WriteLine("4.                              | Salir");
                    Console.WriteLine("*-------------------------------------*");
                    byte OpcionMenu = Convert.ToByte(Console.ReadLine());

                    switch (OpcionMenu)
                    {
                        case 1:
                            do
                            {
                                Console.Clear();
                                Console.WriteLine("Ingrese el nombre del cliente que desea buscar");
                                string NombreCliente = Console.ReadLine();

                                int Validacion = Busqueda(nombres, NombreCliente);

                                if (Validacion == -1)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Nombre no encontrado");
                                    OpcionVolver = true;
                                    Console.ReadKey();
                                }
                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine("Datos del cliente:");
                                    Console.WriteLine("");
                                    Console.WriteLine("Nombre: " + nombres[Validacion]);
                                    Console.WriteLine("Direccion: " + direcciones[Validacion]);
                                    Console.WriteLine("Telefono: " + telefonos[Validacion]);
                                    Console.WriteLine("Nivel de estudio: " + nivelesEstudio[Validacion]);
                                    Console.WriteLine("");

                                    Console.WriteLine("1.   Volver");
                                    Console.WriteLine("2.   Salir");
                                    int opc = Convert.ToByte(Console.ReadLine());

                                    if(opc == 2)
                                    {
                                        Console.Clear();
                                        OpcionSalir = true;
                                        OpcionVolver = true;

                                    }
                                    else if(opc == 1) 
                                    {
                                        OpcionVolver = true;
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Opcion invalida");
                                        Console.ReadKey();
                                        OpcionVolver = true;
                                    }
                                }
                            } while (!OpcionVolver);
                            break;
                        case 2:
                            Console.Clear();

                            //Se copia la matriz "dinero" y la guardamos en otra matriz
                            double[] dineroguardado = new double[dinero.Length];
                            for(int i = 0; i < dineroguardado.Length; i++)
                            {
                                dineroguardado[i] = dinero[i];
                            }

                            //Uso del metodo bubble sort para ordenar la matriz "dinero" de forma ascendente y asi saber que dinero gastado es el mayor
                            MetodoBubbleSort(dinero);
                            int MayorGasto = dinero.Length -1;
                            double DineroMayorGasto = dinero[MayorGasto];

                            //Se llama al metodo de busqueda lineal para ubicar la posicion del dinero gastado dentro de la copia del arreglo "dinero" que previamente se hizo 
                          
                            int PosicionDinero = Busqueda(dineroguardado, DineroMayorGasto);

                            Console.WriteLine("La cifra de dinero con mayor gasto ha sido del cliente:");
                            Console.WriteLine(nombres[PosicionDinero]);
                            Console.WriteLine("Con un monto total de:");
                            Console.WriteLine(DineroMayorGasto);
                            Console.ReadKey();
                            break;
                        case 3:
                            Console.Clear();

                            //Se usa el mismo procedimiento que el caso Nro. 3 con una pequena diferencia
                            dineroguardado = new double[dinero.Length];
                            for (int i = 0; i < dineroguardado.Length; i++)
                            {
                                dineroguardado[i] = dinero[i];
                            }
 
                            MetodoBubbleSort(dinero);

                            int MenorGasto = 0;
                            double DineroMenorGasto = dinero[MenorGasto];

                            PosicionDinero = Busqueda(dineroguardado, DineroMenorGasto);

                            Console.WriteLine("La cifra de dinero con menor gasto ha sido del cliente:");
                            Console.WriteLine(nombres[PosicionDinero]);
                            Console.WriteLine("Con un monto total de:");
                            Console.WriteLine(DineroMenorGasto);
                            Console.ReadKey();

                            break;
                        case 4:
                            OpcionSalir = true;
                            Console.Clear();
                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine("Error! Opcion invalida"); 
                            Console.ReadKey();
                            break;
                    }

                } while (!OpcionSalir);
            }
            catch (FormatException)
            {
                Console.Clear();
                Console.WriteLine("Error! Opcion invalida");

            }
            catch (OverflowException)
            {
                Console.Clear();
                Console.WriteLine("Error! Opcion invalida");
            }

        }
        //Metodos sobrecargados
        //Metodo de busqueda lineal
        public static int Busqueda(string[] ArrNombres, string Elemento)
        {
            for (int i = 0; i < ArrNombres.Length; i++)
            {
                if(ArrNombres[i] == Elemento)
                {
                    return i;
                }
            }
            return -1;

        }
        public static int Busqueda(double[] ArrNombres, double Elemento)
        {
            for (int i = 0; i < ArrNombres.Length; i++)
            {
                if (ArrNombres[i] == Elemento)
                {
                    return i;
                }
            }
            return -1;

        }

        //Metodo Bubble Sort
        static double[] MetodoBubbleSort(double[] Arr)
        {
            int n = Arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (Arr[j] > Arr[j + 1])
                    {
                        double Cajita = Arr[j];
                        Arr[j] = Arr[j + 1];
                        Arr[j + 1] = Cajita;
                    }
                }
            }
            return Arr;
        }

    }
}
