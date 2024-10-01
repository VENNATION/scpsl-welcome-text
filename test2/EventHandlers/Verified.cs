using Exiled.Events.EventArgs.Player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test2.EventHandlers
{
    public static class Verified
    {
        public static void OnVerified(VerifiedEventArgs ev)
        {
            ev.Player.ShowHint("Astro greets you", 8);
        }
    }
}
