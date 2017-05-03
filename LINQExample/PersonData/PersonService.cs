using System.Collections.Generic;
using System.Linq;
using DelegatesPredicates.ClockExample;

namespace LINQExample.PersonData
{
    public class PersonService
    {
        PersonsDB _db = new PersonsDB();

        public Person[] GetPersonsNameStartsWith(char c)
        {
            var persons = from p in _db.Persons
                          where !string.IsNullOrEmpty(p.FirstName) && p.FirstName[0].Equals(c)
                          select p;
            return persons.ToArray();
        }

        public string[] GetUniqPersonsStringKey()
        {
            var personsEnumAble = from p in _db.Persons
                                  where !string.IsNullOrEmpty(p.FirstName)
                                  group p by p.FirstName[0];
            List<string> list = new List<string>(10);
            foreach (var group in personsEnumAble)
            {
                list.Add(group.Key + " : " + group.Count());
            }
            return list.ToArray();
        }
        public int GetUniqPersonsCount()
        {
            var personsEnumAble = from p in _db.Persons
                                  where !string.IsNullOrEmpty(p.FirstName)
                                  group p by p.FirstName[0];
            return personsEnumAble.Count();
        }

        public Person IsExist(Person person)
        {
            var personGroup = from p in _db.Persons
                              where !string.IsNullOrEmpty(p.FirstName) && p.FirstName.Equals(person.FirstName) && p.Location == person.Location
                              select p;
            var itr = personGroup?.GetEnumerator();
            itr.MoveNext();
            var guy = itr.Current;
            itr.Dispose();
            return guy;
        }
    }
}
