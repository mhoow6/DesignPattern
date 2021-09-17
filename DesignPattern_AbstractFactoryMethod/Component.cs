using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern_AbstractFactoryMethod
{
    abstract class Component
    {
        protected abstract string GetCompName();
        public Component()
        {
            Console.WriteLine(this.GetCompName() + " 생성");
        }
    }

    class LightButton : Component
    {
        protected override string GetCompName()
        {
            return "라이트 버튼";
        }
    }

    class DarkButton : Component
    {
        protected override string GetCompName()
        {
            return "다크 버튼";
        }
    }

    class LightSwitch : Component
    {
        protected override string GetCompName()
        {
            return "라이트 스위치";
        }
    }

    class DarkSwitch : Component
    {
        protected override string GetCompName()
        {
            return "다크 스위치";
        }
    }

    class LightDropdown : Component
    {
        protected override string GetCompName()
        {
            return "라이트 드롭다운";
        }
    }

    class DarkDropdown : Component
    {
        protected override string GetCompName()
        {
            return "다크 드롭다운";
        }
    }
}
