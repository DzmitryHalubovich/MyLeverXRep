using System;
using System.Collections.Generic;
using Xunit;
using Xunit.Abstractions;

namespace CommonTests
{
    public class IEquotableTests
    {
        /*
            +IComparer
            +IComparable
            IEqualityComparer
            +IEquotable
            +/-MemberwiseClone
         */

        private readonly ITestOutputHelper _console;

        public IEquotableTests(ITestOutputHelper console)
        {
            _console = console;
        }

        //[Fact]
        //public void Test1()
        //{
        //    var s1 = new Student { FullName = "Ivan Lukyanau", Age = 33 };
        //    var s2 = new Student { FullName = "Ivan Lukyanau", Age = 33 };

        //    var result = s1.Equals(s2);

        //    Assert.True(result);
        //}

        //[Fact]
        //public void Test2()
        //{
        //    var s1 = new Student { FullName = "Ivan Lukyanau", Age = 33 };
        //    var s2 = new Student { FullName = "Ivan Lukyanau", Age = 33 };
        //    var s3 = new Student { FullName = "Ivan Lukyanau", Age = 32 };
        //    var s4 = new Student { FullName = "Ivan Lukyanau", Age = 32 };

        //    var list = new List<Student> { s1, s2, s3 };

        //    Assert.Equal(s3,s4);

        //    list.Remove(s4);

        //    Assert.True(list.Count == 2);
        //}

        //class Student : IEquatable<Student>
        //{
        //    public string FullName { get; set; }
        //    public int Age { get; set; }

        //    public bool Equals(object? other)
        //    public bool Equals(Student? other)
        //    {
        //        return other.Age == Age &&
        //               other.FullName.Equals(FullName, StringComparison.OrdinalIgnoreCase);
        //    }
        //}
    }
}