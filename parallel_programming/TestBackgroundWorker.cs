using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace parallel_programming
{


    class callBackgroundWorker
    {

        public void process() {


            TestBackgroundWorker _test = new TestBackgroundWorker();
            _test.ProgressChanged += _test_ProgressChanged;
            _test.RunWorkerCompleted += _test_RunWorkerCompleted;
            _test.RunWorkerAsync();

        }

        private void _test_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void _test_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }

    class TestBackgroundWorker : BackgroundWorker
    {
        protected override void OnDoWork(DoWorkEventArgs e)
        {

            ReportProgress(1);
            base.OnDoWork(e);
        }
    }
}
