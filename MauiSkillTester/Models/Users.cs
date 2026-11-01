using SQLite;

namespace MauiSkillTester.Models
{
    // שלב 1 : יצירת מודל נתונים עבור משתמשים, כולל תכונות בסיסיות כמו שם משתמש, סיסמה, דוא"ל ותפקיד.

    [Table("Users")]
    public class User
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [Unique, NotNull]
        public string Username { get; set; } = string.Empty;

        [NotNull]
        public string Password { get; set; } = string.Empty;

        [NotNull]
        public string Email { get; set; } = string.Empty;

        // הגדרת תפקיד המשתמש: "Admin" או "Customer"
        [NotNull]
        public string Role { get; set; } = "Customer";
    }
}