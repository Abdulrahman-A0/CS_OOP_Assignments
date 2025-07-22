namespace OOP_05
{
    public static class Maths
    {
        public static int Add(int x, int y)
        {
            return x + y;
        }
        public static int Subtract(int x, int y)
        {
            return x - y;
        }
        public static int Multiply(int x, int y)
        {
            return x * y;
        }
        public static int Divide(int x, int y)
        {
            if (y == 0)
                return -1;
            return x / y;
        }
    }
}
