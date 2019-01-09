namespace Snappy.Common.Client.Models.Requests
{
    public sealed class UserDetailRequest : BaseAuthenticatedRequest
    {
        public  UserDetailRequest(int currentUserId) : base(currentUserId)
        {
        }
    }
}