using WeeklyPlaner.Pages;

namespace WeeklyPlaner.Models
{
    public class EnglishPhrases
    {
        public string Persian = "فارسی";
        public string English = "English";
        public string LanguageMean = "Language";

        public string FoodPlaning = "Food Planing";

        public string NextWeek = "Next week";
        public string CurrentWeek = "Current week";
        public string LastWeek = "Last week";
        public string TwoWeeksAgo = "Two weeks ago";
        public string ThreeWeeksAgo = "Three weeks ago";

        public string Thursday = "Thursday";
        public string Friday = "Friday";
        public string Saturday = "Saturday";
        public string Sunday = "Sunday";
        public string Monday = "Monday";
        public string Tuesday = "Tuesday";
        public string Wednesday = "Wednesday";
        public string ChooseDay = "Choose a day";

        public string Name = "Name";

        public string Info = "Info";
        public string Warning = "Warning";
        public string WarningByMark = "Warning!";
        public string Setting = "Setting";

        public string Meal = "Meal";
        public string NewMeal = "New meal";
        public string ChooseMeal = "Choose a meal";
        public string Foods = "Foods";
        public string Food = "Food";
        public string Category = "Category";
        public string NewCategory = "New category";

        public string Breakfast = "Breakfast";
        public string Lunch = "Lunch";
        public string Dinner = "Dinner";

        public string Cancle = "Cancle";
        public string Save = "Save";
        public string Yes = "Yes";
        public string No = "No";
        public string Ok = "Ok";
        public string Share = "Share";
        public string Insert = "Insert";
        public string Copy = "Copy";
        public string Clear = "Clear";

        public string NeededGrocery = "Needed grocery";
        public string Amount = "Amount";

        public string DidYouEatIt = "Had you eaten this meal?";
        public string FoodWillEarase = "This food will be earase temprarly";
        public string WhyRemoveFood = "This temporary removal of food is done in order to observe diversity and prevent repetition of the food plan";
        public string HowToRefreshFoodsList = "If you wish, you can refresh the list of foods by clicking on the icon below and all the foods will be displayed again in the food section, or remove the check mark in front of any food that you want to remain in the list of foods";
        public string WeeksStartDay = "Weeks start day";
        public string BlankDay = "No meal has been saved on this day!";
        public string GroceryListShare = "Sharing the shopping list of the week";
        public string WeekShare = "Sharing a week plan";
        public string FoodListShare = "Sharing list of foods";
        public string WeekInsert = "Insert a week plan";
        public string FoodListInsert = "Insert list of foods";
        public string WeekInsertPlaceHolder = "Past here the copied week plan";
        public string FoodListInsertPlaceHolder = "Past here the copied list of foods";
        public string InsertLabel = "Shared json text";
        public string WeeksClear = "Reset weeks plan";
        public string FoodsClear = "Reset foods list";
        public string StartDayChangeGuid = "Currently, due to existing restrictions, it is only possible to change the start day of the week to the day you are on or the day after that day, so if the desired day is not on the list, please wait until that day arrives or in The day before that day, change the start day of the week.";



        public string EnterNew(string entity)
        {
            return $"Enter new {entity}‌";
        }

        public string ChangeThe(string entity)
        {
            return $"Change the {entity}";
        }

        public string SureDeleteMeal(List<Food> foods, string meal)
        {
            var foodName = "";
            if (foods.Count > 1)
            {
                foodName = $"these {foods.Count} foods";
            }
            else if(foods.Count == 1)
            {
                foodName = foods[0].Name;
            }
            return $"Are you sure you want to delete {foodName} as {meal}";

        }

        public string SureDelete(string entity, string name)
        {
            return $"Are you sure you want to delete {name} as {entity}";

		}
		public string FieldValidation(string entity)
		{
			return $"The {entity} must be entered";
		}
	}
}
