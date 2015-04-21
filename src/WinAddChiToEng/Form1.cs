using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleLogging.Core;

namespace WinAddChiToEng
{
    public partial class Form1 : Form
    {
        private readonly ILoggingService log;
        public Form1()
        {
            this.log = new SimpleLogging.NLog.NLogLoggingService();
            InitializeComponent();
        }

        private void ChineseAddress_Enter(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
            GetRequest req = new GetRequest(this.log);

            EngText.Text = req.GetAddress(city.Text, cityarea.Text, street.Text, lane.Text, alley.Text, num.Text, num_hyphen.Text, fl.Text, hyphen.Text, suite.Text);
            EngText.Focus();
            EngText.SelectAll();
            EngText.Copy();
        }
        
        private void button1_Click_1(object sender, EventArgs e)
        {
            this.city.Text = string.Empty;
            this.cityarea.Text = string.Empty;
            this.street.Text = string.Empty;
            this.lane.Text = string.Empty;
            this.alley.Text = string.Empty;
            this.num.Text = string.Empty;
            this.num_hyphen.Text = string.Empty;
            this.fl.Text = string.Empty;
            this.hyphen.Text = string.Empty;
            this.suite.Text = string.Empty;
        }
    }
}
