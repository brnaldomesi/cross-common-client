using Snappy.Common.Client.Helpers;
using Snappy.Common.Client.Models.InputModels;
using Snappy.Common.Helpers;

namespace Snappy.Common.Client.Models.ViewModels
{
    public sealed class IntegrationCreateModel : BaseModel
    {
        public string IntegrationName { get; set; }
        public string Description { get; set; }

        public InputModel IntegrationNameInput { get; }
        public LongInputModel DescriptionInput { get; }

        public IntegrationCreateModel()
        {
            Title = Localizer.Localize("integration_create_title");

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