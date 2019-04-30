using System;
using System.Collections.Generic;

namespace Snappy.Common.Client.Models.Contracts
{
    /// <summary>
    /// Inspired from proto-buff protocol
    /// </summary>
    public interface ISnappyModel
    {
        Type Type { get; set; }
        List<string> Headers { get; set; }
        List<object> Values { get; set; }
    }
}