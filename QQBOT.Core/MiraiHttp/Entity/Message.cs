﻿using System.Linq;

#nullable enable
namespace QQBOT.Core.MiraiHttp.Entity
{
    public class Message
    {
        public GroupInfo? GroupInfo;
        public MessageSenderInfo? Sender;

        public MessageChain? MessageChain;
        
        public Message() {}

        public Message(MessageChain chain)
        {
            MessageChain = chain;
        }

        public SourceMessage Source =>
            (MessageChain!.Messages.FirstOrDefault(m => m.Type == MessageType.Source) as SourceMessage)!;
    }
}