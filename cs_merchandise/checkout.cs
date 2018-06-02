using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cs_merchandise
{
    public partial class checkout : Form
    {
        public checkout()
        {
            InitializeComponent();
        }

        public Main checkoutform { get; internal set; }

        private void btnRecordOrder_Click(object sender, EventArgs e)
        {

        }
    }
}
