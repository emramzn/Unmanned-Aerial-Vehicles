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


    public partial class UnnamedViewForm : Form
    {
        public UnnamedViewForm()
        {
            InitializeComponent();
        }
        List<PointLatLng> DefinedTargetList = new List<PointLatLng>();
        List<PointLatLng> listem = new List<PointLatLng>();
        double[] currentPosition = new double[2];
        int sayac = 0, yanson = 0;
        double donusAcisi; // image döndürme açısı.
        GMapOverlay markers2 = new GMapOverlay("markers2");

        // Calculate of  haversine 
        public static double calculate(double lat1, double lon1, double lat2, double lon2)
        {
            var R = 6372.8f; // In kilometers that radius of earth.
            var dLat = toRadians(lat2 - lat1);
            var dLon = toRadians(lon2 - lon1);
            lat1 = toRadians(lat1);
            lat2 = toRadians(lat2);

            var a = Math.Sin(dLat / 2) * Math.Sin(dLat / 2) + Math.Sin(dLon / 2) * Math.Sin(dLon / 2) * Math.Cos(lat1) * Math.Cos(lat2);
            var c = 2 * Math.Asin(Math.Sqrt(a));
            return R * 2 * Math.Asin(Math.Sqrt(a));
        }
        // Measure distance of points ----------------
        public void distanceOfPoints(List<PointLatLng> points)
        {
            for (int i = 0; i < points.Count - 1; i++)
            {

                // MessageBox.Show(calculate(Convert.ToDouble(points[i].Lat), Convert.ToDouble(points[i].Lng), Convert.ToDouble(points[i+1].Lat), Convert.ToDouble(points[i+1].Lng)).ToString());

            }
        }
        // make range of the variables
        public static double toRadians(double angle)
        {
            return Math.PI * angle / 180.0;
        }

        public string GetElevation(string lat, string lng)
        {

            try
            {
                string url = "https://maps.googleapis.com/maps/api/elevation/json?locations="+lat+","+lng+"&key=AIzaSyAzNpn-Q7DbAQe_pXGuhHOaRGuiEhiRmR4";
                WebRequest request = WebRequest.Create(url);
                WebResponse ws = request.GetResponse();

                string jsonstring = string.Empty;
                using (System.IO.StreamReader sreader = new System.IO.StreamReader(ws.GetResponseStream()))
                {
                    jsonstring = sreader.ReadToEnd();
                }

                var elevation = JsonConvert.DeserializeObject<elevationOfPoints>(jsonstring);

                foreach (var item in elevation.results)
                {
                    if (item.elevation == null)
                    {
                        return "İrtifa Bilgisine ulaşılamadı";
                    }
                    else
                    {
                        return item.elevation;
                    }
                }


            }
            catch (WebException wex)
            {

                MessageBox.Show("Error", wex.Message.ToString());
            }
            return "İrtifa bilgisi Bulunamadı";

        }
     
        public void fillGControl(List<PointLatLng> liste)
        {

            gMapControl1.SetPositionByKeywords("Turkey"); // The country to be focused after map is loaded
            gMapControl1.MapProvider = GMapProviders.GoogleTerrainMap;// The map provider
            gMapControl1.MapScaleInfoEnabled = true;
            gMapControl1.ForceDoubleBuffer = true;
            gMapControl1.RoutesEnabled = true;// Map can have Routes
            gMapControl1.MinZoom = 2;     // Minimum zoom level
            gMapControl1.MaxZoom = 26;    // Maximum zoom level
            gMapControl1.Zoom = 100;       // Initial zoom level
            gMapControl1.DragButton = MouseButtons.Left;// Mouse button used for dragging the map

            GMapOverlay routes = new GMapOverlay("routes");// Constructing object for Overlay
            gMapControl1.Overlays.Add(routes);

            GMapRoute r = new GMapRoute(liste, "myroute"); // object for routing
            r.Stroke.Width = 5;
            r.Stroke.Color = Color.Blue;
            routes.Routes.Add(r);


            gMapControl1.ZoomAndCenterRoute(r);
            gMapControl1.Zoom = 10;
         


            foreach (var item in liste)
            {
                PointLatLng point = new PointLatLng(item.Lat, item.Lng);
                // create custom maker
                Bitmap bmp = (Bitmap)Image.FromFile("D:/GoogleMapAndRotation/GoogleMapAndRotation/airplane.png");

                GMapMarker marker = new GMarkerGoogle(point, GMarkerGoogleType.blue_small);
                GMapOverlay markers = new GMapOverlay("markers");
                markers.Markers.Add(marker);
                marker.ToolTipText = point.ToString() +"\n Min. Altitude : "+ GetElevation(item.Lat.ToString().Replace(',', '.'), item.Lng.ToString().Replace(',', '.'))+" M ";
                marker.ToolTip.Stroke.Width = 1;
                marker.ToolTip.Stroke.Brush = Brushes.CornflowerBlue;
            
                marker.ToolTip.Stroke.Color = Color.DarkOrange;
                marker.ToolTip.Font = new Font("Times New Roman", 20.0f);
                
                

                gMapControl1.Overlays.Add(markers); // gmap control üzerine işareti yerleştir.
             
                //rota üzerinde irtifa ve yön gösterimleri için nokta bilgileri.
               // DefinedTargetList.Add(new PointLatLng(item.Lat, item.Lng));

            }
            gMapControl1.Refresh();
        }
        private void UnnamedViewForm_Load(object sender, EventArgs e)
        {
            gMapControl1.Refresh();
            NumberPnt_LBL.Text = "0";
            TargetPnt_LBL.Text = "";
        }

        private void Button1_Click(object sender, EventArgs e)
        {

          //  distanceOfPoints(listem);
            timer1.Enabled = true;
            gMapControl1.Refresh();
          
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (DefinedTargetList.Count>0)
            {
                RotaMeasures measure = new RotaMeasures();
                List<RotaList> Rotas = new List<RotaList>();


                //Anlık pozisyon bilgisi
                currentPosition[0] = DefinedTargetList[sayac].Lat;
                currentPosition[1] = DefinedTargetList[sayac].Lng;
                //---------------------------------------------------
                Bitmap bmp = (Bitmap)Image.FromFile("D:/GoogleMapAndRotation/GoogleMapAndRotation/RedUav.png");
                if (sayac < DefinedTargetList.Count-1)
                {
                    string lati = Convert.ToString(DefinedTargetList[sayac].Lat);
                    string lngi = Convert.ToString(DefinedTargetList[sayac].Lng);

                 

                    PointLatLng listePoint = new PointLatLng(DefinedTargetList[sayac].Lat, DefinedTargetList[sayac].Lng);

                    // İHA img yön verme
                    donusAcisi = RotateAngle(Convert.ToDouble(DefinedTargetList[sayac].Lat), Convert.ToDouble(DefinedTargetList[sayac].Lng), Convert.ToDouble(DefinedTargetList[sayac + 1].Lat), Convert.ToDouble(DefinedTargetList[sayac + 1].Lng));
                    bmp = RotateImage(bmp, donusAcisi);

                    //Yön verilen img'yi haritaya basmak.
                    GMapMarker marker = new GMarkerGoogle(listePoint, bmp);
                    
                    markers2.Markers.Add(marker);
                    

                    if (sayac > DefinedTargetList.Count-1)
                    {
                        timer1.Enabled = false;
                        timer1.Stop();

                    }
                    sayac++;
             

                }
                yanson++;
                if (yanson % 2 == 1)
                {
                    gMapControl1.Overlays.Remove(markers2);

                }
                if (yanson == 2)
                {
                    gMapControl1.Overlays.Add(markers2);
                    yanson = 0;
                }

                if (sayac == DefinedTargetList.Count)
                {
                    timer1.Enabled = false;
                    timer1.Stop();
                }
            }
            else
            {
                MessageBox.Show("lütfen Hedef noktaları girin ");
                timer1.Enabled = false;
                timer1.Stop();
            }

        }
        private void Button2_Click(object sender, EventArgs e)
        {
            Bitmap bmp = (Bitmap)Image.FromFile("D:/GoogleMapAndRotation/GoogleMapAndRotation/197205-64.png");
           // int infocount = 0;
            List<RotaList> Rotas = new List<RotaList>();
            RotaMeasures measure = new RotaMeasures();
          //MessageBox.Show(DefinedTargetList.Count.ToString());
            for (int i = 0; i < DefinedTargetList.Count - 1; i++)
            {

                donusAcisi = RotateAngle(Convert.ToDouble(DefinedTargetList[i].Lat), Convert.ToDouble(DefinedTargetList[i].Lng), Convert.ToDouble(DefinedTargetList[i + 1].Lat), Convert.ToDouble(DefinedTargetList[i + 1].Lng));
                bmp = RotateImage(bmp, donusAcisi);
                measure.rotaList.Add(new RotaList() { countRota = (i + 1).ToString(), elevation = GetElevation(DefinedTargetList[i].Lat.ToString().Replace(',', '.'), DefinedTargetList[i].Lng.ToString().Replace(',', '.')), location = DefinedTargetList[i].Lat.ToString() + " " + DefinedTargetList[i].Lng.ToString(), angle = donusAcisi.ToString(), PicBmp = bmp });

            }
            int NoktaSayisi = DefinedTargetList.Count-1;
          
            measure.rotaList.Add(new RotaList() { countRota = (NoktaSayisi+1).ToString(), elevation = GetElevation(DefinedTargetList[NoktaSayisi].Lat.ToString().Replace(',', '.'), DefinedTargetList[NoktaSayisi].Lng.ToString().Replace(',', '.')), location = DefinedTargetList[NoktaSayisi].Lat.ToString() + " " + DefinedTargetList[NoktaSayisi].Lng.ToString() });

            measure.Show();
        }

        // İHA iconu döndürülme açısı.
        private double RotateAngle(double lat1, double lng1, double lat2, double lng2)
        {
            double x1 = lat1, x2 = lat2, y1 = lng1, y2 = lng2, X = x2 - x1, Y = y2 - y1, Z, R, angle;
            Z = Math.Round(Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y, 2)));
            R = Math.Atan2(Y, X);
            angle = R * 180 / Math.PI;

            return angle;
        }

        public double[,] Uzaklik ()
        {

            double[,] distMatris = new double[DefinedTargetList.Count, DefinedTargetList.Count];


            for (int i = 0; i < DefinedTargetList.Count; i++)
            {

                for (int j = 0; j < DefinedTargetList.Count; j++)
                {

                    distMatris[i, j] = calculate(DefinedTargetList[i].Lat, DefinedTargetList[i].Lng, DefinedTargetList[j].Lat, DefinedTargetList[j].Lng);

                }
            }

            return distMatris;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            DefinedTargetList.Add(new PointLatLng(40.900425, 31.578809));
            DefinedTargetList.Add(new PointLatLng(40.950425, 32.578848));
            // listem.Add(new PointLatLng(40.950425, 32.578848));
            // DefinedTargetList.Add(new PointLatLng(40.996557, 30.478898));
            DefinedTargetList.Add(new PointLatLng(40.625564, 31.978777));
            DefinedTargetList.Add(new PointLatLng(40.456514, 32.478777));
            DefinedTargetList.Add(new PointLatLng(40.972857, 33.510988));
            DefinedTargetList.Add(new PointLatLng(40.986447, 32.688997));

            
            Dijkstra(Uzaklik(), 0, DefinedTargetList.Count);
            fillGControl(listem);

            NumberPnt_LBL.Text = DefinedTargetList.Count().ToString();
            TargetPnt_LBL.Text = "Terget Points.";
            gMapControl1.RefleshMap();
        }
        
        public void RefleshMap(GMapControl map)
        {
            map.Zoom++;
            map.Zoom--;

        }
        // İHA iconu'nun rota doğrultısında döndürülmesi.
        private Bitmap RotateImage(Bitmap bmp, double angle)
        {
            Bitmap rotatedImage = new Bitmap(bmp.Width, bmp.Height);
            using (Graphics g = Graphics.FromImage(rotatedImage))
            {
                // Set the rotation point to the center in the matrix
                g.TranslateTransform(bmp.Width / 2, bmp.Height / 2);
                // Rotate
                g.RotateTransform((float)(angle));
                // Restore rotation point in the matrix
                g.TranslateTransform(-bmp.Width / 2, -bmp.Height / 2);
                // Draw the image on the bitmap
                g.DrawImage(bmp, new Point(0, 0));
            }

            return rotatedImage;
        }

        // Djiksta algoritması
        private  double MinimumDistance(double[] distance, bool[] shortestPathTreeSet, int verticesCount)
        {
            double min = double.MaxValue;
            int minIndex = 0;

            for (int v = 0; v < verticesCount; ++v)
            {
                if (shortestPathTreeSet[v] == false && distance[v] <= min)
                {
                    min = distance[v];
                    minIndex = v;
                }
            }

            return minIndex;
        }
         
         private void Print(double[] distance, int verticesCount)
         {


            listBox1.Items.Add("Vertex    Distance from source");
            string yazi = "";
           
            for (int i = 0; i < verticesCount; ++i)
            {
                yazi = i.ToString() + "\t" + distance[i].ToString();
                listBox1.Items.Add(yazi);
            }

            double[,] dizi = new double[DefinedTargetList.Count, DefinedTargetList.Count];
            dizi = Uzaklik();
            int sayac = 0;
            //Array.Sort(distance);

            listBox1.Items.Add("uzaklık indexleri");
            for (int k = 0; k < DefinedTargetList.Count; k++)
            {
                for (int l = 0; l < DefinedTargetList.Count; l++)
                {
                    if (sayac==distance.Length)
                        {
                            break;
                        }
                    if (dizi[k,l]==distance[sayac])
                    {
                       // listBox1.Items.Add((DefinedTargetList[k].Lat , DefinedTargetList[k].Lng  + "-->"+DefinedTargetList[l].Lat , DefinedTargetList[l].Lng  , distance[sayac], distance.Length));
                        listem.Add(new PointLatLng(DefinedTargetList[l].Lat, DefinedTargetList[l].Lng));
                        
                        sayac++;
                    }
                }
            }

           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            gMapControl1.MapProvider = GMapProviders.GoogleMap;
        }

        private void MapViewTerrBTN_Click(object sender, EventArgs e)
        {
            gMapControl1.MapProvider = GMapProviders.GoogleTerrainMap;// The map provider
        }

        private void MapViewSattBTN_Click(object sender, EventArgs e)
        {
            gMapControl1.MapProvider = GMapProviders.GoogleSatelliteMap;// The map provider
        }

        public void Dijkstra(double[,] graph, int source, int verticesCount)
        {
            double[] distance = new double[verticesCount];
            bool[] shortestPathTreeSet = new bool[verticesCount];

            for (int i = 0; i < verticesCount; ++i)
            {
                distance[i] = int.MaxValue;
                shortestPathTreeSet[i] = false;
            }

            distance[source] = 0;

            for (int count = 0; count < verticesCount - 1; ++count)
            {
                int u = Convert.ToInt32(MinimumDistance(distance, shortestPathTreeSet, verticesCount));
                shortestPathTreeSet[u] = true;

                for (int v = 0; v < verticesCount; ++v)
                {
                    if (!shortestPathTreeSet[v] && Convert.ToBoolean(graph[u, v]) && distance[u] != double.MaxValue && distance[u] + graph[u, v] < distance[v])
                    {
                        distance[v] = distance[u] + graph[u, v];
                    }

                }
            }

            Print(distance, verticesCount);
        }

    }
}
