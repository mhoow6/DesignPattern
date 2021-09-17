using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern_Decorator
{
    // 데코레이터 패턴에 팩토리 메서드 적용
    class FighterFactory
    {
        public Fighter GetFighter(bool laser = false, bool plasma = false)
        {
            Fighter fighter = new XWingFighter();

            if (laser) fighter = new LaserDecorator(fighter);
            if (plasma) fighter = new PlasmaDecorator(fighter);

            return fighter;
        }
    }
}
