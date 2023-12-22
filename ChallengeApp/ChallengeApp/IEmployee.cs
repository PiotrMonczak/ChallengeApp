

namespace ChallengeApp
{
    public interface IEmployee
    {
        public string Name { get; }

        public string Surname { get; }


        void AddGrade(float grade);

        void AddGrade(double grade);

        void AddGrade(int grade);

        void AddGrade(char grade);

        void AddGrade(string grade);

        Statistics GetStatistics();
    }
}
