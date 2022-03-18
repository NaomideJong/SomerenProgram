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
using System.Windows.Input;

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
            switch (panelName)
            {
                case "Dashboard":
                    HideAll();
                    pnlDashboard.Show();
                    imgDashboard.Show();
                    break;
                case "Students":
                    HideAll();
                    StudentsPanel();
                    break;
                case "Teachers":
                    HideAll();
                    TeachersPanel();
                    break;
                case "Rooms":
                    HideAll();
                    RoomsPanel();
                    break;
                case "Drinks":
                    HideAll();
                    DrinksPanel();
                    break;
                case "Cash Register":
                    HideAll();
                    CashRegisterPanel();
                    break;
            }
        }

        private void HideAll()
        {
            // hide all other panels
            pnlDashboard.Hide();
            imgDashboard.Hide();
            pnlStudents.Hide();
            pnlRooms.Hide();
            pnlTeachers.Hide();
            pnlDrinks.Hide();
            pnlCashRegister.Hide();
        }

        private void StudentsPanel()
        {
            // show students
            pnlStudents.Show();

            try
            {
                // fill the students listview within the students panel with a list of students
                StudentService studService = new StudentService();
                List<Student> studentList = studService.GetStudents();

                // clear the listview before filling it again
                listViewStudents.Items.Clear();

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

        private void TeachersPanel()
        {
            // show teachers
            pnlTeachers.Show();

            try
            {
                // fill the teacher listview within the teachers panel with a list of teachers
                TeacherService lecService = new TeacherService(); ;
                List<Teacher> teacherList = lecService.GetTeachers(); ;

                // clear the listview before filling it again
                listViewTeachers.Items.Clear();

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
                MessageBox.Show("Something went wrong while loading the teachers: " + e.Message);
            }
        }

        private void RoomsPanel()
        {
            // show rooms
            pnlRooms.Show();

            try
            {
                // fill the rooms listview within the rooms panel with a list of rooms
                RoomService roomService = new RoomService();
                List<Room> roomList = roomService.GetRooms();

                // clear the listview before filling it again
                listViewRooms.Items.Clear();

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

        private void DrinksPanel()
        {
            // show drinks
            pnlDrinks.Show();

            try
            {
                // fill the drink listview within the drinks panel with a list of drinks
                DrinkService drinkService = new DrinkService(); ;
                List<Drink> drinkList = drinkService.GetDrinks(); ;

                // clear the listview before filling it again
                listViewDrinks.Items.Clear();

                // check each drink in the drinklist and show the contents of the database in the UI
                foreach (Drink d in drinkList)
                {
                    ListViewItem liDrinks = new ListViewItem(d.DrinkId.ToString());
                    liDrinks.SubItems.Add(d.DrinkName);
                    liDrinks.SubItems.Add(d.DrinkPrice.ToString());
                    liDrinks.SubItems.Add(d.DrinkStock.ToString());
                    liDrinks.SubItems.Add(d.DrinkVAT.ToString());
                    liDrinks.SubItems.Add(d.DrinkValue.ToString());
                    liDrinks.SubItems.Add(d.DrinksSold.ToString());
                    if(d.StockAmount)liDrinks.SubItems.Add("Stock sufficient");
                    else liDrinks.SubItems.Add("Stock nearly depleted");
                    listViewDrinks.Items.Add(liDrinks);
                }

            }
            catch (Exception e)
            {
                // catch a error when something went wrong with the UI
                MessageBox.Show("Something went wrong while loading the drinks: " + e.Message);
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            successLabel.Text = "Update succesfull";

        }

        private void CashRegisterPanel()
        {
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
                listViewCashRegisterStudents.Items.Clear();
                listViewCashRegisterDrinks.Items.Clear();

                // check each drink in the drinklist and show the contents of the database in the UI
                foreach (Student s in studentList)
                {
                    ListViewItem liStudents = new ListViewItem(s.StudentId.ToString());
                    liStudents.SubItems.Add(s.StudentName);
                    liStudents.SubItems.Add(s.StudentDateOfBirth.ToString("dd/MM/yyyy"));
                    liStudents.Tag = s;

                    listViewCashRegisterStudents.Items.Add(liStudents);
                }

                foreach (Drink d in drinkList)
                {
                    ListViewItem liDrinks = new ListViewItem(d.DrinkId.ToString());
                    liDrinks.SubItems.Add(d.DrinkName);
                    liDrinks.SubItems.Add(d.DrinkPrice.ToString());
                    liDrinks.SubItems.Add(d.DrinkStock.ToString());
                    liDrinks.SubItems.Add(d.DrinkVAT.ToString());
                    liDrinks.SubItems.Add(d.DrinkValue.ToString());
                    liDrinks.SubItems.Add(d.DrinksSold.ToString());
                    if (d.StockAmount) liDrinks.SubItems.Add("Stock sufficient");
                    else liDrinks.SubItems.Add("Stock nearly depleted");
                    liDrinks.Tag = d;

                    listViewCashRegisterDrinks.Items.Add(liDrinks);
                }

            }
            catch (Exception e)
            {
                // catch a error when something went wrong with the UI
                MessageBox.Show("Something went wrong while loading the cash register: " + e.Message);
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

        private void buttonCheckout_Click(object sender, EventArgs e)
        {
            try
            {
                string studentItem = listViewCashRegisterStudents.SelectedItems[0].SubItems[1].Text;
                string drinkItem = listViewCashRegisterDrinks.SelectedItems[0].SubItems[1].Text;

                Student order1 = (Student)listViewCashRegisterStudents.SelectedItems[0].Tag;
                Drink order2 = (Drink)listViewCashRegisterDrinks.SelectedItems[0].Tag;

                if (listViewCashRegisterStudents.SelectedItems[0].Focused && listViewCashRegisterDrinks.SelectedItems[0].Focused)
                {
                    MessageBox.Show("2 items have been selected");
                    Order order = new Order(order1.StudentId, order2.DrinkId);
                    OrderService orderService = new OrderService();
                    orderService.AddOrders(order);
                    MessageBox.Show($"Succesfully added: {studentItem} and {drinkItem}");
                    this.Refresh();
                }
                else
                {
                    MessageBox.Show("You need to select two items");
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Something went wrong with the selection: " + error.Message);
            }
            
        }

       
    }
}
