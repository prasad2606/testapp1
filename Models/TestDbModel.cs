using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace TestApplication.Models
{
    public partial class TestDbModel
    {
        public class XXIBM_PRODUCT_SKU
        {

            [Key]
            public string ITEM_NUMBER { get; set; }
            public string DESCRIPTION { get; set; }
            public string LONG_DESCRIPTION { get; set; }
            public string CATALOGUE_CATEGORY { get; set; }
            public string SKU_UNIT_OF_MEASURE { get; set; }
            public string STYLE_ITEM { get; set; }
            public string SKU_ATTRIBUTE1 { get; set; }
            public string SKU_ATTRIBUTE2 { get; set; }
            public string SKU_ATTRIBUTE3 { get; set; }
            public string SKU_ATTRIBUTE4 { get; set; }
            public string SKU_ATTRIBUTE5 { get; set; }
            public string SKU_ATTRIBUTE6 { get; set; }
            public string SKU_ATTRIBUTE_VALUE1 { get; set; }
            public string SKU_ATTRIBUTE_VALUE2 { get; set; }
            public string SKU_ATTRIBUTE_VALUE3 { get; set; }
            public string SKU_ATTRIBUTE_VALUE4 { get; set; }
            public string SKU_ATTRIBUTE_VALUE5 { get; set; }
            public string SKU_ATTRIBUTE_VALUE6 { get; set; }
        }
        public class XXIBM_PRODUCT_CATALOGUE
        {
            [Key]
            public string SEGMENT { get; set; }
            public string SEGMENT_NAME { get; set; }
            public string FAMILY { get; set; }
            public string FAMILY_NAME { get; set; }
            public string CLASS { get; set; }
            public string CLASS_NAME { get; set; }
            public string COMMODITY { get; set; }
            public string COMMODITY_NAME { get; set; }


        }

        public class XXIBM_PRODUCT_PRICING
        {
            [Key]
            public string PRICE_ID { get; set; }
            public string ITEM_NUMBER { get; set; }
            public string LIST_PRICE { get; set; }
            public string DISCOUNT { get; set; }
            public string IN_STOCK { get; set; }
            public string PRICE_EFFECTIVE_DATE { get; set; }


        }

        public class XXIBM_PRODUCT_STYLE
        {
            [Key]
            public string ITEM_NUMBER { get; set; }
            public string DESCRIPTION { get; set; }
            public string LONG_DESCRIPTION { get; set; }
            public string CATALOGUE_CATEGORY { get; set; }
            public string BRAND { get; set; }


        }

    }
}
