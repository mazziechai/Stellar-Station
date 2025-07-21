// SPDX-FileCopyrightText: 2025 Janet Blackquill <uhhadd@gmail.com>
//
// SPDX-License-Identifier: LicenseRef-CosmicCult

using Robust.Shared.Player;

namespace Content.Server._ST.CosmicCult;

[ByRefEvent]
public record struct CosmicCultVoterEligibilityEvent(ICommonSession Player, bool Eligible);
