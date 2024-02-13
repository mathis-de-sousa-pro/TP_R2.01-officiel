using System;
using System.Collections.Generic;
using System.Text;

namespace TP_06
{
    /// <summary>
    /// A musical instrumen
    /// </summary>
    class Instrument
    {
        private Musician owner = null;

        /// <summary>
        /// Change the musician who own the instrument
        /// </summary>
        /// <param name="musician">the new owner</param>
        public void ChangeOwner(Musician musician)
        {
            owner = musician;
        }

        /// <summary>
        /// Let the music play !
        /// </summary>
        public void Play()
        {
            // nothing happens
        }
    }
}
