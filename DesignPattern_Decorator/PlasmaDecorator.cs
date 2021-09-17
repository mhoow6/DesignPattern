using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern_Decorator
{
    class PlasmaDecorator : FighterDecorator
    {
        public PlasmaDecorator(Fighter _decoratedFighter) : base(_decoratedFighter)
        {

        }

        public override void Attack()
        {
            base.Attack();
            Console.WriteLine("플라즈마 발사");
        }
    }
}
