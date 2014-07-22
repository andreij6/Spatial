using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace Spatial.Web.Hubs
{
    public class SpatialHub : Hub
    {
        public void Send(string message)
        {
            Clients.All.newMessage(
                    Context.User.Identity.Name + " says " + message
                );
        }

        //https://github.com/DamianEdwards/SignalR-MoveShapeDemo/tree/master/MoveShape
    }
}