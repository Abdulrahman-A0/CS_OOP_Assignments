namespace OOP_04
{
    public class Rectangle : IRectangle
    {
        public double Area { get; set; }

        public string DisplayShapeInfo()
        {
            return $"Area Of Rectangle = {Area}";
        }
    }
}
