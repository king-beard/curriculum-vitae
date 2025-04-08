namespace CurriculumVitaeMiddleware.Helpers.CustomAttribute
{
    public class CollectionCustom
    {
        public static string GetCollectionName<T>()
        {
            return (typeof(T).GetCustomAttributes(typeof(BsonCollectionAttribute), true).FirstOrDefault()
                as BsonCollectionAttribute).CollectionName;
        }
    }
}
