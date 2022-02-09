namespace Uge1 {
    public class Person {
        
        private string name;
        int age; // automatisk private
        public int Age {
            get {
                return age;
            } 
            set {
                age = value;
            }
        }
        public string Name {get {return name;} set {name = value;} }        
        public string Address {get; set;}
        public int ZipNumber {get;}    // kan aldrig ændres   
        public string County {get; private set;} // kan læses udefra, men kun ændres internt

        public Person (string givenName, int givenAge, string Address, int ZipNumber) {
            name = givenName;
            age = givenAge;
            this.Address = Address;
            this.ZipNumber = ZipNumber;
            County = "København";
        }

        public void PrintInfo1() {
            System.Console.WriteLine(name + " is " + age + " years old, and lives at " + Address 
                + ", " + ZipNumber + " " + County);
        }

        public void PrintInfo2() {
            System.Console.WriteLine("{0} is {1} years old, and lives at {2}, {3} {4}", 
                name, age, Address, ZipNumber, County);
        }        
    }
}