using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Apache.NMS;
using Apache.NMS.ActiveMQ.Commands;
using Apache.NMS.Util;

namespace RecieverMessageActiveMQ
{
    class Program
    {
        public static void Main(string[] args)
        {
            IConnectionFactory factory = new NMSConnectionFactory("tcp://localhost:61616");
            IConnection connection = factory.CreateConnection();
            connection.Start();
            ISession session = connection.CreateSession(AcknowledgementMode.AutoAcknowledge);
            IDestination destination = SessionUtil.GetDestination(session, "DuyTan");
            IMessageConsumer messageConsumer = session.CreateConsumer(destination);
            messageConsumer.Listener += new MessageListener(Message_Listenner);
            Console.ReadKey();
        }
        private static void Message_Listenner(IMessage message)
        {
            if(message is ActiveMQTextMessage)
            {
                ActiveMQTextMessage msg = message as ActiveMQTextMessage;
                Console.WriteLine(msg.Text);
            }
        }
    }
}
