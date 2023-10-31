using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoLinq.Clases;
public class LinqOne
{
    List<string> Libros = new List<string>(){
        "a", 
        "b", 
        "c", 
        "d"
    };

    public IEnumerable<string> ListaLibrosByName(string name){
        return Libros.Where(x => x.Contains(name));
    }

    public void PrintData(){
        Console.WriteLine("Ingrese el criterio de busqueda");
        string criterio = Console.ReadLine();
        IEnumerable<string> data = ListaLibrosByName(criterio);
        Console.Clear();
        foreach(string item in data){
            Console.WriteLine($"Se encontro : {item}");
        }
        Console.WriteLine("Gracias por usar este programa");
        Console.ReadKey();
    }
}
