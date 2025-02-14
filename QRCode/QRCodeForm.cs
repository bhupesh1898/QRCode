using System;
using System.Windows.Forms;
using System.Drawing;
using QRCoder;
using System.IO;
using System.Diagnostics;


namespace QRCode
{
    public partial class QRCodeForm : Form
    {
        public QRCodeForm()
        {
            InitializeComponent();
            this.Load += new EventHandler(Form1_Load);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string qrContent = "https://www.instagram.com/bhupesh1898";

            QRCodeGenerator qrGenerator = new QRCodeGenerator();

            QRCodeData qrCodeData = qrGenerator.CreateQrCode(qrContent, QRCodeGenerator.ECCLevel.Q);

            QRCoder.QRCode qrCode = new QRCoder.QRCode(qrCodeData);

            Bitmap qrCodeImage = qrCode.GetGraphic(10);

            PictureBox qrPictureBox = new PictureBox
            {
                Image = qrCodeImage,
                SizeMode = PictureBoxSizeMode.AutoSize,
                Location = new Point(50, 50)
            };

            this.Controls.Add(qrPictureBox);

            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "QRCode.png");
            qrCodeImage.Save(filePath, System.Drawing.Imaging.ImageFormat.Png);

            Console.WriteLine("QR Code Generated Successfully!");
            Console.WriteLine($"QR Code saved to: {filePath}");

            try
            {
                Process.Start(new ProcessStartInfo(filePath) { UseShellExecute = true });
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error opening the file: " + ex.Message);
            }

        }
    }
}
