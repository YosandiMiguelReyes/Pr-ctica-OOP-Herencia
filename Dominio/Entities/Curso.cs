
public class Curso
{
    public int Id { get; private set; } 
    public string Nombre { get; set; }
    public int RecuentoClases { get; set; }
    public int RecuentoEjercicios { get; set; }

    private static int contador = 0;

    public Curso(string nombre, int recuentoClases, int recuentoEjercicios)
    {
        Nombre = nombre;
        RecuentoClases = recuentoClases;
        RecuentoEjercicios = recuentoEjercicios;
        Id = ++contador;
    }
}
