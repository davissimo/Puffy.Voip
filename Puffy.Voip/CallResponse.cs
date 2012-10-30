using System.Xml.Serialization;

namespace Puffy.Voip
{
    public class CallResponse
    {
        [XmlElement("version")]
        public string Version { get; set; }

        [XmlElement("result")]
        public string Result { get; set; }

        [XmlElement("callid")]
        public string CallId { get; set; }

        [XmlElement("resultstring")]
        public string ResultString { get; set; }

        [XmlElement("description")]
        public string Description { get; set; }

        [XmlElement("endcause")]
        public string EndCause { get; set; }
    }
}