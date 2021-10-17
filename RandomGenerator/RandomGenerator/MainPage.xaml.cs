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
            ClassMembers(); //Invokes Classmembers method when MainPage is displayed.
        }

        //declares array classMembers to be listed via ClassMembers() method 
        public string[] classMembers = new string[14] { "Billy", "Dennis", "Josh", "Lumiere", "Michael", "Joe", "Jay", "Austin", "Dan", "Erick", "Wynn", "Scott", "Torrie", "Yohan" };

        public void ClassMembers()
        {
            classMemberList.ItemsSource = classMembers; //Assigns classMembers Array to classMemberList Listview on MainPage.xaml
        }
       
        //When Randomize button is clicked, changes label named printRandomName
        private void btnRandomize_Clicked(object sender, EventArgs e)
        {
            printRandomName.Text = Randomize();
            printRandomName.FontSize = 50;
            printRandomName.TextColor = Color.Red;
        }

        //Performs randomizing upon button click
        private string Randomize()
        {
            Random rand = new Random();
            int index = rand.Next(classMembers.Length);
            return classMembers[index];
        }
        
    }
}
