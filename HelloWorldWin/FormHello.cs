using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorldWin
{
    class FormHello : Form
    {

        Label label = new Label();
        Button button = new Button();

        public FormHello()
        {
            label.Text = "Hello world!";
            label.Location = new Point(10, 10);
            label.Size = new Size(100, 20);

            button.Text = "Translate";
            button.Location = new Point(10, 30);
            button.Size = new Size(100, 20);
            button.Click += Button_Click;

            this.Text = "My first form";
            this.Controls.Add(label);
            this.Controls.Add(button);
        }

        bool isEnglish = true;

        private void Button_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Hello World!");
            isEnglish = !isEnglish;
            if (isEnglish)
            {
                label.Text = "Hello World!";
                button.Text = "Translate";
            }
            else
            {
                label.Text = "Olá mundo!";
                button.Text = "Traduzir";
            }
        }
    }
}
