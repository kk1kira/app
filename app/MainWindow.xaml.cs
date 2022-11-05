﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

namespace app
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int k = 3;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(Password.Password))
            {
                MessageBox.Show("Введите данные");
            }

            //String allowchar = " ";
            //allowchar = "A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,T,U,V,W,X,Y,Z";
            //allowchar += "a,b,c,d,e,f,g,h,i,j,k,l,m,n,o,p,q,r,s,t,u,v,w,y,z";
            //allowchar += "1,2,3,4,5,6,7,8,9,0";
            //char[] a = { ',' };
            //String[] ar = allowchar.Split(a);
            //String pwd = "";
            //string temp = "";
            //Random r = new Random();
            //for (int i = 0; i < 6; i++)
            //{
            //    temp = ar[(r.Next(0, ar.Length))];
            //    pwd += temp;

            //}
            //txt1.Text = pwd;
            
            if (txt1.Text == Password.Password.ToString())
            {
                Main main = new Main();
                main.Show();
                this.Close();
            } else
            {
                k = k - 1;
                MessageBox.Show("Не верно введены данные. У вас осталось " + k +" попыток");
                Password.Clear();
                if(k == 0)
                {
                    this.Close();
                }
            }


        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
