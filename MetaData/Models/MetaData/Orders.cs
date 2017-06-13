using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MetaData.Models
{
    [MetadataType(typeof(OrdersMetadata))]
    public partial class Orders
    {
        public class OrdersMetadata
        {
            [DisplayName("測試測試")]
            [Range(1, 4)]
            public Nullable<decimal> Freight { get; set; }
        }
    }
}