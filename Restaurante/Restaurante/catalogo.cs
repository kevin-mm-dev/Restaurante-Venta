using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurante
{
    public partial class catalogo : Form
    {
        public catalogo()
        {
            InitializeComponent();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            lbl_H.Text = DateTime.Now.ToLongTimeString();
            lbl_F.Text = DateTime.Now.ToLongDateString();

        }

        private void Button1_Click(object sender, EventArgs e)
        {
           // Form Pla_Ent = new Pla_Ent();
        
        }


        /*private void AbrirFormP_E(object P_E)
        {
            if (this.PanelCont.Controls.Count > 0)
            {
                this.PanelCont.Controls.RemoveAt(0);
                Form ef = P_E as Form;
                ef.TopLevel = false;
                ef.Dock = DockStyle.Fill;
                this.PanelCont.Controls.Add(ef);
                this.PanelCont.Tag = ef;
                ef.Show();
            }
        }
        */
        
    }
}
