namespace Labb_7___OOP_Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Geometri referens;

            //List thst contain all the shapes
            List<Geometri> former = new List<Geometri>() 
            {
            new Cirkel(),
            new Fyrkant(),
            new Rektangel(),
            new Parallellogram(),
            new Ellips(),
            };

            //foreach loop to write out the list
            foreach (Geometri form in former)
            {
                //Cirkel
                if (form is Cirkel cirkel)
                {
                    Console.WriteLine("Cirkles area:");
                    Console.WriteLine($"  Radie 1. {form.Area():.##}");
                    //to write out cicels alla area from radius 1 to 10
                    for (int i = 2; i <= 10; i++)
                    {
                        cirkel.Radius = i;
                        Console.WriteLine($"  Radie {i}. {form.Area():.##}");
                    }
                    Console.WriteLine();
                }
                //square
                else if (form is Fyrkant)
                {
                    Console.WriteLine($"Fyrkantens area: {form.Area():.##}" +
                        $"\n");
                }
                //rektangel
                else if (form is Rektangel)
                {
                    Console.WriteLine($"Rektangelns area: {form.Area():.##}" +
                        $"\n");
                }

                //parrallellogram
                else if (form is Parallellogram)
                {
                    Console.WriteLine($"Parallellogram area: {form.Area():.##}" +
                        $"\n");
                }
                //ellips
                else
                {
                    Console.WriteLine($"Ellipsens area: {form.Area():.##}" +
                        $"\n");

                }
            }

        }
    }
}