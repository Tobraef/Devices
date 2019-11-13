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

        public ScannerUI()
        {
            InitializeComponent();
            scanPicture.BorderStyle = BorderStyle.FixedSingle;
            manager = new WIA.DeviceManager();
            foreach(WIA.DeviceInfo device in manager.DeviceInfos)
            {
                if (device.Type.Equals(WIA.WiaDeviceType.ScannerDeviceType))
                {
                    devicesBox.Items.Add(device.DeviceID);
                }
            }
            DisableScanButton();
        }

        private void ScanButton_Click(object sender, EventArgs e)
        {
            DisableScanButton();
            WIA.CommonDialog dialog = new WIA.CommonDialog();
            foreach(WIA.Property property in scanner.Properties)
            {
                if (property.PropertyID.Equals(horizontalPropertyId) && !property.IsReadOnly)
                {
                    property.set_Value(trackBarHResolution.Value);
                }
                if (property.PropertyID.Equals(verticalPropertyId) && !property.IsReadOnly)
                {
                    property.set_Value(trackBarVResolution.Value);
                }
            }
            WIA.ImageFile imageFile = (WIA.ImageFile)dialog.ShowTransfer(scanner, WIA.FormatID.wiaFormatPNG, false);
            var tempFile = Path.Combine(Path.GetTempPath(), Path.GetTempFileName());
            imageFile.SaveFile(tempFile);
            var image = Image.FromFile(tempFile);
            scanPicture.Image = image;
            File.Delete(tempFile);
            EnableScanButton();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            scannerDevice = null;
            scanner = null;
            foreach(WIA.DeviceInfo device in manager.DeviceInfos)
            {
                if (device.DeviceID.Equals(devicesBox.SelectedText))
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
            foreach(WIA.Property property in scanner.Properties)
            {
                if(property.PropertyID.Equals(horizontalPropertyId))
                {
                    if (property.IsReadOnly)
                    {
                        Console.WriteLine("HorizontalDPI is read only");
                    }
                    else
                    {
                        trackBarHResolution.Minimum = property.SubTypeMin;
                        trackBarHResolution.SmallChange = property.SubTypeStep;
                        trackBarHResolution.Maximum = property.SubTypeMax;
                    }
                }
                else if (property.PropertyID.Equals(verticalPropertyId))
                {
                    if (property.IsReadOnly)
                    {
                        Console.WriteLine("VerticalDPI is read only");
                    }
                    else
                    {
                        trackBarVResolution.Minimum = property.SubTypeMin;
                        trackBarVResolution.SmallChange = property.SubTypeStep;
                        trackBarVResolution.Maximum = property.SubTypeMax;
                    }
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
    }
}
