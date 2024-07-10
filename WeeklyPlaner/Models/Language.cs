using WeeklyPlaner.Pages;

namespace WeeklyPlaner.Models
{
    public class Language
    {
        private readonly PersianPhrases PersianPhrases = new PersianPhrases();
        private readonly EnglishPhrases EnglishPhrases = new EnglishPhrases();

        public string Persian = "فارسی";
        public string English = "English";

        public string SelectedLang { get; }

        public string FoodPlaning { get; }

        public string NextWeek { get; }
        public string CurrentWeek { get; }
        public string LastWeek { get; }
        public string TwoWeeksAgo { get; }
        public string ThreeWeeksAgo { get; }

        public string Thursday { get; }
        public string Friday { get; }
        public string Saturday { get; }
        public string Sunday { get; }
        public string Monday { get; }
        public string Tuesday { get; }
        public string Wednesday { get; }
        public string ChooseDay { get; }

        public string Name { get; }

        public string Info { get; }
        public string Warning { get; }
        public string WarningByMark { get; }
        public string Setting { get; }

        public string Meal { get; }
        public string NewMeal { get; }
        public string ChooseMeal { get; }
        public string Foods { get; }
        public string Food { get; }
        public string Category { get; }
        public string NewCategory { get; }

        public string Breakfast { get; }
        public string Lunch { get; }
        public string Dinner { get; }

        public string Cancle { get; }
        public string Save { get; }
        public string Yes { get; }
        public string No { get; }
        public string Ok { get; }
        public string Share { get; }
        public string Insert { get; }
        public string Copy { get; }
        public string Clear { get; }

        public string NeededGrocery { get; }
        public string Amount { get; }

        public string DidYouEatIt { get; }
        public string FoodWillEarase { get; }
        public string WhyRemoveFood { get; }
        public string HowToRefreshFoodsList { get; }
        public string WeeksStartDay { get; }
        public string BlankDay { get; }
        public string GroceryListShare { get; }
        public string WeekShare { get; }
        public string WeekInsert { get; }
        public string WeekInsertPlaceHolder { get; }
        public string WeekInsertLabel { get; }
        public string WeeksClear { get; }
        public string FoodsClear { get; }


        public string EnterNew(string entity)
        {
            string text = SelectedLang == PersianPhrases.Persian ? PersianPhrases.EnterNew(entity) : EnglishPhrases.EnterNew(entity);
            return text;
        }

        public string ChangeThe(string entity)
        {
            string text = SelectedLang == PersianPhrases.Persian ? PersianPhrases.ChangeThe(entity) : EnglishPhrases.ChangeThe(entity);
            return text;
        }

        public string SureDeleteMeal(string foodName, string meal)
        {
            string text = SelectedLang == PersianPhrases.Persian ? PersianPhrases.SureDeleteMeal(foodName, meal) : EnglishPhrases.SureDeleteMeal(foodName, meal);
            return text;

        }

        public string SureDelete(string entity, string name)
        {
            string text = SelectedLang == PersianPhrases.Persian ? PersianPhrases.SureDelete(entity, name) : EnglishPhrases.SureDelete(entity, name);
            return text;
            return $"آیا از حذف {entity}‌ی {name} مطمئن هستی؟";
        }

        public Language(string selectedLang)
        {
            SelectedLang = selectedLang;

            FoodPlaning = selectedLang == PersianPhrases.Persian ? PersianPhrases.FoodPlaning : EnglishPhrases.FoodPlaning;

            NextWeek = selectedLang == PersianPhrases.Persian ? PersianPhrases.NextWeek : EnglishPhrases.NextWeek;
            CurrentWeek = selectedLang == PersianPhrases.Persian ? PersianPhrases.CurrentWeek : EnglishPhrases.CurrentWeek;
            LastWeek = selectedLang == PersianPhrases.Persian ? PersianPhrases.LastWeek : EnglishPhrases.LastWeek;
            TwoWeeksAgo = selectedLang == PersianPhrases.Persian ? PersianPhrases.TwoWeeksAgo : EnglishPhrases.TwoWeeksAgo;
            ThreeWeeksAgo = selectedLang == PersianPhrases.Persian ? PersianPhrases.ThreeWeeksAgo : EnglishPhrases.ThreeWeeksAgo;

            Thursday = selectedLang == PersianPhrases.Persian ? PersianPhrases.Thursday : EnglishPhrases.Thursday;
            Friday = selectedLang == PersianPhrases.Persian ? PersianPhrases.Friday : EnglishPhrases.Friday;
            Saturday = selectedLang == PersianPhrases.Persian ? PersianPhrases.Saturday : EnglishPhrases.Saturday;
            Sunday = selectedLang == PersianPhrases.Persian ? PersianPhrases.Sunday : EnglishPhrases.Sunday;
            Monday = selectedLang == PersianPhrases.Persian ? PersianPhrases.Monday : EnglishPhrases.Monday;
            Tuesday = selectedLang == PersianPhrases.Persian ? PersianPhrases.Tuesday : EnglishPhrases.Tuesday;
            Wednesday = selectedLang == PersianPhrases.Persian ? PersianPhrases.Wednesday : EnglishPhrases.Wednesday;
            ChooseDay = selectedLang == PersianPhrases.Persian ? PersianPhrases.ChooseDay : EnglishPhrases.ChooseDay;

            Name = selectedLang == PersianPhrases.Persian ? PersianPhrases.Name : EnglishPhrases.Name;

            Info = selectedLang == PersianPhrases.Persian ? PersianPhrases.Info : EnglishPhrases.Info;
            Warning = selectedLang == PersianPhrases.Persian ? PersianPhrases.Warning : EnglishPhrases.Warning;
            WarningByMark = selectedLang == PersianPhrases.Persian ? PersianPhrases.WarningByMark : EnglishPhrases.WarningByMark;
            Setting = selectedLang == PersianPhrases.Persian ? PersianPhrases.Setting : EnglishPhrases.Setting;

            Meal = selectedLang == PersianPhrases.Persian ? PersianPhrases.Meal : EnglishPhrases.Meal;
            NewMeal = selectedLang == PersianPhrases.Persian ? PersianPhrases.NewMeal : EnglishPhrases.NewMeal;
            ChooseMeal = selectedLang == PersianPhrases.Persian ? PersianPhrases.ChooseMeal : EnglishPhrases.ChooseMeal;
            Foods = selectedLang == PersianPhrases.Persian ? PersianPhrases.Foods : EnglishPhrases.Foods;
            Food = selectedLang == PersianPhrases.Persian ? PersianPhrases.Food : EnglishPhrases.Food;
            Category = selectedLang == PersianPhrases.Persian ? PersianPhrases.Category : EnglishPhrases.Category;
            NewCategory = selectedLang == PersianPhrases.Persian ? PersianPhrases.NewCategory : EnglishPhrases.NewCategory;

            Breakfast = selectedLang == PersianPhrases.Persian ? PersianPhrases.Breakfast : EnglishPhrases.Breakfast;
            Lunch = selectedLang == PersianPhrases.Persian ? PersianPhrases.Lunch : EnglishPhrases.Lunch;
            Dinner = selectedLang == PersianPhrases.Persian ? PersianPhrases.Dinner : EnglishPhrases.Dinner;

            Cancle = selectedLang == PersianPhrases.Persian ? PersianPhrases.Cancle : EnglishPhrases.Cancle;
            Save = selectedLang == PersianPhrases.Persian ? PersianPhrases.Save : EnglishPhrases.Save;
            Yes = selectedLang == PersianPhrases.Persian ? PersianPhrases.Yes : EnglishPhrases.Yes;
            No = selectedLang == PersianPhrases.Persian ? PersianPhrases.No : EnglishPhrases.No;
            Ok = selectedLang == PersianPhrases.Persian ? PersianPhrases.Ok : EnglishPhrases.Ok;
            Share = selectedLang == PersianPhrases.Persian ? PersianPhrases.Share : EnglishPhrases.Share;
            Insert = selectedLang == PersianPhrases.Persian ? PersianPhrases.Insert : EnglishPhrases.Insert;
            Copy = selectedLang == PersianPhrases.Persian ? PersianPhrases.Copy : EnglishPhrases.Copy;
            Clear = selectedLang == PersianPhrases.Persian ? PersianPhrases.Clear : EnglishPhrases.Clear;

            NeededGrocery = selectedLang == PersianPhrases.Persian ? PersianPhrases.NeededGrocery : EnglishPhrases.NeededGrocery;
            Amount = selectedLang == PersianPhrases.Persian ? PersianPhrases.Amount : EnglishPhrases.Amount;

            DidYouEatIt = selectedLang == PersianPhrases.Persian ? PersianPhrases.DidYouEatIt : EnglishPhrases.DidYouEatIt;
            FoodWillEarase = selectedLang == PersianPhrases.Persian ? PersianPhrases.FoodWillEarase : EnglishPhrases.FoodWillEarase;
            WhyRemoveFood = selectedLang == PersianPhrases.Persian ? PersianPhrases.WhyRemoveFood : EnglishPhrases.WhyRemoveFood;
            HowToRefreshFoodsList = selectedLang == PersianPhrases.Persian ? PersianPhrases.HowToRefreshFoodsList : EnglishPhrases.HowToRefreshFoodsList;
            WeeksStartDay = selectedLang == PersianPhrases.Persian ? PersianPhrases.WeeksStartDay : EnglishPhrases.WeeksStartDay;
            BlankDay = selectedLang == PersianPhrases.Persian ? PersianPhrases.BlankDay : EnglishPhrases.BlankDay;
            GroceryListShare = selectedLang == PersianPhrases.Persian ? PersianPhrases.GroceryListShare : EnglishPhrases.GroceryListShare;
            WeekShare = selectedLang == PersianPhrases.Persian ? PersianPhrases.WeekShare : EnglishPhrases.WeekShare;
            WeekInsert = selectedLang == PersianPhrases.Persian ? PersianPhrases.WeekInsert : EnglishPhrases.WeekInsert;
            WeekInsertPlaceHolder = selectedLang == PersianPhrases.Persian ? PersianPhrases.WeekInsertPlaceHolder : EnglishPhrases.WeekInsertPlaceHolder;
            WeekInsertLabel = selectedLang == PersianPhrases.Persian ? PersianPhrases.WeekInsertLabel : EnglishPhrases.WeekInsertLabel;
            WeeksClear = selectedLang == PersianPhrases.Persian ? PersianPhrases.WeeksClear : EnglishPhrases.WeeksClear;
            FoodsClear = selectedLang == PersianPhrases.Persian ? PersianPhrases.FoodsClear : EnglishPhrases.FoodsClear;
        }
    }
}
