
using object_oriented_program_which_display_brand_of__different_cars;

class Program
{
    static void Main(string[] args)
    {
        // call constructor
        Car car1 = new Car("Bugatti");

        Console.WriteLine("Brand of car1: " + car1.brand);

        // call the copy constructor
        Car car2 = new Car(car1);
        Console.WriteLine("Brand of car2: " + car2.brand);

        Console.ReadLine();
    }
}
