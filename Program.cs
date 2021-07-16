using System; 
using HouseFunction;

/*
    Naming conventions in C#
    -We use PascalCase for most of the naming convention
    -We use camelCase for naming fields 
*/

namespace HelloWord
{
    class Program
    {
        //We can use underscores for private fields to reference them easier in our code
        private static string _first = "Hello";
        private static string _last = "World!";

        /*
            -Main method is the first method that will be called/run. Whenever you do the command dotnet run
            -the static means, I don't have to instantiate the program class to use that method
            -Void, the method will not return anything
        */
        static void Main(string[] args)
        {
            Console.WriteLine("Whatever I want");

            Test obj = new Test(); 
            obj.SomeMethod();

            Console.WriteLine(_first + _last);
            Console.WriteLine(obj.SomeMethod());


            //House Example
            House objHouse = new House();
            Console.WriteLine(objHouse.getColor());
            objHouse.setColor("Blue");
            Console.WriteLine(objHouse.getColor());
            objHouse.Price = 8000;
            Console.WriteLine(objHouse.Price);
            objHouse.Name = "Jonathan's House";
            Console.WriteLine(objHouse.Name);
        }
    }


    class Test
    {
        public string SomeMethod()
        {
            return "Hello World SomeMethod";
        }
    }
}