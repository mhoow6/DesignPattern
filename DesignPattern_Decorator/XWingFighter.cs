using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern_Decorator
{
    class XWingFighter : Fighter
    {
        public void Attack()
        {
            Console.WriteLine("탄환 발사");
        }
    }
}
