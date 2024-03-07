namespace TP._08._2
{
    /// <summary>
    /// Represents a civil aircraft, which is a specialized type of airplane.
    /// </summary>
    public class CivilAirCraft : Airplane
    {
        #region Attributes
        /// <summary>
        /// The number of passengers in the civil aircraft.
        /// </summary>
        private int _nbPassengers;
        #endregion
        
        #region Constructors
        /// <summary>
        /// Initializes a new instance of the CivilAircraft class with a specified name and number of passengers.
        /// </summary>
        /// <param name="name">The name of the civil aircraft.</param>
        /// <param name="nombre">The number of passengers in the civil aircraft.</param>
        public CivilAirCraft(string name, int nombre) : base(name)
        {
            _nbPassengers = nombre;
        }
        #endregion

        #region Methods
        
        /// <summary>
        /// Add passenger.
        /// </summary>
        
        public void PassengersEnter(int nb)
        {
            _nbPassengers += nb;
        }
        
        
        /// <summary>
        /// Remove passenger.
        /// </summary>
        public void PassengersLeave(int nb)
        {
            _nbPassengers -= nb;
        }
        
        /// <summary>
        /// Returns a string that represents the current civil aircraft.
        /// </summary>
        /// <returns>A string that represents the current civil aircraft.</returns>
        public override string ToString()
        {
            return $"{base.ToString()} – {_nbPassengers} passengers";
        }
        #endregion
    }
}