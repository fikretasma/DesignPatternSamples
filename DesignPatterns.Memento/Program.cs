using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            UserMemory memory = new UserMemory();
            User user = new User { Id = 123123, Name = "Fikret", Surname = "Asma" };
           
            Console.WriteLine(user.ToString());
            memory.Memento = user.SaveMemento();

            //User nesnesi üzerinde değişiklikler yapılıyor
            user.Name = "Mehmet";
            user.Surname = "Akın";
            
            Console.WriteLine(user.ToString());

            user.Restore(memory.Memento);

            //Restore sonrası user nesnesi
            Console.WriteLine(user.ToString());

            Console.ReadLine();

        }
    }
}
