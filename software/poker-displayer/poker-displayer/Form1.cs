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
using System.IO;

namespace poker_displayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Width = 530;
            Height = 320;
        }

        private void Card_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void SendCard_Click(object sender, EventArgs e)
        {
            WebRequest request = WebRequest.Create("http://37.187.181.129:8080/api/player/update-info");

            request.Method = "PUT";

            if (PlayerIndex.SelectedIndex != -1 && CardIndex.SelectedIndex != -1 && Card.SelectedIndex != -1)
            {
                string postData = "playerId=" + PlayerIndex.SelectedItem.ToString() + "&cardNumber=" + CardIndex.SelectedItem.ToString() + "&cardValue=" + Card.SelectedItem.ToString();
                byte[] byteArray = Encoding.UTF8.GetBytes(postData);

                request.ContentType = "application/x-www-form-urlencoded";
                request.ContentLength = byteArray.Length;

                Stream dataStream = request.GetRequestStream();

                dataStream.Write(byteArray, 0, byteArray.Length);
                dataStream.Close();
            }

        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            WebRequest request = WebRequest.Create("http://37.187.181.129:8080/api/player/reset-info");

            request.Method = "GET";

            Stream dataStream = request.GetResponse().GetResponseStream();
            dataStream.Close();
        }

        private void SendNickname_Click(object sender, EventArgs e)
        {
            WebRequest request = WebRequest.Create("http://37.187.181.129:8080/api/player/update-nickname");

            request.Method = "PUT";

            if (PlayerIndex2.SelectedIndex != -1)
            {
                string postData = "playerId=" + PlayerIndex2.SelectedItem.ToString() + "&nickname=" + Nickname.Text.ToString();
                byte[] byteArray = Encoding.UTF8.GetBytes(postData);

                request.ContentType = "application/x-www-form-urlencoded";
                request.ContentLength = byteArray.Length;

                Stream dataStream = request.GetRequestStream();

                dataStream.Write(byteArray, 0, byteArray.Length);
                dataStream.Close();
            }
        }
    }
}
