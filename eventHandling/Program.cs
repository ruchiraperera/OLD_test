using System;

namespace eventHandling
{
    class Program
    {
        static void Main(string[] args)
        {

            var _cus = new CustomerHandler();
            var _sendmail = new SendMail();
            _cus.onFinishPdf += _sendmail._sendmail;

            _cus.generatePDf();

            Console.Read();
        }
    }


    internal class SendMail {

        public void _sendmail(string name, EventArgs args) {

            Console.WriteLine("Sending mail now.......");
        }
    }
}
