using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern_Facade
{
    class Json
    {
        public Dictionary<string ,object> Parse(string str)
        {
            Dictionary<string, object> result = new Dictionary<string, object>();
            result.Add("address", "서울시 개발구 객체동");
            return result;
        }
    }
}
