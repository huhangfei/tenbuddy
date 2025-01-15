namespace TenBuddy
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            CheckTimer = new System.Windows.Forms.Timer(components);
            lbTargetName = new Label();
            lbMessageCount = new Label();
            btnReadMessages = new Button();
            btnViewMessages = new Button();
            comboQuestion = new ComboBox();
            btnRequest = new Button();
            label1 = new Label();
            lbInput = new Label();
            richTextBox1 = new RichTextBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            txtTargetIntroduction = new TextBox();
            btnModelConfig = new Button();
            btnInstructPresetConfig = new Button();
            enableAutoReply = new CheckBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // CheckTimer
            // 
            CheckTimer.Enabled = true;
            CheckTimer.Interval = 500;
            CheckTimer.Tick += ReadTimer_Tick;
            // 
            // lbTargetName
            // 
            lbTargetName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbTargetName.AutoEllipsis = true;
            lbTargetName.Location = new Point(15, 21);
            lbTargetName.Margin = new Padding(4, 0, 4, 0);
            lbTargetName.Name = "lbTargetName";
            lbTargetName.Size = new Size(354, 27);
            lbTargetName.TabIndex = 1;
            lbTargetName.Text = "正在识别聊天窗口";
            // 
            // lbMessageCount
            // 
            lbMessageCount.Location = new Point(15, 94);
            lbMessageCount.Margin = new Padding(4, 0, 4, 0);
            lbMessageCount.Name = "lbMessageCount";
            lbMessageCount.Size = new Size(139, 27);
            lbMessageCount.TabIndex = 2;
            lbMessageCount.Text = "当前消息：000";
            // 
            // btnReadMessages
            // 
            btnReadMessages.Location = new Point(162, 91);
            btnReadMessages.Margin = new Padding(4);
            btnReadMessages.Name = "btnReadMessages";
            btnReadMessages.Size = new Size(96, 27);
            btnReadMessages.TabIndex = 3;
            btnReadMessages.Text = "读取更多";
            btnReadMessages.UseVisualStyleBackColor = true;
            btnReadMessages.Click += btnReadMessages_Click;
            // 
            // btnViewMessages
            // 
            btnViewMessages.Location = new Point(266, 91);
            btnViewMessages.Margin = new Padding(4);
            btnViewMessages.Name = "btnViewMessages";
            btnViewMessages.Size = new Size(96, 27);
            btnViewMessages.TabIndex = 4;
            btnViewMessages.Text = "查看内容";
            btnViewMessages.UseVisualStyleBackColor = true;
            btnViewMessages.Click += btnViewMessages_Click;
            // 
            // comboQuestion
            // 
            comboQuestion.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboQuestion.FormattingEnabled = true;
            comboQuestion.Location = new Point(95, 180);
            comboQuestion.Margin = new Padding(4);
            comboQuestion.Name = "comboQuestion";
            comboQuestion.Size = new Size(377, 28);
            comboQuestion.TabIndex = 8;
            comboQuestion.KeyPress += comboQuestion_KeyPress;
            // 
            // btnRequest
            // 
            btnRequest.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRequest.Location = new Point(481, 180);
            btnRequest.Margin = new Padding(4);
            btnRequest.Name = "btnRequest";
            btnRequest.Size = new Size(96, 29);
            btnRequest.TabIndex = 9;
            btnRequest.Text = "请求";
            btnRequest.UseVisualStyleBackColor = true;
            btnRequest.Click += btnRequest_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 185);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 10;
            label1.Text = "AI 对话";
            // 
            // lbInput
            // 
            lbInput.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbInput.AutoEllipsis = true;
            lbInput.Location = new Point(15, 138);
            lbInput.Margin = new Padding(4, 0, 4, 0);
            lbInput.Name = "lbInput";
            lbInput.Size = new Size(562, 27);
            lbInput.TabIndex = 2;
            lbInput.Text = "当前输入：空";
            // 
            // richTextBox1
            // 
            richTextBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            richTextBox1.Location = new Point(15, 216);
            richTextBox1.Margin = new Padding(4);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(561, 349);
            richTextBox1.TabIndex = 12;
            richTextBox1.Text = "";
            // 
            // txtTargetIntroduction
            // 
            txtTargetIntroduction.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtTargetIntroduction.Location = new Point(15, 52);
            txtTargetIntroduction.Margin = new Padding(4);
            txtTargetIntroduction.Name = "txtTargetIntroduction";
            txtTargetIntroduction.PlaceholderText = "可填写人物描述，比如双方关系，对话目的，或使用什么语气进行交谈。";
            txtTargetIntroduction.Size = new Size(561, 27);
            txtTargetIntroduction.TabIndex = 13;
            txtTargetIntroduction.TextChanged += txtTargetIntroduction_TextChanged;
            // 
            // btnModelConfig
            // 
            btnModelConfig.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnModelConfig.Location = new Point(481, 14);
            btnModelConfig.Margin = new Padding(4);
            btnModelConfig.Name = "btnModelConfig";
            btnModelConfig.Size = new Size(96, 31);
            btnModelConfig.TabIndex = 14;
            btnModelConfig.Text = "模型配置";
            btnModelConfig.UseVisualStyleBackColor = true;
            btnModelConfig.Click += btnModelConfig_Click;
            // 
            // btnInstructPresetConfig
            // 
            btnInstructPresetConfig.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnInstructPresetConfig.Location = new Point(377, 14);
            btnInstructPresetConfig.Margin = new Padding(4);
            btnInstructPresetConfig.Name = "btnInstructPresetConfig";
            btnInstructPresetConfig.Size = new Size(96, 31);
            btnInstructPresetConfig.TabIndex = 14;
            btnInstructPresetConfig.Text = "指令预设";
            btnInstructPresetConfig.UseVisualStyleBackColor = true;
            btnInstructPresetConfig.Click += btnInstructPresetConfig_Click;
            // 
            // enableAutoReply
            // 
            enableAutoReply.AutoSize = true;
            enableAutoReply.Location = new Point(390, 94);
            enableAutoReply.Name = "enableAutoReply";
            enableAutoReply.Size = new Size(121, 24);
            enableAutoReply.TabIndex = 15;
            enableAutoReply.Text = "开启自动回复";
            enableAutoReply.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(517, 89);
            button1.Name = "button1";
            button1.Size = new Size(58, 29);
            button1.TabIndex = 16;
            button1.Text = "测试";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(593, 592);
            Controls.Add(button1);
            Controls.Add(enableAutoReply);
            Controls.Add(btnInstructPresetConfig);
            Controls.Add(btnModelConfig);
            Controls.Add(txtTargetIntroduction);
            Controls.Add(richTextBox1);
            Controls.Add(label1);
            Controls.Add(btnRequest);
            Controls.Add(comboQuestion);
            Controls.Add(btnViewMessages);
            Controls.Add(btnReadMessages);
            Controls.Add(lbInput);
            Controls.Add(lbMessageCount);
            Controls.Add(lbTargetName);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MinimumSize = new Size(535, 486);
            Name = "MainForm";
            Text = "TenBuddy";
            FormClosing += MainForm_FormClosing;
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer CheckTimer;
        private Label lbTargetName;
        private Label lbMessageCount;
        private Button btnReadMessages;
        private Button btnViewMessages;
        private ComboBox comboQuestion;
        private Button btnRequest;
        private Label label1;
        private Label lbInput;
        private RichTextBox richTextBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TextBox txtTargetIntroduction;
        private Button btnModelConfig;
        private Button btnInstructPresetConfig;
        private CheckBox enableAutoReply;
        private Button button1;
    }
}
