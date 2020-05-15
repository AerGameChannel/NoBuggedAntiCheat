using WW_SYSTEM;
using WW_SYSTEM.Attributes;

namespace NBAC
{
    [PluginDetails(
        author = "Aer",
        name = "NoBuggedAntiCheat",
        description = "NoBuggedAntiCheat",
        id = "nbac.plugin",
        configPrefix = "NoBuggedAntiCheat",
        version = "1.0",
        WWSYSTEMMajor = 6,
        WWSYSTEMMinor = 3,
        WWSYSTEMRevision = 1
        )]
    public class NoBuggedAC : Plugin
    {

        public override void OnDisable()
        {
            this.Info(this.Details.name + " was disabled");
        }
        public override void OnEnable()
        {
            var nbac_enable = this.Config.GetBool("nbac_enabled", true);
            if (!nbac_enable) return;
            this.Info(this.Details.name + " was enabled");
        }
        public override void Register()
        {
            var nbac_enable = this.Config.GetBool("nbac_enabled", true);
            if (!nbac_enable) return;
            AddEventHandlers(new NBAC(this));
        }
    }
}
