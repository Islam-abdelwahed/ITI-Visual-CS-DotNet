using System;
using System.Collections.Generic;
using System.Text;

namespace lab_03.Models
{
    internal class Point3D : IComparable<Point3D>, ICloneable
    {
        public int x { get; set; }
        public int y { get; set; }
        public int z { get; set; }

        public Point3D() : this(0, 0, 0)
        {
        }
        public Point3D(int value) : this(value, value, value)
        {
        }

        public Point3D(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }


        public static explicit operator string(Point3D p)
        {
            if (p == null)
                return "";

            return p.ToString();
        }

        public static bool operator ==(Point3D p1, Point3D p2)
        {
            if (ReferenceEquals(p1, p2))
                return true;

            if (ReferenceEquals(p1, null) || ReferenceEquals(p2, null))
                return false;

            return p1.Equals(p2);
        }
        public static bool operator !=(Point3D p1, Point3D p2)
        {
            return !(p1 == p2);
        }
        public override string ToString()
        {
            return $"Point Coordinates:   ({x},{y},{z})";
        }

        public override bool Equals(object? obj)
        {
            if (obj == null || !(obj is Point3D))
                return false;

            Point3D other = (Point3D)obj;
            return x == other.x && y == other.y && z == other.z;
        }

        public int CompareTo(Point3D other)
        {
            if (other == null) return 1;
            int result = x.CompareTo(other.x);
            if (result == 0) result = y.CompareTo(other.y);
            return result;
        }

        public object Clone() => new Point3D(x, y, z);
    }
}
