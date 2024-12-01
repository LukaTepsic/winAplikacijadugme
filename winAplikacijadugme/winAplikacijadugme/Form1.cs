using System;
using System;
using System.Windows.Forms;

namespace CheckboxApp
{
    public class MainForm : Form
    {
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private Button button;
        private TextBox textBox;

        public MainForm()
        {
            checkBox1 = new CheckBox() { Text = "Opcija 1", Location = new System.Drawing.Point(20, 20) };
            checkBox2 = new CheckBox() { Text = "Opcija 2", Location = new System.Drawing.Point(20, 50) };
            checkBox3 = new CheckBox() { Text = "Opcija 3", Location = new System.Drawing.Point(20, 80) };
            checkBox4 = new CheckBox() { Text = "Opcija 4", Location = new System.Drawing.Point(20, 110) };
            button = new Button() { Text = "Prikaži Odabir", Location = new System.Drawing.Point(20, 140) };
            textBox = new TextBox() { Multiline = true, Location = new System.Drawing.Point(20, 180), Width = 250, Height = 100 };

            button.Click += Button_Click;

            Controls.Add(checkBox1);
            Controls.Add(checkBox2);
            Controls.Add(checkBox3);
            Controls.Add(checkBox4);
            Controls.Add(button);
            Controls.Add(textBox);
        }

        private void Button_Click(object sender, EventArgs e)
        {
            textBox.Clear();
            if (checkBox1.Checked) textBox.AppendText(checkBox1.Text + Environment.NewLine);
            if (checkBox2.Checked) textBox.AppendText(checkBox2.Text + Environment.NewLine);
            if (checkBox3.Checked) textBox.AppendText(checkBox3.Text + Environment.NewLine);
            if (checkBox4.Checked) textBox.AppendText(checkBox4.Text + Environment.NewLine);
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}

