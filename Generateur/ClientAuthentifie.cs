using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Generateur
{
    class ClientAuthentifie
    {
        [JsonProperty("Token")]
        public string TokenSession { get; set; }
        public string CodeClient { get; set; }
    }
}
