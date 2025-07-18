namespace OOP_04
{
    public class Circle : ICircle
    {
        public double Area { get; set; }

        public string DisplayShapeInfo()
        {
            return $"Area Of Circle = {Area}";
        }
    }
}
