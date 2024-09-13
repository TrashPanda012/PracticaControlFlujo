using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio2.Clases
{
    internal class Persona
    {
        private string[] names = new string[25];
        private string[] lastNames = new string[25];
        private int[] ages = new int[25];

        public void addName(string name, int pos)
        {
            names[pos] = name;
        }
        public void addLastName(string lastName, int pos)
        {
            lastNames[pos] = lastName;
        }
        public void addBirthday(int age, int pos)
        {
            ages[pos] = age;
        }
        public string[] GetNames()
        {
            return names;
        }
        public string[] GetLastnames()
        {
            return lastNames;
        }
        public int[] GetAge()
        {
            return ages;
        }
    }
}
