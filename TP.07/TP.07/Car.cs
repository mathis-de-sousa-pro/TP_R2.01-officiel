namespace TP_07
{
    public class Car
    {
        #region attributs
        // Model of the car
        private string model;
        // Engine of the car
        private Engine engine;
        // Array of wheels of the car
        private Wheel[] wheels;
        // Driver of the car
        private Driver? driver;
        // Trailer attached to the car
        private Trailer? trailer;
        #endregion

        #region constructeurs
        /// <summary>
        /// Initializes a new instance of the Car class with specified power, model, number of wheels, and wheel size.
        /// </summary>
        public Car(int pouvoir, string modele, int nombRoue, int tailleRoue)
        {
            this.model = modele;
            this.engine = new Engine(pouvoir, this);

            this.wheels = new Wheel[nombRoue];
            for (int i = 0; i < nombRoue; i++)
            {
                this.wheels[i] = new Wheel(tailleRoue);
            }
        }

        /// <summary>
        /// Initializes a new instance of the Car class that is a copy of the current instance.
        /// </summary>
        public Car(Car voiture)
        {
            this.model = voiture.model;
            this.engine = new Engine(voiture.engine);
            this.wheels = voiture.wheels;
            this.driver = voiture.driver;
            this.trailer = voiture.trailer;
        }
        #endregion

        #region méthodes
        /// <summary>
        /// Fails the engine of the car.
        /// </summary>
        public void Fail()
        {
            this.engine.Fail();
        }

        /// <summary>
        /// Repairs the engine of the car.
        /// </summary>
        public void Repair()
        {
            this.engine.Repair();
        }

        /// <summary>
        /// Starts the engine of the car.
        /// </summary>
        public void Start()
        {
            this.engine.Start();
        }

        /// <summary>
        /// Stops the engine of the car.
        /// </summary>
        public void Stop()
        {
            this.engine.Stop();
        }

        /// <summary>
        /// Changes the driver of the car.
        /// </summary>
        public void ChangeDriver(Driver conducteur)
        {
            this.driver = conducteur;
        }

        /// <summary>
        /// Attaches a trailer to the car.
        /// </summary>
        public void AttachTrailer(Trailer trail)
        {
            this.trailer = trail;
        }

        /// <summary>
        /// Unties the trailer from the car.
        /// </summary>
        public void UntieTrailler()
        {
            this.trailer = null;
        }

        /// <summary>
        /// Returns a string that represents the current car.
        /// </summary>
        public override string ToString()
        {
            string chaine = "[Car] " + this.model + "\n";
            
            chaine += "->" + this.engine.ToString() + "\n";
            
            foreach (var roue  in this.wheels)
            {
                chaine += "->" + roue.ToString() + " ";
            }
            chaine += "\n";
            
            if (this.driver != null)
            {
                chaine += "->" + this.driver.ToString() + "\n";
            }
            
            if (this.trailer != null)
            {
                chaine += "->" + this.trailer.ToString() + "\n";
            }
            
            return chaine;
        }
        #endregion
    }
}
