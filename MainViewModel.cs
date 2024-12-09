using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace ShellTestMAUI9;
public partial class MainViewModel : ObservableObject
{
    [RelayCommand]
    public async Task GoToSecondPage_Clicked()
    {
        await Shell.Current.GoToAsync($"{nameof(SecondPage)}", true);
    }

    [RelayCommand]
    public void GoBack()
    {
       //Do something here
    }
}
