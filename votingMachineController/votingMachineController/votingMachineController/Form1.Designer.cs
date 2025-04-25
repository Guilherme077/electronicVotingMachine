namespace votingMachineController
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnConnect = new System.Windows.Forms.Button();
            this.cbSelectCOM = new System.Windows.Forms.ComboBox();
            this.btnSendMessage = new System.Windows.Forms.Button();
            this.timerCOM = new System.Windows.Forms.Timer(this.components);
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.tbSendMessage = new System.Windows.Forms.TextBox();
            this.tbConsole = new System.Windows.Forms.TextBox();
            this.btnVoteSettings = new System.Windows.Forms.Button();
            this.btnShowResults = new System.Windows.Forms.Button();
            this.btnStartVoting = new System.Windows.Forms.Button();
            this.btnFormatResults = new System.Windows.Forms.Button();
            this.btnPrintSettings = new System.Windows.Forms.Button();
            this.btnStopVoting = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnConfirmVoter = new System.Windows.Forms.Button();
            this.tbVoterName = new System.Windows.Forms.TextBox();
            this.tbVoterId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.Location = new System.Drawing.Point(233, 12);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(169, 34);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // cbSelectCOM
            // 
            this.cbSelectCOM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSelectCOM.FormattingEnabled = true;
            this.cbSelectCOM.Location = new System.Drawing.Point(12, 12);
            this.cbSelectCOM.Name = "cbSelectCOM";
            this.cbSelectCOM.Size = new System.Drawing.Size(215, 33);
            this.cbSelectCOM.TabIndex = 1;
            // 
            // btnSendMessage
            // 
            this.btnSendMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSendMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendMessage.Location = new System.Drawing.Point(988, 500);
            this.btnSendMessage.Name = "btnSendMessage";
            this.btnSendMessage.Size = new System.Drawing.Size(169, 32);
            this.btnSendMessage.TabIndex = 2;
            this.btnSendMessage.Text = "Send";
            this.btnSendMessage.UseVisualStyleBackColor = true;
            this.btnSendMessage.Click += new System.EventHandler(this.btnSendMessage_Click);
            // 
            // timerCOM
            // 
            this.timerCOM.Interval = 1000;
            this.timerCOM.Tick += new System.EventHandler(this.timerCOM_Tick);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // tbSendMessage
            // 
            this.tbSendMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSendMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSendMessage.Location = new System.Drawing.Point(13, 502);
            this.tbSendMessage.Name = "tbSendMessage";
            this.tbSendMessage.Size = new System.Drawing.Size(969, 30);
            this.tbSendMessage.TabIndex = 3;
            // 
            // tbConsole
            // 
            this.tbConsole.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbConsole.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.tbConsole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbConsole.ForeColor = System.Drawing.Color.LimeGreen;
            this.tbConsole.Location = new System.Drawing.Point(12, 295);
            this.tbConsole.Multiline = true;
            this.tbConsole.Name = "tbConsole";
            this.tbConsole.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbConsole.Size = new System.Drawing.Size(1143, 198);
            this.tbConsole.TabIndex = 4;
            this.tbConsole.TextChanged += new System.EventHandler(this.tbConsole_TextChanged);
            // 
            // btnVoteSettings
            // 
            this.btnVoteSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoteSettings.Location = new System.Drawing.Point(538, 12);
            this.btnVoteSettings.Name = "btnVoteSettings";
            this.btnVoteSettings.Size = new System.Drawing.Size(169, 34);
            this.btnVoteSettings.TabIndex = 5;
            this.btnVoteSettings.Text = "Vote Settings";
            this.btnVoteSettings.UseVisualStyleBackColor = true;
            // 
            // btnShowResults
            // 
            this.btnShowResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowResults.Location = new System.Drawing.Point(713, 12);
            this.btnShowResults.Name = "btnShowResults";
            this.btnShowResults.Size = new System.Drawing.Size(169, 34);
            this.btnShowResults.TabIndex = 6;
            this.btnShowResults.Text = "Show Results";
            this.btnShowResults.UseVisualStyleBackColor = true;
            // 
            // btnStartVoting
            // 
            this.btnStartVoting.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartVoting.Location = new System.Drawing.Point(888, 12);
            this.btnStartVoting.Name = "btnStartVoting";
            this.btnStartVoting.Size = new System.Drawing.Size(257, 34);
            this.btnStartVoting.TabIndex = 7;
            this.btnStartVoting.Text = "Start Voting Process";
            this.btnStartVoting.UseVisualStyleBackColor = true;
            this.btnStartVoting.Click += new System.EventHandler(this.btnStartVoting_Click);
            // 
            // btnFormatResults
            // 
            this.btnFormatResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFormatResults.Location = new System.Drawing.Point(713, 52);
            this.btnFormatResults.Name = "btnFormatResults";
            this.btnFormatResults.Size = new System.Drawing.Size(169, 34);
            this.btnFormatResults.TabIndex = 8;
            this.btnFormatResults.Text = "Format Results";
            this.btnFormatResults.UseVisualStyleBackColor = true;
            // 
            // btnPrintSettings
            // 
            this.btnPrintSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintSettings.Location = new System.Drawing.Point(538, 52);
            this.btnPrintSettings.Name = "btnPrintSettings";
            this.btnPrintSettings.Size = new System.Drawing.Size(169, 34);
            this.btnPrintSettings.TabIndex = 9;
            this.btnPrintSettings.Text = "Print Settings";
            this.btnPrintSettings.UseVisualStyleBackColor = true;
            // 
            // btnStopVoting
            // 
            this.btnStopVoting.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStopVoting.Location = new System.Drawing.Point(888, 52);
            this.btnStopVoting.Name = "btnStopVoting";
            this.btnStopVoting.Size = new System.Drawing.Size(257, 34);
            this.btnStopVoting.TabIndex = 10;
            this.btnStopVoting.Text = "Stop Voting Process";
            this.btnStopVoting.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 22);
            this.label1.TabIndex = 11;
            this.label1.Text = "Enter voter information";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 22);
            this.label2.TabIndex = 12;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 22);
            this.label3.TabIndex = 13;
            this.label3.Text = "ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(464, 44);
            this.label4.TabIndex = 14;
            this.label4.Text = "*These infos don\'t will be send to the voting machine and\r\nthe voter\'s vote will " +
    "not be linked with these infos\r\n";
            // 
            // btnConfirmVoter
            // 
            this.btnConfirmVoter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmVoter.Location = new System.Drawing.Point(236, 186);
            this.btnConfirmVoter.Name = "btnConfirmVoter";
            this.btnConfirmVoter.Size = new System.Drawing.Size(240, 34);
            this.btnConfirmVoter.TabIndex = 15;
            this.btnConfirmVoter.Text = "Start Voting";
            this.btnConfirmVoter.UseVisualStyleBackColor = true;
            this.btnConfirmVoter.Click += new System.EventHandler(this.btnConfirmVoter_Click);
            // 
            // tbVoterName
            // 
            this.tbVoterName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbVoterName.Location = new System.Drawing.Point(80, 150);
            this.tbVoterName.Name = "tbVoterName";
            this.tbVoterName.Size = new System.Drawing.Size(396, 30);
            this.tbVoterName.TabIndex = 16;
            // 
            // tbVoterId
            // 
            this.tbVoterId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbVoterId.Location = new System.Drawing.Point(80, 186);
            this.tbVoterId.Name = "tbVoterId";
            this.tbVoterId.Size = new System.Drawing.Size(150, 30);
            this.tbVoterId.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlueViolet;
            this.ClientSize = new System.Drawing.Size(1168, 541);
            this.Controls.Add(this.tbVoterId);
            this.Controls.Add(this.tbVoterName);
            this.Controls.Add(this.btnConfirmVoter);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStopVoting);
            this.Controls.Add(this.btnPrintSettings);
            this.Controls.Add(this.btnFormatResults);
            this.Controls.Add(this.btnStartVoting);
            this.Controls.Add(this.btnShowResults);
            this.Controls.Add(this.btnVoteSettings);
            this.Controls.Add(this.tbConsole);
            this.Controls.Add(this.tbSendMessage);
            this.Controls.Add(this.btnSendMessage);
            this.Controls.Add(this.cbSelectCOM);
            this.Controls.Add(this.btnConnect);
            this.Name = "Form1";
            this.Text = "Voting Machine Controller - Disconected";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.ComboBox cbSelectCOM;
        private System.Windows.Forms.Button btnSendMessage;
        private System.Windows.Forms.Timer timerCOM;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TextBox tbSendMessage;
        private System.Windows.Forms.TextBox tbConsole;
        private System.Windows.Forms.Button btnVoteSettings;
        private System.Windows.Forms.Button btnShowResults;
        private System.Windows.Forms.Button btnStartVoting;
        private System.Windows.Forms.Button btnFormatResults;
        private System.Windows.Forms.Button btnPrintSettings;
        private System.Windows.Forms.Button btnStopVoting;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnConfirmVoter;
        private System.Windows.Forms.TextBox tbVoterName;
        private System.Windows.Forms.TextBox tbVoterId;
    }
}

