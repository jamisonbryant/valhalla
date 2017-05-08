using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Valhalla.View.Helper
{
    /// <summary>
    /// Provides functions for manipulating and styling form elements.
    /// </summary>
    public static class FormHelper
    {
        private static int ERROR_STATE_STYLE_BORDER_THICKNESS = 2;
        private static int WARNING_STATE_STYLE_BORDER_THICKNESS = 2;
        private static SolidColorBrush ERROR_STATE_STYLE_BORDER_COLOR = Brushes.Red;
        private static SolidColorBrush ERROR_STATE_STYLE_BACKGROUND_COLOR = Brushes.Pink;
        private static SolidColorBrush WARNING_STATE_STYLE_BORDER_COLOR = Brushes.Goldenrod;
        private static SolidColorBrush WARNING_STATE_STYLE_BACKGROUND_COLOR = Brushes.Wheat;

        /// <summary>
        /// Applies the error state style to a text box.
        /// </summary>
        ///
        /// <param name="textBox">Text box to apply style to</param>
        public static void ApplyErrorStateStyle(TextBox textBox)
        {
            // TODO: Add support for customizing error state style (#1)
            ApplyStateStyle(
                textBox,
                ERROR_STATE_STYLE_BACKGROUND_COLOR,
                ERROR_STATE_STYLE_BORDER_COLOR,
                ERROR_STATE_STYLE_BORDER_THICKNESS
            );
        }

        /// <summary>
        /// Applies the error state style to a password box.
        /// </summary>
        ///
        /// <param name="passwordBox">Password box to apply style to</param>
        public static void ApplyErrorStateStyle(PasswordBox passwordBox)
        {
            // TODO: Add support for customizing error state style (#1)
            ApplyStateStyle(
                passwordBox,
                ERROR_STATE_STYLE_BACKGROUND_COLOR,
                ERROR_STATE_STYLE_BORDER_COLOR,
                ERROR_STATE_STYLE_BORDER_THICKNESS
            );
        }

        /// <summary>
        /// Applies the warning state style to a text box.
        /// </summary>
        ///
        /// <param name="textBox">Text box to apply style to</param>
        public static void ApplyWarningStateStyle(TextBox textBox)
        {
            // TODO: Add support for customizing warning state style (#1)
            ApplyStateStyle(
                textBox,
                WARNING_STATE_STYLE_BACKGROUND_COLOR,
                WARNING_STATE_STYLE_BORDER_COLOR,
                WARNING_STATE_STYLE_BORDER_THICKNESS
            );
        }

        /// <summary>
        /// Applies the warning state style to a password box.
        /// </summary>
        ///
        /// <param name="passwordBox">Password box to apply style to</param>
        public static void ApplyWarningStateStyle(PasswordBox passwordBox)
        {
            // TODO: Add support for customizing warning state style (#1)
            ApplyStateStyle(
                passwordBox,
                WARNING_STATE_STYLE_BACKGROUND_COLOR,
                WARNING_STATE_STYLE_BORDER_COLOR,
                WARNING_STATE_STYLE_BORDER_THICKNESS
            );
        }

        /// <summary>
        /// Applies a state style to a control.
        /// </summary>
        ///
        /// <param name="controlToStyle">Control to apply style to</param>
        /// <param name="backgroundColor">Color to change control background to</param>
        /// <param name="borderColor">Color to change control border to</param>
        /// <param name="borderThickness">Thickness of border to apply to control</param>
        private static void ApplyStateStyle(Control controlToStyle,
            SolidColorBrush backgroundColor, SolidColorBrush borderColor,
            int borderThickness)
        {
            var border = (Border) controlToStyle.Parent;
            var margins = controlToStyle.Margin;

            // Set background color
            controlToStyle.Background = backgroundColor;

            // Set border color and thickness
            // Applying a border to a control with defined margins will increase
            // the net margins instead of overriding them. To fix this, we must
            // do the override manually by setting the existing marginsto zero.
            controlToStyle.Margin = new Thickness(0);

            border.Margin = new Thickness(
                margins.Left - borderThickness,
                margins.Top - borderThickness,
                margins.Right - borderThickness,
                margins.Bottom - borderThickness
            );

            border.BorderBrush = borderColor;
            border.BorderThickness = new Thickness(borderThickness);
        }
    }
}
