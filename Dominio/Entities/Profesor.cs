
public class Profesor : Persona
{
    public List<Curso> Cursos { get; set; }

    public Profesor(string nombre) : base(nombre)
    {
        Cursos = new List<Curso>();
    }

    public void AsignarCurso(Curso curso)
    {
        Cursos.Add(curso);
    }
}