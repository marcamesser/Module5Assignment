namespace Module5Assignment
{
    public class Student
    {
        public static int SCount = 0;
        // constructor
        public Student(string SFName, string SLName, int StID)
        {
            this.FirstName = SFName;
            this.LastName = SLName;
            this.StudentID = StID;
            SCount++;
        }

        // the following statements declare private member variables
        private string _FirstName;

        private string _LastName;

        private int _StudentID;

        public string FirstName
        {
            get => _FirstName;
            set => _FirstName = value;
        }

        public string LastName
        {
            get => _LastName;
            set => _LastName = value;
        }

        public int StudentID
        {
            get => _StudentID;
            set => _StudentID = value;
        }
    }
}