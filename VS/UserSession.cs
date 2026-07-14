namespace VS;

public class UserSession
{
    // Guarda el nombre del usuario conectado
    public string UserName { get; set; } = "Invitado";
    
    // Lista global de eventos a los que el usuario se ha inscrito
    public List<string> RegisteredEvents { get; set; } = new();

    // Método sencillo para simular el inicio de sesión
    public void Login(string name)
    {
        UserName = string.IsNullOrEmpty(name) ? "Invitado" : name;
    }
}