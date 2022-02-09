namespace Uge1
{
    public class Lecture : ClassRoom {
        private string agenda;
        private Teacher teacher;

        public Lecture(string name) : base (name) {

        }

        public string GetAgenda() {
            return agenda;
        }

        public void SetAgenda(string newAgenda) {
            agenda = newAgenda;
        }
        public void AssignTeacher(Teacher newTeacher) {
            teacher = newTeacher;
        }
    }
}