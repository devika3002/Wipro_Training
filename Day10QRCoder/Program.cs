using System;
using System.Drawing;
using System.Drawing.Imaging;
using QRCoder;

namespace Demo_QR_Code_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Text or URL for QR Code
            string qrText = "https://www.wipro.com";

            // Step 1: Create QR Code Generator
            QRCodeGenerator qrGenerator = new QRCodeGenerator();

            // Step 2: Create QR Code Data
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(
                qrText,
                QRCodeGenerator.ECCLevel.Q
            );

            // Step 3: Create QR Code
            QRCode qrCode = new QRCode(qrCodeData);

            // Step 4: Generate QR Code Image
            Bitmap qrCodeImage = qrCode.GetGraphic(20);

            // Step 5: Save QR Code Image
            qrCodeImage.Save(
                "Wipro_QR_Code.png",
                ImageFormat.Png
            );

            Console.WriteLine("QR Code generated successfully!");
            Console.WriteLine("Saved as Wipro_QR_Code.png");

            Console.ReadKey();
        }
    }
}
