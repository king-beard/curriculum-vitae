namespace CurriculumVitaeMiddleware.Dtos.Common.Request
{
    public record CurriculumVitaeReqDto
    {
        public string Id { get; set; }
        public string Version { get; set; }
        public string Language { get; set; }
        public HeaderCvReqDto Header { get; set; }
        public ContactCvReqDto Contact { get; set; }
        public AboutMeCvReqDto AboutMe { get; set; }
        public WorkExperienceCvReqDto WorkExperience { get; set; }
        public EducationCvReqDto Education { get; set; }
        public SkillsCvReqDto Skills { get; set; }
        public LanguagesCvReqDto Languages { get; set; }
    }

    public record HeaderCvReqDto
    {
        public string Name { get; set; }
        public string FathersLastName { get; set; }
        public string MothersLastName { get; set; }
        public string Occupation { get; set; }
    }

    public record ContactCvReqDto
    {
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
    }

    public record AboutMeCvReqDto
    {
        public string Description { get; set; }
    }

    public record WorkExperienceCvReqDto
    {
        public string WorkTitle { get; set; }
        public string Company { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int Currently { get; set; }
        public string City { get; set; }
        public string Description { get; set; }
    }

    public record EducationCvReqDto
    {
        public string DegreeTitle { get; set; }
        public string UniversityName { get; set; }
        public DateTime DateGraduation { get; set; }
        public string City { get; set; }
        public string Description { get; set; }
    }

    public record SkillsCvReqDto
    {
        public string Skill { get; set; }
    }

    public record LanguagesCvReqDto
    {
        public string Name { get; set; }
        public string Level { get; set; }
    }
}
