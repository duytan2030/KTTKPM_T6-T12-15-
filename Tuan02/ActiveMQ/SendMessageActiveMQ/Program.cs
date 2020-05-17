using Apache.NMS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Apache.NMS.Util;
using Apache.NMS.ActiveMQ.Commands;

namespace SendMessageActiveMQ
{
    class Program
    {
        public static void Main(string[] args)
        {
            IConnectionFactory factory = new NMSConnectionFactory("tcp://localhost:61616");
            IConnection connection = factory.CreateConnection();
            connection.Start();
            ISession session = connection.CreateSession(AcknowledgementMode.AutoAcknowledge);
            ActiveMQQueue ac = new ActiveMQQueue("DuyTan");
            IMessageProducer message = session.CreateProducer(ac);
            while (true)
            {
                message.Send(session.CreateTextMessage(Console.ReadLine()));

            }
            session.Close();
            connection.Stop();
            Console.ReadKey();
        }
    }
}
