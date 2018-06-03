using System;
using System.Drawing;
using System.Windows.Forms;

namespace Flyweight_MilitaryBase
{
    public partial class Form1 : Form, Imilitary
    {
        public Form1()
        {
            InitializeComponent();
        }

        Boolean solder_flag, transport_flag, light_flag, heavy_flag, avia_flag;
        private Int32[] coord = new Int32[2];
        public int[] Coord
        {
            get
            {
                return coord;
            }
            set
            {
                coord[0] = value[0];
                coord[1] = value[1];
            }
        }

        private Int32 speed;
        public int Speed
        {
            get
            {
                return speed;
            }
            set
            {
                speed = value;
            }
        }

        private Int32 power;
        public int Power
        {
            get
            {
                return power;
            }
            set
            {
                power = value;
            }
        }

        private String name_path;
        public String Name_path

        {
            get
            {
                return name_path;
            }
            set
            {
                name_path = value;
            }
        }

        public event myvoidstringdelegate SetUnit;


        private void button1_Click(object sender, EventArgs e)
        {
            solder_flag = true;
            transport_flag = false;
            light_flag = false;
            heavy_flag = false;
            avia_flag = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            solder_flag = false;
            transport_flag = true;
            light_flag = false;
            heavy_flag = false;
            avia_flag = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            solder_flag = false;
            transport_flag = false;
            light_flag = false;
            heavy_flag = true;
            avia_flag = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            solder_flag = false;
            transport_flag = false;
            light_flag = true;
            heavy_flag = false;
            avia_flag = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            solder_flag = false;
            transport_flag = false;
            light_flag = false;
            heavy_flag = false;
            avia_flag = true;
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (solder_flag || transport_flag || light_flag || heavy_flag || avia_flag)
            {
                coord[0] = e.X;
                coord[1] = e.Y;

                if (solder_flag)
                {
                    SetUnit?.Invoke("Soldier");
                }
                if (transport_flag)
                {
                    SetUnit?.Invoke("Transport");
                }
                if (light_flag)
                {
                    SetUnit?.Invoke("Light");
                }
                if (heavy_flag)
                {
                    SetUnit?.Invoke("Heavy");
                }
                if (avia_flag)
                {
                    SetUnit?.Invoke("Avia");
                }


                PictureBox picture = new PictureBox
                {
                    Location = new Point(coord[0], coord[1]),
                    Image = Image.FromFile(Name_path)
                };
                Controls.Add(picture);

                Label label_speed = new Label
                {
                    Location = new Point(coord[0], coord[1]),
                    Text = "Speed: " + Speed.ToString()
                };
                Controls.Add(label_speed);
                label_speed.TextAlign = ContentAlignment.MiddleCenter;

                Label label_power = new Label
                {
                    Location = new Point(coord[0], coord[1]),
                    Text = "Power: " + Power.ToString()
                };
                Controls.Add(label_power);
                label_power.TextAlign = ContentAlignment.MiddleCenter;

                if (solder_flag)
                {
                    picture.Size = new Size(80, 120);

                    label_speed.Location = new Point(coord[0], coord[1] + 120);
                    label_speed.Size = new Size(80, 15);
                    label_speed.BackColor = Color.White;

                    label_power.Location = new Point(coord[0], coord[1] + 120 + 15);
                    label_power.Size = new Size(80, 15);
                    label_power.BackColor = Color.White;
                }

                if (light_flag)
                {
                    picture.Size = new Size(120, 70);

                    label_speed.Location = new Point(coord[0], coord[1] + 70);
                    label_speed.Size = new Size(120, 15);
                    label_speed.BackColor = Color.Gray;

                    label_power.Location = new Point(coord[0], coord[1] + 70 + 15);
                    label_power.Size = new Size(120, 15);
                    label_power.BackColor = Color.Gray;
                }
                if (heavy_flag)
                {
                    picture.Size = new Size(120, 60);

                    label_speed.Location = new Point(coord[0], coord[1] + 60);
                    label_speed.Size = new Size(120, 15);
                    label_speed.BackColor = Color.White;

                    label_power.Location = new Point(coord[0], coord[1] + 60 + 15);
                    label_power.Size = new Size(120, 15);
                    label_power.BackColor = Color.White;
                }
                if (transport_flag)
                {
                    picture.Size = new Size(120, 65);

                    label_speed.Location = new Point(coord[0], coord[1] + 65);
                    label_speed.Size = new Size(120, 15);
                    label_speed.BackColor = Color.Gray;

                    label_power.Location = new Point(coord[0], coord[1] + 65 + 15);
                    label_power.Size = new Size(120, 15);
                    label_power.BackColor = Color.Gray;
                }
                if (avia_flag)
                {
                    picture.Size = new Size(120, 58);

                    label_speed.Location = new Point(coord[0], coord[1] + 58);
                    label_speed.Size = new Size(120, 15);
                    label_speed.BackColor = Color.White;

                    label_power.Location = new Point(coord[0], coord[1] + 58 + 15);
                    label_power.Size = new Size(120, 15);
                    label_power.BackColor = Color.White;
                }

                picture.BringToFront();
                label_speed.BringToFront();
                label_speed.Show();
                label_power.BringToFront();
                label_power.Show();
                picture.Show();
            }
        }
    }
}
