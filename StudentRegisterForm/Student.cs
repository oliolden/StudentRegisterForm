namespace StudentRegisterForm {
    internal class Student {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Date { get; set; }

        public Student(string firstName, string lastName, string date, string? id = null) {
            FirstName = firstName;
            LastName = lastName;
            Date = date;
            if (id == null) Id = date + firstName.ToLower()[0] + lastName.ToLower()[0];
            else Id = id;
        }

        public override string ToString() => Id;
        public string GetName() { return FirstName + " " + LastName; }
    }
}
