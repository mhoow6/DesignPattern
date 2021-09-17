using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern_FactoryMethod
{
    class CompFactory
    {
        public Component GetComp(CustomConsole.Usage usage)
        {
            if (usage == CustomConsole.Usage.PRESS)
            {
                return new Button();
            }
            else if (usage == CustomConsole.Usage.TOGGLE)
            {
                return new Switch();
            }
            else
            {
                return new Dropdown();
            }
        }
    }
}
