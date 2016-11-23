using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiTests.Domain
{
    public class Group
    {
        public string GroupCode { get; set; }

        public string GroupName { get; set; }

        public string SalesTaxName { get; set; }

        public string ParentGroupCode { get; set; }

        public string GroupCurrencyCode { get; set; }

        public string CompareStatus { get; set; }

        public string TopMostGroupCode { get; set; }

        public int Id { get; set; }

        public int GroupId { get; set; }

        public Guid GroupGuid { get; set; }
    }
}
