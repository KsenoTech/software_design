using System.Data.Entity;

namespace DAL.DbContexts
{

    public class DbInitializer : CreateDatabaseIfNotExists<ShopContext>
    {
        protected override void Seed(ShopContext context)
        {
            context.Types.AddRange(InitialData.TypeList);

            base.Seed(context);
        }
    }
}
