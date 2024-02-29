using ResumeMgtBackend.Core.Enums;

namespace ResumeMgtBackend.Core.Entities
{
    public class Company: BaseEntity
    {
        public string Name { get; set; }
        public CompanySize Size { get; set; }

        //Relation
        public ICollection<Job> Jobs { get; set; }
    }
}
