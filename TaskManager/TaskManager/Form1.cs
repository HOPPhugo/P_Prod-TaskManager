using System.Runtime.CompilerServices;
using TacheEnvironnement;
namespace TacheEnvironnement
{
    public partial class Form1 : Form
    {

        private int nbrTask = 0;
        private int nbrCompletedTask = 0;
        private int id = 1;
        private const int X = 100;
        private int y = 250;
        private List<Label> tasks = new List<Label>();
        private List<Tache> tache = new List<Tache>();
        private List<PictureBox> trashBin = new List<PictureBox>();
        private List<CheckBox> checkBox = new List<CheckBox>();

        public Form1()
        {
            InitializeComponent();
            FormLoad();
        }
        private void FormLoad ()
        {
            nbrTask = tasks.Count();
            foreach (Tache t in  tache)
            {
                if (t.check)
                {
                    nbrCompletedTask++;
                }
            }
            pictureBox1.Select();
            label3.Text = $"Task Completed: {nbrCompletedTask} / {nbrTask}";
            foreach (Control p in panel3.Controls)
            {
                p.Click += (e, s) =>
                {
                    panel1.Select();
                };
            }
            panel2.Height = this.Height;

        }
        private void LoadContent()
        {
            this.Controls.Clear();
            foreach (Label l in tasks)
            {
                this.Controls.Add(l);
            }
            foreach (PictureBox p in trashBin)
            {
                this.Controls.Add(p);
            }
            foreach (CheckBox c in checkBox)
            {
                this.Controls.Add(c);
            }

            InitializeComponent();
            FormLoad();
            ResumeLayout();
        }
        private void InitalizeLabel(Label myLabel, Tache myTache)
        {
            myLabel.Name = myLabel.Name;
            myLabel.Text = myTache.Content;
            myLabel.Location = new Point(myTache.X, myTache.Y);
            myLabel.Font = new Font(myTache.Font, 15);
            myLabel.AutoSize = true;
            myLabel.MaximumSize = new Size(215, 50);
            myLabel.AutoEllipsis = true;
            trashBin.Add(new PictureBox());
            InitializeActions(trashBin[trashBin.Count-1], id, y);
            y += 50;
            id++;
        }
        private void InitializeActions(PictureBox myTrashBin, int idAction, int y)
        {
            //myTrashBin.Name = $"TrashBinN{id}";
            //myTrashBin.Location = new Point(X+100, y);
            //myTrashBin.Size = new Size(50, 50);

            //myTrashBin.Image = Properties.Resources.RecycleBinClosed;
            //myTrashBin.MouseHover += (e, s) =>
            //{
            //    myTrashBin.Image = Properties.Resources.RecycleBin;
            //};

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
        private int GetY()
        {
            y = 250 + (75 * tache.Count);
            return y;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 0)
            {
                SuspendLayout();
                tache.Add(new Tache(textBox1.Text, $"TacheN{tache.Count}", X, GetY()));
                tasks.Add(new Label());
                InitalizeLabel(tasks[tasks.Count-1], tache[tache.Count-1]);
                LoadContent();

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}