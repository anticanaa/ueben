using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiUebung.ViewModels;

public partial class UebungViewModel : ObservableObject
{
    [ObservableProperty]
    int _zahl;
    [ObservableProperty]
    int _zweitezahl;
    [ObservableProperty]
    int _output;

    [RelayCommand]
    void Sum()
    {
        this.Output = Zahl + Zweitezahl;
    }

}
