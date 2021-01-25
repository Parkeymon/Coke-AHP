namespace CokeAHP
{
    using Exiled.API.Enums;
    using Exiled.API.Features;
    using HarmonyLib;

    public sealed class CokeAHP : Plugin<config>
    {
        public override string Prefix => "ItemAHP";
        public override string Name => "ItemAHP";
        public override string Author => "Parkeymon";


        private static readonly Harmony HarmonyInstance = new Harmony(nameof(CokeAHP).ToLowerInvariant());
        internal static CokeAHP Instance;
        private readonly CokeEvents _handler = new CokeEvents();
        public override PluginPriority Priority { get; } = PluginPriority.Medium;

        public override void OnEnabled()
        {
            Instance = this;
            HarmonyInstance.PatchAll();

            Exiled.Events.Handlers.Player.MedicalItemUsed += _handler.MedItemUsed;
        }
        public override void OnDisabled()
        {
            HarmonyInstance.UnpatchAll();
            Instance = null;

            Exiled.Events.Handlers.Player.MedicalItemUsed += _handler.MedItemUsed;
        }
    }
}
