using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab6.Data
{
    public class Poi
    {
        private Poi() { }
        public Poi(Guid _id, string _name, string _description)
        {
            Id = _id;
            Name = _name;
            Description = _description;
        }
        public Guid Id { get; set; }

        public String Name { get; private set; }
        
        public string Description { get; private set; }
       
    }
}
