public class Asignatura
{
    public string Codigo { get; set; } 

    public string NombreAsignatura { get; set; }

    public double Notapromedio { get; set; }

    public int NotaA { get; set; }

    public int NotaB { get; set; }

    public int NotaC { get; set; }

    public int NotaD { get; set; }

    public Asignatura(string codigo, string nombreasignatura)
    {
        Codigo = codigo;
        NombreAsignatura = nombreasignatura;
    }

    public void Resultado()
    {   
        NotaA = 0;
        NotaB = 0;
        NotaC = 0;
        NotaD = 0;

        Notapromedio = (NotaA + NotaB + NotaC + NotaD)/4;
    }
}