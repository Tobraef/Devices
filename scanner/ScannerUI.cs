using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ConsoleApp1
{
    public partial class ScannerUI : Form
    {
        private WIA.Item scanner;
        private WIA.Device scannerDevice;
        private WIA.DeviceManager manager;

        private const int horizontalPropertyId = 6147; // id for horizontalResolution
        private const int verticalPropertyId = 6148;  // id for verticalResolution
        private const int colorIntent = 6146;

        public ScannerUI()
        {
            InitializeComponent();
            FormClosing += ScannerUI_FormClosing;
            scanPicture.BorderStyle = BorderStyle.FixedSingle;
            manager = new WIA.DeviceManager();
            foreach (WIA.DeviceInfo device in manager.DeviceInfos)
            {
                if (device.Type.Equals(WIA.WiaDeviceType.ScannerDeviceType))
                {
                    devicesBox.Items.Add(device.DeviceID);
                }
            }
            DisableScanButton();
        }

        void ScannerUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            scanner = null;
            scannerDevice = null;
            manager = null;
        }

        private void ScanButton_Click(object sender, EventArgs e)
        {
            DisableScanButton();
            WIA.CommonDialog dialog = new WIA.CommonDialog();
            foreach (WIA.Property property in scanner.Properties)
            {
                if (property.PropertyID.Equals(horizontalPropertyId) && !property.IsReadOnly)
                {
                    property.set_Value(comboBoxHRes.SelectedItem);
                }
                if (property.PropertyID.Equals(verticalPropertyId) && !property.IsReadOnly)
                {
                    property.set_Value(comboBoxVRes.SelectedItem);
                }
                if (property.PropertyID.Equals(colorIntent))
                {
                    if (!property.IsReadOnly)
                    {
                        if (checkBoxColor.Checked)
                        {
                            property.set_Value(WIA.WiaImageIntent.ColorIntent);
                        }
                        else
                        {
                            property.set_Value(WIA.WiaImageIntent.GrayscaleIntent);
                        }
                    }
                }
            }
            WIA.ImageFile imageFile = (WIA.ImageFile)dialog.ShowTransfer(scanner, WIA.FormatID.wiaFormatPNG, false);
            var data = (byte[])imageFile.FileData.get_BinaryData();
            var stream = new MemoryStream(data);
            scanPicture.Image = new Bitmap(Image.FromStream(stream), scanPicture.Size);
            EnableScanButton();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            scannerDevice = null;
            scanner = null;
            foreach (WIA.DeviceInfo device in manager.DeviceInfos)
            {
                if (device.DeviceID.Equals(devicesBox.SelectedItem.ToString()))
                {
                    scannerDevice = device.Connect();
                    scanner = scannerDevice.Items[1];
                    EnableScanButton();
                    break;
                }
            }
            if (scannerDevice == null)
            {
                DisableScanButton();
                return;
            }
            foreach (WIA.Property property in scanner.Properties)
            {
                if (property.PropertyID.Equals(horizontalPropertyId))
                {
                    foreach(var i in property.SubTypeValues)
                    {
                        comboBoxHRes.Items.Add(i);
                    }
                    // default choose middle resolution
                    comboBoxHRes.SelectedIndex = comboBoxHRes.Items.Count / 2;
                    
                }
                else if (property.PropertyID.Equals(verticalPropertyId))
                {
                    foreach (var i in property.SubTypeValues)
                    {
                        comboBoxVRes.Items.Add(i);
                    }
                    // default choose middle resolution
                    comboBoxVRes.SelectedIndex = comboBoxVRes.Items.Count / 2;                
                }
            }
        }

        private void DisableScanButton()
        {
            scanButton.BackColor = Color.Red;
            scanButton.Enabled = false;
        }

        private void EnableScanButton()
        {
            scanButton.BackColor = Color.Green;
            scanButton.Enabled = true;
        }

        private void ButtonSaveToFile_Click(object sender, EventArgs e)
        {
            var fileToSave = Path.Combine(textBoxPath.Text, @"Scan.png");
            if (scanPicture.Image != null)
            {
                DisableScanButton();
                scanPicture.Image.Save(fileToSave);
                EnableScanButton();
            }
        }

        private void ScannerUI_Load(object sender, EventArgs e)
        {

        }
    }
}