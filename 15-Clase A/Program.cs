using System;

namespace _10_Ordenes
{
    class Program
    {
        static void Main(string[] args)
        {
            DatosdePrueba datos = new DatosdePrueba();
            string opcion = "";

            while (true)
            {
                Console.Clear();
                Console.WriteLine("~(^v^~)*-.(^v^).-*(~^v^)~");
                Console.WriteLine("= Sistema de Clase A notas =");
                Console.WriteLine("~(^v^~)*-.(^v^).-*(~^v^)~");
                Console.WriteLine("");
                Console.WriteLine("1 - Lista de Notas");
                Console.WriteLine("2 - Lista de clases disponibles");
                Console.WriteLine("3 - Crear Total de periodo");
                Console.WriteLine("4 - Lista de Alumnos");
                Console.WriteLine("5 - Lista de Profesores");
                Console.WriteLine("6 - Lista de Nota");
                Console.WriteLine("0 - Salir");
                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        datos.ListarNotas();
                        break;
                        case "6":
                        datos.Listarclasesdisponibles();
                        break;
                    case "3":
                        datos.Creartotalperiodo();
                        break;
                    case "4":
                        datos.Listaralumnos();
                        break;
                    case "5":
                        datos.Listarprofesor();
                        break;      
                    case "5":
                        datos.ListarNota();
                        break;                                          
                    default:
                        break;
                }

                if (opcion == "0") {
                    break;
                }
            }
        }
    }
}