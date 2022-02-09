namespace Uge1
{
    public class Teacher: Person {
        
        Lecture course;
        public Teacher (string givenName) : 
            base (givenName, 9000 , "DIKU", 2100) {

        }         
        
        public Lecture GetCourse () {
            return course;
        }

        public void SetCourse (Lecture newCourse) {
            this.course = newCourse;
        }        
    }
}