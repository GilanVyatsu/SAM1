namespace SAM
{
    partial class SAM
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
            this.buttonPersonal = new System.Windows.Forms.Button();
            this.buttonClients = new System.Windows.Forms.Button();
            this.buttonAgents = new System.Windows.Forms.Button();
            this.buttonDeal = new System.Windows.Forms.Button();
            this.buttonSupply = new System.Windows.Forms.Button();
            this.buttonDemand = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonPersonal
            // 
            this.buttonPersonal.Location = new System.Drawing.Point(12, 47);
            this.buttonPersonal.Name = "buttonPersonal";
            this.buttonPersonal.Size = new System.Drawing.Size(140, 74);
            this.buttonPersonal.TabIndex = 0;
            this.buttonPersonal.Text = "Персонал";
            this.buttonPersonal.UseVisualStyleBackColor = true;
            this.buttonPersonal.Click += new System.EventHandler(this.buttonPersonal_Click);
            // 
            // buttonClients
            // 
            this.buttonClients.Location = new System.Drawing.Point(184, 47);
            this.buttonClients.Name = "buttonClients";
            this.buttonClients.Size = new System.Drawing.Size(140, 74);
            this.buttonClients.TabIndex = 1;
            this.buttonClients.Text = "Клиенты";
            this.buttonClients.UseVisualStyleBackColor = true;
            // 
            // buttonAgents
            // 
            this.buttonAgents.Location = new System.Drawing.Point(184, 155);
            this.buttonAgents.Name = "buttonAgents";
            this.buttonAgents.Size = new System.Drawing.Size(140, 74);
            this.buttonAgents.TabIndex = 2;
            this.buttonAgents.Text = "Агенты";
            this.buttonAgents.UseVisualStyleBackColor = true;
            // 
            // buttonDeal
            // 
            this.buttonDeal.Location = new System.Drawing.Point(12, 155);
            this.buttonDeal.Name = "buttonDeal";
            this.buttonDeal.Size = new System.Drawing.Size(140, 74);
            this.buttonDeal.TabIndex = 3;
            this.buttonDeal.Text = "Сделка";
            this.buttonDeal.UseVisualStyleBackColor = true;
            // 
            // buttonSupply
            // 
            this.buttonSupply.Location = new System.Drawing.Point(12, 260);
            this.buttonSupply.Name = "buttonSupply";
            this.buttonSupply.Size = new System.Drawing.Size(140, 74);
            this.buttonSupply.TabIndex = 4;
            this.buttonSupply.Text = "Поставка";
            this.buttonSupply.UseVisualStyleBackColor = true;
            // 
            // buttonDemand
            // 
            this.buttonDemand.Location = new System.Drawing.Point(184, 260);
            this.buttonDemand.Name = "buttonDemand";
            this.buttonDemand.Size = new System.Drawing.Size(140, 74);
            this.buttonDemand.TabIndex = 5;
            this.buttonDemand.Text = "Спрос";
            this.buttonDemand.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Система Аниме-Магазина";
            // 
            // SAM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 373);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonDemand);
            this.Controls.Add(this.buttonSupply);
            this.Controls.Add(this.buttonDeal);
            this.Controls.Add(this.buttonAgents);
            this.Controls.Add(this.buttonClients);
            this.Controls.Add(this.buttonPersonal);
            this.Name = "SAM";
            this.Text = "SAM";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPersonal;
        private System.Windows.Forms.Button buttonClients;
        private System.Windows.Forms.Button buttonAgents;
        private System.Windows.Forms.Button buttonDeal;
        private System.Windows.Forms.Button buttonSupply;
        private System.Windows.Forms.Button buttonDemand;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}