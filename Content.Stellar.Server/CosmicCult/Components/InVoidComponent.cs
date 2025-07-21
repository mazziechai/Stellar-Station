// SPDX-FileCopyrightText: 2025 AftrLite
// SPDX-FileCopyrightText: 2025 Janet Blackquill <uhhadd@gmail.com>
//
// SPDX-License-Identifier: LicenseRef-CosmicCult

using Robust.Shared.Serialization.TypeSerializers.Implementations.Custom;

namespace Content.Stellar.Server.CosmicCult.Components;

[RegisterComponent]
[AutoGenerateComponentPause]
public sealed partial class InVoidComponent : Component
{
    [DataField(customTypeSerializer: typeof(TimeOffsetSerializer))]
    [AutoPausedField]
    public TimeSpan ExitVoidTime = default!;

    [DataField]
    public EntityUid OriginalBody;
}
