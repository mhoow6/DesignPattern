using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern_State
{
    public interface ModeState
    {
        public void toggle(ModeSwitch modeSwitch);
    }

    class ModeStateLight : ModeState
    {
        public void toggle(ModeSwitch modeSwitch)
        {
            Console.WriteLine("라이트 모드에서 다크 모드로 전환");
            // 화면이 어둡게 바뀐다..
            modeSwitch.SetState(new ModeStateDark());
        }
    }

    class ModeStateDark : ModeState
    {
        public void toggle(ModeSwitch modeSwitch)
        {
            Console.WriteLine("다크 모드에서 라이트 모드로 전환");
            // 화면이 밝게 바뀐다..
            modeSwitch.SetState(new ModeStateLight());
        }
    }
}
