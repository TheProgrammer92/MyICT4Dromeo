using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetX_TP
{
    public partial class userControlSearch : UserControl
    {
        public userControlSearch()
        {
            InitializeComponent();
        }

        public static userControlSearch Instance {

            get{


                userControlSearch user = new userControlSearch();
                return user;
            }

}

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
