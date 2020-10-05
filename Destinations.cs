using GMap.NET.MapProviders;
using System;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;
using Newtonsoft.Json.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using System.Net;
using Newtonsoft.Json;


namespace GoogleMapAndRotation
{
    public partial class Destinations : Form
    {
        public Destinations()
        {
            InitializeComponent();
        }
        List<PointLatLng> newTargets = new List<PointLatLng>();
        private void İnsertTarget_Click(object sender, EventArgs e)
        {
            //List<PointLatLng> newTargets = new List<PointLatLng>();
            newTargets.Add(new PointLatLng(Convert.ToDouble(TargetLat.Text), Convert.ToDouble(TargetLot.Text)));

            TargetListBox.Items.Add("lat. : " + TargetLat.Text + " lng.  : " + TargetLot.Text);
            

        }

        private void Destinations_Load(object sender, EventArgs e)
        {


        }

        private void İnsertTanget_Click(object sender, EventArgs e)
        {

            foreach (var item in newTargets)
            {
                TangentListBox.Items.Add(item.Lat.ToString() + " - " + item.Lng.ToString());//MessageBox.Show();
            }

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            UnnamedViewForm formNew = new UnnamedViewForm();
            formNew.fillGControl(newTargets);
            this.Hide();
            formNew.Show();
           
            foreach (var item in newTargets)
            {
                TangentListBox.Items.Add(item.Lat.ToString() + " - " + item.Lng.ToString());//MessageBox.Show();
            }

            this.Hide();

        }
    }
}
