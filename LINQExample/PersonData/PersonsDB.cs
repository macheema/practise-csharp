using DelegatesPredicates.ClockExample;

namespace LINQExample.PersonData
{
    class PersonsDB
    {
        Person[] _persons = new Person[10]
        {
            new Person("Awais","Cheema"),
            new Person("Ali","Zaib"),
            new Person("Zeeshan","Sabir"),
            new Person("Usama","Khan"),
            new Person("Aqib","Sheikh"),
            new Person("Nisar","Cheema"),
            new Person("Umer","Ali"),
            new Person("Waqas","Khan"),
            new Person("Rizwan","Khan"),
            new Person("Asad","Shafiq"),
        };

        public Person[] Persons
        {
            get { return _persons; }
            set { _persons = value; }
        }
    }
}
