namespace CokeAHP
{
    using Exiled.API.Enums;
    using Exiled.API.Features;
    using HarmonyLib;
    using System;

    public sealed class CokeAHP : Plugin<Config>
    {

        public override string Author { get; } = "Parkeymon";
        public override string Name { get; } = "ItemAHP";
        public override string Prefix { get; } = "ItemAHP";
        public override Version Version { get; } = new Version(1, 2, 0);
        public override Version RequiredExiledVersion { get; } = new Version(2, 1, 8, 0);




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
