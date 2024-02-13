using System;
using System.Collections.Generic;
using System.Text;

namespace TP_06
{
    /// <summary>
    /// A person, who can play an instrument
    /// </summary>
    class Musician
    {
        private Instrument instrument;
        private string name;

        /// <summary>
        /// Create the musician
        /// </summary>
        /// <param name="name">the name of the musician</param>
        /// <param name="instrument">the instrument of the musician</param>
        public Musician(string name, Instrument instrument)
        {
            this.name = name;
            this.instrument = instrument;
            instrument.ChangeOwner(this);
        }

        /// <summary>
        /// Play the music !
        /// </summary>
        public void Play()
        {
            this.instrument.Play();
        }

        /// <summary>
        /// Change the instrument
        /// </summary>
        /// <param name="i">the new instrument</param>
        public void ChangeInstrument(Instrument i)
        {
            this.instrument.ChangeOwner(null);
            this.instrument = i;
            this.instrument.ChangeOwner(this);
        }
    }
}
