﻿namespace HomeworkOne
{
    public class Employee : Member
    {
        private int yearHired = 0;

        public Employee()
        {
            Generate();
        }

        public Employee(int id) : base(id)
        {
            Generate(id);
        }

        protected string Department { get; set; } = string.Empty;

        public override void Generate()
        {
            base.Generate();
            Department = Names.department[random.Next(Names.department.Length)];
        }

        public override void Generate(int id)
        {
            base.Generate(id);
            Department = Names.department[random.Next(Names.department.Length)];
        }

        public string toString()
        {
            return base.toString() +
                   string.Format($"{Department}");
        }

        public string toString(bool value)
        {
            return (value ? "EMP " : "") + toString();
        }

        public string htmlRow()
        {
            return "<tr>" + htmlColumns() + "</tr>";
        }

        public string htmlColumns()
        {
            return base.htmlColumns() +
                   "<td>" + Department + "</td>";
        }
    }
}