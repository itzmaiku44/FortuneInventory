using System;

namespace FortuneInventory
{
    public static class UserSession
    {
        public static int? CurrentUserId { get; set; }
        public static string? CurrentUserName { get; set; }

        public static void Clear()
        {
            CurrentUserId = null;
            CurrentUserName = null;
        }
    }
}

