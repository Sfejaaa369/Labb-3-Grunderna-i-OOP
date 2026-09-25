namespace GrundernaOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //creating a new object with the class Circle, adding an int in the brackets which will be the Radius
            Circle circle1 = new Circle(5); 
            Console.WriteLine("The area of the circle is: " + circle1.GetArea());

            Circle circle2 = new Circle(6);
            Console.WriteLine("The area of the circle is: " + circle2.GetArea());
        }
    }
}
