using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoogleMapAndRotation
{
    public partial class RotaMeasures : Form
    {

       public List<RotaList> rotaList=new List<RotaList>();
        public RotaMeasures()
        {
            InitializeComponent();
           
        }

        public void  loadRotaInfo()
        {
          //  rotaList.Add(new RotaList("0255", "0225", "0222"));

            //rotaList = new List<RotaList>()
            //{
            //    new RotaList()
            //    {
            //        elevation="125.5245",
            //        location ="1251.14",
            //        angle="kuzey"

            //    },

            //     new RotaList()
            //    {
                    
            //        elevation="125.5245",
            //        location ="1251.14",
            //        angle="güney"

            //    }
            //};

            foreach (RotaList item in rotaList)
            {
                flowLayoutPanel1.Controls.Add(item);
            }

        }



        private void RotaMeasures_Load(object sender, EventArgs e)
        {
            loadRotaInfo();
        }

        private void FlowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
