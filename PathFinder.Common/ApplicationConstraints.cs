﻿namespace PathFinder.Common
{
    public static class ApplicationConstraints
    {
        public static class UserConstraints
        {
            public const int UserFirstNameMinLength = 2;
            public const int UserFirstNameMaxLength = 70;

            public const int UserLastNameMinLength = 10;
            public const int UserLastNameMaxLength = 70;

            public const int UserAddressMinLength = 20;
            public const int UserAddressMaxLength = 100;

            public const string UserBirthDateDateTimeFormat = "yyyy-MM-dd";
        }

        public static class CourseConstraints
        {
            public const int CourseNameMinLength = 4;
            public const int CourseNameMaxLength = 70;

            public const int CourseLocationMinLength = 5;
            public const int CourseLocationMaxLength = 100;

            public const int CourseDescriptionMaxLength = 800;

            public const int CourseStarRatingMaxValue = 5;
            public const int CourseStarRatingMinValue = 1;

            public const string StartDateDateTimeFormat = "yyyy-MM-dd";
            public const string EndDateDateTimeFormat = "yyyy-MM-dd";

        }

        public static class JobConstraints
        {
            public const int JobDescriptionMaxLength = 800;

            public const int JobLocationMinLength = 5;
            public const int JobLocationMaxLength = 100;

            public const int JobTitleMinLength = 2;
            public const int JobTitleMaxLength = 80;

            public const int JobPositionMinLength = 3;
            public const int JobPositionMaxLength = 50;
        }

        public static class ReviewConstraints
        {
            public const int ReviewCommentMaxLength = 750;

            public const string ReviewDateDateTimeFormat = "yyyy-MM-dd";
        }

        public static class RecommendationConstraints
        {
            public const string SuggestedOnDateTimeFormat = "yyyy-MM-dd";
        }

        public static class RoleRequestConstraints
        {
            public const int SenderMinLength = 5;
            public const int SenderMaxLength = 70;

            public const int DescriptionMinLength = 10;
            public const int DescriptionMaxLength = 450;
        }
    }
}
