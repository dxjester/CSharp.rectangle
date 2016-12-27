using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encapsulation
{
    class rectangle
    {
        //member variables

        public double length;
        public double width;

        public double getArea()
        {
            return length * width;
        }

        public void display()
        {
            Console.WriteLine("Length: {0}", length);
            Console.WriteLine("Width: {0}", width);
            Console.WriteLine("Area: {0}", getArea());
        }
        
        class executeRectangle
        {
            static void Main(string[] args)
            {
                rectangle practice = new rectangle();
                practice.length = 12;
                practice.width = 9;
                practice.display();
                Console.ReadLine();
            }
        }
    }
}
