using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wzw.PressurizationStationPro
{
    public partial class FrmMsgNoAck : Form
    {
        public FrmMsgNoAck(string message,string title)
        {
            InitializeComponent();
            this.TopMost=true;
            this.lbl_Message.Text = message;
            this.lbl_Title.Text = title;
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            this.DialogResult= DialogResult.OK;
        }

        private void lbl_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region 无边框拖动
        private Point mpoint;

        private void TopPanel_MouseDown(object sender, MouseEventArgs e)
        {
            mpoint = new Point(e.X, e.Y);
        }

        private void TopPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Location = new Point(this.Location.X + e.X - mpoint.X, this.Location.Y + e.Y - mpoint.Y);
            }
        }
        #endregion
    }
}
