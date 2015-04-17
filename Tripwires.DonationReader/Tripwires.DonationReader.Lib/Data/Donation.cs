using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace Tripwires.DonationReader.Lib.Data
{
    public class Donation
    {
        /**
         * {
         "donations":[
          {
           "username":"Donation-Tracker",
           "note":"Your message goes here!",
           "timestamp":"1407240045",
           "amount":"75.00",
           "currency":"USD",
           "currency_symbol":"$",
           "transaction_id":"DT-F0PGNGB3O",
           "paypal_email":"payment@donation-tracker.com"
          }
         ],
         "api_check":"1"
        }*/
        private string username;
        private string note;
        private string timestamp;
        private string currency;
        private string currency_symbol;
        private string transaction_id;
        private string paypal_email;

        [JsonProperty("username")]
        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        [JsonProperty("note")]
        public string Note
        {
            get { return note; }
            set { note = value; }
        }
        [JsonProperty("timestamp")]
        public string Timestamp
        {
            get { return timestamp; }
            set { timestamp = value; }
        }
        [JsonProperty("currency")]
        public string Currency
        {
            get { return currency; }
            set { currency = value; }
        }
        [JsonProperty("currency_symbol")]
        public string CurrencySymbol
        {
            get { return currency_symbol; }
            set { currency_symbol = value; }
        }
        [JsonProperty("transaction_id")]
        public string TransactionId
        {
            get { return transaction_id; }
            set { transaction_id = value; }
        }
        [JsonProperty("paypal_email")]
        public string PaypalEmail
        {
            get { return paypal_email; }
            set { paypal_email = value; }
        }

    }
}
