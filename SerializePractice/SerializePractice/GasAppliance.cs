
using System.Text.Json.Serialization;

namespace SerializePractice
{
    public class GasAppliance
    {
        private Manufacturer _man;

        public Manufacturer Manufacturer
        {
            get
            {
                return _man;
            }
            set
            {
                if (value == null) throw new ArgumentNullException("null manufacture");
                _man = value;
            }
        }

        [JsonConverter(typeof(JsonStringEnumConverter))]
        public ApplianceType ApplianceType { get; set; }

        public GasAppliance() { }

        public GasAppliance(Manufacturer man, ApplianceType applianceTypes)
        {
            Manufacturer = man;
            ApplianceType = applianceTypes;
        }
    }
}
