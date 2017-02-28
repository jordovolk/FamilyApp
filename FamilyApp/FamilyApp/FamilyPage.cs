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
            var embeddedImage1 = new Image { Aspect = Aspect.AspectFit };
            embeddedImage1.Source = ImageSource.FromResource("FamilyApp.mom.png");

            var embeddedImage2 = new Image { Aspect = Aspect.AspectFit };
            embeddedImage2.Source = ImageSource.FromResource("FamilyApp.dad.png");

            var embeddedImage3 = new Image { Aspect = Aspect.AspectFit };
            embeddedImage3.Source = ImageSource.FromResource("FamilyApp.sister.gif");

            var embeddedImage4 = new Image { Aspect = Aspect.AspectFit };
            embeddedImage4.Source = ImageSource.FromResource("FamilyApp.dog.jpg");

            var embeddedImage5 = new Image { Aspect = Aspect.AspectFit };
            embeddedImage5.Source = ImageSource.FromResource("FamilyApp.uncle.jpg");


            BackgroundColor = Color.White;


            var stackLayout = new StackLayout
            {
                VerticalOptions = LayoutOptions.FillAndExpand,


                Spacing = 3.0,
                Orientation = StackOrientation.Vertical,
                Children =
                {



                new Label { Text = "My mothers name is", FontSize = 50, TextColor = Color.Gray, VerticalOptions = LayoutOptions.FillAndExpand},
                new Label { Text = "Monica", FontSize = 70, TextColor = Color.Red, VerticalOptions = LayoutOptions.FillAndExpand, FontAttributes = FontAttributes.Bold },
                embeddedImage1,
                new Label { Text = "she is a OO Programmer aswell.", FontSize = 50, TextColor = Color.Gray, VerticalOptions = LayoutOptions.FillAndExpand },
                new Label { Text="My fathers name is",  FontSize = 50, TextColor = Color.Gray, VerticalOptions = LayoutOptions.FillAndExpand  },
                new Label { Text = "Gary", FontSize = 70, TextColor = Color.Yellow, VerticalOptions = LayoutOptions.FillAndExpand, FontAttributes = FontAttributes.Bold },
                embeddedImage2,
                new Label { Text="he sells computer parts for a company called SIGMA solutions", FontSize = 50, TextColor = Color.Gray, VerticalOptions = LayoutOptions.FillAndExpand  },
                new Label { Text="My sisters name is",  FontSize = 50, TextColor = Color.Gray, VerticalOptions = LayoutOptions.FillAndExpand  },
                new Label { Text = "Sydney", FontSize = 70, TextColor = Color.Green, VerticalOptions = LayoutOptions.FillAndExpand, FontAttributes = FontAttributes.Bold },
                embeddedImage3,
                new Label { Text = "shes okay i guess haha", FontSize = 50, TextColor = Color.Gray, VerticalOptions = LayoutOptions.FillAndExpand   },
                new Label { Text="My dog's name is", FontSize = 50, TextColor = Color.Gray, VerticalOptions = LayoutOptions.FillAndExpand },
                new Label { Text = "Zoey", FontSize = 70, TextColor = Color.Aqua, VerticalOptions = LayoutOptions.FillAndExpand, FontAttributes = FontAttributes.Bold },
                embeddedImage4,
                new Label { Text="she is a black lab, golden retriever and chow mix", FontSize = 50, TextColor = Color.Gray, VerticalOptions = LayoutOptions.FillAndExpand },
                new Label { Text="My uncle on my moms side name is",  FontSize = 50, TextColor = Color.Gray, VerticalOptions = LayoutOptions.FillAndExpand  },
                new Label { Text="Jarod", FontSize = 70, TextColor = Color.Purple, VerticalOptions = LayoutOptions.FillAndExpand, FontAttributes = FontAttributes.Bold},
                embeddedImage5,
                new Label { Text="He likes to pheasant hunt for fun",  FontSize = 50, TextColor = Color.Gray, VerticalOptions = LayoutOptions.FillAndExpand  }

                }

                };

            Content = new ScrollView
            {
                Orientation = ScrollOrientation.Vertical,
                Content = stackLayout

            };















                }

            };
            
        }

    

