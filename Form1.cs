using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WaldoFinder
{
    public partial class FormWaldo : Form
    {
        Random generator = new Random();
        public FormWaldo()
        {
            InitializeComponent();
        }

        private void FormWaldo_Load(object sender, EventArgs e)
        {
            imgWaldo.Location = new Point(generator.Next(this.ClientSize.Width - imgWaldo.Width), generator.Next(this.ClientSize.Height-imgWaldo.Height));
        }

        private void imgWaldo_Click(object sender, EventArgs e)
        {
            imgWaldo.Location = new Point(generator.Next(this.ClientSize.Width - imgWaldo.Width), generator.Next(this.ClientSize.Height - imgWaldo.Height));
        }
    }
}
