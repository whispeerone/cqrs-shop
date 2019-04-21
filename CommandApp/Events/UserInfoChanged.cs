using System;
using CommandApp.Commands.ChangeInfo;

namespace CommandApp.Events {
    public class UserInfoChanged : ChangeInfoCommand, IEvent {
        public int User { get; set; }
        public DateTime Updated { get; set; }
    }
}