using System;

namespace WpfApp1
{
    /*
     * Использовать класс Triad (тройка чисел). Создать производный класс vector3D, задаваемый тройкой координат.
     * Должны быть реализованы: операция сложения векторов, скалярное произведение векторов.
     */
    internal class vector3D : Triad
    {
        public int A { get { return _one; } set { _one = value; } }

        public int B { get { return _two; } set { _two = value; } }

        public int C { get { return _three; } set { _three = value; } }
        public vector3D()
        {

        }
        public vector3D(int x, int y, int z) : base(x,y,z)
        {
            A = x;
            B = y;
            C = z;
        }
        public int vectorsSum()
        {
            return A + B + C;
        }
    }
}
