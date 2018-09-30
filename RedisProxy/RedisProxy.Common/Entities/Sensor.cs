using System;

namespace RedisProxy.Common.Entities
{
    public class Sensor
    {
        public Guid Id { get; set; }
        
        public string IMEI { get; set; }
        
        public Location Location { get; set; }
        
        public DateTimeOffset Date { get; set; }
        
        public double? Latitude { get; set; }
        
        public Temperature Temperature { get; set; }
    }
}