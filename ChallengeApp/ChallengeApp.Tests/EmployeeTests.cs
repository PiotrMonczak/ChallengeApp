

namespace ChallengeApp.Tests
{
    public class EmployeeTests
    {
        [Test]
        public void ValueMax_ShouldBeEqual()
        {
            // arrange przygotowanie
            var emp1 = new Employee();
            emp1.AddGrade(41);
            emp1.AddGrade(23);
            emp1.AddGrade(17);

            //act uruchomienie
            var statistics = emp1.GetStatistics();
            Assert.AreEqual(41, statistics.Max);

            //assert sprawdzenie
        }

        [Test]
        public void ValueMin_ShouldBeEqual()
        {
            // arrange przygotowanie
            var emp1 = new Employee();
            emp1.AddGrade(34);
            emp1.AddGrade(51);
            emp1.AddGrade(7);

            //act uruchomienie
            var statistics = emp1.GetStatistics();
            Assert.AreEqual(7, statistics.Min);

            //assert sprawdzenie
        }

        [Test]
        public void ValueAverage_ShouldBeEqual()
        {
            // arrange przygotowanie
            var emp1 = new Employee();
            emp1.AddGrade(24);
            emp1.AddGrade(31);
            emp1.AddGrade(54);

            //act uruchomienie
            var statistics = emp1.GetStatistics();
            Assert.AreEqual(Math.Round(36.33, 2), Math.Round(statistics.Average, 2));

            //assert sprawdzenie
        }

        [Test]
        public void AverageLetter_ShouldBeEqualB()
        {
            // arrange przygotowanie
            var emp1 = new Employee();
            emp1.AddGrade(24);
            emp1.AddGrade(31);
            emp1.AddGrade(54);

            //act uruchomienie
            var statistics = emp1.GetStatistics();
            Assert.AreEqual('D', statistics.AverageLetter);

            //assert sprawdzenie
        }
    }
}
