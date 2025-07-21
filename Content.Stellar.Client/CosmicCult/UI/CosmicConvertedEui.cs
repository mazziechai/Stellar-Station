// SPDX-FileCopyrightText: 2025 AftrLite
// SPDX-FileCopyrightText: 2025 Janet Blackquill <uhhadd@gmail.com>
//
// SPDX-License-Identifier: LicenseRef-CosmicCult

using Content.Client.Eui;

namespace Content.Stellar.Client.CosmicCult.UI;

public sealed class CosmicConvertedEui : BaseEui
{
    private readonly CosmicConvertedMenu _menu;

    public CosmicConvertedEui()
    {
        _menu = new CosmicConvertedMenu();
    }

    public override void Opened()
    {
        _menu.OpenCentered();
    }

    public override void Closed()
    {
        base.Closed();

        _menu.Close();
    }
}
