using System;
using System.Collections.Generic;
using System.Text;

namespace eventHandling
{
    public class CustomerHandler
    {

        // first we need to create delegate function
        // second we need to create eventhandler
        //finally rasie the event


        public delegate void onPdfGeneratorHandler(string name, EventArgs args);
        public event onPdfGeneratorHandler onFinishPdf;


        public void generatePDf()
        {
            Console.WriteLine("Running pdf generater.....");

            System.Threading.Thread.Sleep(5000);

            OnFinished();
        }

        //event handler calling method should be protected virtual and void 
        protected virtual void OnFinished()
        {

            if (onFinishPdf != null)
                onFinishPdf("ruchira", EventArgs.Empty);
        }
    }
}
