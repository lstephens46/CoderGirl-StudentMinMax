namespace StudentMinMax
{
    public class Student
    {
        //values for the student class are populated from the included studentdata.txt file. 
        //The student’s name is the first thing on each line, followed by some exam scores. 
        //The number of scores might be different for each student.  
        //The program should calculate the minimum and maximum score for each student and print out their name as well.
        public string Name { get; set; }

        public int[] Scores { get; set; }

        public int? GetMaximumScore()
        {
            int maxScore = 0;
            foreach (int score in Scores)
            {
                if (score > maxScore)
                {
                    maxScore = score;
                }
            }

            return maxScore;
        }

        public int? GetMinimumScore()
        {
            int minScore = 100;
            foreach (int score in Scores)
            {
                if (score < minScore)
                {
                    minScore = score;
                }
            }

            return minScore;
        }
    }
}