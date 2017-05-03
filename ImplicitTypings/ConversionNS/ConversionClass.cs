namespace ImplicitTypings.ConversionNS
{
    class ConversionClass
    {
        //Unintialized var varaible dont compiles
        public string DoSomeImplicit()
        {
            var firstName = "awais";
            var lasName = "cheema";

            return firstName + ' ' + lasName;
        }
    }
}
