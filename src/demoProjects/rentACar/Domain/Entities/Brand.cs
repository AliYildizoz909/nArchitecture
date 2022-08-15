using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Persistence.Repositories;

namespace Domain.Entities
{
    public class Brand:Entity
    {
        public Brand(string name)
        {
            Name = name;
        }

        public Brand(int id, string name) : base(id)
        {
            Name = name;
        }

        public string Name { get; set; }
    }
}
