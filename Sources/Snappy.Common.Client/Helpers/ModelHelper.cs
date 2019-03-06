using Snappy.Common.Client.Models.ViewModels;
using Snappy.Common.Models.Responses;

namespace Snappy.Common.Client.Helpers
{
    public static class ModelHelper
    {
        public static void MapMessages(this BaseModel model, BaseResponse response)
        {
            model.ErrorMessages = response.ErrorMessages;
            model.InfoMessages = response.InfoMessages;
            model.WarningMessages = response.WarningMessages;
            model.SuccessMessages = response.SuccessMessages;
        }
    }
}