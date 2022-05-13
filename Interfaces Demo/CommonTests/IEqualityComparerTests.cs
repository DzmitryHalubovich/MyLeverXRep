using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace CommonTests
{
    public class IEqualityComparerTests
    {
        private readonly ITestOutputHelper _console;

        public IEqualityComparerTests(ITestOutputHelper console)
        {
            _console = console;
        }

        [Fact]
        public void Test1()
        {
            var s0 = new Student { FullName = "Ivan Lukyanau", Age = 40, AverageMark = 10 };
            var s1 = new Student { FullName = "Ivan Lukyanau", Age = 30, AverageMark = 9.2 };
            var s2 = new Student { FullName = "Ivan Lukyanau", Age = 33, AverageMark = 9.1 };
            var s3 = new Student { FullName = "Ivan Lukyanau", Age = 32, AverageMark = 8 };
            var s4 = new Student { FullName = "Ivan Lukyanau", Age = 33, AverageMark = 7 };
            var s5 = new Student { FullName = "Ivan Lukyanau", Age = 33, AverageMark = 9.1 };

            var dict = new Dictionary<Student, string>(new StudentEqualityComparer());
            dict.Add(s0, s0.ToString());
            dict.Add(s1, s1.ToString());
            dict.Add(s2, s2.ToString());
            dict.Add(s3, s3.ToString());
            dict.Add(s4, s4.ToString());
            dict.Add(s5, s5.ToString());


            for (int i = 0; i < dict.Count; i++)
            {
                _console.WriteLine($"Index{i}: {dict.ElementAt(i)}");
            }

            Assert.True(dict.Count == 5);
        }

        class StudentEqualityComparer : IEqualityComparer<Student>
        {
            public bool Equals(Student x, Student y)
            {
                if (x == null && y == null)
                    return true;
                else if (x == null || y == null)
                    return false;
                else if (x.Age == y.Age &&
                         x.FullName == y.FullName &&
                         x.AverageMark == y.AverageMark)
                    return true;
                else
                    return false;
            }

            public int GetHashCode([DisallowNull] Student obj)
            {
                return HashCode.Combine(obj.Age, obj.FullName, obj.AverageMark);
            }
        }

        class Student
        {
            public string FullName { get; set; }
            public int Age { get; set; }

            public double AverageMark { get; set; }

        }
    }
}
