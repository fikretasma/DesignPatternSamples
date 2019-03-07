using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Memento
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public UserMemento SaveMemento()
        {
            return new UserMemento
            {
                Id = this.Id,
                Name = this.Name,
                Surname = this.Surname
            };
        }

        public void Restore(UserMemento userMemento)
        {
            this.Id = userMemento.Id;
            this.Name = userMemento.Name;
            this.Surname = userMemento.Surname;
        }

        public override string ToString()
        {
            return String.Format("Id = {0}, Name : {1}, Surname : {2}", Id, Name, Surname);
        }
    }
}
