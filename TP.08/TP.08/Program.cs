namespace TP._08._2
{

    public static class Programm
    {
        static void Main()
        {
            // 1. Créer un aéroport
            AirPort airport = new AirPort();

            // 2. Create an aircraft of each derived type and display their information
            CargoAirCraft cargoAircraft = new CargoAirCraft("CargoAircraft1");
            Console.WriteLine(cargoAircraft.ToString());

            CivilAirCraft civilAircraft = new CivilAirCraft("CivilAircraft1", 0);
            Console.WriteLine(civilAircraft.ToString());

            MilitaryAirCraft militaryAirCraft = new MilitaryAirCraft("MilitaryAirCraft1", "mission1");
            Console.WriteLine(militaryAirCraft.ToString());

            // 3. Add the created aircraft to the airport
            airport.AddCargo(cargoAircraft);
            airport.AddCivil(civilAircraft);
            airport.AddMilitary(militaryAirCraft);

            // 4. Add 20 passengers to the civil aircraft and make it take off
            civilAircraft.PassengersEnter(20);
            civilAircraft.TakeOff();

            // 5. Create a military aircraft, assign it the mission "rescue hostages", make it take off, and add it to the airport
            MilitaryAirCraft rescueAirCraft = new MilitaryAirCraft("RescueAirCraft", "rescue hostages");
            rescueAirCraft.TakeOff();
            airport.AddMilitary(rescueAirCraft);

            // 6. Display the airport
            Console.WriteLine(airport.ToString());
        }
    }
}


