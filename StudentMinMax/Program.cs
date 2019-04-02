using System;
using System.Collections.Generic;
using System.IO;

namespace StudentMinMax
{
    public static class Program
    {
        //values for the student class are populated from the included studentdata.txt file. 
        //The student’s name is the first thing on each line, followed by some exam scores. 
        //The number of scores might be different for each student.  
        //The program should calculate the minimum and maximum score for each student and print out their name as well.
        public static void Main()
        {
            
            List<Student> studentList = CreateStudentList();
            foreach (var student in studentList)
            {
                
                Console.WriteLine($"{student.Name} Min: {student.GetMinimumScore()} Max: {student.GetMaximumScore()}");
            }

            Console.ReadLine();
        }


        //This is a method named CreateStudentList() with a return type of List<Student>
        private static List<Student> CreateStudentList()
        {
            //create new <Student> List object 
            List<Student> studentList = new List<Student>();

            //For every line in the file create a student and add the student to the studentList 
            foreach (string line in File.ReadLines(@"C:\cg\LESSON_09\CoderGirl-StudentMinMax\StudentMinMax\studentdata.txt"))
            {
                //for every line in the file call the CreateStudent() and assign the return value to a new Student object with the name student.
                Student student = CreateStudent(line);
                
                //add each line as a student to the studentList
                studentList.Add(student);

            }
            //return the value from calling this method to a variable with the type of List<student> studentList
            return studentList;
        }


        //Method that creates a new student object from each line in file  ---> When you call this method in the Main() using the foreach it runs this method for however many lines are in the text file.  That is determined by 
        private static Student CreateStudent(string line)
        {

            //Create new student must !! MUST FIRST CREATE STUDENT.CS!! for this to work 
            Student student = new Student();
            
            //create a new string array by splitting the line by the " "

            //!! And remember by calling this CreateStudent() method from within a foreach statement in Main() it is called every time the foreach iterates through the data, so once for each line.
            string[] sData = line.Split(" ");

            //Create new int array named scores and declare the size of the array that you are creating by [sData - 1], so number of items in each line -1 because we know the first one is the name
            int[] scores = new int[sData.Length - 1];

            //After creating your seperate Student class file and declaring the properties for the Student.cs assign the item at index[0] of each line to the name property
            student.Name = sData[0];

            //then since we know that the first item in each line in the text file is the name we start i = 1, because student.Name = sData[0], if we start at 0 we will overwrite that data, so for the remaining items in that line( determined by the inital length of the string array(sData) assign each index [0] [1] [2] etc. Remember this is a different array than the string array, and all arrays must have a [0] index, and arrays can only hold one value type 
            for (int i = 1; i < sData.Length; i++)
            {
                //so for the scores we assign each index to the parsed value of the parsed value from the string array sData.
                scores[i - 1] = int.Parse(sData[i]);
            }
            //assign the scores(which is an int[] as the property Scores(Scores is defined in the Student.cs file as an int [] , foreach student
            student.Scores = scores;
            //return student object
            return student;
        }
    }
}