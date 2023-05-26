using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payments.Domain.Entity.Base
{
    public abstract class BaseEntity
    {
        public Guid Id { get; private set; }
        public DateTime CreateDate { get; set; }
        protected BaseEntity()
        {
            Id = Guid.NewGuid();
            CreateDate = DateTime.Now;
        }
    }
}
