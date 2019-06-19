﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Thread_HomeWork
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Thread thread;

        public MainWindow()
        {
            InitializeComponent();

            thread = new Thread(Music);
            thread.IsBackground = true;
            thread.Start();

        }
        public void CloseButtonClick(object sender, RoutedEventArgs e)
        {
            using (var streamFile = new StreamWriter("Новый текстовый документ.txt"))
            {
                streamFile.WriteLine(textBox.Text);
            }
        }

        public void Music()
        {
            var player = new MediaPlayer();
            player.Open(new Uri("music.mp3", UriKind.RelativeOrAbsolute));
            player.Play();
        }
    }
}