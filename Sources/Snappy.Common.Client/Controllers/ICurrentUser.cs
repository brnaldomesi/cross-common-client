using Snappy.Common.Models.Shared;

namespace Snappy.Common.Client.Controllers
{
    public interface ICurrentUser
    {
        CurrentUser CurrentUser { get; }
    }
}