using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web.Services.Protocols;

namespace SoapExtension1
{
    class Program
    {
        static void Main(string[] args)
        {
            ////
            ///

            Console.Read();
        }
    }

    public class SoapLoggerExtension : SoapExtension
    {

        private Stream _OldStream;
        private Stream _NewStream;

        public override object GetInitializer(LogicalMethodInfo methodInfo, SoapExtensionAttribute attribute)
        {
            return null;
        }

        public override object GetInitializer(Type serviceType)
        {
            return null;
        }

        public override void Initialize(object initializer)
        {

        }

        public override Stream ChainStream(Stream stream)
        {
            _OldStream = stream;
            _NewStream = new MemoryStream();
            return _NewStream;
        }

        public override void ProcessMessage(SoapMessage message)
        {
            switch (message.Stage)
            {
                case SoapMessageStage.BeforeSerialize:
                    break;
                case SoapMessageStage.AfterSerialize:
                    Log(message, "AfterSerialize");
                    CopyStream(_NewStream, _OldStream);
                    _NewStream.Position = 0;
                    break;
                case SoapMessageStage.BeforeDeserialize:
                    CopyStream(_OldStream, _NewStream);
                    Log(message, "BeforeDeserialize");
                    break;
                case SoapMessageStage.AfterDeserialize:
                    break;
            }
        }

        public void Log(SoapMessage message, string stage)
        {
            _NewStream.Position = 0;
            Console.WriteLine(stage);
            //Logger.Debug(stage);
            var reader = new StreamReader(_NewStream);
            string requestXml = reader.ReadToEnd();
            _NewStream.Position = 0;
            if (!string.IsNullOrWhiteSpace(requestXml))
                Console.WriteLine(requestXml);
        }

        public void ReverseIncomingStream()
        {
            ReverseStream(_NewStream);
        }

        public void ReverseOutgoingStream()
        {
            ReverseStream(_NewStream);
        }

        public void ReverseStream(Stream stream)
        {
            TextReader tr = new StreamReader(stream);
            string str = tr.ReadToEnd();
            char[] data = str.ToCharArray();
            Array.Reverse(data);
            string strReversed = new string(data);

            TextWriter tw = new StreamWriter(stream);
            stream.Position = 0;
            tw.Write(strReversed);
            tw.Flush();
        }

        private void CopyStream(Stream fromStream, Stream toStream)
        {
            try
            {
                StreamReader sr = new StreamReader(fromStream);
                StreamWriter sw = new StreamWriter(toStream);
                sw.WriteLine(sr.ReadToEnd());
                sw.Flush();
            }
            catch (Exception ex)
            {
                string message = String.Format("CopyStream failed because: {0}", ex.Message);
            }
        }
    }
}
