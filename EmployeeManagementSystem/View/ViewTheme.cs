using System;
using System.Drawing;
using System.Windows.Forms;

namespace EmployeeManagementSystem.View
{
    internal static class ViewTheme
    {
        // Corporate Navy & Slate Palette
        public static readonly Color NavyPrimary = Color.FromArgb(26, 47, 77);      // #1A2F4D
        public static readonly Color NavyLight = Color.FromArgb(41, 71, 115);       // #294773
        public static readonly Color NavyDark = Color.FromArgb(17, 31, 51);         // #111F33
        public static readonly Color AccentBlue = Color.FromArgb(26, 86, 219);      // #1A56DB
        public static readonly Color SuccessGreen = Color.FromArgb(22, 101, 52);    // #166534
        public static readonly Color WarningAmber = Color.FromArgb(180, 83, 9);     // #B45309
        public static readonly Color DangerRed = Color.FromArgb(185, 28, 28);       // #B91C1C

        public static readonly Color TextDark = Color.FromArgb(15, 23, 42);         // #0F172A
        public static readonly Color TextMuted = Color.FromArgb(100, 116, 139);     // #64748B
        public static readonly Color TextLight = Color.FromArgb(241, 245, 249);     // #F1F5F9

        public static readonly Color CanvasBackground = Color.FromArgb(244, 246, 250); // #F4F6FA
        public static readonly Color CardBackground = Color.White;
        public static readonly Color BorderColor = Color.FromArgb(226, 232, 240);    // #E2E8F0
        public static readonly Color BorderActive = Color.FromArgb(148, 163, 184);   // #94A3B8
        public static readonly Color TableStripe = Color.FromArgb(248, 250, 252);    // #F8FAFC
        public static readonly Color SelectionRow = Color.FromArgb(224, 237, 255);   // Soft ice blue

        public static readonly Font TitleFont = new Font("Segoe UI", 14F, FontStyle.Bold);
        public static readonly Font SubtitleFont = new Font("Segoe UI", 9.5F, FontStyle.Regular);
        public static readonly Font HeaderFont = new Font("Segoe UI", 9.5F, FontStyle.Bold);
        public static readonly Font NormalFont = new Font("Segoe UI", 9.75F, FontStyle.Regular);
        public static readonly Font BoldFont = new Font("Segoe UI", 9.75F, FontStyle.Bold);
        public static readonly Font SmallFont = new Font("Segoe UI", 8.5F, FontStyle.Regular);

        public static void Apply(Control root)
        {
            if (root is Form form)
            {
                form.Font = NormalFont;
                if (form.BackColor != CardBackground && form.BackColor != NavyPrimary)
                {
                    form.BackColor = CanvasBackground;
                }
            }

            StyleControl(root);
            foreach (Control child in root.Controls)
            {
                Apply(child);
            }
        }

        private static void StyleControl(Control control)
        {
            if (control is DataGridView grid)
            {
                grid.BackgroundColor = CardBackground;
                grid.BorderStyle = BorderStyle.None;
                grid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
                grid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
                grid.ColumnHeadersHeight = 38;
                grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
                grid.ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle
                {
                    BackColor = NavyPrimary,
                    ForeColor = Color.White,
                    SelectionBackColor = NavyPrimary,
                    SelectionForeColor = Color.White,
                    Font = HeaderFont,
                    Padding = new Padding(8, 0, 8, 0),
                    Alignment = DataGridViewContentAlignment.MiddleLeft
                };
                grid.DefaultCellStyle = new DataGridViewCellStyle
                {
                    BackColor = CardBackground,
                    ForeColor = TextDark,
                    SelectionBackColor = SelectionRow,
                    SelectionForeColor = TextDark,
                    Font = NormalFont,
                    Padding = new Padding(8, 0, 8, 0),
                    Alignment = DataGridViewContentAlignment.MiddleLeft
                };
                grid.AlternatingRowsDefaultCellStyle = new DataGridViewCellStyle
                {
                    BackColor = TableStripe,
                    ForeColor = TextDark,
                    SelectionBackColor = SelectionRow,
                    SelectionForeColor = TextDark,
                    Padding = new Padding(8, 0, 8, 0)
                };
                grid.EnableHeadersVisualStyles = false;
                grid.GridColor = BorderColor;
                grid.MultiSelect = false;
                grid.ReadOnly = true;
                grid.RowHeadersVisible = false;
                grid.RowTemplate.Height = 36;
                grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
            else if (control is Button button)
            {
                StyleButton(button);
            }
            else if (control is TextBox textBox)
            {
                if (!textBox.ReadOnly)
                {
                    textBox.BackColor = CardBackground;
                    textBox.BorderStyle = BorderStyle.FixedSingle;
                    textBox.Font = NormalFont;
                    textBox.ForeColor = TextDark;
                }
                else
                {
                    textBox.BackColor = Color.FromArgb(241, 245, 249);
                    textBox.BorderStyle = BorderStyle.FixedSingle;
                    textBox.Font = NormalFont;
                    textBox.ForeColor = TextMuted;
                }
            }
            else if (control is ComboBox comboBox)
            {
                comboBox.FlatStyle = FlatStyle.Flat;
                comboBox.Font = NormalFont;
                comboBox.BackColor = CardBackground;
                comboBox.ForeColor = TextDark;
            }
            else if (control is GroupBox groupBox)
            {
                groupBox.Font = HeaderFont;
                groupBox.ForeColor = NavyPrimary;
                groupBox.BackColor = Color.Transparent;
            }
            else if (control is TabControl tab)
            {
                tab.Font = NormalFont;
            }
            else if (control is DateTimePicker dtp)
            {
                dtp.Font = NormalFont;
            }
            else if (control is NumericUpDown num)
            {
                num.Font = NormalFont;
                num.BorderStyle = BorderStyle.FixedSingle;
                num.BackColor = CardBackground;
            }
        }

        private static void StyleButton(Button button)
        {
            button.Font = BoldFont;
            button.Cursor = Cursors.Hand;
            button.UseVisualStyleBackColor = false;

            // Distinguish between primary, danger, success, and outline buttons
            bool isWhiteText = button.ForeColor == Color.White;
            bool isGreen = button.BackColor.G > 90 && button.BackColor.R < 80;
            bool isRed = button.BackColor.R > 140 && button.BackColor.G < 70;

            if (isWhiteText)
            {
                button.FlatStyle = FlatStyle.Flat;
                button.FlatAppearance.BorderSize = 0;

                if (isGreen)
                {
                    button.BackColor = SuccessGreen;
                    button.FlatAppearance.MouseOverBackColor = Color.FromArgb(21, 128, 61);
                    button.FlatAppearance.MouseDownBackColor = Color.FromArgb(20, 83, 45);
                }
                else if (isRed)
                {
                    button.BackColor = DangerRed;
                    button.FlatAppearance.MouseOverBackColor = Color.FromArgb(220, 38, 38);
                    button.FlatAppearance.MouseDownBackColor = Color.FromArgb(153, 27, 27);
                }
                else
                {
                    button.BackColor = NavyPrimary;
                    button.FlatAppearance.MouseOverBackColor = NavyLight;
                    button.FlatAppearance.MouseDownBackColor = NavyDark;
                }
            }
            else
            {
                // Secondary / Outline button
                button.FlatStyle = FlatStyle.Flat;
                button.BackColor = CardBackground;
                button.ForeColor = TextDark;
                button.FlatAppearance.BorderSize = 1;
                button.FlatAppearance.BorderColor = BorderColor;
                button.FlatAppearance.MouseOverBackColor = Color.FromArgb(241, 245, 249);
                button.FlatAppearance.MouseDownBackColor = SelectionRow;
            }
        }
    }
}

