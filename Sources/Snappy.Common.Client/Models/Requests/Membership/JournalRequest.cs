namespace Snappy.Common.Client.Models.Requests.Membership
{
    public class JournalRequest : BaseAuthenticatedRequest
    {
        public JournalRequest(int currentUserId) : base(currentUserId)
        {
        }
    }
}