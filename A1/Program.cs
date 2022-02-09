using System;

namespace A1 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello World!");
            Person NytClassroom = new Person("SU", 20, "DIKU", 2100);
            NytClassroom.PrintInfo1();
            NytClassroom.PrintInfo2();
        }
    }
}
