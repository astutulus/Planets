namespace PlanetLibrary
{
    public abstract class OrbitingObject : SpaceObject
    {
        // Fields
        private double distanceFromSunMkm;
        private double lengthOfYear;
        private double equatorialDiameterkm;

        // Properties

        protected double DistanceFromSunMkm
        {
            set
            {
                distanceFromSunMkm = value;
            }
            get
            {
                return distanceFromSunMkm;
            }
        }

        protected double LengthOfYear
        {
            set
            {
                lengthOfYear = value;
            }
            get
            {
                return lengthOfYear;
            }
        }

        public double EquatorialDiameterkm
        {
            set
            {
                equatorialDiameterkm = value;
            }
            get
            {
                return equatorialDiameterkm;
            }
        }
    }
}
