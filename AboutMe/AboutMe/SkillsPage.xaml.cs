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
    public partial class SkillsPage : ContentPage
    {
        public SkillsPage()
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
    }
}
