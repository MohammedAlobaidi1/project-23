namespace VendingMachine
{
    partial class VendingMachine
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
            this.Item1 = new System.Windows.Forms.Button();
            this.Items = new System.Windows.Forms.GroupBox();
            this.Item3 = new System.Windows.Forms.Button();
            this.Item2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Quarter = new System.Windows.Forms.Button();
            this.Dimes = new System.Windows.Forms.Button();
            this.Nickles = new System.Windows.Forms.Button();
            this.TotalFundsLabel = new System.Windows.Forms.Label();
            this.ReturnBTN = new System.Windows.Forms.Button();
            this.Alert = new System.Windows.Forms.Label();
            this.ProcessLabel = new System.Windows.Forms.Label();
            this.Inventory = new System.Windows.Forms.ListBox();
            this.ResetBTN = new System.Windows.Forms.Button();
            this.StudentDetails = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.EditBtn = new System.Windows.Forms.Button();
            this.Items.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Item1
            // 
            this.Item1.Location = new System.Drawing.Point(6, 19);
            this.Item1.Name = "Item1";
            this.Item1.Size = new System.Drawing.Size(150, 50);
            this.Item1.TabIndex = 0;
            this.Item1.Text = "Item 1 55 Cents";
            this.Item1.UseVisualStyleBackColor = true;
            this.Item1.Click += new System.EventHandler(this.Item1_Click);
            // 
            // Items
            // 
            this.Items.Controls.Add(this.Item3);
            this.Items.Controls.Add(this.Item2);
            this.Items.Controls.Add(this.Item1);
            this.Items.Location = new System.Drawing.Point(12, 12);
            this.Items.Name = "Items";
            this.Items.Size = new System.Drawing.Size(166, 198);
            this.Items.TabIndex = 1;
            this.Items.TabStop = false;
            this.Items.Text = "Items";
            // 
            // Item3
            // 
            this.Item3.Location = new System.Drawing.Point(6, 131);
            this.Item3.Name = "Item3";
            this.Item3.Size = new System.Drawing.Size(150, 50);
            this.Item3.TabIndex = 2;
            this.Item3.Text = "Item 3 75 Cents";
            this.Item3.UseVisualStyleBackColor = true;
            this.Item3.Click += new System.EventHandler(this.Item3_Click);
            // 
            // Item2
            // 
            this.Item2.Location = new System.Drawing.Point(6, 75);
            this.Item2.Name = "Item2";
            this.Item2.Size = new System.Drawing.Size(150, 50);
            this.Item2.TabIndex = 1;
            this.Item2.Text = "Item 2 70 Cents";
            this.Item2.UseVisualStyleBackColor = true;
            this.Item2.Click += new System.EventHandler(this.Item2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Quarter);
            this.groupBox2.Controls.Add(this.Dimes);
            this.groupBox2.Controls.Add(this.Nickles);
            this.groupBox2.Location = new System.Drawing.Point(401, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(166, 198);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Coins";
            // 
            // Quarter
            // 
            this.Quarter.Location = new System.Drawing.Point(6, 131);
            this.Quarter.Name = "Quarter";
            this.Quarter.Size = new System.Drawing.Size(150, 50);
            this.Quarter.TabIndex = 2;
            this.Quarter.Text = "25 Cents ( Quarter )";
            this.Quarter.UseVisualStyleBackColor = true;
            this.Quarter.Click += new System.EventHandler(this.Quarter_Click);
            // 
            // Dimes
            // 
            this.Dimes.Location = new System.Drawing.Point(6, 75);
            this.Dimes.Name = "Dimes";
            this.Dimes.Size = new System.Drawing.Size(150, 50);
            this.Dimes.TabIndex = 1;
            this.Dimes.Text = "10 Cents ( Dime )";
            this.Dimes.UseVisualStyleBackColor = true;
            this.Dimes.Click += new System.EventHandler(this.Dimes_Click);
            // 
            // Nickles
            // 
            this.Nickles.Location = new System.Drawing.Point(6, 19);
            this.Nickles.Name = "Nickles";
            this.Nickles.Size = new System.Drawing.Size(150, 50);
            this.Nickles.TabIndex = 0;
            this.Nickles.Text = "5 Cents ( Nickle )";
            this.Nickles.UseVisualStyleBackColor = true;
            this.Nickles.Click += new System.EventHandler(this.Nickles_Click);
            // 
            // TotalFundsLabel
            // 
            this.TotalFundsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalFundsLabel.Location = new System.Drawing.Point(184, 22);
            this.TotalFundsLabel.Name = "TotalFundsLabel";
            this.TotalFundsLabel.Size = new System.Drawing.Size(211, 26);
            this.TotalFundsLabel.TabIndex = 4;
            this.TotalFundsLabel.Text = "Funds : 0";
            // 
            // ReturnBTN
            // 
            this.ReturnBTN.Location = new System.Drawing.Point(469, 369);
            this.ReturnBTN.Name = "ReturnBTN";
            this.ReturnBTN.Size = new System.Drawing.Size(88, 27);
            this.ReturnBTN.TabIndex = 6;
            this.ReturnBTN.Text = "Refund Money";
            this.ReturnBTN.UseVisualStyleBackColor = true;
            this.ReturnBTN.Click += new System.EventHandler(this.ReturnBTN_Click);
            // 
            // Alert
            // 
            this.Alert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Alert.ForeColor = System.Drawing.Color.Red;
            this.Alert.Location = new System.Drawing.Point(2, 412);
            this.Alert.Name = "Alert";
            this.Alert.Size = new System.Drawing.Size(393, 21);
            this.Alert.TabIndex = 7;
            this.Alert.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ProcessLabel
            // 
            this.ProcessLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProcessLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ProcessLabel.Location = new System.Drawing.Point(184, 48);
            this.ProcessLabel.Name = "ProcessLabel";
            this.ProcessLabel.Size = new System.Drawing.Size(211, 66);
            this.ProcessLabel.TabIndex = 8;
            // 
            // Inventory
            // 
            this.Inventory.FormattingEnabled = true;
            this.Inventory.Location = new System.Drawing.Point(12, 216);
            this.Inventory.Name = "Inventory";
            this.Inventory.Size = new System.Drawing.Size(555, 147);
            this.Inventory.TabIndex = 11;
            // 
            // ResetBTN
            // 
            this.ResetBTN.Location = new System.Drawing.Point(372, 369);
            this.ResetBTN.Name = "ResetBTN";
            this.ResetBTN.Size = new System.Drawing.Size(90, 27);
            this.ResetBTN.TabIndex = 12;
            this.ResetBTN.Text = "Reset Program";
            this.ResetBTN.UseVisualStyleBackColor = true;
            this.ResetBTN.Click += new System.EventHandler(this.ResetBTN_Click);
            // 
            // StudentDetails
            // 
            this.StudentDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentDetails.ForeColor = System.Drawing.Color.Gray;
            this.StudentDetails.Location = new System.Drawing.Point(12, 443);
            this.StudentDetails.Name = "StudentDetails";
            this.StudentDetails.Size = new System.Drawing.Size(271, 19);
            this.StudentDetails.TabIndex = 13;
            this.StudentDetails.Text = "Mohammed Abdulrahman Al-Obaidi";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(289, 433);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 29);
            this.label1.TabIndex = 14;
            this.label1.Text = "Assienment Solution";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // EditBtn
            // 
            this.EditBtn.Location = new System.Drawing.Point(372, 402);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(185, 28);
            this.EditBtn.TabIndex = 15;
            this.EditBtn.Text = "Modify Items Values";
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // VendingMachine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(583, 471);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StudentDetails);
            this.Controls.Add(this.ResetBTN);
            this.Controls.Add(this.Inventory);
            this.Controls.Add(this.ProcessLabel);
            this.Controls.Add(this.Alert);
            this.Controls.Add(this.ReturnBTN);
            this.Controls.Add(this.TotalFundsLabel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Items);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "VendingMachine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vending Machine";
            this.Items.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Item1;
        private System.Windows.Forms.GroupBox Items;
        private System.Windows.Forms.Button Item3;
        private System.Windows.Forms.Button Item2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Quarter;
        private System.Windows.Forms.Button Dimes;
        private System.Windows.Forms.Button Nickles;
        private System.Windows.Forms.Label TotalFundsLabel;
        private System.Windows.Forms.Button ReturnBTN;
        private System.Windows.Forms.Label Alert;
        private System.Windows.Forms.Label ProcessLabel;
        private System.Windows.Forms.ListBox Inventory;
        private System.Windows.Forms.Button ResetBTN;
        private System.Windows.Forms.Label StudentDetails;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button EditBtn;
    }
}

