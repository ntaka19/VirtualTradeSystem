using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace VirtualTradeSystem
{
    public partial class Form1View : Form
    {
        private Form1ViewModel _viewModel = new Form1ViewModel();

        public Form1View()
        {
            InitializeComponent();
            this.SetDealButton.Click += SetDealButtonClick;

            var deal = new Deal
            {
                TradeDate = DateTime.Parse("2020/1/1")
            };


            
            positionBindingSource.DataSource = _viewModel.Row;
            dealBindingSource.DataSource = _viewModel.RowTemp;

            //ここでなぜ問題が生じるが、bindingListで実施できた。
            _viewModel.Row.Add(deal);

        }

        private void SetDealButtonClick(object sender, EventArgs e)
        {
            _viewModel.SetDealAction();
        }

        //RowTempの計算を行う
        private void CalculatePVButtonClick(object sender, EventArgs e)
        {
            _viewModel.CalculatePVAction();
        }

    }
}

/*
 * 
 * private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                System.Threading.Thread.Sleep(5000);
                backgroundWorker1.ReportProgress(i);


                if (this.test == "main")
                {
                    MessageBox.Show(String.Format("main {0}", i.ToString()));
                }
            }

        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("バックグラウンド処理が完了しました");
        }
 private void btnStartClick(object sender, EventArgs e)
        {
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.RunWorkerAsync();

            this.test = "main";
            this.lblStatus.Text = this.test;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                System.Threading.Thread.Sleep(5000);
                backgroundWorker1.ReportProgress(i);


                if (this.test == "main")
                {
                    MessageBox.Show(String.Format("main {0}", i.ToString()));
                }
            }

        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("バックグラウンド処理が完了しました");
        }
 */