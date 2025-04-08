namespace CurriculumVitaeMiddleware.Dtos.Collection
{
    public class Audit
    {
        public string UserCreationId { get; set; }
        public DateTime CreationDate { get; set; }
        public string UserLastModifiedId { get; set; }
        public DateTime DateLastModificationId { get; set; }
        public int IsActive { get; set; }
    }
}
