using System;

namespace Dond.Models
{
    public class BaseEntity
    {
        private DondDBContext context;

        public int Id { get; set; }
        public DateTimeOffset CreateDate { get; set; }
        public Guid Guid { get; set; }
        public bool IsActive { get; set; }

        public BaseEntity()
        {
            CreateDate = DateTimeOffset.UtcNow;
            Guid = new Guid();
            IsActive = true;
        }

        public BaseEntity(DondDBContext context)
        {
            this.context = context;
        }
    }
}
