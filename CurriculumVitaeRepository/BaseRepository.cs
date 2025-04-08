using MongoDB.Driver;

namespace CurriculumVitaeRepository
{
    public class BaseRepository
    {
        protected readonly IMongoDatabase database;

        public BaseRepository(IMongoDatabase database)
        {
            this.database = database;
        }
    }
}
