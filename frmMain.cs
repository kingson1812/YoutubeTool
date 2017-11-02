using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YoutubeTool;


namespace YoutubeTool
{
    public partial class frmMainFrame : Form
    {
       
        private Event m_event;

        public frmMainFrame()
        {
            InitInstance();
            InitializeComponent();
        }

        private void InitInstance()
        {
            m_event = new Event();
        }

        private void panelTopbar_MouseDown(object sender, MouseEventArgs e)
        {
            m_event.MouseDown((Size)Cursor.Position - (Size)this.Location);
        }

        private void panelTopbar_MouseUp(object sender, MouseEventArgs e)
        {
            m_event.MouseUp();
        }

        private void panelTopbar_MouseMove(object sender, MouseEventArgs e)
        {
            m_event.MouseMove(this, Cursor.Position);
        }
    }
}
