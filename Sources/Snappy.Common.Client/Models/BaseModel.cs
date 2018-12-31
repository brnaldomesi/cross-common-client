using System.Collections.Generic;

namespace Snappy.Common.Client.Models
{
    public abstract class BaseModel
    {
        public string Title { get; set; }
        public List<string> ErrorMessages { get; set; }
        public List<string> InputErrorMessages { get; set; }

        protected BaseModel()
        {
            ErrorMessages = new List<string>();
            InputErrorMessages = new List<string>();
        }

        public virtual void SetInputModelValues()
        {

        }

        public virtual void SetInputErrorMessages()
        {

        }

        public bool IsValid()
        {
            SetInputErrorMessages();

            if (InputErrorMessages.Count > 0
                || ErrorMessages.Count > 0)
            {
                SetInputModelValues();
            }

            return InputErrorMessages.Count == 0
                   && ErrorMessages.Count == 0;
        }

        public bool IsNotValid()
        {
            return !IsValid();
        }
    }
}