using System;

namespace Les5NameScapes
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
namespace Namespaces1
{
    internal class Namespaceclass
    {
        Namespaces2.Vector2 nice = new Namespaces2.Vector2(6, 9);
    }
}
namespace Namespaces2
{
    public struct Vector2
    {
        public int x;
        public int y;
        public Vector2(int vx, int vy)
        {
            this.x = vx;
            this.y = vy;
        }
    }
}