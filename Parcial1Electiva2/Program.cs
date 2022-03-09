using System;
using System.Collections.Generic;

namespace Parcial1Electiva2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //String Menu = " ";
            int Menu;
            int MenuUsuarios;
            int MenuBlogs;

            int MenuSalir;
            int CodigoIdent;
            int incrementU = 1;
            int incrementB = 1;

            //
            //String[] Genero = new string[4] { " ", "HOMBRE", "MUJER", "NO BINARIO" };
            //String[] Facultades = new string[5] { " ", "INGENIERIA", "MEDICINA", "CIENCIAS SOCIALES", "CIENCIAS ADMINISTRATIVAS" };


            Users Usuario = new Users();
            List<Users> ListUsuario = new List<Users>();




            Blogs Blogss = new Blogs();
            List<Blogs> ListBlogs = new List<Blogs>();


            do
            {

                Console.WriteLine("--------------Menu-------------------");
                Console.WriteLine("\n 1. Usuarios \n 2. Blogs \n 3. Salir");

                //Menu = Console.ReadLine();
                Menu = System.Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                switch (Menu)
                {

                    case 1: //opcion 1 Menu Principal

                        Console.Clear();

                        Console.WriteLine("--------------Menu Usuarios-------------------");

                        Console.WriteLine("Usuarios: \n 1. Crear Usuario  \n 2. Listar Usuario \n 3. Regresar Menu Principal");
                        MenuUsuarios = System.Convert.ToInt32(Console.ReadLine());
                        Console.Clear();

                        switch (MenuUsuarios)//Switch MenuUsuarios
                        {
                            case 1://Agregar Usuarios opcion 1 submenu

                                //Console.WriteLine("Ingrese el codigo del usuario :");
                                Usuario.id = incrementU;
                                incrementU++;
                                //Console.Clear();

                                Console.WriteLine("Ingrese el nombre del usuario :");
                                Usuario.nombres = Console.ReadLine();
                                Console.Clear();

                                Console.WriteLine("Ingrese el apellido del usuario :");
                                Usuario.apellidos = Console.ReadLine();
                                Console.Clear();


                                ListUsuario.Add(new Users(Usuario.id, Usuario.nombres, Usuario.apellidos));
                                
                                break;


                            case 2: //Listar Usuarios opcion 2 submenu


                                foreach (Users item in ListUsuario)
                                {

                                    Console.WriteLine($"El Id del usuario es : {item.id} ");
                                    Console.WriteLine($"El Nombre del usuario es : {item.nombres} ");
                                    Console.WriteLine($"El Apellido del usaurio es : {item.apellidos} ");

                                }

                                if (ListUsuario.Count == 0)
                                {

                                    Console.WriteLine("No hay Usuarios Registrados, La lista esta vacia.");
                                    break;
                                }


                                break;


                            default:
                                Console.WriteLine("Opcion no valida");
                                break;

                        }// fin submenu 1

                        break;

                    case 2: //Opcion 2 Menu Principal



                        Console.Clear();

                        Console.WriteLine("--------------Menu Blogs-------------------");

                        Console.WriteLine("Blogs: \n 1. Crear Blog  \n 2. Listar Blogs \n 3. Regresar Menu Principal");
                        MenuBlogs = System.Convert.ToInt32(Console.ReadLine());
                        Console.Clear();


                        switch (MenuBlogs)//Switch MenuBlogs
                           
                        {

                            case 1://Agregar Blogs opcion 1 submenu2

                                Console.WriteLine("Ingrese el codigo del usuario");
                                CodigoIdent = int.Parse(Console.ReadLine());
                                Console.Clear();

                                Boolean validacion = false;

                                foreach (Users item in ListUsuario)
                                {

                                    if (item.id == CodigoIdent)
                                    {
                                        validacion = true;
                                        break;
                                    }
                                    

                                }

                                if (validacion)
                                {   
                                    
                                   

                                        //Console.WriteLine("Ingrese el codigo del Blog :");
                                        Blogss.BlogID = incrementB;                                     
                                        incrementB++;

                                        Blogss.CodigoUsuario = CodigoIdent;

                                        //Console.Clear();

                                        Console.WriteLine("Ingrese el nombre del Blog :");
                                        Blogss.NameBlog = Console.ReadLine();
                                        Console.Clear();

                                        ListBlogs.Add(new Blogs(Blogss.BlogID, Blogss.NameBlog, Blogss.CodigoUsuario));
                                       
                                   
                                 
                                }

                                





                                break;


                            case 2: //Listar Blogs opcion 2 submenu2

                                CodigoIdent = Usuario.id;

                                if (CodigoIdent == Usuario.id)
                                {

                                    foreach (Blogs item in ListBlogs)
                                    {

                                        Console.WriteLine($"El Id del Blogs es : {item.BlogID} ");
                                        Console.WriteLine($"El Nombre del Blog es : {item.NameBlog} ");
                                        Console.WriteLine($"El codigo de usaruio del Blog es : {item.CodigoUsuario} ");

                                    }

                                }
                                {

                                    Console.WriteLine("El usuario no existe");
                                }

                                if (ListBlogs.Count == 0)
                                {

                                    Console.WriteLine("No hay Blogs Registrados, La lista esta vacia.");
                                    break;
                                }

                                break;


                            default:
                                Console.WriteLine("Opcion no valida");
                                break;

                        }// fin submenu 2

                        break;

                    default:
                        Console.WriteLine("Opcion no valida");
                        break;
                }


            }
            while (Menu != 3);
            Console.Clear();


        }
    }
}