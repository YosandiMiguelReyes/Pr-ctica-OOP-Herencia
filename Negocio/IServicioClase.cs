
public interface IServicioClase
{
    void CrearClase(string identificador);
    Clase ObtenerClasePorId(int id);
    IEnumerable<Clase> ObtenerTodasLasClases();
    void AgregarEstudianteAClase(int claseId, Estudiante estudiante);
    void AgregarProfesorAClase(int claseId, Profesor profesor);
}
