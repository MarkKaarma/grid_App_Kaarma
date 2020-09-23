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
        public MainPage()
        {
            /*Grid grid = new Grid
            {
                RowDefinitions =
                {
                    new RowDefinition{Height=new GridLength(1,GridUnitType.Star)},
                    new RowDefinition{Height=new GridLength(1,GridUnitType.Star)},
                    new RowDefinition{Height=new GridLength(1,GridUnitType.Star)},
                    new RowDefinition{Height=new GridLength(1,GridUnitType.Star)},
                    new RowDefinition{Height=new GridLength(1,GridUnitType.Star)}
                }
                ColumnDefinitions =
                {
                    new ColumnDefinition{Width=new GridLength(1,GridUnitType.Star)},
                    new ColumnDefinition{Width=new GridLength(1,GridUnitType.Star)},
                    new ColumnDefinition{Width=new GridLength(1,GridUnitType.Star)},
                    new ColumnDefinition{Width=new GridLength(1,GridUnitType.Star)},
                    new ColumnDefinition{Width=new GridLength(1,GridUnitType.Star)}
                }
            };*/
            Grid grid = new Grid(); // Цикл, что бы не было, как выше.
            for (int i = 0; i < 3; i++)
            {
                grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
                grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                   box=new BoxView { Color=Color.FromRgb(355,0,124)};
                    grid.Children.Add(box, i, j);
                    var tap = new TapGestureRecognizer();
                    //tap.Tapped += Tap_Tapped;
                    box.GestureRecognizers.Add(tap);
                    tap.Tapped += async (object sender, EventArgs e) =>
                    {
                        BoxView box = sender as BoxView;
                        if (box.Color == new Color(355, 0, 0))
                        {
                            box.Color = Color.FromRgb(355, 0, 124);
                        }
                        else
                        {
                            box.Color = new Color(355, 0, 0);
                        }
                    };   

            }

            }

            Content = grid;
        }


        /*private void Tap_Tapped(object sender, EventArgs e)
        {
            BoxView box = sender as BoxView;
            box.Color = Color.Azure;

        }*/
    }
}
