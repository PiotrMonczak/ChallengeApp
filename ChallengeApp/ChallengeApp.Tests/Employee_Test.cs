

namespace ChallengeApp.Tests
{
    public class Tests
    {
       
        [Test]
        public void EmployeeCollctScore_ShouldCorrect_Value()
        {
            // arrange
            var employee = new Employee("Ania", "AniaAnia", "35");
            employee.AddScore(7);
            employee.AddScore(-7);

            //act
            var result = employee.Result;

            //assert
            Assert.AreEqual(0, result);
        }

        [Test]
        public void EmployeeCollctMoreScore_ShouldCorrect_Value()
        {
            // arrange
            var employee = new Employee("Ania", "AniaAnia", "35");
            employee.AddScore(12);
            employee.AddScore(-7);
            employee.AddScore(4);

            //act
            var result = employee.Result;

            //assert
            Assert.AreEqual(9, result);
        }
    }
}