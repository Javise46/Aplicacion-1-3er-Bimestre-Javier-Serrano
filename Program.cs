using System;

namespace Aplicacion_1_3er_Bimestre_Javier_Serrano
{

        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Creado Por Pedro Javier Serrano Ramírez");
                //Variables
                String[] Nombre = new String[15];
                String[] Apellido = new String[15];
                String[] Direccion = new String[15];
                int[] Telefono = new int[15];
                String[] Correo = new String[15];
                String buscar;
                int OP = 1;
                int op;
                //Dato=[0]='a'; 
                Console.WriteLine("Agenda De 15 Contactos");

                while (OP == 1)

                {
                    Console.Clear();
                    Console.WriteLine("----------------------------------------------");
                    Console.WriteLine("-------Cinta De Opciones-------");
                    Console.WriteLine("\n1. Ingresar Contacto \n2. Mostrar Contacto \n3. Buscar Contacto \n4. Salir ");
                    Console.WriteLine("Digite el numero de opcion que desea");
                    op = int.Parse(Console.ReadLine());

                    Console.WriteLine("----------------------------------------------");
                    System.Threading.Thread.Sleep(1500);
                    Console.Clear();
                    if (op == 1)
                    {
                        Console.WriteLine("----------------------------------------------");
                        for (int i = 0; i <= 14; i++)
                        {

                            Console.WriteLine("i: " + i);
                            Console.WriteLine("Ingrese un Nombre: ");
                            Nombre[i] = Console.ReadLine();
                            Console.WriteLine("i: " + i);
                            Console.WriteLine("Ingrese el Apellido: ");
                            Apellido[i] = Console.ReadLine();
                            Console.WriteLine("i: " + i);
                            Console.WriteLine("Ingrese un Direccion: ");
                            Direccion[i] = Console.ReadLine();
                            Console.WriteLine("i: " + i);
                            Console.WriteLine("Ingrese el Telefono: ");
                            Telefono[i] = int.Parse(Console.ReadLine());
                            Console.WriteLine("i: " + i);
                            Console.WriteLine("Ingrese un Correo: ");
                            Correo[i] = Console.ReadLine();

                        }

                        Console.WriteLine("----------------------------------------------");
                        System.Threading.Thread.Sleep(2000);

                    }
                    if (op == 2)
                    {
                        Console.WriteLine("----------------------------------------------");
                        for (int x = 0; x <= 14; x++)
                        {
                            Console.WriteLine("Nombre " + Nombre[x]);
                            Console.WriteLine("Apellido " + Apellido[x]);
                            Console.WriteLine("Direccion " + Direccion[x]);
                            Console.WriteLine("Telefono " + Telefono[x]);
                            Console.WriteLine("Correo " + Correo[x]);
                            Console.WriteLine("----------------------------------------------");
                        }
                        Console.WriteLine("----------------------------------------------");
                        System.Threading.Thread.Sleep(2000);

                    }
                    if (op == 3)
                    {
                        Console.WriteLine("----------------------------------------------");
                        Console.WriteLine("Ingrese el Nombre De Su Contacto a buscar: ");
                        buscar = Console.ReadLine();
                         
                        for (int z = 0; z <= 14; z++)
                        {
                            if (Nombre[z] == buscar)
                            {
                                Console.WriteLine("Contacto: " + buscar + " " + Apellido[z] + "\nDirreccion: " + Direccion[z] + "\nTelefono: " + Telefono[z] + "\nCorreo: " + Correo[z]);
                                Console.WriteLine("Presiona Enter Para Avanzar");
                            }
                        }
                        Console.WriteLine("----------------------------------------------");
                        Console.ReadKey();
                    }

                    if (op == 4)
                    {
                        break;
                    }
                }
                Console.Clear();
                Console.WriteLine("\n Todos Los Creditos A: \n Pedro Javier Serrano Ramírez \n Grado:\n 4to. Bach. BACO");
                Console.ReadKey();

            }
        }
}
