using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern_FactoryMethod
{
    class CustomConsole
    {
        private CompFactory compFactory = new CompFactory();

        Component comp1;
        Component comp2;
        Component comp3;

        void WithoutFactory()
        {
            comp1 = new Button();
            comp2 = new Switch();
            comp3 = new Dropdown();
        }

        void WithFactory()
        {
            comp1 = compFactory.GetComp(Usage.PRESS);
            comp2 = compFactory.GetComp(Usage.TOGGLE);
            comp3 = compFactory.GetComp(Usage.EXPAND);
        }


        public enum Usage
        {
            PRESS,
            TOGGLE,
            EXPAND
        }
    }
}
