using System;
using System.Collections.Generic;
using AzurePlusXamApp.ViewModels;
using Xamarin.Forms;

namespace AzurePlusXamApp.Views.WhichOneFitsYourLifeStyle
{
    public partial class WhichOneFitsYourLifestyleA : ContentPage
    {
        public WhichOneFitsYourLifestyleA()
        {
            InitializeComponent();
            BindingContext = new WhichOneFitsYourLSViewModel();
        }
    }
}
