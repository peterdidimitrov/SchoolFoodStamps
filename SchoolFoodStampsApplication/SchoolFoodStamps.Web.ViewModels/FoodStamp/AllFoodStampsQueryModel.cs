﻿using System.ComponentModel.DataAnnotations;
using static SchoolFoodStamps.Common.GeneralApplicationConstants;

namespace SchoolFoodStamps.Web.ViewModels.FoodStamp
{
    public class AllFoodStampsQueryModel<T>
    {
        public AllFoodStampsQueryModel()
        {
            CurrentPage = DefaultPage;
            FoodStampsPerPage = EntitiesPerPage;

            FoodStamps = new HashSet<FoodStampViewModel>();
            Filter = new HashSet<T>();
        }

        [Display(Name = "Name")]
        public string SearchId { get; set; } = string.Empty;


        public string StudentName { get; set; } = string.Empty;

        public string Status { get; set; } = string.Empty;

        [Display(Name = "Sort by")]
        public FoodStampSorting FoodStampSorting { get; set; }

        public int CurrentPage { get; set; }

        [Display(Name = "Per page by")]
        public int FoodStampsPerPage { get; set; }

        public int TotalFoodStamps { get; set; }

        public IEnumerable<FoodStampViewModel> FoodStamps { get; set; }
        public IEnumerable<T> Filter { get; set; }
    }
}
