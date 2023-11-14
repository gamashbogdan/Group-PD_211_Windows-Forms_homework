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
                System.Diagnostics.Process.Start("MicrosoftEdge.exe", "https://finance.ua/credits/all");
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
            if (mouse.X >= btnCatch.Left - 20 && (mouse.X <= btnCatch.Left + btnCatch.Width + 20))
            {
                if (mouse.X >= btnCatch.Left + (btnCatch.Width / 2))
                {
                    btnCatch.Left = btnCatch.Left - 30;
                }
                else
                {
                    btnCatch.Left = btnCatch.Left + 30;
                }
            }
            else if (mouse.Y >= btnCatch.Top + 20 && (mouse.Y <= btnCatch.Top + btnCatch.Height + 20))
            {
                if (mouse.Y >= btnCatch.Top + (btnCatch.Width / 2))
                {
                    btnCatch.Top = btnCatch.Top - 20;
                }
                else
                {
                    btnCatch.Top = btnCatch.Top + 20;
                }
                
            }
            if (btnCatch.Top < 0)
            {
                btnCatch.Location = new Point(random.Next(this.Width), random.Next(this.Height));
            }
            if (btnCatch.Top + btnCatch.Height > this.ClientSize.Height)
            {
                btnCatch.Location = new Point(random.Next(this.Width), random.Next(this.Height));
            }
            if (btnCatch.Left < 0)
            {
                btnCatch.Location = new Point(random.Next(this.Width), random.Next(this.Height));
            }
            if (btnCatch.Left + btnCatch.Width > this.ClientSize.Width)
            {
                btnCatch.Location = new Point(random.Next(this.Width), random.Next(this.Height));
            }
        }
    }
}