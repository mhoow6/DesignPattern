using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern_Mediator
{
    enum Mode { LIST, GALLERY }

    // 모드에 반응하도록 인터페이스를 구현하도록 한다.
    interface ModeListener
    {
        public void OnModeChange(Mode mode);
    }

    class ListView : ModeListener
    {
        public void OnModeChange(Mode mode)
        {
            Console.WriteLine("리스트 뷰" + (mode == Mode.LIST ? "보여줌" : "감춤"));
        }
    }

    class GalleryView : ModeListener
    {
        public void OnModeChange(Mode mode)
        {
            Console.WriteLine("갤러리 뷰" + (mode == Mode.GALLERY ? "보여줌" : "감춤"));
        }
    }

    class DataDownLoader : ModeListener
    {
        public void OnModeChange(Mode mode)
        {
            Console.WriteLine((mode == Mode.LIST ? "리스트" : "갤러리" + "뷰용 데이터 다운로드"));
        }
    }
}
