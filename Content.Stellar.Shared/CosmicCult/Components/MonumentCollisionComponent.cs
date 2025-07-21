// SPDX-FileCopyrightText: 2025 AftrLite
// SPDX-FileCopyrightText: 2025 Janet Blackquill <uhhadd@gmail.com>
//
// SPDX-License-Identifier: LicenseRef-CosmicCult

using Robust.Shared.GameStates;

namespace Content.Stellar.Shared.CosmicCult.Components;

/// <summary>
/// Component for handling The Monument's collision.
/// </summary>
[RegisterComponent, NetworkedComponent]
[AutoGenerateComponentState]
public sealed partial class MonumentCollisionComponent : Component
{
    /// <summary>
    /// Determines whether The Monument is tangible to non-cultists.
    /// </summary>
    [DataField, AutoNetworkedField] public bool HasCollision;
}
