using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropExample
{
    class Box
    {
        private int width;
        private int height;

        public Box(int width, int height)
        {
            if(width > 0 && height > 0) {
                this.width = width;
                this.height = height;
            }
            else
            {
                Console.WriteLine("너비와 높이는 자연로 초기화 해주세요");
            }
        }
        
        public int Area()
        {
            return this.width * this.height;
        }
    }
}
