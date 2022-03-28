using Microsoft.VisualBasic;
using SomerenLogic;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.Linq;
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
                case "Supervisors":
                    HideAll();
                    SupervisorPanel();
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
            pnlSupervisors.Hide();
            pnlLogIn.Hide();
        }

        private void pnlLogIn()
        {
            //show login
            pnlLogIn.Show();
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
                foreach (ListViewItem lviDrinks in listViewCashRegisterDrinks.CheckedItems)
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
                //change name and stock of drink
                DrinkService drinkService = new DrinkService();
                Drink drink = drinkService.GetById(int.Parse(textBoxDrinkId.Text));
                drink.DrinkName = textBoxDrinkName.Text;
                drink.DrinkStock = int.Parse(textBoxDrinkStock.Text);
                drinkService.UpdateDrink(drink);
                List<Drink> drinkList = drinkService.GetDrinks(); ;

                UpdateDrinks(drinkList);
                succesLabel.Text = $"Succesfully edited: {drink.DrinkName}";
            }
            catch (Exception x)
            {
                // catch a error when something went wrong with the UI
                MessageBox.Show("Something went wrong while updating the table: " + x.Message);
            }
        }

        private void buttonDrinkDelete_Click(object sender, EventArgs e)
        {
            try
            {
                //delete drink
                DrinkService drinkService = new DrinkService();
                Drink drink = drinkService.GetById(int.Parse(textBoxDrinkId.Text));
                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                string title = "Delete Drink";
                string message = $"Are you sure you want to delete {drink.DrinkName}?";
                DialogResult answer = MessageBox.Show(message, title, buttons);
                if (answer == DialogResult.OK)
                {
                    drinkService.DeleteDrink(drink);
                    List<Drink> drinkList = drinkService.GetDrinks();
                    UpdateDrinks(drinkList);
                    deleteLabel.Text = $"Succesfully Deleted: {drink.DrinkName}";
                }
            }
            catch (Exception x)
            {
                // catch a error when something went wrong with the UI
                MessageBox.Show("Something went wrong while deleting the drink: " + x.Message);
            }
        }

        private void buttonDrinkAdd_Click(object sender, EventArgs e)
        {
            try
            {
                DrinkService drinkService = new DrinkService();
                Drink drink = new Drink();
                drink.DrinkName = Interaction.InputBox("Enter Drink Name", "Add drink", "", 500, 300);
                drink.DrinkPrice = decimal.Parse(Interaction.InputBox("Enter drink price", "Add Drink", "", 500, 300));
                drink.DrinkStock = int.Parse(Interaction.InputBox("Enter Drinks amount in stock", "Add Drink", "", 500, 300));
                drink.DrinkVAT = int.Parse(Interaction.InputBox("Enter drink VAT", "Add Drink", "", 500, 300));
                drink.DrinkValue = int.Parse(Interaction.InputBox("Enter drink value in Tokens", "Add Drink", "", 500, 300));
                drink.DrinksSold = int.Parse(Interaction.InputBox("Enter amount of drinks sold", "Add Drink", "", 500, 300));
                drinkService.AddDrink(drink);
                List<Drink> drinkList = drinkService.GetDrinks();
                UpdateDrinks(drinkList);
                MessageBox.Show($"Succesfully added {drink.DrinkName} to the list");
            }

            catch (Exception x)
            {
                // catch a error when something went wrong with the UI
                MessageBox.Show("Something went wrong while adding the drink: " + x.Message);
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
                }
                else
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

        private void UpdateDrinks(List<Drink> drinkList)
        {
            //update tabel
            listViewDrinks.Items.Clear();
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

        private void supervisorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("Supervisors");
        }

        private void SupervisorPanel()
        {
            pnlSupervisors.Show();

            try
            {
                // fill the students listview within the students panel with a list of students
                ActivityService activityService = new ActivityService();
                List<Activity> activityList = activityService.GetActivities();

                // clear the listview before filling it again
                liActivitySupervisors.Items.Clear();

                // check each student in the student list and show the contents of the database in the UI
                foreach (Activity a in activityList)
                {
                    ListViewItem liActivity = new ListViewItem(a.ActivityId.ToString());

                    liActivity.SubItems.Add(a.ActivityDescription);
                    liActivity.Tag = a;
                    liActivitySupervisors.Items.Add(liActivity);
                }

            }
            catch (Exception e)
            {
                // catch a error when something went wrong with the UI
                MessageBox.Show("Something went wrong while loading the activities: " + e.Message);
            }


        }

        private void showSupervisorsButton_Click(object sender, EventArgs e)
        {
            Activity selectedActivity = (Activity)liActivitySupervisors.SelectedItems[0].Tag;
            SupervisorService supervisorService = new SupervisorService();
            List<Supervisor> supervisors = supervisorService.JoinTable(selectedActivity.ActivityId);
            liSupervisors.Items.Clear();

            foreach (Supervisor s in supervisors)
            {
                ListViewItem liSupervisor = new ListViewItem(s.TeacherName.ToString());
                liSupervisor.Tag = s;
                liSupervisors.Items.Add(liSupervisor);
            }
        }

        private void showAllTeachers_Click(object sender, EventArgs e)
        {
            TeacherService lecService = new TeacherService(); 
            List<Teacher> teacherList = lecService.GetTeachers(); ;

            // clear the listview before filling it again
            liSupervisors.Items.Clear();

            // check each teacher in the teacherlist and show the contents of the database in the UI
            foreach (Teacher t in teacherList)
            {
                liSupervisors.Tag = t;
                liSupervisors.Items.Add(t.TeacherName.ToString());
            }

        }


        private void addSelectedSupervisor_Click(object sender, EventArgs e)
        {
            try
            {
                Activity selectedActivity = (Activity)liActivitySupervisors.SelectedItems[0].Tag;
                string selectedSupervisor = liSupervisors.SelectedItems[0].Text;
                if (selectedSupervisor != null)
                {
                    MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                    string title = "Add Supervisor";
                    string message = $"Do you want to add {selectedSupervisor} as supervisor for {selectedActivity.ActivityDescription}?";
                    DialogResult answer = MessageBox.Show(message, title, buttons);
                    if (answer == DialogResult.OK)
                    {

                        SupervisorService supervisorService = new SupervisorService();
                        List<Supervisor> supervisors = supervisorService.JoinTable(selectedActivity.ActivityId);

                        foreach (Supervisor s in supervisors)
                        {
                            if (selectedSupervisor == s.TeacherName)
                            {
                                MessageBox.Show("Supervisor already added");
                                return;
                            }
                        }
                        TeacherService teacherService = new TeacherService();
                        Teacher teacher = teacherService.NameToTeacherId(selectedSupervisor);
                        supervisorService.AddSupervisor(selectedActivity, teacher);
                        MessageBox.Show($"{selectedSupervisor} succesfully addes as supervisor for {selectedActivity.ActivityDescription}.");
                    }
                }
                else
                {
                    MessageBox.Show("No teacher selected");
                }

            }
            catch (Exception b)
            {
                MessageBox.Show("Something went wrong while adding a supervisor: " + b.Message);
            }
        }

        private void deleteSupervisorButton_Click(object sender, EventArgs e)
        {
            try
            {
                //delete supervisor
                Supervisor selectedSupervisor = (Supervisor)liSupervisors.SelectedItems[0].Tag;
                Activity selectedActivity = (Activity)liActivitySupervisors.SelectedItems[0].Tag;
                SupervisorService supervisorService = new SupervisorService();

                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;

                string title = "Delete Supervisor";
                string message = $"Are you sure that you wish to remove {selectedSupervisor.TeacherName} from {selectedActivity.ActivityDescription}?";

                DialogResult answer = MessageBox.Show(message, title, buttons);
                if (answer == DialogResult.OK)
                {
                    //put the deletion the user made through the logic layer
                    TeacherService teacherService = new TeacherService();
                    Teacher teacher = teacherService.NameToTeacherId(selectedSupervisor.TeacherName);
                    supervisorService.DeleteSupervisor(selectedActivity, teacher);
                    //show the changes made in the listview
                    List<Supervisor> supervisors = supervisorService.JoinTable(selectedActivity.ActivityId);
                    liSupervisors.Items.Clear();

                    foreach (Supervisor s in supervisors)
                    {
                        ListViewItem liSupervisor = new ListViewItem(s.TeacherName.ToString());
                        liSupervisor.Tag = s;
                        liSupervisors.Items.Add(liSupervisor);
                    }
                    MessageBox.Show($"{selectedSupervisor.TeacherName} has succesfully been deleted from {selectedActivity.ActivityDescription}.");
                }

                SupervisorPanel();
            }
            catch (Exception x)
            {
                // catch a error when something went wrong with the UI
                MessageBox.Show("Please select something in the listview: " + x.Message);
            }

        }
    }
}
