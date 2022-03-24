using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract
{
    class EmailSender : MessageSender
    {
        public override string SendMessage()
        {
            return $"Masage sent via Email";
        }
    }
}
