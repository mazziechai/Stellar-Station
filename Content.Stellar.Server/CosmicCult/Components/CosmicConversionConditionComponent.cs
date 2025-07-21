// SPDX-FileCopyrightText: 2025 AftrLite
// SPDX-FileCopyrightText: 2025 Janet Blackquill <uhhadd@gmail.com>
//
// SPDX-License-Identifier: LicenseRef-CosmicCult

namespace Content.Server.Objectives.Components;

[RegisterComponent]
public sealed partial class CosmicConversionConditionComponent : Component
{
    /// <summary>
    ///     The amount of cultists this objective would like to be converted
    /// </summary>
    [DataField]
    public int Converted;
}
