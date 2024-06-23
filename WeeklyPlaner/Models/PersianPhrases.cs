using System;

namespace WeeklyPlaner.Models
{
    public class PersianPhrases
    {
        public string CurrentWeek  = "هفته کنونی";
        public string LastWeek  = "هفته‌ قبل";
        public string TwoWeeksAgo  = "دو هفته‌ قبل";
        public string ThreeWeeksAgo  = "سه هفته‌ قبل";

        public string Thursday = "پنجشنبه";
        public string Friday = "جمعه";
        public string Saturday = "شنبه";
        public string Sunday = "یکشنبه";
        public string Monday = "دوشنبه";
        public string Tuesday = "سه‌شنبه";
        public string Wednesday = "چهارشنبه";

        public string Name = "نام";

        public string Warning = "هشدار";
        public string WarningByMark = "هشدار!";

        public string Meal = "وعده";
        public string NewMeal = "وعده جدید";
        public string ChooseMeal = "انتخاب وعده";
        public string Foods = "غذاها";
        public string Food = "غذا";
        public string Category = "دسته";
        public string NewCategory = "دسته‌ی جدید";

        public string Breakfast = "صبحانه";
        public string Lunch = "ناهار";
        public string Dinner  = "شام";

        public string Cancle  = "انصراف";
        public string Save  = "ثبت";

        public string Yes  = "بله";
        public string No = "نه";

        public string NeededGrocery  = "قلم مورد نیاز";
        public string Amount  = "مقدار";

        public string DidYouEatIt  = "آیا این وعده غذا رو خوردی؟";
        public string FoodWillEarase  = "این غذا موقتا از لیست غذاها حذف می‌شه";


        public string EnterNew(string entity)
        {
            return $"{entity}‌ی جدید رو وارد کن";
        }

        public string ChangeThe(string entity)
        {
            return $"{entity} رو تغییر بده";
        }

        public string SureDeleteMeal(string foodName, string meal)
        {
            return $"آیا از حذف {foodName} به عنوان {meal} مطمئن هستی؟";

        }

        public string SureDelete(string entity, string name)
        {
            return $"آیا از حذف {entity}‌ی {name} مطمئن هستی؟";

        }

        public string HowToRefreshFoodsList(string icon)
        {
            return $"با کلیک بر روی ایکون {icon} در بخش غذاها تمامی غذاها دوباره نشون داده می‌شه و به اصطلاح لیست غذاها رفرش می‌شه";

        }

    }
}
