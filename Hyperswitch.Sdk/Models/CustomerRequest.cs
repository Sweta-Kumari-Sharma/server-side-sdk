using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Hyperswitch.Sdk.Models
{
    /// <summary>
    /// Represents the request parameters for creating or updating a customer.
    /// </summary>
    public class CustomerRequest
    {
        /// <summary>
        /// An identifier for the customer, chosen by the merchant.
        /// If not provided when creating, a new ID will be generated by Hyperswitch.
        /// This field is typically not used for update operations via this model if a separate CustomerUpdateRequest exists.
        /// </summary>
        [JsonPropertyName("customer_id")]
        public string? CustomerId { get; set; }

        /// <summary>
        /// Gets or sets the customer's email address.
        /// </summary>
        [JsonPropertyName("email")]
        public string? Email { get; set; }

        /// <summary>
        /// Gets or sets the customer's full name.
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Gets or sets the customer's phone number.
        /// </summary>
        [JsonPropertyName("phone")]
        public string? Phone { get; set; }

        /// <summary>
        /// Gets or sets the country code for the customer's phone number.
        /// </summary>
        [JsonPropertyName("phone_country_code")]
        public string? PhoneCountryCode { get; set; }

        /// <summary>
        /// Gets or sets an arbitrary string that you can attach to a customer object. 
        /// It is primarily useful for storing additional information about the customer in a structured way.
        /// </summary>
        [JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Gets or sets the customer's address.
        /// </summary>
        [JsonPropertyName("address")]
        public AddressDetails? Address { get; set; } 

        /// <summary>
        /// Gets or sets a set of key-value pairs that you can attach to a customer object.
        /// It can be useful for storing additional information about the object in a structured format.
        /// </summary>
        [JsonPropertyName("metadata")]
        public Dictionary<string, string>? Metadata { get; set; }
    }
}
