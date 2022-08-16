using System;
using System.Collections.Generic;

public class Seguridad
{
    private List<Usuario> usuario {get; set;}
    public Seguridad()
    {
        usuario = new List<Usuario>();

        Usuario u1 = new Usuario("Gohan","20000");
        usuario.Add(u1);

        Usuario u2 = new Usuario("Mina","10000");
        usuario.Add(u2);
        
        public bool Autenticar(string nombre, string Contraseña){ 
        
            foreach (var usuario in usuario)
            {
                if (usuario.Nombre == nombre && usuario.Contraseña == Contraseña)
                {
                    return true;
                }
            }
            return false;
        }
        public void ListarUsuario()
        {
            Console.Clear();
            Console.WriteLine("*-.+.-*-.+.-*-.+.-*-.+.-");
            Console.WriteLine("Lista de Ussers Senseis");
            Console.WriteLine("*-.+.-*-.+.-*-.+.-*-.+.-");
            
            foreach (var usuario in usuario)
            {
            Console.WriteLine(usuario.Nombre +" | " + usuario.Contraseña);
            }
            Console.ReadLine();
        }
    }    
}
