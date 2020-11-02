using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibCG
{
    public class Vector3D : Vector2D
    {
        public float z;
        public Vector3D(float x, float y, float z) : base(x, y)
        {
            this.z = z;
        }
        public static Vector3D operator +(Vector3D a, Vector3D b)
        {
            return new Vector3D(a.x + b.x, a.y + b.y, a.z + b.z);
        }
        public static Vector3D operator -(Vector3D a, Vector3D b)
        {
            return new Vector3D(a.x - b.x, a.y - b.y, a.z - b.z);
        }
        public static Vector3D operator *(Vector3D a, float b)
        {
            return new Vector3D(a.x * b, a.y * b, a.z * b);
        }
        public static Vector3D operator /(Vector3D a, float b)
        {
            return new Vector3D(a.x / b, a.y / b, a.z / b);
        }
        public float Magnitude(Vector3D a)
        {
            return (float)Math.Sqrt((a.x * a.x) + (a.y * a.y) + (a.z * a.z));
        }
        public Vector3D Normalizado(Vector3D a)
        {
            return a /= Magnitude(a);
        }
        public bool Igualdade(Vector3D a, Vector3D b)
        {
            Vector3D CompA = a.Normalizado(a), CompB = b.Normalizado(b);
            return (Magnitude(a) == Magnitude(b) && CompA.x == CompB.x && CompA.y == CompB.y);
        }
        public float Dot(Vector3D a, Vector3D b)
        {
            return ((a.x * b.x) + (a.y * b.y) + (a.z * b.z));
        }
        public Vector3D Cross(Vector3D a, Vector3D b)
        {
            return new Vector3D((a.y * b.z) - (a.z * b.y), (a.z * b.x) - (a.x * b.z), (a.x * b.y) - (a.y * b.x));
        }
        public float Projecao(Vector3D a, Vector3D b)
        {
            return (a.Dot(a, b) / Magnitude(b));
        }
        public float Angulo(Vector3D a, Vector3D b)
        {
            return (float)(Math.Acos(Dot(a, b) / (Magnitude(a) * Magnitude(b))) * (180 / Math.PI));
        }
    }
}
