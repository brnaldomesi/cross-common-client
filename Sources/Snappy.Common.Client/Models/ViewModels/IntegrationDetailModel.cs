namespace Snappy.Common.Client.Models.ViewModels
{
    public class IntegrationDetailModel : BaseModel
    {
        public object IntegrationUid { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string OrganizationUid { get; set; }
        public string OrganizationName { get; set; }
    }
}