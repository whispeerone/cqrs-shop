using System;

namespace CommandApp.Commands{
    public abstract class CommandWrapper<T>{
        
        public Guid Id { get; } = Guid.NewGuid();
        public DateTime Created { get; } = DateTime.Now;
        public T Command { get; set; }
    }
}