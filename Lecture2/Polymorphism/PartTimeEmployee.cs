﻿namespace Polymorphism {
    class PartTimeEmployee : Employee {
        public double HourlyWage;
        public int HoursPerMonth;

        public PartTimeEmployee(string Name, double HourlyWage, int HoursPerMonth) : base(Name) {
            this.HourlyWage = HourlyWage;
            this.HoursPerMonth = HoursPerMonth;
        }

        public override double GetMonthlySalary() {
            return HoursPerMonth * HourlyWage;
        }
    }
}