﻿namespace Serialization;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        buttonXMLSerialize = new Button();
        buttonXMLDeserialize = new Button();
        SuspendLayout();
        // 
        // buttonXMLSerialize
        // 
        buttonXMLSerialize.Location = new Point(12, 12);
        buttonXMLSerialize.Name = "buttonXMLSerialize";
        buttonXMLSerialize.Size = new Size(139, 23);
        buttonXMLSerialize.TabIndex = 0;
        buttonXMLSerialize.Text = "XML Serialize";
        buttonXMLSerialize.UseVisualStyleBackColor = true;
        buttonXMLSerialize.Click += buttonXMLSerialize_Click;
        // 
        // buttonXMLDeserialize
        // 
        buttonXMLDeserialize.Location = new Point(12, 41);
        buttonXMLDeserialize.Name = "buttonXMLDeserialize";
        buttonXMLDeserialize.Size = new Size(139, 23);
        buttonXMLDeserialize.TabIndex = 1;
        buttonXMLDeserialize.Text = "XML Deserialize";
        buttonXMLDeserialize.UseVisualStyleBackColor = true;
        buttonXMLDeserialize.Click += buttonXMLDeserialize_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(861, 432);
        Controls.Add(buttonXMLDeserialize);
        Controls.Add(buttonXMLSerialize);
        Name = "Form1";
        Text = "Form1";
        Load += Form1_Load;
        ResumeLayout(false);
    }

    #endregion

    private Button buttonXMLSerialize;
    private Button buttonXMLDeserialize;
}
