using System;

namespace CommandApp.Entity
{
    public class BaseEntity
    {
        public int Id { get; protected set; }

        public DateTime Created { get; protected set; }

        protected BaseEntity()
        {
            Created = DateTime.Now;
        }
    }
}