namespace RedisProxy.Common.Entities
{
    public class Location
    {
        public double? Longitude { get; set; }
        
        public double? Latitude { get; set; }
        
        public string FormattedAddress { get; set; }
    }
}