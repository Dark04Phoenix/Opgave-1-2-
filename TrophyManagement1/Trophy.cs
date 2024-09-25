using System;

namespace TrophyManagement1
{
    public class Trophy
    {
        private int _id;
        private string _competition;
        private int _year;

        public int Id
        {
            get => _id;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Id must be greater than 0.");
                }
                _id = value;
            }
        }

        public string Competition
        {
            get => _competition;
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 3)
                {
                    throw new ArgumentException("Competition must be at least 3 characters long and cannot be null.");
                }
                _competition = value;
            }
        }

        public int Year
        {
            get => _year;
            set
            {
                if (value < 1970 || value > 2024)
                {
                    throw new ArgumentOutOfRangeException("Year must be between 1970 and 2024.");
                }
                _year = value;
            }
        }

        public Trophy(int id = 1, string competition = "Default Competition", int year = 1970)
        {
            Id = id;
            Competition = competition;
            Year = year;
        }

        public override string ToString()
        {
            return $"Trophy Id: {Id}, Competition: {Competition}, Year: {Year}";
        }
    }
}