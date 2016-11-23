using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;
using NUnit.Framework.Constraints;

namespace ApiTests.Domain
{
    [XmlRoot(ElementName = "row")]
    public class StatusReportRowObject
    {
        [XmlIgnore]
        public int Id { get; set; }

        [XmlElement("transactionID")]
        public string TransactionId { get; set; }

        [XmlElement("status")]
        public string Status { get; set; }

        [XmlArray("errorMessages")]
        [XmlArrayItem("errorMessage")]
        public List<string> ErrorMessages = new List<string>();

        public override bool Equals(object obj)
        {
            var source = obj as StatusReportRowObject;
            if (source != null)
            {
                var first = source.ErrorMessages.Except(this.ErrorMessages);
                var second = this.ErrorMessages.Except(source.ErrorMessages);
                if (source.Status == this.Status && source.TransactionId == this.TransactionId &&
                    source.ErrorMessages.Count == this.ErrorMessages.Count && (!first.Any() && !second.Any()))
                {
                    return true;
                }
            }

            return false;
        }
    }

    [Serializable()]
    [XmlRoot(ElementName = "rows")]
    public class Rows
    {
        [XmlElement("row")]
        public List<StatusReportRowObject> RowCollection { get; set; }
    }

    [Serializable()]
    [XmlRoot(ElementName = "header")]
    public class Header
    {
        [XmlElement("fileID")]
        public string FileId { get; set; }

        [XmlElement("dateTime")]
        public string DateTime { get; set; }

        [XmlElement("rowCount")]
        public int RowCount { get; set; }
    }

    [Serializable()]
    [XmlInclude(typeof(StatusReportRowObject))]
    [XmlRoot(ElementName = "starChefResponse")]
    public class StarChefResponse
    {
        [XmlElement("header")]
        public Header Header { get; set; }

        [XmlElement("rows")]
        public Rows Rows { get; set; }
    }
}
