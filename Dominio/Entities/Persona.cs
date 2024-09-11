
public abstract class Persona
{
    public int Id { get; private set; } 
    public string Nombre { get; set; }

    private static int contador = 0;

    protected Persona(string nombre)
    {
        Nombre = nombre;
        Id = ++contador;
    }
}
