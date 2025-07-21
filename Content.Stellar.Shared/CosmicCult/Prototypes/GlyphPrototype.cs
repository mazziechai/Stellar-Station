// SPDX-FileCopyrightText: 2025 AftrLite
// SPDX-FileCopyrightText: 2025 Janet Blackquill <uhhadd@gmail.com>
//
// SPDX-License-Identifier: LicenseRef-CosmicCult

using Robust.Shared.Prototypes;
using Robust.Shared.Utility;

namespace Content.Stellar.Shared.CosmicCult.Prototypes;

[Prototype]
public sealed partial class GlyphPrototype : IPrototype
{
    [IdDataField]
    public string ID { get; private set; } = default!;

    [DataField(required: true)]
    public LocId Name;

    [DataField]
    public LocId Tooltip;

    [DataField(required: true)]
    public SpriteSpecifier Icon = SpriteSpecifier.Invalid;

    [DataField(required: true)]
    public EntProtoId Entity;

    [DataField(required: true)]
    public int Tier;
}
