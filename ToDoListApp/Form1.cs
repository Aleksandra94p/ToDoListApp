namespace ToDoListApp
{
    public partial class Form1 : Form
    {
        Dictionary<DateTime, List<string>> tasksByDay = new Dictionary<DateTime, List<string>>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Visok");
            comboBox1.Items.Add("Srednji");
            comboBox1.Items.Add("Nizak");

            comboBox1.SelectedIndex = 0;
            this.Load += new System.EventHandler(this.Form1_Load);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                string selectedTask = listBox1.SelectedItem.ToString();
                DateTime selectedDate = DateTime.Parse(selectedTask.Split('-')[2].Trim());

                listBox1.Items.Remove(listBox1.SelectedItem);
                if (tasksByDay.ContainsKey(selectedDate))
                {
                    tasksByDay[selectedDate].Remove(selectedTask);

                    if (tasksByDay[selectedDate].Count == 0)
                    {
                        tasksByDay.Remove(selectedDate);
                    }
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text) && comboBox1.SelectedItem != null)
            {
                DateTime selectedDate = monthCalendar1.SelectionStart.Date;
                string day = selectedDate.ToString("dddd");

                string task = $"{comboBox1.SelectedItem} - {textBox1.Text} - {selectedDate.ToString()}";

                if (tasksByDay.ContainsKey(selectedDate))
                {
                    tasksByDay[selectedDate].Add(task);
                }
                else
                {
                    tasksByDay[selectedDate] = new List<string>{ task };
                }


                textBox1.Clear();
                comboBox1.SelectedIndex = -1;

                ShowTasksForTheDay(selectedDate);

            }
            else
            {
                MessageBox.Show("Molimo unesite zadatak i izaberite prioritet.");
            }
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime selectedDate = monthCalendar1.SelectionStart.Date;
            ShowTasksForTheDay(selectedDate);
        }

        private void ShowTasksForTheDay(DateTime selectedDate)
        {
            listBox1.Items.Clear();
            if (tasksByDay.ContainsKey(selectedDate))
            {
                foreach (string task in tasksByDay[selectedDate])
                {
                    listBox1.Items.Add(task).ToString();

                }
            }
            else
            {
                listBox1.Items.Add("Nema zadataka za ovaj dan.");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
