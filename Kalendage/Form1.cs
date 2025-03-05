using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalendage
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
            CenterTitleLabel();
        }
     

        private void CenterTitleLabel()
        {
            int centerY = (tabPage1.ClientSize.Height - TitleLabel.Height) / 2;
            int centerX = (tabPage1.ClientSize.Width - TitleLabel.Width) / 2;
            TitleLabel.Location = new Point(centerX, centerY);
        }
    }
}
