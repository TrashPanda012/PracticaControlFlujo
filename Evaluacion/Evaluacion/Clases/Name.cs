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

        //Funcion que agarra un string y un int, va a la posicion en el arreglo y en esa posicion agrega el string.
        public void addElement(string name, int pos)
        {
            names[pos] = name;
        }
        //Funcion que agarra un string y un int, va a la posicion en el arreglo de nombres con caracteres mayores a 25 y en esa posicion agrega el string.
        public void addElement25(string name, int pos)
        {
            names25[pos] = name;
        }
        //Funcion que extrae la longitud del string
        public int getLength(string name)
        {
            int longitud = name.Length;
            return longitud;
        }
        //Gets para arreglo de nombres
        public string[] GetElements()
        {
            return names;
        }
        //Gets para arreglo de nombres con caracteres mayores a 25
        public string[] GetElements25()
        {
            return names25;
        }
    }
}
