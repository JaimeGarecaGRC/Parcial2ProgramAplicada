
namespace AppParcial2.Models
{
    using System;


    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class AppParcial2
    {
        [JsonProperty("albumId")]
        public long AlbumId { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }

        [JsonProperty("thumbnailUrl")]
        public Uri ThumbnailUrl { get; set; }
    }
};

    /*public partial class AppParcial2
    {
        public static AppParcial2[] FromJson(string json) => JsonConvert.DeserializeObject<AppParcial2[]>(json, AppParcial2.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this AppParcial2[] self) => JsonConvert.SerializeObject(self, AppParcial2.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }
}
    */