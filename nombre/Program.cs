// See https://aka.ms/new-console-template for more information



Curso curso = new Curso();
curso.code = "INF-101";
curso.nombre = "Algoritmos";
curso.profesor = new Profesor() { Id = 10, nombre = "Dra. Pérez" };

public class Estudiante
{
    public int Id;
    public string nombre = "";
    public string email = "";
}

public class Profesor
{
    public int Id;
    public string nombre = "";
}

public class Curso
{
    public string code = "";
    public string nombre = "";
    public Profesor profesor = new Profesor();
    public List<Estudiante> estudiantes = new List<Estudiante>();
    public List<Parcial> parciales = new List<Parcial>();
}

public class Parcial
{
    public string titulo = "";
    public DateTime fecha = DateTime.Now;
    public int nota; 
    
}