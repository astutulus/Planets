namespace PlanetLibrary
{
    public abstract class SpaceObject
    {
        // Fields
        private string name;
        private double mass;
        private string colour;

        // Properties
        public string Name
        {
            set
            {
                name = value;
            }
            get
            {
                return name;
            }
        }

        protected double Mass
        {
            set
            {
                mass = value;
            }
            get
            {
                return mass;
            }
        }

        protected string Colour
        {
            set
            {
                colour = value;
            }
            get
            {
                return colour;
            }
        }
    }
}
