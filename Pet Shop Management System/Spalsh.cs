namespace Pet_Shop_Management_System
{
    public partial class Spalsh : Form
    {
        public Spalsh()
        {
            InitializeComponent();
            timer1.Start();
        }
        int startP = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startP += 1;
            Myprogress.Value = startP;
            PercentageLbl.Text = startP + "%";
            if (startP == 100) 
                {Login Obj = new Login();
                Obj.Show();
                this.Hide();
                Myprogress.Value = 0;
                timer1.Stop();
                }
            }
        }
}
