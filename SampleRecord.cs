using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAndClassesDemo
{
    public record SampleRecord
    {
        public string Name { get; set; }
        public SampleRecord(string name) => Name = name;
    }

}
