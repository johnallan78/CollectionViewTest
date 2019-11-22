using System;

using Xamarin.Forms;

namespace CollectionViewXF_Test.Templates
{
    public class TemplateTest : ContentPage
    {
        public TemplateTest()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
        }
    }
}

