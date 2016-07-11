namespace Trajectus.Models
{
    public class GPSPosition
    {
        public int GPSPositionID { get; set; }

        private long DDLatitude { get; set; }
        private long DDLongitude { get; set; }

        private long DMSLatitude { get; set; }
        private long DMSLongitude { get; set; }

    }
}