using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluacion.Clases
{
    internal class Name
    {
        private string[] names = new string[25];
        private string[] names25 = new string[25];
        public void addElement(string name, int pos)
        {
            names[pos] = name;
        }
        public void addElement25(string name, int pos)
        {
            names25[pos] = name;
        }
        public int getLength(string name)
        {
            int longitud = name.Length;
            return longitud;
        }
        public string[] GetElements()
        {
            return names;
        }
        public string[] GetElements25()
        {
            return names25;
        }
    }
}
