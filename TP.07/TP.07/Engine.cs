using System;

namespace TP_07
{
    public class Engine
    {
        #region Attributes
        /// <summary>
        /// The power of the engine.
        /// </summary>
        private int power;

        /// <summary>
        /// Indicates whether the engine is running.
        /// </summary>
        private bool isRunning;

        /// <summary>
        /// Indicates whether the engine has failed.
        /// </summary>
        private bool failure;

        /// <summary>
        /// The car that this engine is associated with.
        /// </summary>
        private Car car;
        #endregion

        #region Constructors
        /// <summary>
        /// Initializes a new instance of the Engine class.
        /// </summary>
        /// <param name="power">The power of the engine.</param>
        /// <param name="car">The car that this engine is associated with.</param>
        public Engine(int power, Car car)
        {
            this.power = power;
            this.car = car;
            this.isRunning = false;
            this.failure = false;
        }

        /// <summary>
        /// Initializes a new instance of the Engine class by copying an existing instance.
        /// </summary>
        /// <param name="engine">The engine to copy.</param>
        public Engine(Engine engine) {
            this.power = engine.power;
            this.car = engine.car;
            this.isRunning = engine.isRunning;
            this.failure = engine.failure;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Starts the engine.
        /// </summary>
        public void Start()
        {
            this.isRunning = true;
        }

        /// <summary>
        /// Stops the engine.
        /// </summary>
        public void Stop()
        {
            this.isRunning = false;
        }

        /// <summary>
        /// Causes the engine to fail.
        /// </summary>
        public void Fail()
        {
            this.failure = true;
            this.isRunning = false;
        }

        /// <summary>
        /// Repairs the engine.
        /// </summary>
        public void Repair()
        {
            this.failure = false;
        }

        /// <summary>
        /// Returns a string that represents the current engine.
        /// </summary>
        /// <returns>A string that represents the current engine.</returns>
        public override string ToString()
        {
            if (this.isRunning)
            {
                return "[Engine] power "+this.power+", running";
            }
            else
            {
                if (failure)
                {
                    return "[Engine] power "+this.power+", failure";
                }
                else
                {
                    return "[Engine] power "+this.power+", stopped";
                }
            }
        }
        
        /// <summary>
        /// Determines whether the specified Engine is equal to the current Engine.
        /// </summary>
        /// <param name="other">The Engine to compare with the current Engine.</param>
        /// <returns>true if the specified Engine is equal to the current Engine; otherwise, false.</returns>
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Engine engine = (Engine)obj;
            return power == engine.power && isRunning == engine.isRunning && failure == engine.failure;
        }
        
        #endregion

        #region Properties
        /// <summary>
        /// Gets or sets a value indicating whether this engine is running.
        /// </summary>
        public bool IsRunning
        {
            get { return isRunning; }
        }
        #endregion
    }
}