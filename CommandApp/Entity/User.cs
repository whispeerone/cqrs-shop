using CommandApp.Enum;

namespace CommandApp.Entity{
    
    public class User : BaseEntity{
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public Gender Gender { get; set; }
        public long Balance { get; set; }
    }
}