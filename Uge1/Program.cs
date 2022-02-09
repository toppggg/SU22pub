using System;

namespace Uge1 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello World!");
            Student RandomStudent = new Student("Datalogi", "Mit Navn", 20, "DIKU", 2100);
            RandomStudent.PrintInfo1();
            RandomStudent.PrintInfo2();
            Lecture SU = new Lecture("Softwareudvikling");
            Teacher ATeacher = new Teacher("Lærer navn");
            ATeacher.SetCourse(SU);
            ATeacher.PrintInfo2(); // Denne funktion returnerer ikke noget, men printer direkte.
            System.Console.WriteLine(ATeacher.GetCourse().GetName()); // funktionen returnerer string

        }
    }
}
