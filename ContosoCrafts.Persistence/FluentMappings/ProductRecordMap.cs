using ContosoCrafts.Business.Models;
using ContosoCrafts.Persistence.Records;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace ContosoCrafts.Persistence.FluentMappings
{
    public class ProductRecordMap : ClassMap<ProductRecord>
    {
        public ProductRecordMap()
        {
            Table("product");
            //LazyLoad();
            Id(obj => obj.Id).GeneratedBy.Assigned().Column("id");
            Map(obj => obj.Name).Column("name");
        }
    }
}
