using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buildings
{
    public class Building
    {
            protected int pFloors;
            protected int pWidth;
            protected int pHeight;

            public Building(int numberFloors, int width, int height)
            {
                pFloors = numberFloors;
                pWidth = width;
                pHeight = height;
            }
            public int getNumberFloors()
            {
                return pFloors;
            }
            public int getWidth()
            {
                return pWidth;
            }
            public int getHeight()
            {
                return pHeight;
            }
            public void setNumberFloors(int numberFloors)
            {
                if (numberFloors > 0)
                {
                    this.pFloors = numberFloors;
                }
                else
                {
                    Console.WriteLine("Number of floors must be greater than 0");
                }
            }
            public void setWidth(int width)
            {
                if (width > 0)
                {
                    this.pWidth = width;
                }
                else
                {
                    Console.WriteLine("Width must be greater than 0");
                }
            }
            public void setHeight(int height)
            {
                if (height > 0)
                {
                    this.pHeight = height;
                }
                else
                {
                    Console.WriteLine("Height must be greater than 0");
                }
            }
    }
}
