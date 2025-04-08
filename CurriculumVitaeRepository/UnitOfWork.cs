using CurriculumVitaeMiddleware.Contract.Repository;
using CurriculumVitaeMiddleware.Helpers.Constants;
using MongoDB.Driver;

namespace CurriculumVitaeRepository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IMongoDatabase database;
        private readonly string db = Environment.GetEnvironmentVariable(CommonConst.ConnectionString);

        public UnitOfWork()
        {
            MongoClient client = new(db);
            database = client.GetDatabase(CommonConst.DatabaseName);
        }
    }
}
