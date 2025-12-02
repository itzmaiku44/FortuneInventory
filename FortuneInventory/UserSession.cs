using System;

namespace FortuneInventory
{
    public static class UserSession
    {
        public static int? CurrentUserId { get; set; }
        public static string? CurrentUserName { get; set; }
        public static int? CurrentUserRoleId { get; set; } // 1 = Admin, 2 = Staff
        public static bool IsAdmin => CurrentUserRoleId == 1;

        public static void Clear()
        {
            CurrentUserId = null;
            CurrentUserName = null;
            CurrentUserRoleId = null;
        }
    }
}

