using Newtonsoft.Json;

namespace Dotnet.Core.DomainModel.Models
{
    public class StoreModel
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("workplace")]
        public string Workplace { get; set; }
    }
}
