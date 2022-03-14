using SomerenLogic;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SomerenUI
{
    public partial class SomerenUI : Form
    {
        public SomerenUI()
        {
            InitializeComponent();
        }

        private void SomerenUI_Load(object sender, EventArgs e)
        {
            // call method showpanel and send the panel name
            showPanel("Dashboard");
        }

        private void showPanel(string panelName)
        {
            if (panelName == "Dashboard")
            {
                // hide all other panels
                pnlStudents.Hide();
                pnlRooms.Hide();
                pnlTeachers.Hide();
                pnlDrinks.Hide();
                pnlCashRegister.Hide();

                // show dashboard
                pnlDashboard.Show();
                imgDashboard.Show();
            }
            else if (panelName == "Students")
            {
                // hide all other panels
                pnlDashboard.Hide();
                imgDashboard.Hide();
                pnlRooms.Hide();
                pnlTeachers.Hide();
                pnlDrinks.Hide();
                pnlCashRegister.Hide();

                // show students
                pnlStudents.Show();

                try
                {
                    // fill the students listview within the students panel with a list of students
                    StudentService studService = new StudentService(); 
                    List<Student> studentList = studService.GetStudents();

                    // clear the listview before filling it again
                    listViewStudents.Clear();

                    // give the columns appropriate names
                    listViewStudents.View = View.Details;
                    listViewStudents.Columns.Add("Student ID", 100);
                    listViewStudents.Columns.Add("Name", 100);
                    listViewStudents.Columns.Add("Language", 100);
                    listViewStudents.Columns.Add("Date Of Birth", 100);
                    listViewStudents.Columns.Add("Student Room ID", 100);

                    // check each student in the student list and show the contents of the database in the UI
                    foreach (Student s in studentList)
                    {
                        ListViewItem liStudents = new ListViewItem(s.StudentId.ToString());
                        liStudents.SubItems.Add(s.StudentName);
                        liStudents.SubItems.Add(s.StudentLanguage);
                        liStudents.SubItems.Add(s.StudentDateOfBirth.ToString("dd/MM/yyyy"));
                        liStudents.SubItems.Add(s.StudentRoomId.ToString());
                        listViewStudents.Items.Add(liStudents);
                    }
                }
                catch (Exception e)
                {
                    // catch a error when something went wrong with the UI
                    MessageBox.Show("Something went wrong while loading the students: " + e.Message);
                }
            }
            else if (panelName == "Rooms")
            {
                // hide all other panels
                pnlDashboard.Hide();
                imgDashboard.Hide();
                pnlStudents.Hide();
                pnlTeachers.Hide();
                pnlDrinks.Hide();
                pnlCashRegister.Hide();

                // show rooms
                pnlRooms.Show();

                try
                {
                    // fill the rooms listview within the rooms panel with a list of rooms
                    RoomService roomService = new RoomService();
                    List<Room> roomList = roomService.GetRooms();

                    // clear the listview before filling it again
                    listViewRooms.Clear();

                    // give the columns appropriate names
                    listViewRooms.View = View.Details;
                    listViewRooms.Columns.Add("Room ID", 100);
                    listViewRooms.Columns.Add("Type of room", 100);
                    listViewRooms.Columns.Add("Capacity", 100);

                    // check each room in the roomList and show the contents of the database in the UI
                    foreach (Room r in roomList)
                    {
                        ListViewItem liRooms = new ListViewItem(r.RoomId.ToString());
                        liRooms.SubItems.Add(r.RoomType);
                        liRooms.SubItems.Add(r.RoomCapacity.ToString());
                        listViewRooms.Items.Add(liRooms);
                    }
                }
                catch (Exception e)
                {
                    // catch a error when something went wrong with the UI
                    MessageBox.Show("Something went wrong while loading the rooms: " + e.Message);
                }
            }
            else if (panelName == "Teachers")
            {
                // hide all other panels
                pnlDashboard.Hide();
                imgDashboard.Hide();
                pnlStudents.Hide();
                pnlRooms.Hide();
                pnlDrinks.Hide();
                pnlCashRegister.Hide();

                // show teachers
                pnlTeachers.Show();

                try
                {
                    // fill the teacher listview within the teachers panel with a list of teachers
                    TeacherService lecService = new TeacherService(); ;
                    List<Teacher> teacherList = lecService.GetTeachers(); ;

                    // clear the listview before filling it again
                    listViewTeachers.Clear();

                    // give the columns appropriate names
                    listViewTeachers.View = View.Details;
                    listViewTeachers.Columns.Add("Teacher ID", 100);
                    listViewTeachers.Columns.Add("Name", 100);
                    listViewTeachers.Columns.Add("Course", 100);

                    // check each teacher in the teacherlist and show the contents of the database in the UI
                    foreach (Teacher t in teacherList)
                    {
                        ListViewItem liTeachers = new ListViewItem(t.TeacherId.ToString());
                        liTeachers.SubItems.Add(t.TeacherName);
                        liTeachers.SubItems.Add(t.TeacherCourse);
                        listViewTeachers.Items.Add(liTeachers);

                    }

                }
                catch (Exception e)
                {
                    // catch a error when something went wrong with the UI
                    MessageBox.Show("Something went wrong while loading the students: " + e.Message);
                }
            }
            else if (panelName == "Drinks")
            {
                // hide all other panels
                pnlDashboard.Hide();
                imgDashboard.Hide();
                pnlStudents.Hide();
                pnlRooms.Hide();
                pnlTeachers.Hide();
                pnlCashRegister.Hide();

                // show drinks
                pnlDrinks.Show();

                try
                {
                    // fill the drink listview within the drinks panel with a list of drinks
                    DrinkService drinkService = new DrinkService(); ;
                    List<Drink> drinkList = drinkService.GetDrinks(); ;

                    // clear the listview before filling it again
                    listViewDrinks.Clear();

                    // give the columns appropriate names
                    listViewDrinks.View = View.Details;
                    listViewDrinks.Columns.Add("Drink ID", 100);
                    listViewDrinks.Columns.Add("Name", 100);
                    listViewDrinks.Columns.Add("Price", 100);
                    listViewDrinks.Columns.Add("Stock", 100);
                    listViewDrinks.Columns.Add("VAT", 100);

                    // check each drink in the drinklist and show the contents of the database in the UI
                    foreach (Drink d in drinkList)
                    {
                        ListViewItem liDrinks = new ListViewItem(d.DrinkId.ToString());
                        liDrinks.SubItems.Add(d.DrinkName);
                        liDrinks.SubItems.Add(d.DrinkPrice.ToString());
                        liDrinks.SubItems.Add(d.DrinkStock.ToString());
                        liDrinks.SubItems.Add(d.DrinkVAT.ToString());

                        listViewDrinks.Items.Add(liDrinks);
                    }

                }
                catch (Exception e)
                {
                    // catch a error when something went wrong with the UI
                    MessageBox.Show("Something went wrong while loading the students: " + e.Message);
                }
            }
            else if(panelName == "Cash Register")
            {
                // hide all other panels
                pnlDashboard.Hide();
                imgDashboard.Hide();
                pnlStudents.Hide();
                pnlRooms.Hide();
                pnlTeachers.Hide();
                pnlDrinks.Hide();

                // show drinks
                pnlCashRegister.Show();

                try
                {
                    // fill the drink listview within the drinks panel with a list of drinks
                    StudentService studentService = new StudentService();
                    DrinkService drinkService = new DrinkService();

                    List<Student> studentList = studentService.GetStudents();
                    List<Drink> drinkList = drinkService.GetDrinks();

                    // clear the listview before filling it again
                    listViewCashRegisterStudents.Clear();
                    listViewCashRegisterDrinks.Clear();

                    // give the columns appropriate names
                    listViewCashRegisterStudents.View = View.Details;
                    listViewCashRegisterDrinks.View = View.Details;

                    listViewCashRegisterStudents.Columns.Add("Student ID", 100);
                    listViewCashRegisterStudents.Columns.Add("Name", 100);
                    listViewCashRegisterStudents.Columns.Add("Date Of Birth", 100);

                    listViewCashRegisterDrinks.Columns.Add("Drink ID", 100);
                    listViewCashRegisterDrinks.Columns.Add("Name", 50);
                    listViewCashRegisterDrinks.Columns.Add("Price", 50);
                    listViewCashRegisterDrinks.Columns.Add("Stock", 50);
                    listViewCashRegisterDrinks.Columns.Add("VAT", 50);

                    // check each drink in the drinklist and show the contents of the database in the UI
                    foreach (Student s in studentList)
                    {
                        ListViewItem liStudents = new ListViewItem(s.StudentId.ToString());
                        liStudents.SubItems.Add(s.StudentName);
                        liStudents.SubItems.Add(s.StudentDateOfBirth.ToString("dd/MM/yyyy"));

                        listViewCashRegisterStudents.Items.Add(liStudents);
                    }

                    foreach (Drink d in drinkList)
                    {
                        ListViewItem liDrinks = new ListViewItem(d.DrinkId.ToString());
                        liDrinks.SubItems.Add(d.DrinkName);
                        liDrinks.SubItems.Add(d.DrinkPrice.ToString());
                        liDrinks.SubItems.Add(d.DrinkStock.ToString());
                        liDrinks.SubItems.Add(d.DrinkVAT.ToString());

                        listViewCashRegisterDrinks.Items.Add(liDrinks);
                    }

                }
                catch (Exception e)
                {
                    // catch a error when something went wrong with the UI
                    MessageBox.Show("Something went wrong while loading the students: " + e.Message);
                }
            }
        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dashboardToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // call method showpanel and send the panel name
            showPanel("Dashboard");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void imgDashboard_Click(object sender, EventArgs e)
        {
            MessageBox.Show("What happens in Someren, stays in Someren!");
        }

        private void studentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // call method showpanel and send the panel name
            showPanel("Students");
        }

        private void roomsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // call method showpanel and send the panel name
            showPanel("Rooms");
        }

        private void lecturersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // call method showpanel and send the panel name
            showPanel("Teachers");
        }

        private void pnlTeachers_Paint(object sender, PaintEventArgs e)
        {

        }

        private void drinksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("Drinks");
        }

        private void cashRegisterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("Cash Register");
        }
    }
}
