using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern_Decorator
{
    abstract class FighterDecorator : Fighter
    {
        private Fighter decoratedFighter;
        public FighterDecorator(Fighter _decoratedFighter)
        {
            decoratedFighter = _decoratedFighter;
        }

        public virtual void Attack()
        {
            decoratedFighter.Attack();
        }
    }
}
