using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Threading;

namespace BackgroundWorkerProcess
{
    public class sequence:BackgroundWorker
    {
        Activation _activation = null;
        public UserControl1 _userControl = new UserControl1();
        AutoResetEvent _auto = new AutoResetEvent(false);

        public sequence()
        {
            _activation = new Activation();
            _activation.WorkerReportsProgress = true;
            _activation.ProgressChanged += _activation_ProgressChanged;
            _activation.RunWorkerCompleted += _activation_RunWorkerCompleted;

        }

        private void _activation_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            _auto.Set();
        }

        private void _activation_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            _userControl.setProgressValue(e.ProgressPercentage);
        }

        protected override void OnDoWork(DoWorkEventArgs e)
        {
            _activation.RunWorkerAsync();
            _auto.WaitOne();
            base.OnDoWork(e);
        }
    }
}
