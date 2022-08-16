using System;

namespace NotasEscolares
{
    class Program
    {
        static void Main(string[] args)
        {
            Seguridad datos2 = new Seguridad();  
            string nombre;
            string contraseña;

            Console.Clear();
            Console.WriteLine("~(^o^~)*-..\(^o^)/..-*(~^o^)~");
            Console.WriteLine("Entrada al Sistema");
            Console.WriteLine("~(^o^~)*-..\(^o^)/..-*(~^o^)~");
            Console.WriteLine("");

            Console.WriteLine("Ingresa tu nombre: ");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingresa tu contraseña: ");
            contraseña = Console.ReadLine();

            bool resultado = datos2.Autenticar(nombre,contraseña);

            if (resultado == true)
            {
                Console.Clear();
                Console.WriteLine("~(^o^~)*-..\(^o^)/..-*(~^o^)~ ~(^o^~)*-..\(^o^)/..-*(~^o^)~");
                Console.WriteLine("Bienvido al Registro de notas donde sabras si ya valiste o no");
                Console.WriteLine("~(^o^~)*-..\(^o^)/..-*(~^o^)~~(^o^~)*-..\(^o^)/..-*(~^o^)~");
                Console.WriteLine("");
                Console.WriteLine("Profe" + nombre);
            }else
            {
                Console.WriteLine("Usuario o contraseña desconocidos, de donde rayos saliste?");
                return;
            }
            Console.ReadKey();

            Notas datos = new Notas();
            string opcion = "";


            while (true)
            {
                Console.Clear();
                Console.WriteLine("~(^o^~)*-..\(^o^)/..-*(~^o^)~");
                Console.WriteLine("Escuela Estrella Naranja");
                Console.WriteLine("~(^o^~)*-..\(^o^)/..-*(~^o^)~ ");
                Console.WriteLine("");
                Console.WriteLine("Registro de Notas de Los Estudiantes");
                Console.WriteLine("~(^o^~)*-..\(^o^)/..-*(~^o^)~ ");
                Console.WriteLine("*-.+.-*-.+.-*-.+.-*-.+.-*-.+.-*-.+.-*-.");
                Console.WriteLine("Bienvenido Sensei " + nombre);
                Console.WriteLine("*-.+.-*-.+.-*-.+.-*-.+.-*-.+.-*-.+.-*-.");
                Console.WriteLine("");
                Console.WriteLine("1. Lista de Senseis");
                Console.WriteLine("2. Estudiantes");
                Console.WriteLine("3. Materias");
                Console.WriteLine("");
                Console.WriteLine("*-.+.-*-.+.-*-.+.-*-.+.-*-.+.-*-.+.-*-.");
                Console.WriteLine("Calificaciones");
                Console.WriteLine("*-.+.-*-.+.-*-.+.-*-.+.-*-.+.-*-.+.-*-.");
                Console.WriteLine("4. Registro de Notas");
                Console.WriteLine("5. Notas Finales :v ");
                Console.WriteLine("0. Salir");
                Console.WriteLine("");
                Console.WriteLine("Escoge una opcion que el sistema no lo hara por ti: ");
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
