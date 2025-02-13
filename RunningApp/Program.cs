﻿using System;

 class Program{
    static List <Usuario> usuarios = new List<Usuario>(); //lista para guardar usuarios
    static List <Entrenamiento> entrenamientos = new Lits <Entrenamiento>();

    public static void Main(string[]args){

        bool continuar = true;
        while (continuar)
        {

         Console.WriteLine("\n Bienvenido a tu programa de entrenamiento");
         Console.WriteLine("1.Registrar Usuario");
         Console.WriteLine("2.Iniciar sesión");
         Console.WriteLine("3.Salir");
         Console.Write("Seleccione una opción: ");

        string opcion = Console.ReadLine();

        switch (opcion){

            case "1": 
            RegistrarUsuario();
            break;

            case "2":
            IniciarSesion();
            break;

            case "3":
            continuar = false; //para terminar consola
            break; 

            default:
            Console.WriteLine("Término erróneo. Intenteló de nuevo");
            break;
        }

    }
        
}

    static void RegistrarUsuario(){ //metodo de registro 

        Console.Write("Ingrese su email: ");
        string email = Console.ReadLine();

        Console.Write("Ingrese su nombre: ");
        string nombre = Console.ReadLine();

        if(usuario.Exists(usuario => usuario.Nombre == nombre)){ //busca si el nombre ya esta guardado 

            Console.WriteLine("Este nombre de usuario ya esta en uso")
            Console.WriteLine("Presione cualquier tecla para volver al menú: ");
            Console.ReadKey();
            return;
        }

        Console.Write("Ingrese su contraseña: ");
        string contrasena = Console.ReadLine();
        
        usuarios.Add(new Usuario {Email = email, Nombre = nombre , Contrasena = contrasena }); //crea un objeto Usuario y verifica que no haya duplicaodos
        Console.WriteLine("Usuario registrado con éxito");

        Console.WriteLine("Presione cualquier tecla para volver al menú: ");
        Console.ReadKey();

    }

    static void IniciarSesion(){
        Console.WriteLine("Ingrese su correo electrónico: ");
        string email = Console.ReadLine();

         Console.Write("Ingrese su contraseña: ");
        string contrasena = Console.ReadLine();

        Usuario usuario = usuarios.Find(usuario => usuario.Email == email && usuario.Contrasena == contrasena); //buscan el email y contraeña

        if(usuario != null){ 
            Console.WriteLine("Bienvenido" );
        }
        else{
            Console.WriteLine("Email o Contraseña incorrectos");
        }
    }

    /*

    static void MenuEntrenamiento(){
        
        bool inicioSesion = true;
        while (inicioSesion)
        {

         Console.WriteLine("\n ¿Qué desea hacer?");
         Console.WriteLine("1.Registrar un entrenamiento");
         Console.WriteLine("2.Listar in entrenamiento");
         Console.WriteLine("3.Borrar un entrenamiento");
         Console.WriteLine("4.Cerrar sesión");

        string opcion = Console.ReadLine();

        switch (opcion){

            case "1": 
            RegistrarEntrenamiento();
            break;

            case "2":
            //ListarEntrenamiento();
            break;

            case "3":
            //VaciarEntrenamiento();

            case "4":
            inicioSesion = false; //para terminar consola
            Console.WriteLine("Sesión cerrada. Volviendo al menú")
            break; 

            default:
            Console.WriteLine("Término erróneo. Intenteló de nuevo");
            break;
            
            }
            
        }
    }

    static void RegistrarEntrenamiento(){
        Console.WriteLine("Ingrese la distancia recorrida: ")
        string distancia = Console.ReadLine();

        Console.WriteLine("Ingrese el tiempo de duracion: ")
        string duracion = Console.ReadLine();

        entrenamientos.Add(new Entrenamiento {Distancia = distancia, Duracion = duracion});
        Console.WriteLine ("Entrenamiento registrado correctamente");

    }
    */
 }
