namespace CarsProject;
class Program
{
    
   

    static void Main(string[] args)
    {
        Car carObj1 = new Car("purple", "Honda", 1998); //creating an instance, creating a reference 
        Car carObj2 = new Car("black", "Audi", 2023);
        Car carObj3 = new Car("golden", "BMW", 2013);

        Car carObj4 = new Car();

        Console.WriteLine($"Car color: {carObj1.color}, Model: {carObj1.model}, Year: {carObj1.year}");
        Console.WriteLine(carObj2.color);
        Console.WriteLine(carObj3.color);

        Console.WriteLine($"Car color: {carObj4.color}, Model: {carObj4.model}, Year: {carObj4.year}");

        carObj1.buyCar();
    }
}
