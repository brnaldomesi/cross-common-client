namespace Snappy.Common.Client.Models.Requests.Admin
{
    public sealed class JournalRequest : BaseAuthenticatedRequest
    {
        public JournalRequest(int currentUserId) : base(currentUserId)
        {
        }
    }
}