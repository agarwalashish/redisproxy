using System;
using Newtonsoft.Json;

namespace RedisProxy.Common.Entities
{
    /// <summary>
    /// Sensor reading
    /// </summary>
    public class Reading
    {
        [JsonProperty("Imei")]
        public string IMEI { get; set; }
        
        public Location Location { get; set; }
        
        public DateTimeOffset? Date { get; set; }
        
        public double? Latitude { get; set; }
        
        public Temperature Temperature { get; set; }
    }
}