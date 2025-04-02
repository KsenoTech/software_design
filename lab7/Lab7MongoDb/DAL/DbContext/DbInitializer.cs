using System.Data.Entity;

namespace DAL.DbContexts
{

    public class DbInitializer : CreateDatabaseIfNotExists<PhonesContext>
    {
        protected override void Seed(PhonesContext context)
        {
            context.Manufacturers.AddRange(InitialData.ManufacturerList);

            base.Seed(context);
        }
    }
}
