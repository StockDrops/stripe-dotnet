namespace Stripe
{
    using System.IO;
    using System.Text.Json.Serialization;

    public class FileCreateOptions : BaseOptions
    {
        [JsonPropertyName("file")]
        public Stream File { get; set; }

        [JsonPropertyName("file_link_data")]
        public FileFileLinkDataOptions FileLinkData { get; set; }

        [JsonPropertyName("purpose")]
        public string Purpose { get; set; }
    }
}
