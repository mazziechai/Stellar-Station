// SPDX-FileCopyrightText: 2025 AftrLite
// SPDX-FileCopyrightText: 2025 Janet Blackquill <uhhadd@gmail.com>
//
// SPDX-License-Identifier: LicenseRef-CosmicCult

namespace Content.Stellar.Server.CosmicCult;

/// <summary>
///     Associates an entity with a specific cosmic cult gamerule
/// </summary>
[RegisterComponent]
public sealed partial class CosmicCultAssociatedRuleComponent : Component
{
    /// <summary>
    ///     The gamerule that this entity is associated with
    /// </summary>
    [DataField]
    public EntityUid CultGamerule;
}
