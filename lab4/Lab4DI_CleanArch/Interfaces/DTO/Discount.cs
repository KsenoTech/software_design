﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Discount
    {
        DayOfWeek[] promotionDays = new DayOfWeek[] {DayOfWeek.Monday, DayOfWeek.Tuesday, DayOfWeek.Wednesday, DayOfWeek.Thursday};
        public Discount(decimal val)
        {
            _value = val;
        }

        private decimal _value = 0;
        public decimal Value { get { return _value; } }

        public decimal GetDiscountedPrice(decimal sum)
        {
            if (promotionDays.Contains( DateTime.Now.DayOfWeek ))
                return sum - sum * _value;
            return sum;
        }
    }
}
