using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Diagnostics;

namespace ShellTestMAUI9;
public partial class MainViewModel : ObservableObject
{
    [RelayCommand]
    public async Task GoToSecondPage5_Clicked()
    {
        await Shell.Current.GoToAsync($"{nameof(SecondPage5)}", true);
    }

    [RelayCommand]
    public async Task GoToSecondPage6_Clicked()
    {
        await Shell.Current.GoToAsync($"{nameof(SecondPage6)}", true);
    }

    [RelayCommand]
    public async Task GoBack()
    {
        await Shell.Current.GoToAsync("..", true);
        Debug.WriteLine("GoBack() executed.");
    }
}
