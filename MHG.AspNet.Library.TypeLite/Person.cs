using TypeLite;

namespace MHG.AspNet.LibraryTypeLite
{
    [TsClass(Module = "TypeLiteTest", Name = "TestClass")]
    public class Person
    {
        public string Name { get; set; }
        [TsProperty(Name = "LastName")]
        public string Surname { get; set; }
        [TsIgnore]
        public int Age { get; set; }
    }

    [TsClass]
    public class Auto
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        [TsIgnore]
        public int Year { get; set; }
    }
}