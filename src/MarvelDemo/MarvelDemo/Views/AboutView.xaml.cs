using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MarvelDemo.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AboutView : ContentPage
	{
		public AboutView ()
		{
			InitializeComponent ();
		}

        private void OnMarvelLinkClicked(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("http://developer.marvel.com"));
        }

        private void OnIcons8LinkClicked(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("http://www.icons8.com"));
        }
    }
}
