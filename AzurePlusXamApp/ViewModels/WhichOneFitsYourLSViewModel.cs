using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using AzurePlusXamApp.Models;

namespace AzurePlusXamApp.ViewModels
{
    public class WhichOneFitsYourLSViewModel : BaseViewModel
    {
        public ObservableCollection<LifestylePlan> LifestylePlanList { get; set; }

        public WhichOneFitsYourLSViewModel()
        {
            LifestylePlanList = new ObservableCollection<LifestylePlan>
            {
                new LifestylePlan()
                {
                    Image = "https://s3-eu-west-1.amazonaws.com/wbm.thumbnail/dissolve/1200/721158.jpg",
                    Title = "Two-Person",
                    Members = 2,
                    Price = 9.99f
                },
                new LifestylePlan()
                {
                    Image = "https://synergyprivatehealth.com/wp-content/uploads/2018/06/family-cooking-class.jpg",
                    Title = "Family",
                    Members = 4,
                    Price = 7.49f
                }
            };
        }
    }
}
