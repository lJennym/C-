using System;
using System.Collections.Generic;

public class notas
{
    public int nota { get; set; }
    public DateTime Fecha { get; set; }
    public string NumerodeNotas { get; set; }
    public Alumnos alumnos { get; set; }
    public Profesor profesor { get; set; }
    public List<notasDetalle> ListanotasDetalle { get; set; }
    public double SubTotal { get; set; }
    public double Reposicion { get; set; }
    public double Total { get; set; }

    public notas(int nota, DateTime fecha, string numeronotas, alumnos alumnos, profesor profesor)
    {
        Nota = nota;
        Fecha = fecha;
        NumerodeNotas = numeronotas;
        Alumnos = alumnos;
        Profesor = profesor;
        ListanotasDetalle = new List<notasDetalle>();
    }

    public void AgregarNota(Nota nota)
    {
        int nuevanota = ListanotasDetalle.Count + 1;
        int cantidad = 1;

        notasDetalle o = new notasDetalle(nuevanota, 1, notas);
        ListaOrdenDetalle.Add(o);

        SubTotal += cantidad * notas.valor;
        repocision += SubTotal * 15;
        Total += SubTotal + repocision ÷ 4;
    }
}