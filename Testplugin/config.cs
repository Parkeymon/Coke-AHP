using Exiled.API.Interfaces;
using System.ComponentModel;

namespace CokeAHP
{
    public sealed class Config : IConfig
    {
        [Description("Is the plugin enabled?")]
        public bool IsEnabled { get; set; } = true;
        [Description("How much AHP should these items give when used.")]
        public float Scp207AHP { get; set; } = 40;
        public float Scp500AHP { get; set; } = 50;
        public float AdrenalineAHP { get; set; } = 30;
        public float MedKitAHP { get; set; } = 10;
        public float PainKillerAHP { get; set; } = 10;
    }
}
