using WinFormsApp1.Models;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private UniversityContext context;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            context = new UniversityContext();
            dataGridView1.DataSource = context.Students.ToList();

            button1.Click += SearchButton;
            button2.Click += ResetButton;
            button3.Click += AddButton;
        }

        private void ResetButton(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
        }
         private void SearchButton(object sender, EventArgs e)
        {
            var searchTxt = textBox1.Text;
            var FilteredStudents = context.Students
                                   .Where(s=> s.StudName.Contains( searchTxt)).ToList();

            dataGridView1 .DataSource = FilteredStudents;
        }

        private void AddButton(object sender, EventArgs e)
        {
            int studID= int.Parse(textBox2.Text);
            string name=textBox3.Text;
            string DepName=textBox4.Text;
            string DepartmentID = context.Departments.Where(d => d.DepName == DepName).Select(d => d.DepId).FirstOrDefault();

            Student newStudent = new Student
            {
                Id = studID,
                StudName = name,
                DepID = DepartmentID
            };
            context.Students.Add(newStudent);
            context.SaveChanges();
            dataGridView1.DataSource=context.Students.ToList();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}