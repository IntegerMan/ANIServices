//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MattEland.Ani.AniServices
{
    using System;
    using System.Collections.Generic;
    
    public partial class FrostPredictionDataView
    {
        public bool HadFrost { get; set; }
        public double MinutesToDefrost { get; set; }
        public int Low { get; set; }
        public int High { get; set; }
        public bool HadRain { get; set; }
        public bool HasRain { get; set; }
        public bool HasClouds { get; set; }
        public bool HasStorm { get; set; }
        public bool HasWind { get; set; }
        public bool HasSnow { get; set; }
        public int WeatherCode { get; set; }
    }
}
