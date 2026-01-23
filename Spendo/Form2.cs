using System;
using System.Windows.Forms;

namespace Spendo
{
    public partial class SplashForm : Form
    {
        int progress = 0;

        public SplashForm()
        {
            InitializeComponent();
        }

        private void SplashForm_Load(object sender, EventArgs e)
        {
            this.Opacity = 0;
            lblStatus.Text = "Loading" + new string('.', progress % 4);


            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            progressBar1.Value = 0;

            timerFade.Interval = 30;
            timerFade.Start();
        }

        private void timerFade_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1)
            {
                this.Opacity += 0.05;
            }

            if (progress < 100)
            {
                progress += 2;
                progressBar1.Value = progress;
                lblStatus.Text = "Loading" + new string('.', (progress / 10) % 4);

            }
            else
            {
                timerFade.Stop();
                this.Close();
            }
        }
    }
}
