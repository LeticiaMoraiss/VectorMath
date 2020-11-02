using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibCG
{
    public class Vector2D
    {
        public float x, y;
        public Vector2D(float x, float y)
        {
            this.x = x;
            this.y = y;
        }
        public static Vector2D operator +(Vector2D a, Vector2D b)
        {
            return new Vector2D(a.x + b.x, a.y + b.y);
        }
        public static Vector2D operator -(Vector2D a, Vector2D b)
        {
            return new Vector2D(a.x - b.x, a.y - b.y);
        }
        public static Vector2D operator *(Vector2D a, float b)
        {
            return new Vector2D(a.x * b, a.y * b);
        }
        public static Vector2D operator /(Vector2D a, float b)
        {
            return new Vector2D(a.x / b, a.y / b);
        }
        public float Magnitude(Vector2D a)
        {
            return (float)Math.Sqrt((a.x * a.x) + (a.y * a.y));
        }
        public Vector2D Normalizado(Vector2D a)
        {
            return a /= Magnitude(a);
        }
        public bool Igualdade(Vector2D a, Vector2D b)
        {
            Vector2D CompA = Normalizado(a), CompB = Normalizado(b);
            return (Magnitude(a) == Magnitude(b) && CompA.x == CompB.x && CompA.y == CompB.y);
        }
        public float Dot(Vector2D a, Vector2D b)
        {
            return ((a.x * b.x) + (a.y * b.y));
        }
        public float Projecao(Vector2D a, Vector2D b)
        {
            return (Dot(a, b) / Magnitude(b));
        }
        public float Angulo(Vector2D a, Vector2D b)
        {
            return (float)(Math.Acos(Dot(a, b) / (Magnitude(a) * Magnitude(b))) * (180 / Math.PI));
        }
    }
}
