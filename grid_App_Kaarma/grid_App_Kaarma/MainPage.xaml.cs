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
        Button new_game;
        bool turn = true;
        public MainPage()
        {
            New_Game_Clicked();
        }
        Grid grid = new Grid();
        void New_Game_Clicked()
        {
            // Цикл что бы не расписывать, как в xaml 
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
                    //tap.Tapped += Tap_Tapped1;
                }
            }
            new_game = new Button { Text = "Обнулить" };
            grid.Children.Add(new_game, 0, 3);
            Grid.SetColumnSpan(new_game, 2);
            new_game.Clicked += New_game_Clicked;
            Content = grid;
        }

        private void New_game_Clicked(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                {
                    box = new BoxView { Color = Color.FromRgb(355, 0, 124) };
                    var tap = new TapGestureRecognizer();
                    box.GestureRecognizers.Add(tap);
                    grid.Children.Add(box, i, j);
                    tap.Tapped += Tap_Tapped;
                }
        }

        /*private void Tap_Tapped1(object sender, EventArgs e)
        {
            BoxView box = sender as BoxView;
            box.Color = Color.Aqua;
        }*/
        private void Tap_Tapped(object sender, EventArgs e)
        {
            BoxView box = sender as BoxView;
            
            if (turn)
            {
               
                box.Color = Color.Black;
            }
            else
            {

                box.Color = Color.Blue;
            }
            turn = !turn;
        }
    }

}