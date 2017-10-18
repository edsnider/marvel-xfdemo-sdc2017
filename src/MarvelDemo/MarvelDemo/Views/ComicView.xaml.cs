using System;
using MarvelDemo.Models;
using MarvelDemo.ViewModels;
using Xamarin.Forms;

namespace MarvelDemo.Views
{
	//[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ComicView : ContentPage
	{
        ComicViewModel _vm => BindingContext as ComicViewModel;
        Comic _comic;

        public ComicView(Comic comic)
        {
            InitializeComponent();

            _comic = comic;

            BindingContext = new ComicViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            _vm.Init(_comic);
        }

        private void CloseButton_OnClicked(object sender, EventArgs e)
        {
            Navigation.PopModalAsync(true);
        }
    }
}
