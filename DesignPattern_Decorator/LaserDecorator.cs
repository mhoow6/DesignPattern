using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern_Decorator
{
    class LaserDecorator : FighterDecorator
    {
        public LaserDecorator(Fighter _decoratedFighter) : base(_decoratedFighter)
        {
        }

        public override void Attack()
        {
            base.Attack();
            Console.WriteLine("레이저 발사");
        }
    }
}
