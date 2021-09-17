using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern_Facade
{
    // 여러 클래스의 객체를 사용하는 외벽을 하나 만든다.
    class MyLocFacade
    {
        public void PrintMyAddress()
        {
            double[] myGeoLoc = new GeoLocation().getGetoLoc();

            InterConnection conn = new InterConnection();
            conn.connect();
            string data = conn.getData("https://주소_API_URL", myGeoLoc);
            conn.disconnect();

            Dictionary<string, object> address = new Json().Parse(data);

            Console.WriteLine(address["address"]);
        }
    }
}
