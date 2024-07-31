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
        public string HowToRefreshFoodsList = "If you wish, you can refresh the food list by clicking on the icon similar to the one below, and all the foods will be displayed again in the food section.";
        public string WeeksStartDay = "Weeks start day";
        public string BlankDay = "No meal has been saved on this day!";
        public string GroceryListShare = "Sharing the shopping list of the week";
        public string WeekShare = "Sharing a week plan";
        public string WeekInsert = "Insert a week plan";
        public string WeekInsertPlaceHolder = "Past here the copied week plan";
        public string WeekInsertLabel = "Shared json text";
        public string WeeksClear = "Reset weeks plan";
        public string FoodsClear = "Reset foods list";


        public string EnterNew(string entity)
        {
            return $"Enter new {entity}‌";
        }

        public string ChangeThe(string entity)
        {
            return $"Change the {entity}";
        }

        public string SureDeleteMeal(string foodName, string meal)
        {
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
