﻿using Exiled.API.Features;

namespace CokeAHP
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Exiled.Events;
    using Grenades;
    using Hints;
    using Mirror;
    using UnityEngine;
    using Exiled.Events.EventArgs;
    using static CokeAHP;


    public sealed class CokeEvents
    {
        internal void MedItemUsed(UsedMedicalItemEventArgs ev)
        {
            if (Instance.Config.IsEnabled)
            {
                switch (ev.Item)
                {
                    case ItemType.SCP207:
                        ev.Player.ArtificialHealth += (int)Instance.Config.Scp207AHP;
                        break;
                    case ItemType.SCP500:
                        ev.Player.ArtificialHealth += (int)Instance.Config.Scp500AHP;
                        break;
                    case ItemType.Adrenaline:
                        ev.Player.ArtificialHealth = (int)Instance.Config.AdrenalineAHP;
                        break;
                    case ItemType.Medkit:
                        ev.Player.ArtificialHealth += (int)Instance.Config.MedKitAHP;
                        break;
                    case ItemType.Painkillers:
                        ev.Player.ArtificialHealth += (int)Instance.Config.PainKillerAHP;
                        break;
                }
            }
        }
    }
}
