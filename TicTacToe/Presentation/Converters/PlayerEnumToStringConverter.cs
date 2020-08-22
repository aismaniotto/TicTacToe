using System;
using System.Globalization;
using TicTacToe.Game;
using Xamarin.Forms;

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
