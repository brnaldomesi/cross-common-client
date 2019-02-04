using Snappy.Common.Client.Helpers;
using Snappy.Common.Client.Models.InputModels;
using Snappy.Common.Helpers;

namespace Snappy.Common.Client.Models.ViewModels
{
    public class IntegrationEditBaseModel : BaseModel
    {
        public string IntegrationUid { get; set; }
        public string IntegrationName { get; set; }
        public string Description { get; set; }

        public HiddenInputModel IntegrationUidInput { get; }
        public InputModel IntegrationNameInput { get; }
        public LongInputModel DescriptionInput { get; }

        public IntegrationEditBaseModel()
        {
            Title = Localizer.Localize("integration_edit_title");

            IntegrationUidInput = new HiddenInputModel("IntegrationUid","integration_uid");
            IntegrationNameInput = new InputModel("IntegrationName", "integration_name", true);
            DescriptionInput = new LongInputModel("Description", "description");
        }

        public override void SetInputModelValues()
        {
            IntegrationNameInput.Value = IntegrationName;
            DescriptionInput.Value = Description;
        }

        public override void SetInputErrorMessages()
        {
            if (IntegrationName.IsEmpty())
            {
                IntegrationNameInput.ErrorMessage.Add("integration_name_required_error_message");
                InputErrorMessages.AddRange(IntegrationNameInput.ErrorMessage);
            }
        }
    }
}