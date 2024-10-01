using Exiled.API.Features;
using Exiled.CustomItems.API.Features;
using Exiled.Loader;
using player = Exiled.Events.Handlers.Player;
using System.ComponentModel;

namespace test2
{
    public class Class1 : Plugin<Config>
    {
        public static Class1 Instance;
        public override void OnEnabled()
        {
            Instance = this;
            player.Verified += EventHandlers.Verified.OnVerified;
            base.OnEnabled();
        }
        public override void OnDisabled()
        {
            Instance = null;
            player.Verified -= EventHandlers.Verified.OnVerified;
            base.OnDisabled();
        }
    }
}
