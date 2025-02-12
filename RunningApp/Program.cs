using System;

 class Program{
    static List <Usuario> usuarios = new List<Usuario>(); //lista para guardar usuarios
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
            Console.WriteLine("Bienvenido");
        }
        else{
            Console.WriteLine("Email o Contraseña incorrectos");
        }
    }
 }
