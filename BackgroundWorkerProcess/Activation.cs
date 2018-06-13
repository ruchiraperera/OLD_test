using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace BackgroundWorkerProcess
{
    public class Activation :BackgroundWorker
    {

        public Activation()
        {

        }

        private void process() {

            for (int i = 0; i < 10; i++)
            {
                System.Threading.Thread.Sleep(1000);
                ReportProgress(10 * i);
            }
        }

        protected override void OnDoWork(DoWorkEventArgs e)
        {
            process();
            base.OnDoWork(e);
        }
    }
}
