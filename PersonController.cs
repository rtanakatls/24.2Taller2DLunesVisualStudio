using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2DVisualStudioSemana1
{
    internal class PersonController
    {
        private List<Person> people;
        
        public PersonController()
        {
            people = new List<Person>();
        }

        public void AddNewPerson(string name, int age)
        {
            people.Add(new Person(name, age));
        }

        public void RemovePerson(string name)
        {
            Person p = null;
            foreach(Person person in people)
            {
                if (person.Name == name)
                {
                    p = person;
                }
            }
            if (p != null)
            {
                people.Remove(p);
            }
        }

        public string ShowAllPeople()
        {
            string peopleData="";
            foreach(Person person in people)
            {
                peopleData += $"{person.GetData()}\n";
            }
            return peopleData;
        }
    }
}
