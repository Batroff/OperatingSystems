
namespace OS_practice
{
    class Person
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public override string ToString()
        {
            return $"Имя: {Name}, возраст: {Age}, зарплата: {Salary}.";
        }
    }
}