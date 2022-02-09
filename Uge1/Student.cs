namespace Uge1
{
    public class Student : Person {
        Lecture course;
        int semester;
        public Student (string course, string givenName, int givenAge, string Address, int ZipNumber) : 
            base (givenName, givenAge, Address, ZipNumber) {

        } 

        public Lecture GetCourse () {
            return course;
        }

        public void SetCourse (Lecture newCourse) {
            this.course = newCourse;
        }

        public void JoinNextSemester() {
            semester++;
        }
    }
}