using Microsoft.Win32;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace HighlightСolor
{
    public partial class Form1 : Form
    {
        public RegistryKey keyColorsHilight;
        public RegistryKey keyHotTrackingColor;
        public WorkRegistry workRegistry = new WorkRegistry();
        public DominationColor dominationColor = new DominationColor();
        public string pathImageDesctop = @"C:\Users\" + Environment.UserName + @"\AppData\Roaming\Microsoft\Windows\Themes\TranscodedWallpaper";
        
        public Form1()
        {
            InitializeComponent();   
        }

        private void Apply_Click(object sender, EventArgs e)
        {
            workRegistry.ApplyColor(colorValues.Text, hotTreckingValues.Text);
        }

        private void OriginalColors_Click(object sender, EventArgs e)
        {
            string colorHilight = "0 120 215";
            string hotTrackingColor = "0 102 204";
            colorValues.Text = colorHilight;
            hotTreckingValues.Text = hotTrackingColor;
            workRegistry.ApplyColor(colorHilight, hotTrackingColor);
        }

        private void colorValues_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == ',' || e.KeyChar == 8) return;
            else
                e.Handled = true;
        }

        private void hotTreckingValues_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == ',' || e.KeyChar == 8) return;
            else
                e.Handled = true;
        }

        private void hint_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Вводить значения нужно в RGB формате."
                + "Пример: 255,0,255", "Подсказка");
        }

        private void colorValues_TextChanged(object sender, EventArgs e)
        {
            workRegistry.RemoveText(colorValues);
        }

        private void hotTreckingValues_TextChanged(object sender, EventArgs e)
        {
            workRegistry.RemoveText(hotTreckingValues);
        }

        private void Selection_Click(object sender, EventArgs e)
        {
            try
            {
                Bitmap bitmap = new Bitmap(pathImageDesctop);
                Color colors = dominationColor.GetColor(bitmap);
                colorValues.Text = $"{colors.R},{colors.G},{colors.B}";
                colorPanel.BackColor = colors;
                int offset = 50;
                int r = colors.R + offset > 254 ? 254 : colors.R + offset;
                int g = colors.G + offset > 254 ? 254 : colors.G + offset;
                int b = colors.B + offset > 254 ? 254 : colors.B + offset;
                hotTreckingValues.Text = $"{r},{g},{b}";
                hotTreckingPanel.BackColor = Color.FromArgb(r,g,b);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void colorPanel_Click(object sender, EventArgs e)
        {
           workRegistry.RefrashColorPanel(colorValues, colorPanel, colorDialog1,colorPanel.BackColor);
        }

        private void hotTreckingPanel_Click(object sender, EventArgs e)
        {
            workRegistry.RefrashColorPanel(hotTreckingValues, hotTreckingPanel, colorDialog1, hotTreckingPanel.BackColor);
        }
    }
}