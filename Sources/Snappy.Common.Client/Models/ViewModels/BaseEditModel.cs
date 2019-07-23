using Snappy.Common.Client.Models.InputModels;
using Snappy.Common.Helpers;
using System.Collections.Generic;
using System.Linq;

namespace Snappy.Common.Client.Models.ViewModels
{
    public abstract class BaseEditModel : BaseModel
    {
        public InputModel NameInput { get; set; }

        public List<string> ErrorMessages { get; set; }
        public List<string> SuccessMessages { get; set; }
        public List<string> WarningMessages { get; set; }
        public List<string> InputErrorMessages { get; set; }
        public List<string> InfoMessages { get; set; }

        public BaseEditModel()
        {
            ClearMessages();
            NameInput = new InputModel("Name", "name", true);
        }

        public override void SetInputModelValues()
        {
            NameInput.Value = Name;
        }

        public virtual void SetInputErrorMessages()
        {
            Name = Name.TrimOrDefault();
            if (Name.IsEmpty())
            {
                NameInput.ErrorMessage.Add("name_required_error_message");
                InputErrorMessages.AddRange(NameInput.ErrorMessage);
            }
        }

        public bool IsValid()
        {
            ClearMessages();

            SetInputErrorMessages();
            InputErrorMessages = InputErrorMessages.Distinct().ToList();

            if (InputErrorMessages.Count > 0
                || ErrorMessages.Count > 0)
            {
                SetInputModelValues();
            }

            return InputErrorMessages.Count == 0
                   && ErrorMessages.Count == 0;
        }

        private void ClearMessages()
        {
            InputErrorMessages = new List<string>();
            SuccessMessages = new List<string>();
            WarningMessages = new List<string>();
            ErrorMessages = new List<string>();
            InfoMessages = new List<string>();
        }

        public bool IsNotValid()
        {
            return !IsValid();
        }
    }
}