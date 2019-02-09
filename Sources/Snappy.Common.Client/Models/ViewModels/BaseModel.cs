using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace Snappy.Common.Client.Models.ViewModels
{
    public abstract class BaseModel
    {
        public string Title { get; set; }
        public List<string> ErrorMessages { get; set; }
        public List<string> SuccessMessages { get; set; }
        public List<string> WarningMessages { get; set; }
        public List<string> InputErrorMessages { get; set; }

        protected BaseModel()
        {
            ClearMessages();
        }

        public virtual void SetInputModelValues()
        {

        }

        public virtual void SetInputErrorMessages()
        {

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
            ErrorMessages = new List<string>();
            SuccessMessages = new List<string>();
            WarningMessages = new List<string>();
            InputErrorMessages = new List<string>();
        }

        public bool IsNotValid()
        {
            return !IsValid();
        }
    }
}