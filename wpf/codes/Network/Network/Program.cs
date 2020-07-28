using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Network
{
    class Program
    {
        static void Main(string[] args)
        {
            // 서버 소켓이 동작하는 스레드
            Thread serverThread = new Thread(serverFunc);
            serverThread.IsBackground = true;
            serverThread.Start();

            Thread.Sleep(500);  //  소켓 서버용 스레드가 실행될 시간을 주기 위해.

            // 클라이언트 소켓이 동작하는 스레드
            Thread clientThread = new Thread(clientFunc);
            clientThread.IsBackground = true;
            clientThread.Start();

            Console.WriteLine("종료하려면 아무 키나 누르세요.");
            Console.ReadLine();
        }

        private static void clientFunc()
        {
            throw new NotImplementedException();
        }

        private static void serverFunc()
        {
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

            IPAddress iPAddress = GetCurrentIPAddress();
            if (iPAddress == null)
            {
                Console.WriteLine("IPv4용 랜 카드가 없습니다.");
                return;
            }
            IPEndPoint endPoint = new IPEndPoint(iPAddress, 10200);
            socket.Bind(endPoint);
        }

        // 현재 컴퓨터에 장착된 네트워크 어댑터의 IPv4 주소를 반환
        private static IPAddress GetCurrentIPAddress()
        {
            IPAddress[] addresses = Dns.GetHostEntry(Dns.GetHostName()).AddressList;
            foreach (IPAddress iPAddress in addresses)
            {
                if (iPAddress.AddressFamily == AddressFamily.InterNetwork)
                {
                    return iPAddress;
                }
            }

            return null;
        }

    }
}
