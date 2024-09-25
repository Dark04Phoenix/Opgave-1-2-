using System;
using System.Collections.Generic;
using System.Linq;

namespace TrophyManagement1
{
    public class TrophiesRepository
    {
        private List<Trophy> _trophies;

        public TrophiesRepository()
        {
            _trophies = new List<Trophy>
            {
                new Trophy(1, "Olympics", 2021),
                new Trophy(2, "World Cup", 2018),
                new Trophy(3, "Champions League", 2020),
                new Trophy(4, "World Championship", 2022),
                new Trophy(5, "Euro Cup", 2016)
            };
        }

        public List<Trophy> Get(int? year = null, string sortBy = null)
        {
            var result = _trophies.AsQueryable();

            if (year.HasValue)
            {
                result = result.Where(t => t.Year == year.Value);
            }

            if (!string.IsNullOrEmpty(sortBy))
            {
                result = sortBy.ToLower() switch
                {
                    "competition" => result.OrderBy(t => t.Competition),
                    "year" => result.OrderBy(t => t.Year),
                    _ => result
                };
            }

            return result.ToList();
        }

        public Trophy GetById(int id)
        {
            return _trophies.FirstOrDefault(t => t.Id == id);
        }

        public Trophy Add(Trophy trophy)
        {
            trophy.Id = _trophies.Count == 0 ? 1 : _trophies.Max(t => t.Id) + 1;
            _trophies.Add(trophy);
            return trophy;
        }

        public Trophy Remove(int id)
        {
            var trophy = GetById(id);
            if (trophy != null)
            {
                _trophies.Remove(trophy);
            }
            return trophy;
        }

        public Trophy Update(int id, Trophy values)
        {
            var trophy = GetById(id);
            if (trophy != null)
            {
                trophy.Competition = values.Competition;
                trophy.Year = values.Year;
            }
            return trophy;
        }
    }
}