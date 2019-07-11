using MyABP.EntityFramework;
using EntityFramework.DynamicFilters;

namespace MyABP.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private readonly MyABPDbContext _context;

        public InitialHostDbBuilder(MyABPDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            _context.DisableAllFilters();

            new DefaultEditionsCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();
        }
    }
}
