namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            var myCar = new Car();
            myCar.Make = "honda";
            myCar.Model = "civic";
            myCar.Year = "2003";

            Console.WriteLine($"This car is a {myCar.Make} and the model is a {myCar.Model} and it is from {myCar.Year}");

        }
    }
}
