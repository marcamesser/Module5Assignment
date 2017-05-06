namespace Module5Assignment
{
    public class Teacher
    {
        public static int TCount;
        // constructor
        public Teacher(string TFName, string TLName, int TID)
        {
            this.FirstName = TFName;
            this.LastName = TLName;
            this.TeacherID = TID;
            TCount++;
        }

        // the following statements declare private member variables
        private string _FirstName;

        private string _LastName;

        private int _TeacherID;

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

        public int TeacherID
        {
            get => _TeacherID;
            set => _TeacherID = value;
        }
    }
}