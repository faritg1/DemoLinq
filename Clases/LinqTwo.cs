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
        new Student(){Id = 14, Name = "Sebastian", Age = 62}
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
}
