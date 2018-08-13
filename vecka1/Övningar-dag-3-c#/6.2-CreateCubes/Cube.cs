using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp55
{
    class Cube
    {
        int cubeHeight;
        int cubeWidth;
        int cubeDepth;
        

       

        public Cube(int height, int width, int depth)
        {
            cubeHeight = height;
            cubeWidth = width;
            cubeDepth = depth;

           
        }

        public void WriteVolume()
        {
            int total = (cubeHeight * cubeWidth * cubeDepth);
            Console.WriteLine($"The volume of the Cube is: " + (total));
            
        }
    }

    
}
