namespace TP._03
{
    /// <summary>
    /// Represents a fraction.
    /// </summary>
    class Fraction
    {
        private int _num; // Numerator
        private int _den; // Denominator

        /// <summary>
        /// Initializes a new instance of the <see cref="Fraction"/> class.
        /// </summary>
        /// <param name="num">Numerator (default is 0).</param>
        /// <param name="den">Denominator (default is 1). Must not be equal to 0!</param>
        public Fraction(int num = 0, int den = 1)
        {
            this._num = num;
            this._den = den;
            Simplify();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Fraction"/> class by copying another fraction.
        /// </summary>
        /// <param name="f">The fraction to copy.</param>
        public Fraction(Fraction f)
        {
            this._num = f._num;
            this._den = f._den;
        }

        /// <summary>
        /// Adds another fraction to this fraction.
        /// </summary>
        /// <param name="f">Another fraction to add.</param>
        public void Add(Fraction f)
        {
            this._num = (this._num * f._den + f._num * this._den);
            this._den = this._den * f._den;
            Simplify();
        }

        /// <summary>
        /// Adds two fractions and returns the result.
        /// </summary>
        /// <param name="f1">The first fraction.</param>
        /// <param name="f2">The second fraction.</param>
        /// <returns>The sum of f1 and f2.</returns>
        public static Fraction Add(Fraction f1, Fraction f2)
        {
            Fraction f = new Fraction(f1);
            f.Add(f2);
            return f;
        }

        /// <summary>
        /// Determines whether the specified object is equal to the current fraction.
        /// </summary>
        /// <param name="obj">The object to compare with the current fraction.</param>
        /// <returns>True if the specified object is equal to the current fraction; otherwise, false.</returns>
        public override bool Equals(object obj)
        {
            return obj is Fraction fraction &&
                   _num == fraction._num &&
                   _den == fraction._den;
        }

        /// <summary>
        /// Returns a string representation of the fraction.
        /// </summary>
        /// <returns>A string in the format "numerator/denominator".</returns>
        public override string ToString()
        {
            return $"{_num}/{_den}";
        }

        /// <summary>
        /// Gets the decimal value of the fraction.
        /// </summary>
        public double Value => (double)_num / (double)_den;

        // Private method to simplify the fraction.
        private void Simplify()
        {
            if (_num != 0)
            {
                int p = Pgcd(_num, _den);
                this._num /= p;
                this._den /= p;
            }
        }

        // Private method to calculate the greatest common divisor (GCD) of two numbers.
        private static int Pgcd(int a, int b)
        {
            int p;
            if (a == 1 || b == 1)
                p = 1;
            else if (a == b)
                p = a;
            else if (a < b)
                p = Pgcd(a, b - a);
            else
                p = Pgcd(b, a - b);
            return p;
        }
    }
}
