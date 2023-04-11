using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAndClassesDemo
{
    internal class SampleClass : ISampleInterface1
    {
        public SampleClass(string myProperty)
        {
            TestProperty = myProperty;
        }

        public string TestProperty { get; set; }

        public void DoWork(ISampleInterface2 someValue)
        {

        }
    }

    internal interface ISampleInterface1 
    { 
    }
    internal interface ISampleInterface2
    {
    }

}
