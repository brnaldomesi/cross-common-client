using System;

using Snappy.Common.Models.Requests;

namespace Snappy.Common.Client.Models.Requests
{
    public abstract class BaseAuthenticatedRequest : BaseRequest
    {
        public string OrganizationUid { get; set; }
        public int CurrentUserId { get; set; }

        protected BaseAuthenticatedRequest(int currentUserId)
        {
            if (currentUserId < 1)
            {
                throw new ArgumentException(nameof(currentUserId));
            }

            CurrentUserId = currentUserId;
        }
    }
}