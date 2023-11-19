
namespace ChallengeApp.Tests
{
    public class TypeTest
    {
        [Test]
        public void CompareTwoFloatNumber_SchouldtBeTheSame()
        {
            // arrange
            float value1 = 3.14F;
            float value2 = 3.14F;

            //act

            //assert
            Assert.AreEqual(value1, value2);
        }
        [Test]
        public void CompareTwoString_SchoulNotdtBeTheSame()
        {
            // arrange
            string pass1 = "1234";
            string pass2 = "4321";

            //act

            //assert
            Assert.AreNotEqual(pass1, pass2);
        }
        [Test]
        public void CompareTwoValue_SchouldNotBeTheSame()
        {
            // arrange
            int number1 = 4;
            int number2 = 6;

            //act

            //assert
            Assert.AreNotEqual(number1, number2);
        }
        [Test]
        public void CompareUserName_ScouldNotBeTheSame()
        {
            // arrange
            var empl1 = GetEmployee("Ania", "AniaAnia", "35");
            var empl2 = GetEmployee("Kasia", "KasiaKasia", "30");

            //act

            //assert
            Assert.AreNotEqual(empl1.Name, empl2.Name);
        }

        private Employee GetEmployee(string name, string username, string age)
        {
            return new Employee(name, username, age);
        }
    }
}
