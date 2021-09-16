using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern_Strategy
{
    public interface SearchStrategy
    {
        public void Search();
    }

    class SearchAll : SearchStrategy
    {
        public void Search()
        {
            Console.WriteLine("Search All");
        }
    }

    class SearchImage : SearchStrategy
    {
        public void Search()
        {
            Console.WriteLine("Search Image");
        }
    }

    class SearchNews : SearchStrategy
    {
        public void Search()
        {
            Console.WriteLine("Search News");
        }
    }

    class SearchMap : SearchStrategy
    {
        public void Search()
        {
            Console.WriteLine("Search Map");
        }
    }
}
