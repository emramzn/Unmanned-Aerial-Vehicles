using GMap.NET.WindowsForms;

namespace GoogleMapAndRotation
{
    public static class GmapControlExtension
    {
        public static void RefleshMap(this GMapControl map)
        {
            map.Zoom++;
            map.Zoom--;
        }
    }
}
