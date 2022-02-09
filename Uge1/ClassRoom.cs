namespace Uge1
{
    public class ClassRoom {
        string name;
        string field2;
        public ClassRoom (string classRoomName) {
            name = classRoomName;
        }

        public string GetName () {
            return name;
        }
        
        public void SetName (string NewName) {
            name = NewName;
        }
    }
}