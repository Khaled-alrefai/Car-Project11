namespace WebApplication1.Models
{
    public class Car
    {
        // القسم الأول: المعلومات الأساسية
        public int Id { get; set; } // معرف السيارة (Primary Key)
        public string CarNumber { get; set; } // رقم السيارة
        public string Company { get; set; } // الشركة المصنعة
        public string Model { get; set; } // موديل السيارة
        public DateTime DateOfMade { get; set; } // تاريخ الصنع
        public int Mileage { get; set; } // ممشى السيارة بالكيلومترات
        public decimal Price { get; set; } // سعر السيارة
        public string ImageUrl { get; set; } // رابط الصورة الأساسية

        // القسم الثاني: المواصفات التقنية
        public string Engine { get; set; } // تفاصيل المحرك
        public string Transmission { get; set; } // ناقل الحركة
        public string Control { get; set; } // نوع التحكم
        public string FuelConsumption { get; set; } // استهلاك الوقود
        public string Brakes { get; set; } // نوع الفرامل

        // القسم الثالث: المظهر الخارجي
        public string Color { get; set; } // لون السيارة
        public string Lights { get; set; } // تفاصيل المصابيح

        // القسم الرابع: الوظائف المميزة
        public string Seats { get; set; } // تفاصيل المقاعد
        public string Key { get; set; } // نظام التشغيل والمفاتيح
        public string Condition { get; set; } // الحالة العامة

        //تساعد على الفلترة 
        public bool Featured { get; set; } // هل السيارة مميزة ؟
        public bool ForFamilies { get; set; } // هل السيارة للعائلات ؟
        public bool Recommended { get; set; } //موصى بها  
        public bool Economical { get; set; } // اقتصادية
        public DateOnly ArrivalTime { get; set; } // وقت الوصول الى الشركة

        // القسم الأخير: الوصف العام
        public string Description { get; set; } // وصف السيارة
    }
}
