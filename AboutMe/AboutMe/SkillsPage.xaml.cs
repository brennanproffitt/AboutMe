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
            macOSSkill.Description = "I have used Apple devices for most of my life, and the school I attended growing up had a 1 to 1 device program. Every student and faculty member got a device, and these were all Apple devices. I have experience managing macOS devices and iOS devices, and a common task for me while working as a Tech Assistant for USD 346 involved setting up these devices and doing maintenance work.";

            skillItem xCode = new skillItem();
            xCode.Name = "Xcode";
            xCode.Icon = "icons8_xcode.png";
            xCode.Description = "I am an Xcode novice, as I have only made a simple single view app. I followed along with an introductory guide to Xcode over the summer and learned the basics of the language.";

            skillItem cSharp = new skillItem();
            cSharp.Name = "C#";
            cSharp.Icon = "icons8_c_sharp_logo.png";
            cSharp.Description = "This app was made using C#! The Xamarin framework was used to allow the app to run on multiple platforms. The user interface code language is XAML, which is similar to HTML. The backend (navigation mainly) is in C#, so I have used if statements, functions, and various validating logic, mainly for the contact page of this app.";

            skillItem excel = new skillItem();
            excel.Name = "Microsoft Excel";
            excel.Icon = "icons8_microsoft_excel.png";
            excel.Description = "I took an intro course to Computer Information Systems my first semester of college. We exclusively worked with excel, and I had plenty of practice with how to make spreadsheets look better, and of course using functions to automatically update other cells within the spreadsheet.";

            skillItem writing = new skillItem();
            writing.Name = "Writing";
            writing.Icon = "icons8_pencil.png";
            writing.Description = "Hopefully this skills page has highlighted my writing ability. These descriptions were a bit lengthier than I intended, but that's okay! Throughout highschool I was in the upper level English class, and my writing skills were sharpened. I was required to write many analyses over books, 3 research papers, and expanding vocabulary was also a big focus. Also, Pittsburg State requires that all students complete at least two Writing to Learn courses, which allows me to further exercise my writing skills.";

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

        private void skillsList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
            {
                return;
            }

            skillItem selectedSkill = e.SelectedItem as skillItem;

            (sender as ListView).SelectedItem = null;

            Navigation.PushAsync(new SkillDetailPage(selectedSkill));
        }
    }
}
