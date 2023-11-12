namespace Dz_na._16._11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("https://finance.ua/credits/all");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Помилка відкриття веб-сайту: " + ex.Message);
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            this.Text = $"Mouse position : {e.X} : {e.Y}";
            Point mouse = e.Location;
            Random random = new Random();
            if (mouse.X >= btnCatch.Left - 40 && (mouse.X <= btnCatch.Left + btnCatch.Width + 40))
            {
                if (mouse.X >= btnCatch.Left + (btnCatch.Width / 2))
                {
                    btnCatch.Left = btnCatch.Left - 30;
                }
                else
                {
                    btnCatch.Left = btnCatch.Left + 30;
                }

                if (btnCatch.Left < 0)
                {
                    btnCatch.Location = new Point(random.Next(this.Width), random.Next(this.Height));
                }
                if (btnCatch.Right + 30 > this.Width)
                {
                    btnCatch.Location = new Point(random.Next(this.Width), random.Next(this.Height));
                }
            }
            else if (mouse.Y >= btnCatch.Top + 40 && (mouse.Y <= btnCatch.Top + btnCatch.Height + 40))
            {
                if (mouse.Y >= btnCatch.Top + (btnCatch.Width / 2))
                {
                    btnCatch.Top = btnCatch.Top - 20;
                }
                else
                {
                    btnCatch.Top = btnCatch.Top + 20;
                }
                if (btnCatch.Top < 0)
                {
                    btnCatch.Location = new Point(random.Next(this.Width), random.Next(this.Height));
                }
                if (btnCatch.Top + 100 > this.Height)
                {
                    btnCatch.Location = new Point(random.Next(this.Width), random.Next(this.Height));
                }
            }
        }
    }
}