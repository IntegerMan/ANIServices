//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AniServices
{
    using System;
    using System.Collections.Generic;
    
    public partial class WeatherPrediction
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WeatherPrediction()
        {
            this.WeatherFrostResults = new HashSet<WeatherFrostResult>();
        }
    
        public int WP_ID { get; set; }
        public System.DateTime WP_CreatedTimeUTC { get; set; }
        public System.DateTime WP_PredictionDateUTC { get; set; }
        public int WP_CreatorUserNodeID { get; set; }
        public int WP_ZipCode { get; set; }
        public int WP_TempLow { get; set; }
        public int WP_TempHigh { get; set; }
        public int WP_WeatherCode { get; set; }
        public int WP_WeatherSourceID { get; set; }
        public Nullable<double> WP_MinutesToDefrost { get; set; }
    
        public virtual UserNode UserNode { get; set; }
        public virtual WeatherCode WeatherCode { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WeatherFrostResult> WeatherFrostResults { get; set; }
        public virtual WeatherSource WeatherSource { get; set; }
    }
}
