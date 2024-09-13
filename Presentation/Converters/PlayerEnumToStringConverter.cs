using System;
using System.Globalization;
using TicTacToe.Game;
using Microsoft.Maui.Controls.Compatibility;
using Microsoft.Maui.Controls;
using Microsoft.Maui;

namespace TicTacToe.Presentation.Converters
{
    public class PlayerEnumToStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is Player player)
            {
                if (player == Player.X)
                    return "X";
                else if (player == Player.O)
                    return "O";
            }

            return "";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
