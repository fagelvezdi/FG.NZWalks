using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NZWalks.Domain.Common
{
    public abstract class BaseEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;

    }
}
