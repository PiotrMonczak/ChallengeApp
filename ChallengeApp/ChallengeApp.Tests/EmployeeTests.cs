

namespace ChallengeApp.Tests
{
    public class EmployeeTests
    {
        [Test]
        public void ValueMax_ShouldBeEqual()
        {
            // arrange przygotowanie
            var emp1 = new Employee("Ania", "AniaAnia");
            emp1.AddGrade(4);
            emp1.AddGrade(1);
            emp1.AddGrade(7);

            //act uruchomienie
            var statistics = emp1.GetStatistics();
            Assert.AreEqual(7, statistics.Max);

            //assert sprawdzenie

        }


        [Test]
        public void ValueMin_ShouldBeEqual()
        {
            // arrange przygotowanie
            var emp1 = new Employee("Ania", "AniaAnia");
            emp1.AddGrade(4);
            emp1.AddGrade(1);
            emp1.AddGrade(7);

            //act uruchomienie
            var statistics = emp1.GetStatistics();
            Assert.AreEqual(1, statistics.Min);

            //assert sprawdzenie

        }

        [Test]
        public void ValueAverage_ShouldBeEqual()
        {
            // arrange przygotowanie
            var emp1 = new Employee("Ania", "AniaAnia");
            emp1.AddGrade(4);
            emp1.AddGrade(1);
            emp1.AddGrade(7);

            //act uruchomienie
            var statistics = emp1.GetStatistics();
            Assert.AreEqual(4, statistics.Average);

            //assert sprawdzenie

        }
    }
}
