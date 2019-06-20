using System;
using System.Collections.Generic;
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
        public List<string> InfoMessages { get; set; }

        public string CreatedByName { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }

        public string UpdatedByName { get; set; }
        public Guid? UpdatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }

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
            InfoMessages = new List<string>();
            InputErrorMessages = new List<string>();
        }

        public bool IsNotValid()
        {
            return !IsValid();
        }
    }
}