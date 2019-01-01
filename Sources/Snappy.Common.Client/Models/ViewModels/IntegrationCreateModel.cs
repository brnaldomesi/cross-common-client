using Snappy.Common.Client.Helpers;
using Snappy.Common.Client.Models.InputModels;
using Snappy.Common.Helpers;

namespace Snappy.Common.Client.Models.ViewModels
{
    class IntegrationCreateModel : BaseModel
    {
        public string IntegrationName { get; set; }
        public string Description { get; set; }

        public LongInputModel IntegrationNameInput { get; }
        public TextareaInputModel DescriptionInput { get; }

        public IntegrationCreateModel()
        {
            Title = Localizer.Localize("integration_create_title");

            IntegrationNameInput = new LongInputModel("IntegrationName", "integration_name", true);
            DescriptionInput = new TextareaInputModel("Description", "description", false);
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