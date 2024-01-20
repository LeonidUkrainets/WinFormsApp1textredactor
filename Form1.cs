namespace WinFormsApp1textredactor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "All Files(*.*)|*.*|Text Files(*.txt)|*.txt";
            open.FilterIndex = 1;
            if (open.ShowDialog() == DialogResult.OK)
            {
                StreamReader reader = File.OpenText(open.FileName);
                textBox1.Text = reader.ReadToEnd();
                reader.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            if (save.ShowDialog() == DialogResult.OK)
            {
                StreamWriter streamWriter = new StreamWriter(save.FileName);
                streamWriter.Write(textBox1.Text);
                streamWriter.Close();
            }
        }
    }
}