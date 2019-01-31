using System;

using Snappy.Common.Helpers;

namespace Snappy.Common.Client.Models.Requests.Membership
{
    public class IntegrationTokenBaseRequest : IntegrationBaseRequest
    {
        public string TokenUid { get; set; }

        public IntegrationTokenBaseRequest(string integrationUid, string tokenUid) : base(integrationUid)
        {
            if (tokenUid.IsNotUid())
            {
                throw new ArgumentException(nameof(tokenUid));
            }

            TokenUid = tokenUid;
        }
    }
}