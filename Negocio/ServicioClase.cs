// Services/ServicioClase.cs
public class ServicioClase : IServicioClase
{
    private readonly IRepository<Clase> _claseRepository;

    public ServicioClase(IRepository<Clase> claseRepository)
    {
        _claseRepository = claseRepository;
    }

    public void CrearClase(string identificador)
    {
        var clase = new Clase(identificador);
        _claseRepository.Add(clase);
    }

    public Clase ObtenerClasePorId(int id)
    {
        return _claseRepository.GetById(id);
    }

    public IEnumerable<Clase> ObtenerTodasLasClases()
    {
        return _claseRepository.GetAll();
    }

    public void AgregarEstudianteAClase(int claseId, Estudiante estudiante)
    {
        var clase = ObtenerClasePorId(claseId);
        if (clase != null)
        {
            clase.AgregarEstudiante(estudiante);
        }
    }

    public void AgregarProfesorAClase(int claseId, Profesor profesor)
    {
        var clase = ObtenerClasePorId(claseId);
        if (clase != null)
        {
            clase.AgregarProfesor(profesor);
        }
    }
}
