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
            Boolean validacion = false;


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

                                Console.WriteLine("Usuarios Actuales");
                                foreach (Users item in ListUsuario)
                                {
                                    Console.WriteLine($"ID usuario : {item.id} | Nombre : {item.nombres} |  Apellido : {item.apellidos}");

                                }

                                Console.WriteLine("Ingrese el codigo del usuario");
                                CodigoIdent = int.Parse(Console.ReadLine());
                                Console.Clear();



                                foreach (Users item in ListUsuario)
                                {

                                    if (item.id == CodigoIdent)
                                    {
                                        validacion = true;
                                        Console.WriteLine("usuario encontrado");
                                        
                                        break;
                                    }
                                    Console.Clear();

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
                                else
                                {
                                    Console.WriteLine("Usuario no encontrado");
                                }







                                break;


                            case 2: //Listar Blogs opcion 2 submenu2

                                Console.WriteLine("Usuarios Actuales");
                                foreach (Users item in ListUsuario)
                                {
                                    Console.WriteLine($"ID usuario : {item.id} | Nombre : {item.nombres} |  Apellido : {item.apellidos}");

                                }

                                Console.WriteLine("Ingresar id del usuario");
                                CodigoIdent = Convert.ToInt32(Console.ReadLine());

                                foreach (Users item in ListUsuario)
                                {
                                    if (item.id == CodigoIdent)
                                    {
                                        validacion = true;
                                        Console.WriteLine("Usuario encontrado");
                                        
                                        break;

                                    }
                                    Console.Clear();
                                }

                                if (validacion)
                                {

                                    foreach (Blogs item in ListBlogs)
                                    {

                                        if (item.CodigoUsuario == CodigoIdent)
                                        {
                                            Console.WriteLine($"El Id del Blogs es : {item.BlogID} ");
                                            Console.WriteLine($"El Nombre del Blog es : {item.NameBlog} ");
                                            Console.WriteLine($"El codigo de usaruio del Blog es : {item.CodigoUsuario} ");
                                        }


                                    }


                                }
                                else
                                {
                                    Console.WriteLine("Usuario no encontrado");
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