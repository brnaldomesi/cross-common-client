using System;
using System.Collections.Generic;

namespace Snappy.Common.Client.Models.Contracts
{
    public interface IUidListModel
    {
        List<Guid> Uids { get; set; }
    }
}