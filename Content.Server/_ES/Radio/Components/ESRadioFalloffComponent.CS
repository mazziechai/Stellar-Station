// SPDX-FileCopyrightText: 2025 Nemanja / EmoGarbage404
//
// SPDX-License-Identifier: MIT

using Content.Shared.Dataset;
using Robust.Shared.Prototypes;

namespace Content.Server._ES.Radio.Components;

[RegisterComponent]
[Access(typeof(ESRadioSystem))]
public sealed partial class ESRadioFalloffComponent : Component
{
    [DataField]
    public float MaxClearSendDistance = 37f;

    [DataField]
    public float MaxSendDistance = 94f;

    [DataField]
    public ProtoId<LocalizedDatasetPrototype> FalloffInterjectionDataset = "ESRadioFalloffInterjections";
}
