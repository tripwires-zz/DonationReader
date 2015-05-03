using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tripwires.DonationReader.Lib.Data
{
    class DonationList:List<Donation>
    {
        private List<Donation> donations;
        [JsonProperty("donations")]
        public List<Donation> Donations
        {
            get { return donations; }
            set { donations = value; }
        }
        private bool api_check;
        [JsonProperty("api_check")]
        public bool Api_check
        {
            get { return api_check; }
            set { api_check = value; }
        }
    }
}
