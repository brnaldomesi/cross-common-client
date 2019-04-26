using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ModelBinding;

using Snappy.Common.Client.Models.Contracts;
using Snappy.Common.Helpers;

namespace Snappy.Common.Client.ModelBinders
{
    public class UidListBinder : IModelBinder
    {
        public Task BindModelAsync(ModelBindingContext bindingContext)
        {
            const string uidFieldName = nameof(IUidListModel.Uids);
            if (!bindingContext.HttpContext.Request.Form.ContainsKey(uidFieldName))
            {
                return Task.CompletedTask;
            }

            var uidStrings = bindingContext.HttpContext.Request.Form[uidFieldName][0];
            if (uidStrings.IsEmpty())
            {
                return Task.CompletedTask;
            }

            var model = (IUidListModel)Activator.CreateInstance(bindingContext.ModelType);
            bindingContext.Model = model;

            var items = uidStrings.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            for (var i = 0; i < items.Length; i++)
            {
                var item = items[i];
                if (item.IsNotUid())
                {
                    continue;
                }

                model.Uids.Add(new Guid(item));
            }

            bindingContext.Result = ModelBindingResult.Success(bindingContext.Model);
            return Task.FromResult(model);
        }
    }
}