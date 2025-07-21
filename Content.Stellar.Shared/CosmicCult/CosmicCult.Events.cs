// SPDX-FileCopyrightText: 2025 AftrLite
// SPDX-FileCopyrightText: 2025 Janet Blackquill <uhhadd@gmail.com>
//
// SPDX-License-Identifier: LicenseRef-CosmicCult

using Robust.Shared.Serialization;

namespace Content.Stellar.Shared.CosmicCult;

[Serializable, NetSerializable]
public sealed partial class CosmicSiphonIndicatorEvent(NetEntity target) : EntityEventArgs
{
    public NetEntity Target = target;

    public CosmicSiphonIndicatorEvent() : this(new())
    {
    }
}
