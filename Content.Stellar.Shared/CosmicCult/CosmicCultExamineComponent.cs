// SPDX-FileCopyrightText: 2025 AftrLite
// SPDX-FileCopyrightText: 2025 Janet Blackquill <uhhadd@gmail.com>
//
// SPDX-License-Identifier: LicenseRef-CosmicCult

namespace Content.Stellar.Shared.CosmicCult;

/// <summary>
///     Event dispatched from shared into server code where something creates another thing that should be associated with the gamerule
/// </summary>
[RegisterComponent]
public sealed partial class CosmicCultExamineComponent : Component
{
    [DataField(required: true)]
    public LocId CultistText;

    [DataField]
    public LocId OthersText = "cosmic-examine-text-structures";
}
