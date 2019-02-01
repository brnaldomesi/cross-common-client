﻿using System;

using Snappy.Common.Client.Models.Requests.Membership.Organization.Base;
using Snappy.Common.Helpers;

namespace Snappy.Common.Client.Models.Requests.Membership.Organization
{
    public class OrganizationEditRequest : OrganizationBaseRequest
    {
        public string OrganizationName { get; }
        public string Description { get; }

        public OrganizationEditRequest(string organizationUid, string organizationName, string description) : base(organizationUid)
        {
            if (organizationName.IsEmpty())
            {
                throw new ArgumentException(nameof(organizationName));
            }

            OrganizationName = organizationName;
            Description = description;
        }
    }
}