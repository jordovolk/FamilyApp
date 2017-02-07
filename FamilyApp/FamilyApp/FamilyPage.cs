using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FamilyApp
{
    class FamilyPage : ContentPage

    {

        public FamilyPage()
        {
            BackgroundColor = Color.Black;
            

            var stackLayout = new StackLayout
            {
                HorizontalOptions = LayoutOptions.Fill,
               

                Spacing = 3.0,
                Orientation = StackOrientation.Horizontal,
                Children =
                {



                new Label { Text = "I have several family members I would like to share with you. My mothers name is ", TextColor = Color.White},
                new Label { Text = "Monica", FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)), FontAttributes = FontAttributes.Bold, TextColor = Color.Red, BackgroundColor = Color.Yellow, VerticalOptions = LayoutOptions.CenterAndExpand},
                new Label { Text = "," , TextColor = Color.White},
                new Label { Text = " my fathers name is " , TextColor = Color.White },
                new Label { Text = "Gary", FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)), FontAttributes = FontAttributes.Bold, TextColor = Color.Blue },
                new Label { Text = "My two uncles names are " , TextColor = Color.White },
                new Label { Text = "Jarod ", FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)), FontAttributes = FontAttributes.Bold, TextColor = Color.Green },
                new Label { Text = "and " , TextColor = Color.White },
                new Label { Text = "Jesse, ", FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)), FontAttributes = FontAttributes.Bold, TextColor = Color.Purple },
                new Label { Text = "last but not least my sister's name is " , TextColor = Color.White },
                new Label { Text = "Sydney", FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)), FontAttributes = FontAttributes.Bold, TextColor = Color.Yellow }


                }

                };

            Content = new ScrollView
            {
                Orientation = ScrollOrientation.Horizontal,
                Content = stackLayout

            };















                }

            };
            
        }

    

