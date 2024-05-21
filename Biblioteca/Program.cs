//By Nate :D

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] titulos = new string[]
            {
                //le falto poner Harry Potter D:
                "El Quijote", "Cien Años de Soledad", "1984", "Orgullo y Prejuicio", "La Odisea",
                "Crimen y Castigo", "El Gran Gatsby", "Matar a un Ruiseñor", "Guerra y Paz", "En Busca del Tiempo Perdido",
                "Don Juan Tenorio", "El Retrato de Dorian Gray", "Los Hermanos Karamazov", "El Señor de los Anillos", "Ulises",
                "Madame Bovary", "El Proceso", "Fahrenheit 451", "Lolita", "El Amor en los Tiempos del Cólera",
                "Drácula", "La Metamorfosis", "Moby Dick", "Jane Eyre", "La Divina Comedia",
                "Las Mil y Una Noches", "Frankenstein", "Hamlet", "Romeo y Julieta", "Los Miserables",
                "El Nombre de la Rosa", "Cumbres Borrascosas", "Anna Karenina", "La Isla del Tesoro", "Los Viajes de Gulliver",
                "El Príncipe", "La Iliada", "El Viejo y el Mar", "Robinson Crusoe", "El Lobo Estepario"
            };

            string[] autores = new string[]
            {
                "Miguel de Cervantes", "Gabriel García Márquez", "George Orwell", "Jane Austen", "Homero",
                "Fiódor Dostoyevski", "F. Scott Fitzgerald", "Harper Lee", "León Tolstói", "Marcel Proust",
                "José Zorrilla", "Oscar Wilde", "Fiódor Dostoyevski", "J.R.R. Tolkien", "James Joyce",
                "Gustave Flaubert", "Franz Kafka", "Ray Bradbury", "Vladimir Nabokov", "Gabriel García Márquez",
                "Bram Stoker", "Franz Kafka", "Herman Melville", "Charlotte Brontë", "Dante Alighieri",
                "Anónimo", "Mary Shelley", "William Shakespeare", "William Shakespeare", "Victor Hugo",
                "Umberto Eco", "Emily Brontë", "León Tolstói", "Robert Louis Stevenson", "Jonathan Swift",
                "Nicolás Maquiavelo", "Homero", "Ernest Hemingway", "Daniel Defoe", "Hermann Hesse"
            };

            int[] anosPublicacion = new int[]
            {
                1605, 1967, 1949, 1813, -800,
                1866, 1925, 1960, 1869, 1913,
                1844, 1890, 1880, 1954, 1922,
                1857, 1925, 1953, 1955, 1985,
                1897, 1915, 1851, 1847, 1320,
                800, 1818, 1609, 1597, 1862,
                1980, 1847, 1877, 1883, 1726,
                1532, -750, 1952, 1719, 1927
            };

            string[] generos = new string[]
            {
                "Novela", "Realismo Mágico", "Distopía", "Romance", "Épica",
                "Novela", "Novela", "Novela", "Novela", "Novela",
                "Teatro", "Novela", "Novela", "Fantasía", "Épica",
                "Novela", "Novela", "Ciencia Ficción", "Novela", "Realismo Mágico",
                "Terror", "Novela", "Novela", "Romance", "Épica",
                "Cuentos", "Terror", "Teatro", "Teatro", "Novela",
                "Novela Histórica", "Romance", "Novela", "Aventura", "Aventura",
                "Política", "Épica", "Novela", "Aventura", "Novela"
            };

            try
            {
                //Declaracion de variables principales
                bool Salir = false;
                bool Volver = false;
                do
                {
                    Console.Clear();
                    Console.WriteLine("*-----------Biblioteca-----------*");
                    Console.WriteLine("*                                *");
                    Console.WriteLine("*Maneras de busqueda:            *");
                    Console.WriteLine("*                                *");
                    Console.WriteLine("*     1. Busqueda por titulo     *");
                    Console.WriteLine("*     2. Busqueda por genero     *");
                    Console.WriteLine("*                                *");
                    Console.WriteLine("*                     | 3. Salir *");
                    Console.WriteLine("*--------------------------------*");
                    byte OpcionMenu = Convert.ToByte(Console.ReadLine());

                    switch (OpcionMenu)
                    {
                        case 1:
                            do
                            {
                                Console.Clear();
                                Console.WriteLine("Ingrese el titulo del libro que desee buscar");
                                Console.WriteLine("(Recuerda escribirlo correctamente)");
                                string TituloLibro = Console.ReadLine();

                                int ValidacionBusqueda = Busqueda(titulos, TituloLibro);

                                if (ValidacionBusqueda == -1)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Lo sentimos! Libro no encontrado");
                                    Console.ReadKey();
                                    Volver = true;
                                }
                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine("----------Datos del libro----------");
                                    Console.WriteLine("  Titulo:");
                                    Console.WriteLine("  "+titulos[ValidacionBusqueda]);
                                    Console.WriteLine("");
                                    Console.WriteLine("  Autor:");
                                    Console.WriteLine("  "+autores[ValidacionBusqueda]);
                                    Console.WriteLine("");
                                    Console.WriteLine("  Año de publicacion:");
                                    Console.WriteLine("  " + anosPublicacion[ValidacionBusqueda]);
                                    Console.WriteLine("");
                                    Console.WriteLine("  Genero:");
                                    Console.WriteLine("  " + generos[ValidacionBusqueda]);
                                    Console.WriteLine("------------------------------------");
                                    Console.ReadKey();
                                    Volver = true;
                                }
                            } while (!Volver);


                            break;
                        case 2:
                            do
                            {
                              
                                Console.Clear();
                                Console.WriteLine("Escriba el genero que desee buscar");
                                string GeneroLibro = Console.ReadLine();

                                int ValidacionBusqueda = Busqueda(generos, GeneroLibro);

                                if (ValidacionBusqueda == -1)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Genero no encontrado");
                                    Console.ReadKey();
                                    Volver = true;
                                }
                                else
                                {
                                    int CantidadElementos = BusquedaGenero(generos, GeneroLibro).Length;
                                    int[] BusquedaGenerosLibros = new int[CantidadElementos];
                                    for (int i = 0; i < CantidadElementos; i++)
                                    {
                                        BusquedaGenerosLibros[i] = BusquedaGenero(generos, GeneroLibro)[i];
                                    }

                                    Console.Clear();
                                    Console.WriteLine("Titulos encontrados en relacion a (" + GeneroLibro + "): ");
                                    Console.WriteLine("");
                                    for (int i = 0; i < BusquedaGenerosLibros.Length; i++)
                                    {
                                        Console.WriteLine(titulos[BusquedaGenerosLibros[i]]);
                                        Console.WriteLine("de: " + autores[BusquedaGenerosLibros[i]] + " " + "(" + anosPublicacion[BusquedaGenerosLibros[i]] + ")");
                                        Console.WriteLine("");
                                    }
                                    Console.ReadKey();
                                    Volver = true;
                                }
                                   
                               
                            } while (!Volver);
                            break;
                        case 3:
                            Console.Clear();
                            Salir = true;
                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine("Opcion invalida");
                            Console.ReadKey();
                            break;
                    }
                } while (!Salir);
            }
            catch (FormatException)
            {
                Console.Clear();
                Console.WriteLine("Opcion invalida");
            }
            catch (OverflowException)
            {
                Console.Clear();
                Console.WriteLine("Opcion invalida");
            }
        }
        public static int Busqueda(string[] ArrTitulos, string Elemento)
        {
            for (int i = 0; i < ArrTitulos.Length; i++)
            {
                if (ArrTitulos[i] == Elemento)
                {
                    return i;
                }
            }
            return -1;

        }
        public static int[] BusquedaGenero(string[] ArrGeneros, string Elemento)
        {
            int Contador = 0;
            int Contador2 = 0;
            for(int i = 0; i < ArrGeneros.Length; i++)
            {
                if (ArrGeneros[i] == Elemento)
                {
                    Contador++;
                }
            }
            int[] LibrosDeUnMismoGenero = new int[Contador];
            for(int i = 0; i < ArrGeneros.Length; i++)
            {
                if (ArrGeneros[i] == Elemento)
                {
                    LibrosDeUnMismoGenero[Contador2] = i;
                    Contador2++;
                }
            }
            return LibrosDeUnMismoGenero;
        }
    }
}
