using ResumeMgtBackend.Core.Enums;

namespace ResumeMgtBackend.Core.Dtos.Company
{
    public class CompanyCreateDto
    {
        public string Name { get; set; }
        public CompanySize Size { get; set; }
    }
}
