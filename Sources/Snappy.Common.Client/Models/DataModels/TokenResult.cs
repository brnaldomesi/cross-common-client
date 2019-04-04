using System;

namespace Snappy.Common.Client.Models.DataModels
{
    public class TokenResult
    {
        public Guid Token { get; set; }
        public string CreatedAt { get; set; }
        public string ExpiresAt { get; set; }
    }
}