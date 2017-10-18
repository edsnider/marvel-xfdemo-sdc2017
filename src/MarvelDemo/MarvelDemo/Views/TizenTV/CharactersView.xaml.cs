using MarvelDemo.Models;
using MarvelDemo.ViewModels;
using Xamarin.Forms;

namespace MarvelDemo.Views.TizenTV
{
	//[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CharactersView : ContentPage
	{
        CharactersViewModel _vm => BindingContext as CharactersViewModel;

		public CharactersView()
		{
            InitializeComponent();
            
            BindingContext = new CharactersViewModel();
		}

        protected override void OnAppearing()
        {
            base.OnAppearing();

            _vm.Init();
        }

        async void OnCharacterSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var character = e.SelectedItem as Character;
            await Navigation.PushAsync(new CharacterView(character));
        }
    }
}
