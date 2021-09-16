using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern_Adapter
{
    public class MyProgram
    {
        private SearchButton searchButton;
        public MyProgram()
        {
            searchButton = new SearchButton(this);
        }

        public void SetModeAll()
        {
            searchButton.SetSearchStrategy(new SearchAll());
        }

        public void SetModeImage()
        {
            searchButton.SetSearchStrategy(new SearchImage());
        }

        public void SetModeNews()
        {
            searchButton.SetSearchStrategy(new SearchNews());
        }

        public void SetModeMap()
        {
            searchButton.SetSearchStrategy(new SearchMap());
        }

        public void SetModeMovie()
        {
            searchButton.SetSearchStrategy(new SearchFindAdapter(new FindMoveAlgorithm()));
        }

        public void TestProgram()
        {
            searchButton.OnClick();

            SetModeImage();
            searchButton.OnClick();

            SetModeNews();
            searchButton.OnClick();

            SetModeMap();
            searchButton.OnClick();

            SetModeMovie();
            searchButton.OnClick();
        }
    }
}
