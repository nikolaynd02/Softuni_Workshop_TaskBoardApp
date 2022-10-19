namespace Workshop_TaskBoardApp.Data.Models
{
    public static class Constants
    {
        public static class User
        {
            public const int MaxFirstName = 15;
            public const int MaxLastName = 15;
        }

        public static class Task
        {
            public const int MaxTitle = 70;
            public const int MinTitle = 5;

            public const int MaxDescription = 1000;
            public const int MinDescription = 10;
        }

        public static class Board
        {
            public const int MaxName = 30;
            public const int MinName = 3;
        }
    }
}
