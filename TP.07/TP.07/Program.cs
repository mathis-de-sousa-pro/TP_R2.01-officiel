// See https://aka.ms/new-console-template for more information

namespace TP_07
{
    class Program
    {
        static void Main(string[] args)
        {
            Driver driver = new Driver("Toto");
            Trailer trailer = new Trailer(450);
            Car car = new Car(600, "Twingo", 4, 15);
            Console.WriteLine("Cas 1 : voiture arrêtée sans conducteur ni remorque");
            Console.WriteLine(car.ToString());
            car.ChangeDriver(driver);
            car.Start();
            Console.WriteLine("Cas 2 : voiture avec conducteur sans remorque qui roule");
            Console.WriteLine(car.ToString());
            car.Fail();
            car.AttachTrailer(trailer);
            Console.WriteLine("Cas 3 : voiture avec conducteur et remorque en panne");
            Console.WriteLine(car.ToString());
            
            
            Wheel w1 = new Wheel(15) ;
            Wheel w2 = new Wheel(w1) ;
            Console.WriteLine(w1==w2) ; // doit indiquer false
            Console.WriteLine(w1.Equals(w2)) ; // doit indiquer true
        }
    }
}