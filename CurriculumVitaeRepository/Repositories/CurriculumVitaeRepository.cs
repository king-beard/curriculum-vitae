using CurriculumVitaeMiddleware.Contract.Repository;
using CurriculumVitaeMiddleware.Dtos.Collection;
using CurriculumVitaeMiddleware.Helpers.CustomAttribute;
using MongoDB.Driver;

namespace CurriculumVitaeRepository.Repositories
{
    public class CurriculumVitaeRepository(IMongoDatabase database) : BaseRepository(database), ICurriculumVitaeRepository
    {
        private readonly IMongoCollection<CurriculumVitae> collection = database.GetCollection<CurriculumVitae>(CollectionCustom.GetCollectionName<CurriculumVitae>());

        public void Add(CurriculumVitae curriculumVitae) => collection.InsertOneAsync(curriculumVitae);
    }
}
