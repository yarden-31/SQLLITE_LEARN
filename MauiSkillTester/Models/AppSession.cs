using System;
using System.Collections.Generic;
using System.Text;
using MauiSkillTester.Models;



namespace MauiSkillTester
{
    // שלב 2 שמירה של פרטי המשתמש המחובר כרגע, כדי לאפשר גישה נוחה למידע זה מכל מקום באפליקציה. 
    public static class AppSession
    {
        // ישמור את פרטי המשתמש המחובר כרגע (או null אם אף אחד לא מחובר)
        public static User CurrentUser { get; set; }

        // בדיקה מהירה האם המשתמש הנוכחי הוא מנהל
        public static bool IsAdmin => CurrentUser != null && CurrentUser.Role == "Admin";
    }
}