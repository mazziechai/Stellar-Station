// SPDX-FileCopyrightText: 2025 AftrLite
// SPDX-FileCopyrightText: 2025 Janet Blackquill <uhhadd@gmail.com>
//
// SPDX-License-Identifier: LicenseRef-CosmicCult

using Robust.Shared.Prototypes;

namespace Content.Stellar.Shared.CosmicCult.Components;

/// <summary>
/// Indicates that an entity will be converted to the given prototype when corrupted by the Cosmic Cult
/// </summary>
[RegisterComponent]
public sealed partial class CosmicCorruptibleComponent : Component
{
    [DataField(required: true)]
    public EntProtoId ConvertTo;
}
