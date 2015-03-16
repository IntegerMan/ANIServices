using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace AniServices
{
    public class AniService : IAniService
    {

        /// <summary>
        /// Gets the number of minutes estimated to scrape frost from a car for the specified zip code and date.
        /// This will error if out of the area of service or not for a time with recorded data present.
        /// </summary>
        /// <param name="zipCode">The zip code.</param>
        /// <param name="predictionDate">The prediction date.</param>
        /// <returns>The number of minutes required to scrape frost from a car in the morning.</returns>
        public double? GetFrostScrapeTimeInMinutes(int zipCode, DateTime predictionDate)
        {
            var entities = new AniEntities();

            // Ensure we're just working with the date
            predictionDate = predictionDate.Date;

            var prediction = entities.WeatherPredictions.Where(wp => wp.WP_ZipCode == zipCode).FirstOrDefault(wp => DbFunctions.TruncateTime(wp.WP_PredictionDateUTC) == predictionDate);

            return prediction?.WP_MinutesToDefrost;
        }

        /*
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
        */
    }
}
