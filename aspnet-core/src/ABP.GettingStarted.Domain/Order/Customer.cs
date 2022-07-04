using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Values;

namespace ABP.GettingStarted.Order
{
    public class Customer: ValueObject
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return ID;
            yield return Name;
            yield return Address;
        }
    }
}
