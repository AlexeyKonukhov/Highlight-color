using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace HighlightСolor
{
    public class WorkRegistry
    {
        public RegistryKey keyColorsHilight;
        public RegistryKey keyHotTrackingColor;

        public void RemoveText(TextBox textBox)
        {
            if (textBox.Text.Length > 11)
            {
                textBox.Text = textBox.Text.Remove(11, 1);
            }
        }

        public void RefrashColorPanel(TextBox textBox, Panel panel, ColorDialog colorDialog, Color color)
        {
            colorDialog.Color = color;
            colorDialog.ShowDialog();
            panel.BackColor = colorDialog.Color;
            textBox.Text = $"{colorDialog.Color.R},{colorDialog.Color.G},{colorDialog.Color.B}";
        }

        public void ApplyColor(string hilight, string hotTrackingColor)
        {
            if (!string.IsNullOrWhiteSpace(hilight) && !string.IsNullOrWhiteSpace(hotTrackingColor))
            {
                try
                {
                    RegistryOpen();
                    keyColorsHilight.SetValue("Hilight", TextFormat(hilight));
                    keyHotTrackingColor.SetValue("HotTrackingColor", TextFormat(hotTrackingColor));
                    RegistryClose();
                    if (MessageBox.Show("Перезагрузить сейчас ?", "Предупреждение !", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        Process.Start("shutdown", "/r /t 0");
                    }
                }
                catch (Exception e)
                {

                    MessageBox.Show(e.Message);
                }
            }
            else
            {
                MessageBox.Show("Ошибка, заданы не все значиния", "Ошибка");
            }
        }

        private void RegistryClose()
        {
            keyColorsHilight.Close();
            keyHotTrackingColor.Close();
        }

        private void RegistryOpen()
        {
            keyColorsHilight = Registry.CurrentUser.OpenSubKey(@"Control Panel\Colors", true);
            keyHotTrackingColor = Registry.CurrentUser.OpenSubKey(@"Control Panel\Colors", true);
        }

        private string TextFormat(string value)
        {
            return value.Replace(",", " ");
        }

        
    }
}
