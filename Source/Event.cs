using System.Drawing;
using System.Windows.Forms;

namespace YoutubeTool
{
    public partial class Event
    {
        public Event()
        {}

        //Mouse Event
        #region MouseEvent
        private bool m_isMouseDown = false;
        private Size m_offSet;
        
        public void MouseDown(Size offSet)
        {
            m_isMouseDown = true;
            m_offSet = offSet;
        }

        public void MouseUp()
        {
            m_isMouseDown = false;
        }

        public void MouseMove(Form form, Point mouseLocation)
        {
            if(m_isMouseDown)
            {
                form.Location = mouseLocation - m_offSet;
                form.Update();
            }
        }
        #endregion MouseEvent
    }
}
