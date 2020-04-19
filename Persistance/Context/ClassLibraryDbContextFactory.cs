using Microsoft.EntityFrameworkCore;
using Persistance.Infrastructure;

namespace Persistance.Context
{
    public class ClassLibraryDbContextFactory : DesignTimeDbContextFactoryBase<ClassLibraryDbContext>
    {
        protected override ClassLibraryDbContext CreateNewInstance(DbContextOptions<ClassLibraryDbContext> options)
        {
            return new ClassLibraryDbContext(options);
        }
    }
}
