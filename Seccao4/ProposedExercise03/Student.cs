using System.Globalization;

namespace ProposedExercise03
{
    class Student
    {
        public string Name;
        public double FirstTrimester;
        public double SecondTrimester;
        public double ThirdTrimester;

        public double FinalGrade()
        {
            return FirstTrimester + SecondTrimester + ThirdTrimester;
        }

        public bool ApprovedOrNotApproved()
        {
            if (FinalGrade() >= 60.0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double MissingPoints()
        {
            if (ApprovedOrNotApproved())
            {
                return 0.0;
            }
            else
            {
                return 60.0 - FinalGrade();
            }
        }
    }
}
