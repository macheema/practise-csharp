namespace DelegatesPredicates.ClockExample
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public LocationEnum Location = LocationEnum.AtHome;

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        public Person(ClockTower tower)
        {
            tower.ClockTick += (ObjRef, e) =>
            {
                var eventObj = (ClockEventArgs)e;
                switch (eventObj.Time.Hour)
                {
                    case 8:
                        Location = LocationEnum.OnWay;
                        break;
                    case 9:
                        Location = LocationEnum.InOffice;
                        break;
                    case 18:
                        Location = LocationEnum.OnWay;
                        break;
                    case 13:
                        Location = LocationEnum.InCafe;
                        break;
                    case 14:
                        Location = LocationEnum.InOffice;
                        break;
                    case 19:
                        Location = LocationEnum.AtHome;
                        break;
                }
            };
        }
    }
}
