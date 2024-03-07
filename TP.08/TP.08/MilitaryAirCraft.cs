namespace TP._08._2
{
    /// <summary>
    /// Represents a military aircraft, which is a specialized type of airplane.
    /// </summary>
    public class MilitaryAirCraft : Airplane
    {
        #region attributes
        /// <summary>
        /// The mission of the military aircraft.
        /// </summary>
        private string? _mission;
        #endregion

        #region accessors
        /// <summary>
        /// Gets or sets the mission of this military aircraft.
        /// </summary>
        public string? Mission
        {
            get => _mission;
            set => _mission = value;
        }
        #endregion
        
        #region constructors
        /// <summary>
        /// Initializes a new instance of the MilitaryAirCraft class with a specified name and mission.
        /// </summary>
        /// <param name="name">The name of the military aircraft.</param>
        /// <param name="goal">The mission of the military aircraft.</param>
        public MilitaryAirCraft(string name, string? goal) : base(name)
        {
            _mission = goal;
        }

        /// <summary>
        /// Initializes a new instance of the MilitaryAirCraft class with a specified name and no mission.
        /// </summary>
        /// <param name="name">The name of the military aircraft.</param>
        public MilitaryAirCraft(string name) : base(name)
        {
            _mission = null;
        }
        #endregion

        #region methods
        /// <summary>
        /// Returns a string that represents the current military aircraft.
        /// </summary>
        /// <returns>A string that represents the current military aircraft.</returns>
        public override string ToString()
        {
            string? missionInfo = _mission != null ? _mission : "no mission";
            return $"{base.ToString()} – {missionInfo}";
        }
        #endregion
    }
}