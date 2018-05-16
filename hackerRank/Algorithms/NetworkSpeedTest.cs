using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;

namespace hackerRank
{
    class NetworkSpeedTest
    {
        public NetworkSpeedTest()
        {
            NetworkInterface[] adapter = NetworkInterface.GetAllNetworkInterfaces();

            String NetworkCard = adapter[0].Description.ToString();

            Console.WriteLine(NetworkCard);



        }

    }
}
