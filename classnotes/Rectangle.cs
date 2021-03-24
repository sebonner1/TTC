namespace classnotes // must match
{
    public class Rectangle
    {
        // properties
        private double length;
        private double width;
        private static int count;

        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
            // We use width for data shadowing
        }

        public Rectangle() // Overloaded method - two methods with the same name but different signatures (no arg and setters)
        {

        }

        // methods

        public void SetLength(double length);
        {
            this.length = length; // "this" is specific for the instance
        }

        public double GetLength();
        {
            return length;
        }

        public void SetWidth(double width);
        {
            this.width = width; // "this" is specific for the instance
        }

        public double GetWidth();
        {
            return width;
        }

        public double GetArea()
        {
            return length * width;
        }

    }
}