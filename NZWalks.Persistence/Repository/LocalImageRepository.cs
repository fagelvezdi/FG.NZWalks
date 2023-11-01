using NZWalks.Application.DataAccess;
using NZWalks.Domain;
using Microsoft.AspNetCore;
using NZWalks.Persistence.DatabaseContext;

namespace NZWalks.Persistence.Repository
{
    public class LocalImageRepository : IImageRepository
    {
        private readonly NZWalksDbContext dbContext;

        public LocalImageRepository(NZWalksDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<Image> Upload(Image image)
        {
            await dbContext.Images.AddAsync(image);

            await dbContext.SaveChangesAsync();

            return image;
        }
    }
}
