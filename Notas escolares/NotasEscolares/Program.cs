using System;

namespace NotasEscolares
{
    class Program
    {
       static void Main(string[] arg)
       {
        Seguridad datos2 = new Seguridad();  
        string nombre;
        string contraseña;

        Console.Clear();
        Console.WriteLine("*-.+.-*-.+.-*-.+.-*-.+.-");
        Console.WriteLine("Ingreso al Programa");
        Console.WriteLine("*-.+.-*-.+.-*-.+.-*-.+.-");
        Console.WriteLine("");

        Console.WriteLine("Ingresa el nombre de usuario para saber quien eres: ");
        nombre = Console.ReadLine();
        Console.WriteLine("Inserta tu contraseña: ");
        contraseña = Console.ReadLine();

        bool resultado = datos2.Autenticar(nombre,contraseña);

        if (resultado == true)
        {
          Console.Clear();
          Console.WriteLine("*-.+.-*-.+.-*-.+.-*-.+.-*-.+.-*-.+.-*-.+.-*-.+.-*-.+.-*-.+.-*-.+.-*-.+.-");
          Console.WriteLine("Bienvenido al Sistema de notas, donde veras quien paso y quien ya valio");
          Console.WriteLine("*-.+.-*-.+.-*-.+.-*-.+.-*-.+.-*-.+.-*-.+.-*-.+.-*-.+.-*-.+.-*-.+.-*-.+.-");
          Console.WriteLine("");
          Console.WriteLine("Sensei " + nombre);
        }else
        {
          Console.WriteLine("Usuario o contraseña invalido, saquese impostor");
          return;
        }
        Console.ReadKey();

        Notas datos = new Notas();
        string opcion = "";


        while (true)
        {
            Console.Clear();
            Console.WriteLine("*-.+.-*-.+.-*-.+.-*-.+.-");
            Console.WriteLine("Orange Star School");
            Console.WriteLine("*-.+.-*-.+.-*-.+.-*-.+.-");
            Console.WriteLine("");
            Console.WriteLine("Registro de Notas Escolares");
            Console.WriteLine("*-.+.-*-.+.-*-.+.-*-.+.-*-.+.-*-.+.-");
            Console.WriteLine("*-.+.-*-.+.-*-.+.-*-.+.-*-.+.-*-.+.-");
            Console.WriteLine("Bienvenido Sensei " + nombre);
            Console.WriteLine("*-.+.-*-.+.-*-.+.-*-.+.-*-.+.-*-.+.-");
            Console.WriteLine("");
            Console.WriteLine("1. Lista de Senseis");
            Console.WriteLine("2. Lista de Estudiantes");
            Console.WriteLine("3. Lista de clases");
            Console.WriteLine("");
            Console.WriteLine("*-.+.-*-.+.-*-.+.-*-.+.-");
            Console.WriteLine("Calificaciones");
            Console.WriteLine("*-.+.-*-.+.-*-.+.-*-.+.-");
            Console.WriteLine("4. Registro de Notas");
            Console.WriteLine("5. Notas Finales");
            Console.WriteLine("0. Exit");
            Console.WriteLine("");
            Console.WriteLine("Inserta una de la opciones que el sistema no lo hara por ti: ");
            opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                     datos2.ListarUsuario();
                     break;
                case "2":
                     datos.ListarEstudiantes();
                     break;
                case "3":
                     datos.ListarAsignatura();
                     break;
                case "4":
                     datos.ingresarNotas();
                     break;
                case "5":
                     datos.Notafinales();
                     break;    
                default:
                break;
            }
            if(opcion == "0")
            {
                break;
            }
         }
       }
    }
}
