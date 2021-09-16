using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern_Adapter
{
    public class SearchButton
    {
        private MyProgram myProgram;

        public SearchButton (MyProgram _myProgram)
        {
            myProgram = _myProgram;
        }

        private SearchStrategy searchStrategy = new SearchAll();

        // Setter를 통하여 언제든지 다른 검색 전략으로 바꿀 수 있다.
        // 인터페이스를 구현한 객체를 매개변수로 받는것이 핵심.
        public void SetSearchStrategy(SearchStrategy _searchStrategy)
        {
            searchStrategy = _searchStrategy;
        }

        public void OnClick()
        {
            searchStrategy.Search();
        }
    }
}
