using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern_Adapter
{
    interface FindAlgorithm
    {
        public void Find(bool global);
    }

    class FindMoveAlgorithm : FindAlgorithm
    {
        public void Find(bool global)
        {
            Console.WriteLine("Find Movie..");
        }
    }
}
