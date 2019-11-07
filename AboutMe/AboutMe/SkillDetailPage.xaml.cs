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
    public partial class SkillDetailPage : ContentPage
    {
        private skillItem skillOnPage;
        
        public SkillDetailPage(skillItem skill)
        {
            InitializeComponent();

            this.skillOnPage = skill;

            this.skillImage.Source = skillOnPage.Icon;
            this.skillLabel.Text = skillOnPage.Name;
            this.descriptionLabel.Text = skillOnPage.Description;
        }

        private void PreviousButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SkillsPage());
        }
    }
}