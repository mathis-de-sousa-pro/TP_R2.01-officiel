namespace TP._08._2
{
    public class Airplane
    {
        #region Attributes

        /// <summary>
        /// Indicates whether the airplane is flying.
        /// </summary>
        private bool _fly;

        /// <summary>
        /// The name of the airplane.
        /// </summary>
        private string _name;

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the AirPlane class.
        /// </summary>
        /// <param name="nom">The name of the airplane.</param>
        public Airplane(string nom)
        {
            this._name = nom;
            this._fly = false;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Makes the airplane take off.
        /// </summary>
        public void TakeOff()
        {
            this._fly = true;
        }

        /// <summary>
        /// Makes the airplane land.
        /// </summary>
        public void Land()
        {
            this._fly = false;
        }

        /// <summary>
        /// Returns a string that represents the current airplane.
        /// </summary>
        /// <returns>A string that represents the current airplane.</returns>
        public override string ToString()
        {
            return _name + " - " + (_fly ? "flying" : "grounded");
        }

        #endregion
    }
}