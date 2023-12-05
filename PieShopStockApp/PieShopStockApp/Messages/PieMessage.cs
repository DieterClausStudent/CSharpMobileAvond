using CommunityToolkit.Mvvm.Messaging.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PieShopStockApp.Messages
{

    public class PieMessage : ValueChangedMessage<string>
    {
        public PieMessage(string value) : base(value)
        {
        }
    }
}
