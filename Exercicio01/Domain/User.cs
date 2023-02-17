using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01.Domain
{
    public class User
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public DateTime Created_at { get; set; }


        public User(int id, string name)
        {
            Id = id;
            Name = name;
            Created_at = DateTime.Now;
        }
    }
}
