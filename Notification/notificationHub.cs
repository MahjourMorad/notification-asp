﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace Notification
{
    public class notificationHub : Hub
    {
        public void Hello()
        {
            Clients.All.hello();
        }
    }
}