﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MudDesigner.MudEngine.Networking
{
    public class ClientMessageReceived : MessageBase<ClientData>
    {
        public ClientMessageReceived(ClientData data)
        {
            this.Content = data;
        }
    }
}
