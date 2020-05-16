using WW_SYSTEM;
using WW_SYSTEM.EventHandlers;
using WW_SYSTEM.Events;

namespace NBAC
{
    public class NBAC : IEventHandlerPlayerHurt
    {
        public Plugin plugin;
        
        public NBAC(Plugin plugin)
        {
            this.plugin = plugin;
        }
        
        public void OnPlayerHurt(PlayerHurtEvent ev)
        {
            if (ev.DamageType == DamageTypes.Flying)
            {
                ev.Damage = 0;
            }
        }
    }
}
