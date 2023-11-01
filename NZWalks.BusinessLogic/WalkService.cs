using NZWalks.Application.BusinessLogic;
using NZWalks.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NZWalks.BusinessLogic
{
    public class WalkService : IWalkService
    {
        public Task<WalkEntity> CreateAsync(WalkEntity walkEntity)
        {
            throw new NotImplementedException();
        }
    }
}
