﻿using MarvelDemo.Models;
using MarvelDemo.Services;
using MarvelDemo.ViewModels;
using Xamarin.Forms;

namespace MarvelDemo.Views
{
	//[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CharacterView : ContentPage
	{
        CharacterViewModel _vm => BindingContext as CharacterViewModel;
        Character _character;

        public CharacterView(Character character)
		{
            InitializeComponent();

            _character = character;

            var hashService = DependencyService.Get<IHashService>();
            var dataService = new MarvelDataService(hashService);

            BindingContext = new CharacterViewModel(dataService);
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            _vm.Init(_character);
        }

        private void OnComicSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var comic = e.SelectedItem as Comic;
            Navigation.PushModalAsync(new ComicView(comic));
        }
    }
}
