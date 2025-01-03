﻿using BepInEx.Configuration;
using UnityEngine;

namespace COM3D2.Highheel.Plugin;

public class PluginConfig
{
    public PluginConfig(ConfigFile config)
    {
        const string configSection = "Config";
        Enabled = config.Bind(configSection, nameof(Enabled), true, "Plugin enabled");

        UIShortcut = config.Bind(
            configSection, nameof(UIShortcut), new KeyboardShortcut(KeyCode.F9, KeyCode.LeftControl),
            "Shortcut to toggle configuration UI"
        );
    }

    public ConfigEntry<bool> Enabled { get; private set; }
    public ConfigEntry<KeyboardShortcut> UIShortcut { get; private set; }
}