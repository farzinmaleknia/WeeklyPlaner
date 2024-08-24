using System;

namespace WeeklyPlaner.Models
{
    public class PersianPhrases
    {
        public string Persian  = "فارسی";
        public string English  = "English";
        public string LanguageMean  = "زبان";

        public string FoodPlaning  = "برنامه‌ریزی غذایی";
        
        public string NextWeek  = "هفته بعد";
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
        public string ChooseDay = "انتخاب روز";

        public string Name = "نام";

        public string Info = "اطلاعات";
        public string Warning = "هشدار";
        public string WarningByMark = "هشدار!";
        public string Setting = "تنظیمات";

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
        public string Ok = "باشه";
        public string Share = "اشتراک گذاری";
        public string Insert = "بارگذاری";
        public string Copy = "کپی";
        public string Clear = "پاک کردن";

        public string NeededGrocery  = "قلم مورد نیاز";
        public string Amount  = "مقدار";

        public string DidYouEatIt  = "آیا این وعده غذا رو خوردی؟";
        public string FoodWillEarase  = "این غذا موقتا از لیست غذاها حذف می‌شه";
        public string WhyRemoveFood  = "این حذف موقتی غذا، در جهت رعایت تنوع و جلوگیری از تکراری شدن برنامه غذایی انجام می‌شه";
        public string HowToRefreshFoodsList = "در صورت تمایل می‌تونی با کلیک بر روی ایکون زیر لیست غذاها رو رفرش کنی و در بخش غذاها تمامی غذاها دوباره نشون داده می‌شه و یا تیک جلوی هر غدایی که میخواهید در لیست غذا ها بماند بردارید ";
        public string WeeksStartDay = "روز شروع هفته";
        public string BlankDay = "در این روز وعده‌ای ثبت نشده است!";
        public string GroceryListShare = "اشتراک گذاری لیست خرید هفته";
        public string WeekShare = "اشتراک گذاری برنامه یک هفته";
        public string FoodListShare = "اشتراک گذاری لیست غذاها";
        public string WeekInsert = "بارگذاری برنامه یک هفته";
        public string FoodListInsert = "بارگذاری لیست غذاها";
        public string WeekInsertPlaceHolder = "برنامه‌ی هفته کپی شده را در این قسمت بارگذاری کنید";
        public string FoodListInsertPlaceHolder = "لیست غذاهای کپی شده را در این قسمت بارگذاری کنید";
        public string InsertLabel = "متن Json منتشر شده";
        public string WeeksClear = "پاک کردن اطلاعات هفته‌ها";
        public string FoodsClear = "پاک کردن اطلاعات غذا‌ها";
        public string StartDayChangeGuid = "در حال حاضر به دلیل محدودیت های موجود، تغییر روز شروع هفته تنها به روزی که در آن قرار داری یا فردای آن روز امکان پذیر است، پس اگر روز مورد نظر در لیست قرار ندارد، خواهشا صبر کن تا آن روز فرا برسه و یا در روز قبل از آن روز، نسبت به تغییر روز شروع هفته اقدام کن.";


        public string EnterNew(string entity)
        {
            return $"{entity}‌ی جدید رو وارد کن";
        }

        public string ChangeThe(string entity)
        {
            return $"{entity} رو تغییر بده";
        }

        public string SureDeleteMeal(List<Food> foods, string meal)
        {
            var foodName = "";
            if (foods.Count > 1)
            {
                foodName = $"این {foods.Count} غذا";
            }
            else if(foods.Count == 1)
            {
                foodName = foods[0].Name;
            }
            return $"آیا از حذف {foodName} به عنوان {meal} مطمئن هستی؟";

        }

        public string SureDelete(string entity, string name)
        {
            return $"آیا از حذف {entity}‌ی {name} مطمئن هستی؟";

		}
		public string FieldValidation(string entity)
		{
			return $"وارد کردن {entity} لازم هست";
		}

	}
}
