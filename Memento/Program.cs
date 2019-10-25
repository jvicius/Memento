using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Memento.Models;

namespace Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            Originator originator = new Originator("Inicio");
            Caretaker caretaker = new Caretaker(originator);

            caretaker.Backup();
            originator.SetState("Estado 1");

            caretaker.Backup();
            originator.SetState("Estado 2");

            caretaker.Backup();
            originator.SetState("Estado 3");

            Console.WriteLine();
            caretaker.ShowHistory();

            Console.WriteLine();
            var x = originator.GetState();

            Console.WriteLine("\nClient: Now, let's rollback!\n");
            caretaker.Undo();

            Console.WriteLine("\nClient: Now, let's second rollback!\n");
            caretaker.Undo();

            Console.ReadKey();
        }
    }
}
