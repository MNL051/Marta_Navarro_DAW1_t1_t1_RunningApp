using System.Collections;
class Usuario{

    private string? email; // uso del ? para obligarlo a tener valor 
    private string? contrasena;

    private ArrayList listaUsuarios;

    public Usuario (string email, string contrasena){ //constructor 
        this.email = email;
        this.contrasena = contrasena;
    }
}