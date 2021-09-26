using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace RandomGenerator
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            ClassMembers();
        }

        public string ClassMembers()
        {
            string[] classMembers = new string[14]; // string[] classMembers = new string[] { Billy, Dennis, Josh, Lumiere, Michael, Joe, Jay, Austin, Dan, Erick, Wynn, Scott, Torrie, Yohan }
            classMembers[0] = "Billy";
            classMembers[1] = "Dennis";
            classMembers[2] = "Josh";
            classMembers[3] = "Lumiere";
            classMembers[4] = "Michael";
            classMembers[5] = "Joe";
            classMembers[6] = "Jay";
            classMembers[7] = "Austin";
            classMembers[8] = "Nguyen";
            classMembers[9] = "Erick";
            classMembers[10] = "Dan";
            classMembers[11] = "Scott";
            classMembers[12] = "Torrie";
            classMembers[13] = "Yohan";
            //binds ^ above array list to the listview display
            classMemberList.ItemsSource = classMembers;

            Random rand = new Random();
            int index = rand.Next(classMembers.Length);
            return classMembers[index];
            //printRandomName.Text = classMembers[index];
        }
       

        private void btnRandomize_Clicked(object sender, EventArgs e)
        {
            //TODO figure out how to print random name to screen
            //TODO ClassMembers() as called in the public MainPage adds classMembers to listview (i think) and also randomizes and returns something. It should only do the first part (add classMembers)
            //...the randomization and printing should be done somewhere else (i think)
            //Random rand = new Random();
            //int index = rand.Next(ClassMembers().Length);
            //rand.Next(ClassMembers().Length);
            //ClassMembers randClass = new ClassMembers(string);

            printRandomName.Text = ClassMembers();
            printRandomName.FontSize = 50;
            printRandomName.TextColor = Color.Red;
        }
        
    }
}
