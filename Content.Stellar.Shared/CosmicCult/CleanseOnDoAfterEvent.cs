// SPDX-FileCopyrightText: 2025 AftrLite
// SPDX-FileCopyrightText: 2025 Janet Blackquill <uhhadd@gmail.com>
//
// SPDX-License-Identifier: LicenseRef-CosmicCult

using Content.Shared.DoAfter;
using Robust.Shared.Serialization;

namespace Content.Stellar.Shared.CosmicCult;

[Serializable, NetSerializable]
public sealed partial class CleanseOnDoAfterEvent : SimpleDoAfterEvent;
