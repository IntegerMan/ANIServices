using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MattEland.Ani.AniServices.DataObjects
{
    /// <summary>
    /// Encapsulated Weather Data for current weather and upcoming forecasts
    /// </summary>
    [DataContract]
    public class WeatherData
    {

        /// <summary>
        /// Gets or sets the zip code.
        /// </summary>
        /// <value>The zip code.</value>
        [DataMember]
        public int ZipCode { get; set; }

        /// <summary>
        /// Gets or sets the current weather conditions.
        /// </summary>
        /// <value>The conditions.</value>
        [DataMember]
        public WeatherConditionData Conditions { get; set; }

        /// <summary>
        /// Gets or sets the forecasts.
        /// </summary>
        /// <value>The forecasts.</value>
        [DataMember]
        public List<WeatherForecastData> Forecasts { get; set; }
    }
}