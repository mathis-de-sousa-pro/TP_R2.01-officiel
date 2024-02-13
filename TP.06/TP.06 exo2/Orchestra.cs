using System;
using System.Collections.Generic;
using System.Text;

namespace TP_06
{
    /// <summary>
    /// An orchestra is a set of musicians
    /// </summary>
    /// <see cref="Musician"/>
    class Orchestra
    {
        private List<Musician> musicians;
        private string name;

        /// <summary>
        /// Init the orchestra
        /// </summary>
        /// <param name="name">the name of the orchestra</param>
        public Orchestra(string name)
        {
            this.name = name;
            this.musicians = new List<Musician>();
        }

        /// <summary>
        /// Gets or sets the orchestra's name
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        /// <summary>
        /// Play the music !
        /// </summary>
        public void Play()
        {
            foreach(Musician m in musicians)
            {
                m.Play();
            }
        }

        /// <summary>
        /// Add a musician
        /// </summary>
        /// <param name="m">the new musician</param>
        public void AddMusician(Musician m)
        {
            musicians.Add(m);
        }

        /// <summary>
        /// Remove a musician
        /// </summary>
        /// <param name="m">the musician who leave the orchestra</param>
        public void RemoveMusician(Musician m)
        {
            musicians.Remove(m);
        }
    }
}
