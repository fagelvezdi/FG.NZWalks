using NZWalks.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NZWalks.Application.BusinessLogic
{
    public interface IWalkService
    {
        Task<WalkEntity> CreateAsync(WalkEntity walkEntity);
    }
}
