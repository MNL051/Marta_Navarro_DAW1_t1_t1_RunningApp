using System.Collections;
class Usuario{

    private string? email; // uso del ? para obligarlo a tener valor 
    private string? contrasena;
    private string? nombre;

    //Para modificar valores 
    public string? Email { get => email; set => email = value; }
    public string? Contrasena { get => contrasena; set => contrasena = value; }
    public string? Nombre { get => nombre; set => nombre = value; }
}