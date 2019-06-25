using System;

using Snappy.Common.Models.DataTransferObjects;

namespace Snappy.Common.Client.Models.ViewModels
{
    public abstract class BaseDetailModel : BaseModel
    {
        public string CreatedByName { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }

        public string UpdatedByName { get; set; }
        public Guid? UpdatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public void MapCreatedAndUpdatedInfo(BaseDto dto)
        {
            CreatedBy = dto.CreatedBy;
            CreatedByName = dto.CreatedByName;
            CreatedAt = dto.CreatedAt;
            UpdatedBy = dto.UpdatedBy;
            UpdatedByName = dto.UpdatedByName;
            UpdatedAt = dto.UpdatedAt;
        }
    }
}