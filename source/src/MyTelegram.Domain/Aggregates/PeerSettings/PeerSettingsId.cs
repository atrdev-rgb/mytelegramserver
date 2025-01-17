﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTelegram.Domain.Aggregates.PeerSettings;

[JsonConverter(typeof(SystemTextJsonSingleValueObjectConverter<PeerSettingsId>))]
public class PeerSettingsId(string value) : Identity<PeerSettingsId>(value)
{
    public static PeerSettingsId Create(long userId, long targetPeerId)
    {
        return NewDeterministic(GuidFactories.Deterministic.Namespaces.Commands, $"peersettings-{userId}-{targetPeerId}");
    }
}