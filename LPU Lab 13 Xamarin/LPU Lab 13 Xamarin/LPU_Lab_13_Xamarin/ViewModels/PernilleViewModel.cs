using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace LPU_Lab_13_Xamarin
{
    public class PernilleViewModel
    {
        public string Intro { get; set; }

        public ImageSource ImageSource => FileImageSource.FromUri(
            new Uri("https://scontent-ams3-1.xx.fbcdn.net/v/t1.0-9/10475515_10152537283119785_1616235661356090014_n.jpg?oh=d0cf0720273fe73f7bb99a3720f840b5&oe=59383CB6"));

        public PernilleViewModel()
        {
            Intro = "Welcome to this page about Pernille";
        }
    }
}
