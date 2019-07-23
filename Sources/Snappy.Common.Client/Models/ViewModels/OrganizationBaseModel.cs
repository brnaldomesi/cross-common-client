using System;

using Snappy.Common.Client.Models.InputModels;
using Snappy.Common.Helpers;

namespace Snappy.Common.Client.Models.ViewModels
{
    public class OrganizationBaseModel : BaseEditModel
    {
        public Guid OrganizationUid { get; set; }

        public HiddenInputModel OrganizationUidInput { get; set; }

        public OrganizationBaseModel()
        {
            OrganizationUidInput = new HiddenInputModel("OrganizationUid");
        }

        public override void SetInputModelValues()
        {
            base.SetInputModelValues();

            OrganizationUidInput.Value = OrganizationUid.ToUidString();
        }

        public override void SetInputErrorMessages()
        {
            base.SetInputErrorMessages();

            if (OrganizationUid.IsEmptyGuid())
            {
                ErrorMessages.Add("organization_uid_is_not_valid");
            }
        }
    }
}