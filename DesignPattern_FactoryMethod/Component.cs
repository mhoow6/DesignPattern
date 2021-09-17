using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern_FactoryMethod
{
    abstract class Component
    {
        protected abstract string GetCompName();
        public Component()
        {
            Console.WriteLine(this.GetCompName() + " 생성");
        }
    }

    class Button : Component
    {
        protected override string GetCompName()
        {
            return "버튼";
        }
    }

    class Switch : Component
    {
        protected override string GetCompName()
        {
            return "스위치";
        }
    }

    class Dropdown : Component
    {
        protected override string GetCompName()
        {
            return "드랍다운";
        }
    }
}
