using MauiUebung.ViewModels;

namespace MauiUebung
{
    public partial class MainPage : ContentPage
    {
    

        public MainPage()
        {
            InitializeComponent();
            this.BindingContext = new UebungViewModel();
        }

    }

}
