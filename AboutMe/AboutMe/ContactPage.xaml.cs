using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AboutMe
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContactPage : ContentPage
    {
        public ContactPage()
        {
            InitializeComponent();
        }

        private void AboutMeButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }

        private void SkillsButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SkillsPage());
        }

        private void ContactButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ContactPage());
        }

        private async void SubmitButton_Clicked(object sender, EventArgs e)
        {
            if (nameEntry.Text == "" || nameEntry.Text == null)
            {
                await DisplayAlert("Error", "Please enter your name.", "Return");
                return;
            }

            if (emailEntry.Text == "" || emailEntry.Text == null || !emailEntry.Text.Contains ("@") || !emailEntry.Text.Contains ("."))
            {
                await DisplayAlert("Error", "Please enter a valid email.", "Return");
                return;
            }

            if (messageEntry.Text == "" || messageEntry.Text == null)
            {
                await DisplayAlert("Error", "Please enter a message.", "Return");
                return;
            }

            await DisplayAlert("Thank you!", "Your message was sent and I will get back to you shortly.", "Return");

            await Navigation.PopAsync();
        }
    }
}