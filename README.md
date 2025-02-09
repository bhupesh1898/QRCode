QR Code (Windows Forms Application)

This is a Windows Forms application written in C# that generates a QR code for a given URL and displays it in the application window. The generated QR code is also saved as an image on the user's desktop and automatically opened.

Features

Generates a QR code from a predefined URL

Displays the QR code in the application window

Saves the QR code as a PNG file on the desktop

Automatically opens the saved QR code image

Technologies Used

C# (.NET Windows Forms)

QRCoder library for QR code generation

Prerequisites

Visual Studio installed with .NET framework support

QRCoder NuGet package installed (Install-Package QRCoder)

Installation and Usage

Clone the repository:

git clone https://github.com/bhupesh1898/QRCode.git

Open the project in Visual Studio.

Install dependencies if not already installed:

Install-Package QRCoder

Build and run the project.

How It Works

When the application starts, it generates a QR code for the predefined URL.

The QR code is displayed in a PictureBox inside the application window.

The QR code is saved as QRCode.png on the desktop.

The saved image is automatically opened using the default image viewer.

Code Overview

QRCodeForm.cs: Contains the main logic for generating and displaying the QR code.

Program.cs: The entry point that starts the Windows Forms application.



License

This project is open-source and available under the MIT License.

Author

Bhupesh Dhurandher
