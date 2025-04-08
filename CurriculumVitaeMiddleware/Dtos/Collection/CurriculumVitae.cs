using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using CurriculumVitaeMiddleware.Helpers.CustomAttribute;

namespace CurriculumVitaeMiddleware.Dtos.Collection
{
    [BsonCollection("cv_version")]
    public class CurriculumVitae : Audit
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Version { get; set; }
        public string Language { get; set; }
        [BsonElement("header_cv")]
        public HeaderCv Header { get; set; }
        [BsonElement("contact_cv")]
        public ContactCv Contact { get; set; }
        [BsonElement("about_me_cv")]
        public AboutMeCv AboutMe { get; set; }
        [BsonElement("work_experience_cv")]
        public WorkExperienceCv WorkExperience { get; set; }
        [BsonElement("education_cv")]
        public EducationCv Education { get; set; }
        [BsonElement("skills_cv")]
        public SkillsCv Skills { get; set; }
        [BsonElement("languages_cv")]
        public LanguagesCv Languages { get; set; }
    }

    public class HeaderCv : Audit
    {
        public string Name { get; set; }
        [BsonElement("fathers_last_name")]
        public string FathersLastName { get; set; }
        [BsonElement("mothers_last_name")]
        public string MothersLastName { get; set; }
        public string Occupation { get; set; }
    }

    public class ContactCv : Audit
    {
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        [BsonElement("postal_code")]
        public string PostalCode { get; set; }
        public string City { get; set; }
    }

    public class AboutMeCv : Audit
    {
        public string Description { get; set; }
    }

    public class WorkExperienceCv : Audit
    {
        [BsonElement("work_title")]
        public string WorkTitle { get; set; }
        public string Company { get; set; }
        [BsonElement("start_date")]
        public DateTime StartDate { get; set; }
        [BsonElement("end_date")]
        public DateTime EndDate { get; set; }
        public int Currently { get; set; }
        public string City { get; set; }
        public string Description { get; set; }
    }

    public class EducationCv : Audit
    {
        [BsonElement("degree_title")]
        public string DegreeTitle { get; set; }
        public string UniversityName { get; set; }
        public DateTime DateGraduation { get; set; }
        public string City { get; set; }
        public string Description { get; set; }
    }

    public class SkillsCv : Audit
    {
        public string Skill { get; set; }
    }

    public class LanguagesCv : Audit
    {
        public string Name { get; set; }
        public string Level { get; set; }
    }
}
