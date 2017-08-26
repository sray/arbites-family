﻿using System;
using System.Collections.Generic;
using Eto.Forms;
using Eto.Drawing;

namespace ArbitesEto2
{
    partial class FmFirmwareUpdater : Form
    {
        Button BtnSelectFile, BtnUpload, BtnPorts;
        Label LSelectedFile, LSelectedPort;
        Label LStatus;
        void InitializeComponent()
        {
            Title = "Firmware Uploader";
            ClientSize = new Size(400, 300);

            var slMain = new StackLayout();
            slMain.Spacing = 5;
            Content = slMain;

            var l1 = new Label();
            l1.Wrap = WrapMode.Word;
            l1.Text = "This is the firmware uploader, it is used to upload firmware to your hardware device, allowing you to update the firmware in your device, follow the steps below to upload your firmware:\n\n1. Download the compiled *.hex firmware file for your device\n2. Press browse and select your *.hex file\n3. Press select port to select the port of your device\n4. Press upload, then wait around 30 seconds for the firmware to be uploaded to your hardware, a command line window will pop up during the upload\n";
            slMain.Items.Add(l1);

            var slFile = new StackLayout();
            slFile.Spacing = 5;
            slFile.Orientation = Orientation.Horizontal;
            slFile.VerticalContentAlignment = VerticalAlignment.Center;
            slMain.Items.Add(slFile);

            LSelectedFile = new Label();
            LSelectedFile.Text = "No file seelcted";
            slFile.Items.Add(LSelectedFile);

            BtnSelectFile = new Button();
            BtnSelectFile.Text = "Browse";
            BtnSelectFile.ToolTip = "Browse";
            slFile.Items.Add(BtnSelectFile);

            var slPort = new StackLayout();
            slPort.Spacing = 5;
            slPort.Orientation = Orientation.Horizontal;
            slPort.VerticalContentAlignment = VerticalAlignment.Center;
            slMain.Items.Add(slPort);

            LSelectedPort = new Label();
            LSelectedPort.Text = "No Ports Selected";
            slPort.Items.Add(LSelectedPort);

            BtnPorts = new Button();
            BtnPorts.Text = "Select Port";
            BtnPorts.ToolTip = "Select Port";
            slPort.Items.Add(BtnPorts);

            BtnUpload = new Button();
            BtnUpload.Text = "Upload";
            BtnUpload.ToolTip = "Upload";
            slPort.Items.Add(BtnUpload);

            LStatus = new Label();
            LStatus.Wrap = WrapMode.Word;
            LStatus.Text = "Awaiting upload to begin";
            slMain.Items.Add(LStatus);
        }
    }
}
