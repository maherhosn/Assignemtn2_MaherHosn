
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CharacterPage : ContentPage
	{
		public CharacterPage ()
		{
			InitializeComponent ();
		}

        //event handler for leaderbaord button
        async void ButtonToLeaderboard(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Leaderboard());
        }

        //event handler for characters button
        async void ButtonToCharacters(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ItemsPage());
        }

        //event handler for items button
        async void ButtonToItems(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ItemsPage());
        }
    }
}