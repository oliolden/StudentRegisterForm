using System.Data.SQLite;
using System.IO;
using System.Reflection.Metadata;

namespace StudentRegisterForm {
    internal class StudentRegister {
        private SQLiteConnection connection;
        private SQLiteCommand command;
        public StudentRegister() {
            connection = new SQLiteConnection("URI=file:" + "students.db");
            command = connection.CreateCommand();
        }

        public void AddStudent(Student student) {
            connection.Open();
            command.CommandText = string.Format("INSERT INTO students(id, first_name, last_name, date) VALUES('{0}', '{1}', '{2}', '{3}');", student.Id, student.FirstName, student.LastName, student.Date);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public Course[] GetCourses() {
            connection.Open();
            command.CommandText = "SELECT * FROM courses";
            Course[] result = ReadCourses(command.ExecuteReader());
            connection.Close();
            return result;
        }

        public void AddCourse(string name) {
            connection.Open();
            command.CommandText = string.Format("INSERT INTO courses(name) VALUES('{0}');", name);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void UpdateCourse(int id, string name) {
            connection.Open();
            command.CommandText = $"UPDATE courses SET name = '{name}' WHERE id = '{id}'";
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void AddStudentCourse(string studentId, int courseId) {
            connection.Open();
            command.CommandText = $"INSERT INTO student_course(student, course) VALUES('{studentId}', '{courseId}')";
            command.ExecuteNonQuery();
            connection.Close();
        }

        public Student[] Find(string search) {
            connection.Open();
            command.CommandText = string.Format("SELECT * FROM students WHERE first_name LIKE '%{0}%' OR last_name LIKE '%{0}%' OR date LIKE '%{0}%'", search);
            Student[] result = ReadStudents(command.ExecuteReader());
            connection.Close();
            return result;
        }

        public Student[] GetStudents() {
            connection.Open();
            command.CommandText = "SELECT * FROM students";
            Student[] result = ReadStudents(command.ExecuteReader());
            connection.Close();
            return result;
        }

        public Student FindId(string id) {
            connection.Open();
            command.CommandText = string.Format("SELECT * FROM students WHERE id = '{0}'", id);
            Student[] result = ReadStudents(command.ExecuteReader());
            connection.Close();
            if (result.Length == 1) {
                return result[0];
            }
            else return null;
        }

        private Student[] ReadStudents(SQLiteDataReader reader) {
            List<Student> result = new List<Student>();
            while (reader.Read()) {
                result.Add(new Student(reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(0)));
            }
            reader.Close();
            return result.ToArray();
        }
        
        private Course[] ReadCourses(SQLiteDataReader reader) {
            List<Course> result = new List<Course>();
            while (reader.Read()) {
                result.Add(new Course(reader.GetString(1), reader.GetInt32(0)));
            }
            reader.Close();
            return result.ToArray();
        }

        public void UpdateStudent(string id, string firstName, string lastName, string date) {
            connection.Open();
            command.CommandText = $"UPDATE students SET first_name = '{firstName}', last_name = '{lastName}', date = '{date}' WHERE id = '{id}'";
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void DeleteStudent(string id) {
            connection.Open();
            command.CommandText = string.Format("DELETE FROM students WHERE id='{0}'", id);
            connection.Close();
        }

        public void DeleteCourse(string id) {
            connection.Open();
            command.CommandText = string.Format("DELETE FROM courses WHERE id='{0}'", id);
            connection.Close();
        }

        public Course[] GetStudentCourses(string id) {
            return null;
        }
    }
}
