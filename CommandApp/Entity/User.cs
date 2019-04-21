using System;
using CommandApp.Enum;

namespace CommandApp.Entity{
    
    public class User : BaseEntity{
        public string Name { get; protected set; }
        public string Surname { get; protected set; }
        public string Patronymic { get; protected set; }
        public Gender Gender { get; protected set; }
        public long Balance { get; protected set; }

        public User(){
            Balance = 0l;
        }

        public void SetName(string name, string surname, string patronymic){
            Name = name;
            Surname = surname;
            Patronymic = patronymic;
        }

        public void IncreaseBalance(long money){
            Balance += money;
        }

        public void DecreaseBalance(long money){
            if (Balance - money > 0){
                Balance -= money;
            }else{
                throw new Exception("not enough money");
            }
        }

        public void SetGender(Gender gender){
            Gender = gender;
        }

    }
}