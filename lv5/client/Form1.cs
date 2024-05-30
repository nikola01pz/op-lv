using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Globalization;

namespace client
{
    public partial class Form1 : Form
    {
        string hostName;
        string hostPort;

        TcpClient client;
        NetworkStream stream;

        string message;
        byte[] sendData;

        Random random = new Random();
        const int canvasHeight = 600;
        const int canvasWidth = 800;
        float x, y;
        string[] colors = { "black", "red", "green", "blue", "yellow", "purple", "orange", "pink"};
        List<PointF> polygonDots = new List<PointF>();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            hostName = textBox1.Text;
            hostPort = textBox2.Text;

            message = "Ovo je poruka!";
            client = new TcpClient(hostName, Int32.Parse(hostPort));
            if (client.Connected)
            {

                panel_connection_status.BackColor = Color.Green;
            }
            stream = client.GetStream();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            stream.Close();
            client.Close();
            panel_connection_status.BackColor = Color.Red;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel_connection_status.BackColor = Color.Red;

            if (client != null && client.Connected)
            {
                panel_connection_status.BackColor = Color.Green;
            }
        }

        private void button_line_send_Click(object sender, EventArgs e)
        {
            message = $"Line {textbox_line_color.Text} {textbox_line_dot1x.Text} {textbox_line_dot1y.Text} {textbox_line_dot2x.Text} {textbox_line_dot2y.Text}";
            sendData = Encoding.ASCII.GetBytes(message);
            stream.Write(sendData, 0, sendData.Length);
        }

        private void button_triangle_send_Click(object sender, EventArgs e)
        {
            message = $"Triangle {textbox_triangle_color.Text} {textbox_triangle_dot1x.Text} {textbox_triangle_dot1y.Text} {textbox_triangle_dot2x.Text} {textbox_triangle_dot2y.Text} {textbox_triangle_dot3x.Text} {textbox_triangle_dot3y.Text}";
            sendData = Encoding.ASCII.GetBytes(message);
            stream.Write(sendData, 0, sendData.Length);
        }

        private void textbox_rectangle_send_Click(object sender, EventArgs e)
        {
            message = $"Rectangle {textbox_rectangle_color.Text} {textbox_rectangle_dot1x.Text} {textbox_rectangle_dot1y.Text} {textbox_rectangle_height.Text} {textbox_rectangle_width.Text}";
            sendData = Encoding.ASCII.GetBytes(message);
            stream.Write(sendData, 0, sendData.Length);
        }

        private void textbox_circle_send_Click(object sender, EventArgs e)
        {
            message = $"Circle {textbox_circle_color.Text} {textbox_circle_centerx.Text} {textbox_circle_centery.Text} {textbox_circle_radius.Text}";
            sendData = Encoding.ASCII.GetBytes(message);
            stream.Write(sendData, 0, sendData.Length);
        }

        private void textbox_ellipse_send_Click(object sender, EventArgs e)
        {
            message = $"Ellipse {textbox_ellipse_color.Text} {textbox_ellipse_centerx.Text} {textbox_ellipse_centery.Text} {textbox_ellipse_radius1.Text} {textbox_ellipse_radius2.Text}";
            sendData = Encoding.ASCII.GetBytes(message);
            stream.Write(sendData, 0, sendData.Length);
        }

        private void button_line_random_Click(object sender, EventArgs e)
        {
            x = (float)(random.NextDouble() * canvasWidth);
            y = (float)(random.NextDouble() * canvasHeight);
            textbox_line_dot1x.Text = x.ToString();
            textbox_line_dot1y.Text = y.ToString();

            x = (float)(random.NextDouble() * canvasWidth);
            y = (float)(random.NextDouble() * canvasHeight);
            textbox_line_dot2x.Text = x.ToString();
            textbox_line_dot2y.Text = y.ToString();

            int index = random.Next(0, colors.Length);
            textbox_line_color.Text = colors[index];
        }

        private void button_triangle_random_Click(object sender, EventArgs e)
        {
            x = (float)(random.NextDouble() * canvasWidth);
            y = (float)(random.NextDouble() * canvasHeight);
            textbox_triangle_dot1x.Text = x.ToString();
            textbox_triangle_dot1y.Text = y.ToString();

            x = (float)(random.NextDouble() * canvasWidth);
            y = (float)(random.NextDouble() * canvasHeight);
            textbox_triangle_dot2x.Text = x.ToString();
            textbox_triangle_dot2y.Text = y.ToString();

            x = (float)(random.NextDouble() * canvasWidth);
            y = (float)(random.NextDouble() * canvasHeight);
            textbox_triangle_dot3x.Text = x.ToString();
            textbox_triangle_dot3y.Text = y.ToString();

            int index = random.Next(0, colors.Length);
            textbox_triangle_color.Text = colors[index];
        }

        private void textbox_circle_random_Click(object sender, EventArgs e)
        {
            x = (float)(random.NextDouble() * canvasWidth);
            y = (float)(random.NextDouble() * canvasHeight);
            textbox_circle_centerx.Text = x.ToString();
            textbox_circle_centery.Text = y.ToString();

            float maxRadius = Math.Min(Math.Min(x, canvasWidth - x), Math.Min(y, canvasHeight - y));
            float radius = (float)(random.NextDouble() * maxRadius);
            textbox_circle_radius.Text = radius.ToString();

            int index = random.Next(0, colors.Length);
            textbox_circle_color.Text = colors[index];
        }

        private void textbox_ellipse_random_Click(object sender, EventArgs e)
        {
            float maxRadius1 = Math.Min(x, canvasWidth - x);
            float maxRadius2 = Math.Min(y, canvasHeight - y);

            x = (float)(random.NextDouble() * (canvasWidth - 2 * maxRadius1) + maxRadius1);
            y = (float)(random.NextDouble() * (canvasHeight - 2 * maxRadius2) + maxRadius2);

            textbox_ellipse_centerx.Text = x.ToString();
            textbox_ellipse_centery.Text = y.ToString();

            float radius1 = (float)(random.NextDouble() * maxRadius1);
            float radius2 = (float)(random.NextDouble() * maxRadius2);
            textbox_ellipse_radius1.Text = radius1.ToString();
            textbox_ellipse_radius2.Text = radius2.ToString();

            int index = random.Next(0, colors.Length);
            textbox_ellipse_color.Text = colors[index];
        }

        private void button_polygon_add_point_Click(object sender, EventArgs e)
        {
            x = float.Parse(textbox_polygon_dotx.Text, CultureInfo.InvariantCulture.NumberFormat);
            y = float.Parse(textbox_polygon_doty.Text, CultureInfo.InvariantCulture.NumberFormat);
            polygonDots.Add(new PointF(x, y));
            listbox_polygon.Items.Add($"{x}, {y}");
            textbox_polygon_dotx.Clear();
            textbox_polygon_doty.Clear();
        }

        private void button_polygon_send_Click(object sender, EventArgs e)
        {
            string color = textbox_polygon_color.Text;
            StringBuilder messageBuilder = new StringBuilder();
            messageBuilder.Append("Polygon ").Append(color);

            foreach (PointF point in polygonDots)
            {
                messageBuilder.Append(" ").Append(point.X.ToString(CultureInfo.InvariantCulture)).Append(" ").Append(point.Y.ToString(CultureInfo.InvariantCulture));
            }

            string message = messageBuilder.ToString();
            byte[] sendData = Encoding.ASCII.GetBytes(message);

            try
            {
                stream.Write(sendData, 0, sendData.Length);
                polygonDots.Clear();
                listbox_polygon.Items.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error sending data: {ex.Message}");
            }

        }

        private void button_polygon_random_Click(object sender, EventArgs e)
        {
            int numDots = random.Next(3, 11);
            listbox_polygon.Items.Clear();

            int index = random.Next(0, colors.Length);
            textbox_polygon_color.Text = colors[index];

            float centerX = random.Next(canvasWidth);
            float centerY = random.Next(canvasHeight);

            float maxRadius = Math.Min(centerX, canvasWidth - centerX);
            maxRadius = Math.Min(maxRadius, centerY);
            maxRadius = Math.Min(maxRadius, canvasHeight - centerY);

            float radius = (float)(random.NextDouble() * maxRadius);

            List<float> angles = new List<float>();
            for (int i = 0; i < numDots; i++)
            {
                float angle = (float)(random.NextDouble() * 2 * Math.PI);
                angles.Add(angle);
            }
            angles.Sort();

            foreach (float angle in angles)
            {
                float x = centerX + (float)(radius * Math.Cos(angle));
                float y = centerY + (float)(radius * Math.Sin(angle));

                listbox_polygon.Items.Add($"{x.ToString(CultureInfo.InvariantCulture)} {y.ToString(CultureInfo.InvariantCulture)}");
                polygonDots.Add(new PointF(x, y));
            }
        }

        private void textbox_rectangle_random_Click(object sender, EventArgs e)
        {
            x = (float)(random.NextDouble() * canvasWidth);
            y = (float)(random.NextDouble() * canvasHeight);
            textbox_rectangle_dot1x.Text = x.ToString();
            textbox_rectangle_dot1y.Text = y.ToString();

            float width = (float)(random.NextDouble() * (canvasWidth - x));
            float height = (float)(random.NextDouble() * (canvasHeight - y));
            textbox_rectangle_width.Text = width.ToString();
            textbox_rectangle_height.Text = height.ToString();

            int index = random.Next(0, colors.Length);
            textbox_rectangle_color.Text = colors[index];
        }
    }

}
