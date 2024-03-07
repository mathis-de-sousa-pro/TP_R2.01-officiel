namespace TP._08._2
{
    /// <summary>
    /// Represents a cargo aircraft, which is a specialized type of airplane.
    /// </summary>
    public class CargoAirCraft : Airplane
    {
        #region Attributes
        /// <summary>
        /// The shipment of the cargo aircraft.
        /// </summary>
        private string? _shipment;
        #endregion

        #region Properties
        /// <summary>
        /// Gets or sets the shipment of this cargo aircraft.
        /// </summary>
        public string? Shipment
        {
            get => _shipment;
            set => _shipment = value;
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Initializes a new instance of the CargoAircraft class with a specified name and shipment.
        /// </summary>
        /// <param name="shipment">The shipment of the cargo aircraft.</param>
        /// <param name="name">The name of the cargo aircraft.</param>
        public CargoAirCraft(string? shipment, string name) : base(name)
        {
            _shipment = shipment;
        }

        /// <summary>
        /// Initializes a new instance of the CargoAircraft class with a specified name and no shipment.
        /// </summary>
        /// <param name="name">The name of the cargo aircraft.</param>
        public CargoAirCraft(string name) : base(name)
        {
            _shipment = null;
        }
        #endregion

        #region Methods

        /// <summary>
        /// Returns a string that represents the current cargo aircraft.
        /// </summary>
        /// <returns>A string that represents the current cargo aircraft.</returns>
        public override string ToString()
        {
            string? shipmentInfo = _shipment != null ? _shipment : "no shipment";
            return $"{base.ToString()} – {shipmentInfo}";
        }
        #endregion
    }
}