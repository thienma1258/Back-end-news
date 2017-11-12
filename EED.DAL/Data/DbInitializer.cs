using EED.DAL.Context;

namespace EED.DAL.Data
{
    public static class DbInitializer
    {
        public static void Initialize(EEDSqlContext context)
        {
            context.Database.EnsureCreated();
        }
    }
}
