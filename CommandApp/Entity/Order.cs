using System.Collections.Generic;

namespace CommandApp.Entity{
    
    public class Order : BaseEntity{
        public User Owner { get; set; }
        public List<OrderItem> Items { get; set; }
        public int Status { get; set; }
    }
}