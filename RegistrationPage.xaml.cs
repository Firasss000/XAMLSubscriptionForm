using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class RegistrationPage : ContentPage
	{
		public RegistrationPage ()
		{
			InitializeComponent ();
		}

		// Méthode appelée lors du clic sur le bouton "Subscribe"
		private void OnRegisterClicked(object sender, EventArgs e)
		{
			String username = UsernameEntry.Text;
			String email = EmailEntry.Text;
			String password = PasswordEntry.Text;
			bool acceptedTerms = TermsSwitch.IsToggled;

			if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(email)
				|| string.IsNullOrWhiteSpace(password))
			{
				DisplayAlert("Erreur", "Veuillez remplir tout les champs", "Ok");

			}
			else if (!acceptedTerms)
			{
				DisplayAlert("Erreur", "Veuillez accepter les conditions", "Ok");

			}
			else
			{
				DisplayAlert("Success", "Souscription réussite", "OK");
			}
		}
    }
}