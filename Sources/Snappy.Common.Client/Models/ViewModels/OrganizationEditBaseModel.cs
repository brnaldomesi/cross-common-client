using Snappy.Common.Client.Helpers;
using Snappy.Common.Client.Models.InputModels;
using Snappy.Common.Helpers;

namespace Snappy.Common.Client.Models.ViewModels
{
    public class OrganizationEditBaseModel : BaseModel
    {
        public string OrganizationName { get; set; }
        public string Description { get; set; }

        public InputModel OrganizationNameInput { get; }
        public LongInputModel DescriptionInput { get; }

        public OrganizationEditBaseModel()
        {
            Title = Localizer.Localize("organization_edit_title");

            OrganizationNameInput = new InputModel("OrganizationName", "organization_name", true);
            DescriptionInput = new LongInputModel("Description", "description");
        }

        public override void SetInputModelValues()
        {
            OrganizationNameInput.Value = OrganizationName;
            DescriptionInput.Value = Description;
        }

        public override void SetInputErrorMessages()
        {
            if (OrganizationName.IsEmpty())
            {
                OrganizationNameInput.ErrorMessage.Add("organization_name_required_error_message");
                InputErrorMessages.AddRange(OrganizationNameInput.ErrorMessage);
            }
        }
    }
}