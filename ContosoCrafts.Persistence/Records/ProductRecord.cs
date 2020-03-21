using System;
using System.Collections.Generic;
using System.Text;

namespace ContosoCrafts.Persistence.Records
{
    public class ProductRecord
    {
        public ProductRecord() { }
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
    }
}
