namespace StudentRegisterForm {
    internal class Course {
        public int Id { get; set; }
        public string Name { get; set; }
        public Course(string name, int id) {
            Name = name;
            Id = id;
        }

        public override string ToString() => Name;
    }
}
