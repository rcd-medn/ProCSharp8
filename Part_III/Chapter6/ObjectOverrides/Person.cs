




namespace ObjectOverrides
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string SSN { get; } = "";

        public Person() { }
        public Person(string name, string lastName, int age, string ssn)
        {
            FirstName = name;
            LastName = lastName;
            Age = age;
            SSN = ssn;
        }

        public override string ToString()
            => $"[First Name: {FirstName}; Last Name: {LastName}; Age: {Age}]";
        
        public override bool Equals(object obj)
            => obj?.ToString() == ToString();
        // public override bool Equals(object obj)
        // {   
        //     if (!(obj is Person tmp))
        //     {
        //         return false;
        //     }
            
        //     if (tmp.FirstName == this.FirstName && tmp.LastName == this.LastName && tmp.Age == this.Age)
        //     {
        //         return true;
        //     }
            
        //     return false;
        // }
        
        // override object.GetHashCode
        public override int GetHashCode()
            => SSN.GetHashCode();
    }
}
