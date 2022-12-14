namespace Assignment02
{
    public class Rectangle
    {
        //variables declaration
        int length;
        int width;

        //default constructor
        public Rectangle()
        {
            this.length = 1;
            this.width = 1;
        }
        //non-default constructor
        public Rectangle(int length, int width)
        {
            this.length = length;
            this.width = width;
        }
        public int GetCurrentLength()
        {
            return length;
        }

        public int SetNewLength(int length)
        {
            this.length = length;
            return length;
        }
        public int GetCurrentWidth()
        {
            return width;
        }
        public int SetNewWidth(int width)
        {
            this.width = width;
            return width;
        }
        public int GetPerimeter()
        {
            return 2 * (length + width);
        }
        public int GetArea()
        {
            return length * width;
        }


    }
}
