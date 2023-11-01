using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoLinq.Clases;
public class LinqTwo
{
    List<Student> _student = new List<Student>(){
        new Student(){Id = 12, Name = "Juan", Age = 12},
        new Student(){Id = 13, Name = "Carlos", Age = 14},
        new Student(){Id = 14, Name = "Sebastian", Age = 62},
        new Student(){Id = 14, Name = "Fait", Age = 62}
    };

    public void PrintDta(){
        var teenPerson = _student.Where(x => x.Age > 12 && x.Age < 20).ToList<Student>();
        teenPerson.ForEach(tp => Console.WriteLine($"Nombre {tp.Name}"));
    }

    public void PrintDta2(){
        var expre = from s in _student select new {
            s.Id,s.Name
        };
        foreach(var item in expre){
            Console.WriteLine($"{item.Id} {item.Name}");
        }
    }

    public void PrintDta3(){
        var filteredResults = _student.Where((s, i) => {
            if(i % 2 == 0){
                return true;
            }
        return false;
        });

        foreach(var result in filteredResults){
            Console.WriteLine(result.Name);
        }
    }

    public void PrintDta4(){
        int op = 0;
        bool entrando = true;
        do
        {
            try{
                
                Console.WriteLine("Como desea ordenar los nombres de los estudiantes");
                Console.WriteLine("1. Ascendente");
                Console.WriteLine("2. Descendente");
                Console.WriteLine("0. Salir");
                Console.Write("--> ");
                op = int.Parse(Console.ReadLine());;

                switch (op){
                case 0:
                    Console.Clear();
                    Console.WriteLine("|--------------------------------------|");
                    Console.WriteLine("|    Gracias por usar este programa    |");
                    Console.WriteLine("|--------------------------------------|");
                    entrando = false;
                break;
                case 1:
                    var studentAsc = _student.OrderBy(s => s.Name).ToList();
                    studentAsc.ForEach(tp => Console.WriteLine($"Nombre Ascendente {tp.Name}"));
                    Thread.Sleep(2000);
                    Console.Clear();

                break;
                case 2:
                    var studentDes = _student.OrderByDescending(s => s.Name).ToList();
                    studentDes.ForEach(tp => Console.WriteLine($"Nombre Descentende {tp.Name}"));
                    Thread.Sleep(2000);
                    Console.Clear();
                break;
                default:
                    Console.WriteLine("Te Saliste del RANGO");
                    Thread.Sleep(2000);
                    Console.Clear();
                break;
                }
            }
            catch (Exception ex){
                Console.WriteLine("ALGO HIZO MAL!!! {0}",ex.Message.ToString());
                Thread.Sleep(2000);
                Console.Clear();
            }
        } while (entrando);
    }
}
