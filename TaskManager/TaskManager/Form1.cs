using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using TacheEnvironnement;
using TaskManager;
using TaskManager.Properties;
namespace TacheEnvironnement
{
    public partial class Form1 : Form
    {
        private int nbrTask = 0;
        private int nbrCompletedTask = 0;
        private int id = 0;
        private const int X = 100;
        private int y = 0;
        private const int YSTART = 50;
        private List<Label> tasksLabel = new List<Label>();
        private List<Tache> tasksLogic = new List<Tache>();
        private List<TrashBin> trashBinLogic = new List<TrashBin>();
        private List<CheckBoxManual> checkBoxLogic = new List<CheckBoxManual>();
        private List<PictureBox> trashBin = new List<PictureBox>();
        private List<PictureBox> checkBox = new List<PictureBox>();
        private bool textBoxFocus = false;

        public Form1()
        {
            InitializeComponent();
            FormLoad();
            KeyPreview = true;
            KeyDown += Form1_KeyDown;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !textBox1.Focused)
            {
                // Ton action ici
                textBox1.Select();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Enter && textBox1.Focused)
            {
                CreateTask();
            }
        }
        private void FormLoad()
        {
            nbrTask = tasksLabel.Count();
            nbrCompletedTask = 0;
            foreach (Tache t in tasksLogic)
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

        }
        private void TaskUp (PictureBox pct)
        {
            for (int i = 0; i < tasksLogic.Count; i++)
            {
                if (tasksLogic[i].Id > (Int16)pct.Tag)
                {
                    tasksLogic[i].Id--;
                    tasksLabel[i].Tag = tasksLogic[i].Id;
                    tasksLogic[i].Y = tasksLabel[i].Location.Y;
                    tasksLogic[i].Y -= 75;

                }
            }
            for (int i = 0; i < trashBinLogic.Count; i++)
            {
                if (trashBinLogic[i].Id > (Int16)pct.Tag)
                {
                    trashBinLogic[i].Id--;
                    trashBin[i].Tag = trashBinLogic[i].Id;
                    trashBinLogic[i].Y = trashBin[i].Location.Y;
                    trashBinLogic[i].Y -= 75;
                }
            }
            for (int i = 0; i < checkBoxLogic.Count; i++)
            {
                if (checkBoxLogic[i].Id > (Int16)pct.Tag)
                {
                    checkBoxLogic[i].Id--;
                    checkBox[i].Tag = checkBoxLogic[i].Id;
                    checkBoxLogic[i].Y = checkBox[i].Location.Y;
                    checkBoxLogic[i].Y -= 75;
                }
            }
        }
        private void LoadContent()
        {
            foreach (Label l in tasksLabel)
            {
                panel2.Controls.Add(l);
            }
            foreach (PictureBox c in checkBox)
            {
                panel2.Controls.Add(c);
            }
            foreach (PictureBox p in trashBin)
            {
                panel2.Controls.Add(p);

            }

            panel2.PerformLayout();
            FormLoad();
            ResumeLayout();
            PictureBox pct = trashBin[trashBin.Count - 1];
            pct.Click += async (e, s) =>
            {
                DialogResult choice = MessageBox.Show("Êtes-vous sûre de vouloir supprimer cette tâche ?", "Suppression tâche.", MessageBoxButtons.YesNo);
                if (choice == DialogResult.Yes)
                {
                    short actualId = (Int16)pct.Tag;
                    TaskUp(pct);

                    foreach (Label l in tasksLabel)
                    {
                        if ((Int16)l.Tag == (Int16)pct.Tag)
                        {
                            panel2.Controls.Remove(l);
                            tasksLabel.Remove(l);
                            break;
                        }
                    }
                    foreach (Tache t in tasksLogic)
                    {
                        if (t.Id == (Int16)pct.Tag)
                        {
                            tasksLogic.Remove(t);
                            break;
                        }
                    }

                    foreach (PictureBox p in checkBox)
                    {
                        if ((Int16)p.Tag == (Int16)pct.Tag)
                        {
                            panel2.Controls.Remove(p);
                            checkBox.Remove(p);
                            break;
                        }
                    }
                    foreach (TrashBin t in trashBinLogic)
                    {
                        if (t.Id == (Int16)pct.Tag)
                        {
                            trashBinLogic.Remove(t);
                            break;
                        }
                    }
                    foreach (CheckBoxManual c in checkBoxLogic)
                    {
                        if (c.Id == (Int16)pct.Tag)
                        {
                            checkBoxLogic.Remove(c);
                            break;
                        }
                    }
                    foreach (PictureBox p in trashBin)
                    {
                        if (p.Tag == pct.Tag)
                        {
                            panel2.Controls.Remove(p);
                            trashBin.Remove(p);
                            break;
                        }
                    }

                    ReplaceContent(actualId);

                    id--;
                    FormLoad();
                }
            };
            panel2.PerformLayout();
            FormLoad();
            ResumeLayout();

        }
        private void ReplaceContent(short actualId)
        {

            for (int i = 0; i < checkBox.Count; i++)
            {
                if ((Int16)checkBox[i].Tag >= actualId)
                {

                    checkBox[i].Location = new Point(checkBoxLogic[i].X, checkBoxLogic[i].Y + 13);
                }
            }
            for (int i = 0; i < trashBin.Count; i++)
            {
                if ((Int16)trashBin[i].Tag >= actualId)
                {
                    trashBinLogic[i].Y = trashBin[i].Location.Y - 75;
                    trashBin[i].Location = new Point(trashBinLogic[i].X, trashBinLogic[i].Y + 10);
                }
            }
            for (int i = 0; i < tasksLabel.Count; i++)
            {
                if ((Int16)tasksLabel[i].Tag >= actualId)
                {
                    tasksLogic[i].Y = tasksLabel[i].Location.Y - 75;
                    tasksLabel[i].Location = new Point(tasksLogic[i].X, tasksLogic[i].Y + 13);
                }
            }
        }
        private void InitalizeLabel(Label myLabel, Tache myTache)
        {
            myLabel.Name = myTache.Name;
            myLabel.Text = myTache.Content;
            myLabel.Location = new Point(myTache.X, myTache.Y);
            myLabel.Font = new Font(myTache.Font, 15);
            myLabel.AutoSize = true;
            myLabel.Tag = myTache.Id;
            myLabel.MaximumSize = new Size(215, 50);
            myLabel.AutoEllipsis = true;
            myLabel.TabIndex = 1;
            myLabel.ForeColor = Color.Black;
            trashBin.Add(new PictureBox());
            trashBinLogic.Add(new TrashBin((myLabel.Location.X + myLabel.MaximumSize.Width), myLabel.Location.Y - 10, $"trashBin{id}", (short)id));

            checkBox.Add(new PictureBox());
            checkBoxLogic.Add(new CheckBoxManual(myLabel.Location.X - 60, myLabel.Location.Y - 13, $"checkBox{id}", (short)id));
            InitializeActions(trashBin[trashBin.Count - 1], checkBox[checkBox.Count - 1], checkBoxLogic[checkBoxLogic.Count - 1], trashBinLogic[trashBinLogic.Count - 1]);
            y += 50;
            id++;
            if (myLabel.Text.Count() > 18)
            {
                myLabel.Location = new Point(myTache.X, myTache.Y - 15);
            }
            myLabel.Click += (e, s) =>
            {
                tasksLogic[(Int16)myLabel.Tag].ChangeName();
                myLabel.Name = tasksLogic[(Int16)myLabel.Tag].Name;
                MessageBox.Show(myLabel.Text, myLabel.Name);
            };
        }
        private void InitializeActions(PictureBox myTrashBin, PictureBox myCheckBox, CheckBoxManual myManualCheckBox, TrashBin myManualTrashBin)
        {
            myTrashBin.Name = myManualTrashBin.Name;
            myTrashBin.Location = new Point(myManualTrashBin.X, myManualTrashBin.Y);
            myTrashBin.Tag = myManualTrashBin.Id;
            myTrashBin.Image = Resources.RecycleBinClosed;


            myTrashBin.BackColor = Color.Transparent;
            myTrashBin.Size = new Size(35, 35);
            myTrashBin.TabIndex = 1;
            myTrashBin.Visible = true;
            myTrashBin.TabStop = false;
            myTrashBin.SizeMode = PictureBoxSizeMode.StretchImage;
            myTrashBin.MouseEnter += async (e, s) =>
            {
                myTrashBin.Image = Resources.RecycleBinOpened;
                myManualTrashBin.State = true;
            };

            myTrashBin.MouseLeave += async (e, s) =>
            {
                if (myManualTrashBin.State)
                {
                    myTrashBin.Image = Resources.RecycleBinClosed;
                    myManualTrashBin.State = false;
                }
            };

            myCheckBox.Name = myManualCheckBox.Name;
            myCheckBox.Location = new Point(myManualCheckBox.X, myManualCheckBox.Y);
            myCheckBox.Tag = myManualCheckBox.Id;
            myCheckBox.Image = Resources._unchecked;
            myCheckBox.Size = new Size(50, 50);
            myCheckBox.SizeMode = PictureBoxSizeMode.StretchImage;

            myCheckBox.Click += async (e, s) =>
            {
                myManualCheckBox.State = !myManualCheckBox.State;

                if (myManualCheckBox.State)
                {
                    myCheckBox.Image = Resources._checked;
                    tasksLogic[(Int16)myCheckBox.Tag].check = true;
                    nbrCompletedTask++;
                }
                else
                {
                    myCheckBox.Image = Resources._unchecked;
                    tasksLogic[(Int16)myCheckBox.Tag].check = false;
                    nbrCompletedTask--;
                }
                FormLoad();
            };
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
            if (checkBox.Count != 0)
            {
                y = checkBox[checkBox.Count - 1].Location.Y + 75;
            }
            else
            {
                y = YSTART + (75 * tasksLogic.Count);
            }
            return y;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateTask();
        }
        private void CreateTask()
        {
            if (textBox1.Text.Length != 0)
            {
                SuspendLayout();
                tasksLogic.Add(new Tache(textBox1.Text, X, GetY(), (short)id));
                tasksLabel.Add(new Label());
                InitalizeLabel(tasksLabel[tasksLabel.Count - 1], tasksLogic[tasksLogic.Count - 1]);
                LoadContent();
                textBox1.Clear();

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Focus();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            textBoxFocus = true;
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {

            textBoxFocus = false;
        }
    }
}