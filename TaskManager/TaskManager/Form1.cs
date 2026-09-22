using System.Runtime.CompilerServices;
namespace TaskManager
{
    public partial class Form1 : Form
    {

        private int nbrTask = 0;
        private int nbrCompletedTask = 0;
        private int id = 1;
        private const int X = 100;
        private int y = 250;
        private List<Label> tasks = new List<Label>();

        public Form1()
        {
            InitializeComponent();
            FormLoad();
        }
        private void FormLoad ()
        {
            pictureBox1.Select();
            label3.Text = $"Task Completed: {nbrCompletedTask} / {nbrTask}";
            foreach (Control p in panel3.Controls)
            {
                p.Click += (e, s) =>
                {
                    panel1.Select();
                };
            }
        }
        private void InitalizeLabel(Label myLabel, string text)
        {
            myLabel.Name = $"myLabel{id}";
            myLabel.AutoSize = true;
            myLabel.Font = new Font("Arial Rounded MT Bold", 15);
            myLabel.Location = new Point(X, y);
            myLabel.TabIndex = 1;
            myLabel.Text = text;
            y += 50;
            id++;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            panel1.Select();

        }

        private void panel3_Click(object sender, EventArgs e)
        {
            panel1.Select();

        }

        private void label3_Click(object sender, EventArgs e)
        {
            label3.Select();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 0)
            {
                SuspendLayout();
                tasks.Add(new Label());
                this.Controls.Clear();
                InitalizeLabel(tasks[tasks.Count-1], textBox1.Text);
                foreach (Label l in  tasks)
                {
                    this.Controls.Add(l);
                }
                InitializeComponent();
                FormLoad();
                ResumeLayout();

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}