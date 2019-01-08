using System;
using Snappy.Common.Client.Helpers;

namespace Snappy.Common.Client.Models.ViewModels
{
    public class JournalModel : BaseModel
    {
        public string UserUId { get; set; }
        public string UserName { get; set; }
        public string AccessToken { get; set; }
        public string Message { get; set; }
        public DateTime CreatedAt { get; set; }

        public JournalModel()
        {
            Title = Localizer.Localize("journal_tittle");
        }
    }
}