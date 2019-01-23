namespace Snappy.Common.Client.Models.Requests
{
    public sealed class JournalRequest : BaseAuthenticatedRequest
    {
        public JournalRequest(int currentUserId) : base(currentUserId)
        {
        }
    }
}