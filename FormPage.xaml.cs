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
    public partial class FormPage : ContentPage
    {
        public FormPage()
        {
            InitializeComponent();
        }

        // Méthode appelée lors du clic sur le bouton d'inscription
        private void OnSignUpButtonClicked(object sender, EventArgs e)
        {
            String username = UserNameEntry.Text; 
            String email = EmailEntry.Text;
            String phone = TelephoneEntry.Text;
            String password = PasswordEntry.Text;
            String confirmPassword = ConfirmPasswordEntry.Text;

            //Valider les champs du formulaire
            if (String.IsNullOrWhiteSpace(username) ||
                String.IsNullOrWhiteSpace(email) ||
                String.IsNullOrWhiteSpace(phone) ||
                String.IsNullOrWhiteSpace(password) ||
                String.IsNullOrWhiteSpace(confirmPassword) )
            {
                DisplayAlert("Erreur", "Veuillez remplir tout les champs", "OK"); 
            }
            else if ( password != confirmPassword)
            {
                DisplayAlert("Erreur", "Les mots de passe ne correspondent pas","OK"); 
            }
            else
            {
                DisplayAlert("Success", "Inscription réussie", "OK");
            }
        }

    }
}