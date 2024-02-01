using System.Collections.Generic;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace CommandSample.ViewModels;

public partial class MainWindowViewModel : ObservableObject
{
    [ObservableProperty] private List<string> _conversationLog;

    [ObservableProperty] private string _robotName;

    [RelayCommand]
    private void OpenThePodBayDoors()
    {
        ConversationLog.Clear();
        ConversationLog.Add("I'm sorry, Dave, I'm afraid I can't do that.");
    }
}