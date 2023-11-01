using NZWalks.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NZWalks.Application.DataAccess
{
    public interface IImageRepository
    {
        Task<Image> Upload(Image image);
    }
}
