namespace CommandApp.Entity{
    
    public class OrderItem : BaseEntity{
        public int Count { get; set; }
        public Order Order { get; set; }
        public Product Product { get; set; } 
    }
}