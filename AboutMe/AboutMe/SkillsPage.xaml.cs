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
        public ObservableCollection<skillItem> Skills { get; set; }

        public SkillsPage()
        {
            InitializeComponent();

            this.Skills = new ObservableCollection<skillItem>();

            skillItem macOSSkill = new skillItem();
            macOSSkill.Name = "macOS and iOS";
            macOSSkill.Icon = "icons8_apple_logo.png";

            skillItem xCode = new skillItem();
            xCode.Name = "Xcode";
            xCode.Icon = "icons8_xcode.png";

            skillItem cSharp = new skillItem();
            cSharp.Name = "C#";
            cSharp.Icon = "icons8_c_sharp_logo.png";

            skillItem excel = new skillItem();
            excel.Name = "Microsoft Excel";
            excel.Icon = "icons8_microsoft_excel.png";

            skillItem writing = new skillItem();
            writing.Name = "Writing";
            writing.Icon = "icons8_pencil.png";

            Skills.Add(macOSSkill);
            Skills.Add(xCode);
            Skills.Add(cSharp);
            Skills.Add(excel);
            Skills.Add(writing);

            this.skillsList.ItemsSource = this.Skills;
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
