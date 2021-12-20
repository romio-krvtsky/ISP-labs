namespace ClassLibrary2
{
    public class LearningCourse
    {
        public byte Id { get; set; }
        public string Subject { get; set; }
        public int Students { get; set; }
        public static byte TotalAmount { get; set; }

        public LearningCourse(byte id, string sbj, int students)
        {
            Id = id;
            Subject = sbj;
            Students = students;
        }

        public static bool Checks(LearningCourse lc)
        {
            if (lc.Students == 0)
                return false;
            ++TotalAmount;
            return true;
        }
    }
}