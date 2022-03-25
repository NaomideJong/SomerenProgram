﻿using Microsoft.VisualBasic;
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
                case "Activities":
                    HideAll();
                    ActivitiesPanel();
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
            pnlActivities.Hide();
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
                    if (d.StockAmount) liDrinks.SubItems.Add("Stock sufficient");
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

                listViewCashRegisterDrinks.View = View.Details;
                listViewCashRegisterDrinks.CheckBoxes = true;

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
                    liDrinks.Tag = d;
                    if (d.StockAmount) liDrinks.SubItems.Add("Stock sufficient");
                    else liDrinks.SubItems.Add("Stock nearly depleted");
                    listViewCashRegisterDrinks.Items.Add(liDrinks);
                }

                // put label back to empty
                lblTotalAmount.Text = "";
            }
            catch (Exception e)
            {
                // catch a error when something went wrong with the UI
                MessageBox.Show("Something went wrong while loading the cash register: " + e.Message);
            }
        }

        private void ActivitiesPanel()
        {
            pnlActivities.Show();
            SetDateTimeFormat();

            try
            {
                // fill the students listview within the students panel with a list of students
                ActivityService activityService = new ActivityService();
                List<Activity> activityList = activityService.GetActivities();

                // clear the listview before filling it again
                listViewActivities.Items.Clear();

                // check each student in the student list and show the contents of the database in the UI
                foreach (Activity a in activityList)
                {
                    ListViewItem liActivities = new ListViewItem(a.ActivityId.ToString());
                    liActivities.SubItems.Add(a.ActivityDescription);
                    liActivities.SubItems.Add(a.ActivityStartTime.ToString("dd/MM/yyyy  HH:mm:ss"));
                    liActivities.SubItems.Add(a.ActivityEndTime.ToString("dd/MM/yyyy HH:mm:ss"));
                    liActivities.Tag = a;
                    listViewActivities.Items.Add(liActivities);
                }
            }
            catch (Exception e)
            {
                // catch a error when something went wrong with the UI
                MessageBox.Show("Something went wrong while loading the activities: " + e.Message);
            }
        }

        private void SetDateTimeFormat()
        {
            dateTimePickerStartTime.CustomFormat = "dd-MM-yyyy HH:mm:ss";
            dateTimePickerEndTime.CustomFormat = "dd-MM-yyyy HH:mm:ss";
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

        private void activitiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("Activities");
        }

        private void cashRegisterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("Cash Register");
        }

        private void buttonCheckout_Click(object sender, EventArgs e)
        {
            try
            {
                // saving the selected item to a object
                Student order1 = (Student)listViewCashRegisterStudents.SelectedItems[0].Tag;

                OrderService orderService = new OrderService();

                // check each checked item in the listview of listViewRegisterDrinks
                foreach(ListViewItem lviDrinks in listViewCashRegisterDrinks.CheckedItems)
                {
                    Drink drink = (Drink)lviDrinks.Tag;
                    // take in the studentId of student listview, drinkId of drink listview
                    // and current time and move them in the parameters
                    Order order = new Order(order1.StudentId, drink.DrinkId, DateTime.Now);
                    // place the order end send it to the logic layer
                    orderService.AddOrders(order);
                    MessageBox.Show($"Succesfully added: {order.StudentOrderId} and {order.DrinkOrderId}");
                }
                CashRegisterPanel();
            }
            catch (Exception error)
            {
                MessageBox.Show("You need to select atleast 1 student and 1 drink.");
            }
        }

        private void listViewCashRegisterDrinks_SelectedIndexChanged(object sender, EventArgs e)
        {
            decimal totalPrice = 0m;
            
            foreach (ListViewItem lviDrinks in listViewCashRegisterDrinks.CheckedItems)
            {
                Drink drink = (Drink)lviDrinks.Tag;
                // count up price foreach drink selected
                totalPrice += drink.DrinkPrice;
            }
            // put the text to the label as string
            lblTotalAmount.Text = totalPrice.ToString();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Drink drink = new Drink();
                drink.DrinkName = textBoxDrinkName.Text;
                drink.DrinkStock = int.Parse(textBoxDrinkStock.Text);
                DrinkService drinkService = new DrinkService();
                drinkService.UpdateDrink(drink);
                MessageBox.Show($"Succesfully edited: {drink.DrinkName}");
            }
            catch (Exception x)
            {
                // catch a error when something went wrong with the UI
                MessageBox.Show("Something went wrong while updating the table: " + x.Message);
            }
        }

        private void buttonUpdateActivities_Click(object sender, EventArgs e)
        {
            try
            {
                //change decription, start time and end time
                Activity selectedActivity = (Activity)listViewActivities.SelectedItems[0].Tag;
                ActivityService activityService = new ActivityService();
                //get the id you wish to have changed
                Activity activity = activityService.GetById(selectedActivity.ActivityId);
                //get values from textboxes below
                activity.ActivityDescription = textBoxNewDescription.Text;
                activity.ActivityStartTime = dateTimePickerStartTime.Value;
                activity.ActivityEndTime = dateTimePickerEndTime.Value;
                //put the changes the user made through the logic layer
                activityService.UpdateActivity(activity);

                List<Activity> activityList = activityService.GetActivities();
                //show the changes made in the listview
                UpdateActivities(activityList);
                MessageBox.Show("A change has succesfully been made");

                ActivitiesPanel();
            }
            catch (Exception x)
            {
                // catch a error when something went wrong with the UI
                MessageBox.Show("Please select something in the listview: " + x.Message);
            }
        }

        private void listViewActivities_SelectedIndexChanged(object sender, EventArgs e)
        {
           /*if (listViewActivities.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select something");
                return;
            }
            Activity activityClick = (Activity)listViewActivities.SelectedItems[0].Tag;
            MessageBox.Show($"{activityClick.ActivityId}, {activityClick.ActivityDescription}");*/
        }

        private void buttonDeleteActivity_Click(object sender, EventArgs e)
        {
            try
            {
                //delete activity
                Activity selectedActivity = (Activity)listViewActivities.SelectedItems[0].Tag;
                ActivityService activityService = new ActivityService();
                //get the id you wish to have deleted
                Activity activity = activityService.GetById(selectedActivity.ActivityId);
                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;

                string title = "Delete Activity";
                string message = $"Are you sure that you wish to remove this activity: {activity.ActivityDescription}?";

                DialogResult answer = MessageBox.Show(message, title, buttons);
                if (answer == DialogResult.OK)
                {
                    //put the deletion the user made through the logic layer
                    activityService.DeleteActivity(activity);
                    List<Activity> activityList = activityService.GetActivities();
                    //show the changes made in the listview
                    UpdateActivities(activityList);
                    MessageBox.Show($"{activity.ActivityDescription} has succesfully been deleted");
                }

                ActivitiesPanel();
            }
            catch (Exception x)
            {
                // catch a error when something went wrong with the UI
                MessageBox.Show("Please select something in the listview: " + x.Message);
            }
        }

        private void buttonAddActivity_Click(object sender, EventArgs e)
        {
            try
            {
                //change decription, start time and end time
                ActivityService activityService = new ActivityService();
                Activity activity = new Activity();

                //get values from textboxes below
                activity.ActivityDescription = textBoxNewDescription.Text;
                activity.ActivityStartTime = dateTimePickerStartTime.Value;
                activity.ActivityEndTime = dateTimePickerEndTime.Value;
                List<Activity> activityList = activityService.GetActivities();
                //check if the description already exists in the list
                bool containsItem = activityList.Any(item => item.ActivityDescription == activity.ActivityDescription);
                if (containsItem)
                {
                    //the add won't go through 
                    MessageBox.Show($"{activity.ActivityDescription} already exists please write another activity.");
                } else
                {
                    //the add has gone through the logic layer
                    activityService.AddActivity(activity);
                    MessageBox.Show($"{activity.ActivityDescription} has succesfully been added");
                }

                listViewActivities.Items.Clear();

                //show the changes made in the listview
                foreach (Activity a in activityList)
                {
                    ListViewItem liActivities = new ListViewItem();
                    liActivities.SubItems.Add(a.ActivityDescription);
                    liActivities.SubItems.Add(a.ActivityStartTime.ToString("dd/MM/yyyy  HH:mm:ss"));
                    liActivities.SubItems.Add(a.ActivityEndTime.ToString("dd/MM/yyyy HH:mm:ss"));
                    listViewActivities.Items.Add(liActivities);
                }
                ActivitiesPanel();
            }
            catch (Exception x)
            {
                // catch a error when something went wrong with the UI
                MessageBox.Show("Please select something in the listview: " + x.Message);
            }
        }

        private void UpdateActivities(List<Activity> activitiesList)
        {
            listViewActivities.Items.Clear();

            foreach (Activity a in activitiesList)
            {
                ListViewItem liActivities = new ListViewItem(a.ActivityId.ToString());
                liActivities.SubItems.Add(a.ActivityDescription);
                liActivities.SubItems.Add(a.ActivityStartTime.ToString("dd/MM/yyyy  HH:mm:ss"));
                liActivities.SubItems.Add(a.ActivityEndTime.ToString("dd/MM/yyyy HH:mm:ss"));
                liActivities.Tag = a;
                listViewActivities.Items.Add(liActivities);
            }
        }
    }
}
