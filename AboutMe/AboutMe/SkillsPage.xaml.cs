using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        public ObservableCollection<string> Skills { get; set; }

        public SkillsPage()
        {
            InitializeComponent();

            this.Skills = new ObservableCollection<string>();
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

        private void Button_Clicked(object sender, EventArgs e)
        {
            this.Skills.Add(newSkillEntry.Text);

            newSkillEntry.Text = "";

            skillsList.ItemsSource = this.Skills;
        }
    }
}
