using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace BikeShop.Helpers
{
    /// <summary>
    /// Generic validation and screen-clearing routines (from the class samples),
    /// shared by every form. Each method shows a message, puts the focus on the
    /// bad control and returns false when the data is not valid.
    /// </summary>
    internal static class ValidationHelper
    {
        public static string Title { get; set; } = "Entry Error";

        // ---------- Required fields ----------

        public static bool IsPresent(Control control, string name)
        {
            if (control.Text.Trim() == "")
            {
                ShowError(control, $"{name} is a required field.");
                return false;
            }
            return true;
        }

        /// <summary>For MaskedTextBox fields such as phone and postal code.</summary>
        public static bool IsMaskCompleted(MaskedTextBox mask, string name)
        {
            if (!mask.MaskCompleted)
            {
                ShowError(mask, $"{name} must be entered in the format {mask.Mask.Replace('0', '#')}.");
                return false;
            }
            return true;
        }

        /// <summary>For DropDownList combo boxes.</summary>
        public static bool IsSelected(ComboBox combo, string name)
        {
            if (combo.SelectedIndex == -1)
            {
                ShowError(combo, $"Please select a {name}.");
                return false;
            }
            return true;
        }

        // ---------- Numeric data ----------

        public static bool IsDecimal(TextBox textBox, string name)
        {
            if (!decimal.TryParse(textBox.Text, out _))
            {
                ShowError(textBox, $"{name} must be a decimal number.");
                return false;
            }
            return true;
        }

        public static bool IsInt32(TextBox textBox, string name)
        {
            if (!int.TryParse(textBox.Text, out _))
            {
                ShowError(textBox, $"{name} must be a whole number.");
                return false;
            }
            return true;
        }

        public static bool IsWithinRange(TextBox textBox, string name, decimal min, decimal max)
        {
            decimal number = Convert.ToDecimal(textBox.Text);
            if (number < min || number > max)
            {
                ShowError(textBox, $"{name} must be between {min} and {max}.");
                return false;
            }
            return true;
        }

        // ---------- Dates ----------

        public static bool IsDateWithinRange(DateTimePicker picker, string name, DateTime min, DateTime max)
        {
            if (picker.Value.Date < min.Date || picker.Value.Date > max.Date)
            {
                ShowError(picker, $"{name} must be between {min:d} and {max:d}.");
                return false;
            }
            return true;
        }

        // ---------- Formats ----------

        public static bool IsValidEmail(TextBox textBox, string name)
        {
            string pattern = @"^[\w\.\-+]+@[\w\-]+(\.[\w\-]+)+$";
            if (!Regex.IsMatch(textBox.Text.Trim(), pattern))
            {
                ShowError(textBox, $"{name} must be a valid email address (example: name@domain.com).");
                return false;
            }
            return true;
        }

        // ---------- Clearing the screen ----------

        /// <summary>
        /// Clears every input control on the form (recursing into group boxes
        /// and panels). Labels, buttons and read-only text boxes are left alone.
        /// </summary>
        public static void ClearControls(Control.ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                switch (control)
                {
                    case MaskedTextBox mask:
                        mask.Clear();
                        break;
                    case TextBox textBox when !textBox.ReadOnly:
                        textBox.Clear();
                        break;
                    case ComboBox combo:
                        combo.SelectedIndex = -1;
                        break;
                    case CheckBox check:
                        check.Checked = false;
                        break;
                    case RadioButton radio:
                        radio.Checked = false;
                        break;
                    case DateTimePicker picker:
                        picker.Value = DateTime.Today;
                        break;
                    case NumericUpDown number:
                        number.Value = number.Minimum;
                        break;
                }

                if (control.HasChildren && control is not DataGridView)
                {
                    ClearControls(control.Controls);
                }
            }
        }

        private static void ShowError(Control control, string message)
        {
            MessageBox.Show(message, Title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            control.Focus();
        }
    }
}
