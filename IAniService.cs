using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace AniServices
{
    /// <summary>
    /// The public interface (service contract) of the ANI Data Service
    /// </summary>
    [ServiceContract]
    public interface IAniService
    {

        /// <summary>
        /// Gets the number of minutes estimated to scrape frost from a car for the specified zip code and date.
        /// This will return null if out of the area of service or not for a time with recorded data present.
        /// </summary>
        /// <param name="zipCode">The zip code.</param>
        /// <param name="predictionDate">The prediction date.</param>
        /// <returns>The number of minutes required to scrape frost from a car in the morning.</returns>
        [OperationContract]
        double? GetFrostScrapeTimeInMinutes(int zipCode, DateTime predictionDate);

        /*
        /// <summary>
        /// Gets the number of minutes estimated to scrape frost from a car given the forecasted conditions.
        /// </summary>
        /// <param name="weatherCode">The Yahoo weather code.</param>
        /// <param name="lowForecast">The low forecast.</param>
        /// <param name="highForecast">The high forecast.</param>
        /// <returns>The number of minutes required to scrape frost from a car in the morning.</returns>
        [OperationContract]
        double GetFrostScrapeTimeInMinutes(int weatherCode, double lowForecast, double highForecast);
        */

        /*
        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);
        */

        // TODO: Add your service operations here
    }

    /*
    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
    */
}
