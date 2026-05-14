namespace CybersecurityChatbot
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            richTextBoxChat = new RichTextBox();
            textBoxUserInput = new TextBox();
            btnSend = new Button();
            lblTitle = new Label();
            SuspendLayout();
            // 
            // richTextBoxChat
            // 
            richTextBoxChat.Location = new Point(192, 89);
            richTextBoxChat.Name = "richTextBoxChat";
            richTextBoxChat.Size = new Size(409, 183);
            richTextBoxChat.TabIndex = 0;
            richTextBoxChat.Text = "";
            richTextBoxChat.TextChanged += richTextBox1_TextChanged;
            // 
            // textBoxUserInput
            // 
            textBoxUserInput.Location = new Point(329, 278);
            textBoxUserInput.Multiline = true;
            textBoxUserInput.Name = "textBoxUserInput";
            textBoxUserInput.Size = new Size(150, 31);
            textBoxUserInput.TabIndex = 1;
            textBoxUserInput.TextChanged += textBox1_TextChanged;
            // 
            // btnSend
            // 
            btnSend.Location = new Point(352, 315);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(112, 34);
            btnSend.TabIndex = 2;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(279, 51);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(239, 25);
            lblTitle.TabIndex = 3;
            lblTitle.Text = "Cybersecurity Awareness Bot";
            lblTitle.Click += label1_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(819, 464);
            Controls.Add(lblTitle);
            Controls.Add(btnSend);
            Controls.Add(textBoxUserInput);
            Controls.Add(richTextBoxChat);
            Name = "MainForm";
            Text = "MainForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private TextBox textBox1;
        private Button btnSend;
        private Label lblTitle;
        private TextBox textBoxUserInput;
        private RichTextBox richTextBoxChat;
    }
}