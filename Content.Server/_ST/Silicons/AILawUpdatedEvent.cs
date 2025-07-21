// SPDX-FileCopyrightText: 2025 AftrLite
//
// SPDX-License-Identifier: LicenseRef-CosmicCult

using Content.Shared.Silicons.Laws;
using Robust.Shared.Prototypes;

namespace Content.Server._ST.Silicons;

/// <summary>
///     This event gets called whenever an AIs laws are actually updated.
/// </summary>
[ByRefEvent]
public record struct AILawUpdatedEvent(EntityUid Target, ProtoId<SiliconLawsetPrototype> Lawset);
