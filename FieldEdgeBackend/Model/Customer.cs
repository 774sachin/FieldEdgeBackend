using Newtonsoft.Json;

namespace FieldEdgeBackend.Model
{
    public class Customer
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        [JsonProperty(PropertyName = "salutation")]
        public string Salutation { get; set; }
        [JsonProperty(PropertyName = "initials")]

        public string Initials { get; set; }
        [JsonProperty(PropertyName = "firstname")]

        public string Firstname { get; set; }

        [JsonProperty(PropertyName = "firstname_ascii")]
        public string FirstnameAscii { get; set; }

        [JsonProperty(PropertyName = "firstname_country_rank")]
        public string FirstnameCountryRank { get; set; }
        [JsonProperty(PropertyName = "firstname_country_frequency")]

        public string FirstnameCountryFrequency { get; set; }
        [JsonProperty(PropertyName = "lastname")]

        public string Lastname { get; set; }
        [JsonProperty(PropertyName = "lastname_ascii")]
        public string LastnameAscii { get; set; }
        [JsonProperty(PropertyName = "lastname_country_rank")]

        public string LastnameCountryRank { get; set; }
        [JsonProperty(PropertyName = "lastname_country_frequency")]

        public string LastnameCountryFrequency { get; set; }
        [JsonProperty(PropertyName = "email")]

        public string Email { get; set; }
        [JsonProperty(PropertyName = "password")]

        public string Password { get; set; }
        [JsonProperty(PropertyName = "country_code")]

        public string CountryCode { get; set; }
        [JsonProperty(PropertyName = "country_code_alpha")]

        public string CountryCodeAlpha { get; set; }
        [JsonProperty(PropertyName = "country_name")]

        public string CountryName { get; set; }
        [JsonProperty(PropertyName = "primary_language_code")]

        public string PrimaryLanguageCode { get; set; }
        [JsonProperty(PropertyName = "primary_language")]

        public string PrimaryLanguage { get; set; }
        [JsonProperty(PropertyName = "balance")]

        public double Balance { get; set; }

        [JsonProperty(PropertyName = "phone_Number")]

        public string PhoneNumber { get; set; }
        [JsonProperty(PropertyName = "currency")]

        public string Currency { get; set; }
        [JsonProperty(PropertyName = "gender")]

        public string Gender { get; set; }

    }
}
