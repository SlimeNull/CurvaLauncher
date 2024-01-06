﻿using CommunityToolkit.Mvvm.ComponentModel;
using CurvaLauncher.Models;

namespace CurvaLauncher.ViewModels;

public partial class SettingsViewModel : ObservableObject
{
    [ObservableProperty]
    private CurvaLauncherPluginInstance? _selectedPluginInstance;

}
