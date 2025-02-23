using System;

 class Program{
    static List <Usuario> usuarios = new List<Usuario>(); //lista para guardar usuarios
    static List <Entrenamiento> entrenamientos = new List <Entrenamiento>();

    public static void Main(string[]args){

        bool continuar = true;
        while (continuar)
        {
        //menú principal
         Console.WriteLine("\n Bienvenido a tu programa de entrenamiento");
         Console.WriteLine("1.Registrar Usuario");
         Console.WriteLine("2.Iniciar sesión");
         Console.WriteLine("3.Salir");
         Console.Write("\nSeleccione una opción: ");

        string? opcion = Console.ReadLine();

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
            Console.WriteLine("\nTérmino erróneo. Intenteló de nuevo");
            break;
        }

    }
        
}

    static void RegistrarUsuario(){ //metodo de registro 

        Console.WriteLine("\nIngrese su correo electrónico: ");
        string? email = Console.ReadLine();

        Console.WriteLine("\nIngrese su nombre: ");
        string? nombre = Console.ReadLine();

        if(usuarios.Exists(usuario => usuario.Nombre == nombre)){ //busca si el nombre ya esta guardado 

            Console.WriteLine("\nEste nombre de usuario ya esta en uso");
            Console.WriteLine("\nPresione cualquier tecla para volver al menú: ");
            Console.ReadKey();
            return;
        }

        Console.WriteLine("\nIngrese su contraseña: ");
        string? contrasena = Console.ReadLine();
        
        usuarios.Add(new Usuario {Email = email, Nombre = nombre , Contrasena = contrasena }); //crea un objeto Usuario y verifica que no haya duplicaodos
        Console.WriteLine("\nUsuario registrado con éxito");

        Console.WriteLine("Presione cualquier tecla para volver al menú: ");
        Console.ReadKey();

    }

    static void IniciarSesion(){
        Console.WriteLine("\nIngrese su correo electrónico: ");
        string? email = Console.ReadLine();

         Console.WriteLine("\nIngrese su contraseña: ");
        string? contrasena = Console.ReadLine();

        Usuario? usuario = usuarios.Find(usuario => usuario.Email == email && usuario.Contrasena == contrasena); //buscan el email y contraseña

        if(usuario != null){ 
            Console.WriteLine("\nBienvenido " + usuario.Nombre);

            MenuEntrenamiento();
        }
        else{
            Console.WriteLine("\nCorreo o contraseña incorrectos");
        }
    }
    static void MenuEntrenamiento(){
        
        bool inicioSesion = true;
        while (inicioSesion)
        {
        //menú de entrenamiento
         Console.WriteLine("\n ¿Qué desea hacer?");
         Console.WriteLine("1.Registrar un entrenamiento");
         Console.WriteLine("2.Listar un entrenamiento");
         Console.WriteLine("3.Borrar los entrenamientos");
         Console.WriteLine("4.Cerrar sesión");
         Console.Write("\nSeleccione una opción: ");

        string? opcion = Console.ReadLine();

        switch (opcion){

            case "1": 
            RegistrarEntrenamiento();
            break;

            case "2":
            ListarEntrenamiento();
            break;

            case "3":
            VaciarEntrenamiento();
            break;

            case "4":
            inicioSesion = false; //para terminar consola
            Console.WriteLine("\nSesión cerrada. Volviendo al menú de entrenamiento");
            break;;

            default:
            Console.WriteLine("\nTérmino erróneo. Intenteló de nuevo");
            break;
            
            }
            
        }
    }

    static void RegistrarEntrenamiento(){

        Console.WriteLine("\nIngrese la distancia recorrida: ");
        string? distancia = Console.ReadLine();

        Console.WriteLine("\nIngrese los minutos o horas de duracion: ");
        string? duracion = Console.ReadLine();

        entrenamientos.Add(new Entrenamiento {Distancia = distancia, Duracion = duracion});
        Console.WriteLine ("\nEntrenamiento guardado correctamente") ;

        Console.WriteLine("\nPresione cualquier tecla para volver al menú de entrenamiento: ");
        Console.ReadKey();

    }

    static void ListarEntrenamiento(){

        if (entrenamientos.Count > 0){
            int contador = 1;

            foreach (var entrenamiento in entrenamientos)
            {
                Console.WriteLine("\nEntrenamiento " + contador++ + ":" + " Distancia: " + entrenamiento.Distancia +","+ " Tiempo: " + entrenamiento.Duracion); 
            }
        }
        else{
            
            Console.WriteLine("\nNo hay ningún entrenamiento guardado");
        }
        
    }

    static void VaciarEntrenamiento(){

        entrenamientos.Clear();
        Console.WriteLine("\nEntrenamientos borrados con éxito");

    }
    
 }
