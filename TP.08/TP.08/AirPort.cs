using System.Text;

namespace TP._08._2
{
     /// <summary>
    /// Represents an airport, which can contain various types of airplanes.
    /// </summary>
    public class AirPort
    {
        #region Attributes
        /// <summary>
        /// The list of airplanes at the airport.
        /// </summary>
        private List<Airplane> _airplanelist;
        #endregion

        #region Constructors
        /// <summary>
        /// Initializes a new instance of the AirPort class.
        /// </summary>
        public AirPort()
        {
            _airplanelist = new List<Airplane>(); // Initialisez la liste ici
        }
        #endregion

        #region Properties
        /// <summary>
        /// Gets or sets the list of airplanes at this airport.
        /// </summary>
        public List<Airplane> Airplanelist
        {
            get => _airplanelist;
            set => _airplanelist = value;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Adds a military aircraft to the airport.
        /// </summary>
        /// <param name="item">The military aircraft to add.</param>
        public void AddMilitary(MilitaryAirCraft item)
        {
            Airplanelist.Add(item);
        }

        /// <summary>
        /// Adds a civil aircraft to the airport.
        /// </summary>
        /// <param name="item">The civil aircraft to add.</param>
        public void AddCivil( CivilAirCraft item)
        {
            Airplanelist.Add(item);
        }

        /// <summary>
        /// Adds a cargo aircraft to the airport.
        /// </summary>
        /// <param name="item">The cargo aircraft to add.</param>
        public void AddCargo(CargoAirCraft item)
        {
            Airplanelist.Add(item);
        }

        /// <summary>
        /// Removes an airplane from the airport.
        /// </summary>
        /// <param name="item">The airplane to remove.</param>
        public void DelPlane(Airplane item)
        {
            Airplanelist.Remove(item);
        }

        /// <summary>
        /// Returns a string that represents the current airport.
        /// </summary>
        /// <returns>A string that represents the current airport.</returns>
        public override string ToString()
        {
            var temp = new StringBuilder("[Airport] \n");
            foreach (var elem in Airplanelist)
            {
                temp.AppendLine(elem.ToString());
            }

            return temp.ToString();
        }
        #endregion
    }
}