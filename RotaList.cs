using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoogleMapAndRotation
{
    public partial class RotaList : UserControl
    {
        public RotaList()
        {
            InitializeComponent();
        }

        public Bitmap PicBmp
        {
            set { pictureBox1.Image = value; }
        }
        public string elevation
        {
            get { return LblElevation.Text; }
            set { LblElevation.Text = value +" M"; }


        }
        public string countRota
        {

            set { CountOfRota.Text = value; }
        }
        public string location
        {
            get { return LblLocation.Text; }
            set { LblLocation.Text = value; }


        }
        public string angle
        {
            get { return LblAngle.Text; }
            set { LblAngle.Text = value; }

        }

     
        private void RotaList_Load(object sender, EventArgs e)
        {

        }
    }
}
