using System;
using System.Collections.Generic;
using System.Text;

namespace VectorMath
{
    public class Vector3
    {
        double X;
        double Y;
        double Z;

        public Vector3(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        // Vector Addition
        public static Vector3 Add(Vector3 a, Vector3 b)
        {
            return new Vector3(a.X + b.X, a.Y + b.Y, a.Z + b.Z);
        }

        public Vector3 Add(Vector3 other)
        {
            return new Vector3(this.X + other.X, this.Y + other.Y, this.Z + other.Z);
        }

        public void AddInPlace(Vector3 other)
        {
            this.X += other.X;
            this.Y += other.Y;
            this.Z += other.Z;
        }

        public static Vector3 operator +(Vector3 a, Vector3 b)
        {
            return new Vector3(a.X + b.X, a.Y + b.Y, a.Z + b.Z);
        }

        public static Vector3 operator ++(Vector3 a)
        {
            return new Vector3(a.X++, a.Y++, a.Z++);
        }
        // Vector Subtraction 

        public static Vector3 operator -(Vector3 a, Vector3 b)
        {
            return new Vector3(a.X - b.X, a.Y - b.Y, a.Z - b.Z);
        }


        // Vector Scaling 
        public static Vector3 operator *(Vector3 a, double scalar)
        {
            return new Vector3(a.X * scalar, a.Y * scalar, a.Z * scalar);
        }

        // Vector Comparison
        public static bool Comparison(Vector3 a, Vector3 b)
        {
            if (a.X == b.X)
            {
                if (a.Y == b.Y)
                {
                    if (a.Z == b.Z)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public static bool operator ==(Vector3 a, Vector3 b)
        {
            if (a.X == b.X)
            {
                if (a.Y == b.Y)
                {
                    if (a.Z == b.Z)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public static bool operator !=(Vector3 a, Vector3 b)
        {
            return !(a == b);
        }
    }
}
