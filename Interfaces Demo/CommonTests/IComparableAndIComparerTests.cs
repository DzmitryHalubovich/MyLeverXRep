using System;
using System.Collections.Generic;
using Xunit;
using Xunit.Abstractions;

namespace CommonTests
{
    public class IComparableAndIComparerTests
    {

        private readonly ITestOutputHelper _console;

        public IComparableAndIComparerTests(ITestOutputHelper console)
        {
            _console = console;
        }

        [Fact]
        public void Test1()
        {
            var s1 = new Student { FullName = "Ivan Lukyanau", Age = 40 };
            var s2 = new Student { FullName = "Ivan Lukyanau", Age = 30 };
            var s3 = new Student { FullName = "Ivan Lukyanau", Age = 31 };
            var s4 = new Student { FullName = "Ivan Lukyanau", Age = 32 };
            var s5 = new Student { FullName = "Ivan Lukyanau", Age = 33 };
            
            var list = new List<Student> { s1, s2, s3, s4, s5 };

            list.Sort();

            for (int i = 0; i < list.Count; i++)
            {
                _console.WriteLine($"Index{i}: Ages: {list[i].Age}");
            }
        }


        [Fact]
        public void Test2()
        {
            var s1 = new Student { FullName = "Ivan Lukyanau", Age = 40, PassportData = 
                new PassportData { IssuedDate = DateTime.Now, ExpirationDate = DateTime.Now, Number = "123123" }
            };
            //var s2 = s1.Clone();
            var s2 = s1.MakeDeepCopy();

            _console.WriteLine($"FullName: {s1.FullName} and Ages: {s1.Age}," +
               $" IssuedDate: {s1.PassportData.IssuedDate}");
           _console.WriteLine($"FullName: {s2.FullName} and Ages: {s2.Age}," +
               $" IssuedDate: {s2.PassportData.IssuedDate}");

            s1.FullName = "Henadz Lukyanau";
            s1.PassportData.Number = "456456";

           
           
            Assert.Equal(s1.Age, s2.Age);
            //Assert.Equal(s1.FullName, s2.FullName);
            Assert.Equal(s1.PassportData.IssuedDate, s2.PassportData.IssuedDate);
            Assert.NotEqual(s1.PassportData.Number, s2.PassportData.Number);
        }

        class AscSorting : IComparer<Student>
        {
            public int Compare(Student? x, Student? y)
            {
                return x.Age > y.Age ? 1
                                     : x.Age < y.Age ? -1
                                                     : 0;
            }
        }

        class DescSorting : IComparer<Student>
        {
            public int Compare(Student? x, Student? y)
            {
                return x.Age > y.Age ? -1
                                     : x.Age < y.Age ? 1
                                                     : 0;
            }
        }

        // non-anemic models
        class Student : IComparable<Student>
        {
            public string FullName { get; set; }
            public int Age { get; set; }

            public PassportData PassportData { get; set; }

            //public Student(string issuedDate, int expirationDate, PassportData passportData)
            //{
            //    FullName = issuedDate;
            //    Age = expirationDate;
            //    PassportData = passportData;
            //}
            public Student MakeShallowCopy() { 
                return (Student)this.MemberwiseClone();
            }

            //public Student MakeDeepCopy()
            //{
            //    //var student.PassportData = new PassportData(issuedDate, expirationDate, passportNumber)
            //    //return (Student)this.MemberwiseClone();
            //    return (Student)this.MemberwiseClone();
            //}

            
            // MakeDeepCopy
            // var student.PassportData = new PassportData(issuedDate,expirationDate,passportNumber)
            public int CompareTo(Student? other)
            {
                /*
                 * 1
                 * 0
                 * -1
                 */
                return other.Age.CompareTo(Age);
            }

            //public object Clone() => new Student(FullName = this.FullName, Age = this.Age, new PassportData(this.PassportData.Number));

            public Student MakeDeepCopy()
            {
                var student = (Student)this.MemberwiseClone();
                student.PassportData = (PassportData)this.PassportData.Clone();
                return (Student)student;
            }
        }
    }
}
