class Car
{
    public string color; //we write public to make it accessible in Program.cs; outside this class using keyword public
    public string model; 
    public int year;

    public Car() //a default model of the Car template, constructor 
    {
        color = "purple"; 
        model = "Honda";
        year = 2013;
    }

    public Car(string modelColor, string modelName, int modelYear) //constructor + parameters, same as properties in the top
    {
        color = modelColor;
        model = modelName;
        year = modelYear;
    }

    public void buyCar()
    {
        Console.WriteLine("Car is sold!");
    }


}