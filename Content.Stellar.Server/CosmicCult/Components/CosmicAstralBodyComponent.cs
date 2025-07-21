// SPDX-FileCopyrightText: 2025 AftrLite
// SPDX-FileCopyrightText: 2025 Janet Blackquill <uhhadd@gmail.com>
//
// SPDX-License-Identifier: LicenseRef-CosmicCult

using Content.Stellar.Server.CosmicCult.Abilities;

namespace Content.Stellar.Server.CosmicCult.Components;

[RegisterComponent, Access(typeof(CosmicReturnSystem))]
public sealed partial class CosmicAstralBodyComponent : Component
{
    [DataField]
    public EntityUid OriginalBody;
}
