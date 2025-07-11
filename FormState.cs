using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Đồ_án_1___Nhóm_14
{
    internal class FormState
    {
        public static Size LastSize = new Size(1280, 720);
        public static Point LastLocation = new Point(100, 100);

        public static void Save(Form form)
        {
            LastSize = form.Size;
            LastLocation = form.Location;
        }

        public static void Apply(Form form)
        {
            form.Size = LastSize;
            form.Location = LastLocation;
            form.StartPosition = FormStartPosition.Manual;
        }
    }
}