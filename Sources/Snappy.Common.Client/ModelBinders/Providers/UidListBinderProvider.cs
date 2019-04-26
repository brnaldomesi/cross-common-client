using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;

using Snappy.Common.Client.Models.Contracts;

namespace Snappy.Common.Client.ModelBinders.Providers
{
    public class UidListBinderProvider : IModelBinderProvider
    {
        public IModelBinder GetBinder(ModelBinderProviderContext context)
        {
            if (context.Metadata.ModelType.GetInterface(nameof(IUidListModel)) != null)
            {
                return new BinderTypeModelBinder(typeof(UidListBinder));
            }

            return null;
        }
    }
}