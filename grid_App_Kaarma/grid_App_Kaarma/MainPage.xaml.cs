using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace grid_App_Kaarma
{
    public partial class MainPage : ContentPage
    {
        BoxView box;
        Button new_game, random_player;
        public MainPage()
        {
            New_Game_Clicked();
        }
        void New_Game_Clicked()
        {
            Grid grid = new Grid(); // Цикл что бы не расписывать, как в xaml 
            for (int i = 0; i < 4; i++)
            {
                grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
                grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    box = new BoxView { Color = Color.FromRgb(355, 0, 124) };
                    grid.Children.Add(box, i, j);
                    var tap = new TapGestureRecognizer();
                    box.GestureRecognizers.Add(tap);
                    tap.Tapped += Tap_Tapped;
                }
            }
            new_game = new Button { Text = "Обнулить" };
            grid.Children.Add(new_game, 0, 3);
            Grid.SetColumnSpan(new_game, 2);
            random_player = new Button { Text = "Крестик или нолик?" };
            grid.Children.Add(random_player, 2, 3);
            Grid.SetColumnSpan(random_player, 2);
            Content = grid;
        }


        private void Tap_Tapped(object sender, EventArgs e)
        {
            BoxView box = sender as BoxView;
            box.Color = Color.Black;
        }
    }

}

