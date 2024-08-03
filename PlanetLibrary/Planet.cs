using System;

namespace PlanetLibrary
{
    public class Planet : OrbitingObject
    {
        // Constructors
        public Planet(string name, double distanceFromSunMkm, double lengthOfYear,
            double equatorialDiameterkm)
        {
            this.Name = name;
            this.DistanceFromSunMkm = distanceFromSunMkm;
            this.LengthOfYear = lengthOfYear;
            this.EquatorialDiameterkm = equatorialDiameterkm;
        }

        // Methods
        public Position getPosition(int days)
        {
            Position myPosition = new Position();

            myPosition.X = (Convert.ToInt16(DistanceFromSunMkm * Math.Cos(((2 * Math.PI) / LengthOfYear) * days)));
            myPosition.Y = (Convert.ToInt16(DistanceFromSunMkm * Math.Sin(((2 * Math.PI) / LengthOfYear) * days)));

            return myPosition;
        }

        public static Planet Implode (Planet planet)
        {
            double volume = 4 * Math.PI * (planet.EquatorialDiameterkm / 2) * (planet.EquatorialDiameterkm / 2);

            volume = volume / 2;

            return new Planet(planet.Name, planet.DistanceFromSunMkm, planet.LengthOfYear,  2 * (Math.Sqrt(volume / (4 * Math.PI))));
        }

        public Planet Implode()
        {
            double volume = 4 * Math.PI * (this.EquatorialDiameterkm / 2) * (this.EquatorialDiameterkm / 2);

            volume = volume / 2;

            return new Planet(this.Name, this.DistanceFromSunMkm, this.LengthOfYear, 2 * (Math.Sqrt(volume / (4 * Math.PI))));
        }

        //Overloading operators
        public static bool operator ==(Planet planet1, Planet planet2)
        {
            return (planet1.EquatorialDiameterkm == planet2.EquatorialDiameterkm) ?
                true : false;

        }

        public static bool operator !=(Planet planet1, Planet planet2)
        {
            return !(planet1 == planet2);
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Planet))
            {
                return false;
            }
            else
            {
                return this == (Planet)obj;
            }
        }

        public override int GetHashCode()
        {
            int hashCode = -1385555308;
            hashCode = hashCode * -1521134295 + Mass.GetHashCode();
            hashCode = hashCode * -1521134295 + DistanceFromSunMkm.GetHashCode();
            return hashCode;
        }

        public static bool operator <(Planet planet1, Planet planet2)
        {
            if (planet1.EquatorialDiameterkm < planet2.EquatorialDiameterkm)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator >(Planet planet1, Planet planet2)
        {
            if (planet1.EquatorialDiameterkm > planet2.EquatorialDiameterkm)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static double operator +(Planet planet1, Planet planet2)
        {
            return planet1.EquatorialDiameterkm + planet2.EquatorialDiameterkm;
        }
    }
}
