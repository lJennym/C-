public class Estudiantes: Persona
{
  public int CodigoEstudiante { get; set; }

  public string Apellido { get; set; }

  public Estudiantes(int codigoestudiante, string nombre, string apellido)
  {
    CodigoEstudiante = codigoestudiante;
    Nombre = nombre;
    Apellido = apellido;
  }
}