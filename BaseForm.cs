using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Đồ_án_1___Nhóm_14
{
    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            InitializeComponent();
            this.Size = FormState.LastSize;
            this.Location = FormState.LastLocation;
            this.StartPosition = FormStartPosition.Manual;

            this.FormClosing += (s, e) =>
            {
                FormState.LastSize = this.Size;
                FormState.LastLocation = this.Location;
            };
        }
    }
}
