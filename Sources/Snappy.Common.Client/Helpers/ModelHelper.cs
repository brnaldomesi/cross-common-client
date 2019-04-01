using Snappy.Common.Client.Models.ViewModels;
using Snappy.Common.Models.Responses;

namespace Snappy.Common.Client.Helpers
{
    public static class ModelHelper
    {
        public static void MapMessages(this BaseModel model, BaseResponse response)
        {
            model.ErrorMessages.AddRange(response.ErrorMessages);
            model.InfoMessages.AddRange(response.InfoMessages);
            model.WarningMessages.AddRange(response.WarningMessages);
            model.SuccessMessages.AddRange(response.SuccessMessages);

            model.SetInputModelValues();
        }
    }
}