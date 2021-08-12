using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Journality2._0
{
    public partial class JournalityMainForm : Form
    {
        //Used for implementing dragging on form
        private bool _dragging = false;
        private Point _start_point = new Point(0, 0);
        
        public JournalityMainForm()
        {
            InitializeComponent();
            GraphicsPath p = new GraphicsPath();
            p.AddEllipse(1, 1, todoButton.Width - 4, todoButton.Height - 4);
            todoButton.Region = new Region(p);
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void toppanel_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;
            _start_point = new Point(e.X, e.Y);
        }

        private void toppanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }

        private void toppanel_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        private void toppanel_Paint(object sender, PaintEventArgs e)
        {

        }
        // Make window have shadows
        private const int CS_DropShadow = 0x00020000;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle = CS_DropShadow;
                return cp;
            }
        }
        class CircleButton : Button
        {
            protected override void OnPaint(PaintEventArgs pevent)
            {
                GraphicsPath graphics = new GraphicsPath();
                graphics.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
                this.Region = new System.Drawing.Region(graphics);
                base.OnPaint(pevent);


            }

        }

        private void todoButton_Click(object sender, EventArgs e)
        {

        }
    }
}
