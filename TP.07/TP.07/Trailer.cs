using System;

namespace TP_07
{
    public class Trailer 
    {
        #region attributs
        // Size of the trailer
        private int size;
        // Car the trailer belongs to
        private Car car;
        #endregion

        #region accesseurs
        /// <summary>
        /// Gets or sets the car the trailer belongs to.
        /// </summary>
        public Car Car
        {
            get => car;
            set => car = value;
        }
        #endregion

        #region constructeurs
        /// <summary>
        /// Initializes a new instance of the Trailer class with a specified size.
        /// </summary>
        /// <param name="taille">The size of the trailer.</param>
        public Trailer(int taille)
        {
            this.size = taille;
        }

        /// <summary>
        /// Initializes a new instance of the Trailer class that is a copy of the current instance.
        /// </summary>
        /// <param name="trailer">The trailer to copy.</param>
        public Trailer(Trailer trailer)
        {
            this.size = trailer.size;
            this.car = trailer.car;
        }
        #endregion

        #region méthodes
        /// <summary>
        /// Returns a string that represents the current trailer.
        /// </summary>
        /// <returns>A string that represents the current trailer.</returns>
        public override string ToString()
        {
            return "[Trailer] capacity "+this.size+"l";
        }

        /// <summary>
        /// Determines whether the specified Trailer is equal to the current Trailer.
        /// </summary>
        /// <param name="other">The Trailer to compare with the current Trailer.</param>
        /// <returns>true if the specified Trailer is equal to the current Trailer; otherwise, false.</returns>
        protected bool Equals(Trailer other)
        {
            return size == other.size;
        }

        /// <summary>
        /// Determines whether the specified object is equal to the current Trailer.
        /// </summary>
        /// <param name="obj">The object to compare with the current Trailer.</param>
        /// <returns>true if the specified object is equal to the current Trailer; otherwise, false.</returns>
        public override bool Equals(object? obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Trailer) obj);
        }

        /// <summary>
        /// Serves as a hash function for a Trailer object.
        /// </summary>
        /// <returns>A hash code for this instance that is suitable for use in hashing algorithms and data structures such as a hash table.</returns>
        public override int GetHashCode()
        {
            return size;
        }
        #endregion
    }
}