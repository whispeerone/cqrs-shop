namespace CommandApp.Entity{
    
    public class Product : BaseEntity{
        public string Title { get; set; }
        public string Description { get; set; }
        public int Count { get; set; }
        public long Price { get; set; }
        public Image Image { get; set; }
    }
}