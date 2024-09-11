
public class Clase
{
    public int Id { get; private set; }
    public string Identificador { get; set; }
    public List<Estudiante> Estudiantes { get; set; }
    public List<Profesor> Profesores { get; set; }

    private static int contador = 0;

    public Clase(string identificador)
    {
        Identificador = identificador;
        Estudiantes = new List<Estudiante>();
        Profesores = new List<Profesor>();
        Id = ++contador;
    }

    public void AgregarEstudiante(Estudiante estudiante)
    {
        Estudiantes.Add(estudiante);
    }

    public void AgregarProfesor(Profesor profesor)
    {
        Profesores.Add(profesor);
    }
}
