using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestion_Hotel
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void reservation_btn_Click(object sender, EventArgs e)
        {
            reserver formeReserver = new reserver();
            formeReserver.Show();
        }
        private void AfficherControl()
        {
            //UserControl1 child1Reserver = new UserControl1();

            //panel1.Controls.Clear();
            //panel1.Controls.Add(child1Reserver);

            ////Panel1.Controls.Add()

            //child1Reserver.Show();


            //child1Reserver.Dock = DockStyle.Fill;
            //child1Reserver.Visible = true;
        }
    }
}
