namespace WebApplication1.Models
{
    public class Admin
    {
        public int Id { get; set; } // المفتاح الأساسي
        public string Username { get; set; } // اسم المستخدم
        public string PasswordHash { get; set; } // كلمة المرور المشفرة
        public bool SupreAdmin { get; set; } // الدور الوظيفي (مثل SuperAdmin or Admin)
        public string PhoneNumber { get; set; } // رقم المدير
        public string Address { get; set; } // عنوان السكن
    }
}
