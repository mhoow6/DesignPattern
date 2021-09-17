using System;

// 중재자 패턴
// - 특정 이벤트에 반응해서 관련된 다른 클래스에게 알려줘야하는 일을 중개자 클래스에게 맡긴다.
// - 중재자를 중심으로 N:N 관계를 만들 수 있다
// - 여러 클래스들의 관계가 복잡하게 얽힌 설계에서 사용한다.

namespace DesignPattern_Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            ModeSwitch modeSwitch = new ModeSwitch();
            ModeMediator modeMediator = new ModeMediator();
            modeSwitch.SetModeMediator(modeMediator);

            /* 또 다른 연락업체가 중개자를 통하여 모드를 바꿀수도 있다.. */
            ModeSwitch modeSwitch2 = new ModeSwitch();
            modeSwitch2.SetModeMediator(modeMediator);

            /* 중개자 */
            modeMediator.AddListener(new ListView());
            modeMediator.AddListener(new GalleryView());
            modeMediator.AddListener(new DataDownLoader());

            modeSwitch.ToggleMode();
            // 리스트뷰 감춤
            // 갤러리뷰 보여줌
            // 갤러리뷰용 데이터 다운로드

            modeSwitch.ToggleMode();
            // 리스트뷰 보여줌
            // 갤러리뷰 감춤
            // 리스트뷰용 데이터 다운로드
        }
    }
}
