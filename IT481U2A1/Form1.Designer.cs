namespace IT481U2A1
{
    partial class Form1
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
            this.testconnect = new System.Windows.Forms.Button();
            this.outputview = new System.Windows.Forms.TextBox();
            this.view = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.region = new System.Windows.Forms.TextBox();
            this.desc = new System.Windows.Forms.TextBox();
            this.regiondescription = new System.Windows.Forms.Label();
            this.regionid = new System.Windows.Forms.Label();
            this.insert = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.newregiondescription = new System.Windows.Forms.Label();
            this.newdesc = new System.Windows.Forms.TextBox();
            this.update = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // testconnect
            // 
            this.testconnect.Location = new System.Drawing.Point(14, 18);
            this.testconnect.Name = "testconnect";
            this.testconnect.Size = new System.Drawing.Size(96, 23);
            this.testconnect.TabIndex = 0;
            this.testconnect.Text = "Test Connection";
            this.testconnect.UseVisualStyleBackColor = true;
            this.testconnect.Click += new System.EventHandler(this.testconnect_Click);
            // 
            // outputview
            // 
            this.outputview.Location = new System.Drawing.Point(14, 47);
            this.outputview.Multiline = true;
            this.outputview.Name = "outputview";
            this.outputview.Size = new System.Drawing.Size(344, 196);
            this.outputview.TabIndex = 1;
            // 
            // view
            // 
            this.view.Location = new System.Drawing.Point(283, 18);
            this.view.Name = "view";
            this.view.Size = new System.Drawing.Size(75, 23);
            this.view.TabIndex = 2;
            this.view.Text = "View";
            this.view.UseVisualStyleBackColor = true;
            this.view.Click += new System.EventHandler(this.view_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(202, 18);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 23);
            this.clear.TabIndex = 3;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // region
            // 
            this.region.Location = new System.Drawing.Point(491, 80);
            this.region.Name = "region";
            this.region.Size = new System.Drawing.Size(112, 20);
            this.region.TabIndex = 4;
            // 
            // desc
            // 
            this.desc.Location = new System.Drawing.Point(491, 115);
            this.desc.Name = "desc";
            this.desc.Size = new System.Drawing.Size(112, 20);
            this.desc.TabIndex = 5;
            // 
            // regiondescription
            // 
            this.regiondescription.AutoSize = true;
            this.regiondescription.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.regiondescription.Location = new System.Drawing.Point(363, 122);
            this.regiondescription.Name = "regiondescription";
            this.regiondescription.Size = new System.Drawing.Size(97, 13);
            this.regiondescription.TabIndex = 7;
            this.regiondescription.Text = "Region Description";
            // 
            // regionid
            // 
            this.regionid.AutoSize = true;
            this.regionid.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.regionid.Location = new System.Drawing.Point(363, 87);
            this.regionid.Name = "regionid";
            this.regionid.Size = new System.Drawing.Size(55, 13);
            this.regionid.TabIndex = 8;
            this.regionid.Text = "Region ID";
            // 
            // insert
            // 
            this.insert.Location = new System.Drawing.Point(366, 220);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(75, 23);
            this.insert.TabIndex = 9;
            this.insert.Text = "Insert";
            this.insert.UseVisualStyleBackColor = true;
            this.insert.Click += new System.EventHandler(this.insert_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(447, 220);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 23);
            this.delete.TabIndex = 10;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // newregiondescription
            // 
            this.newregiondescription.AutoSize = true;
            this.newregiondescription.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.newregiondescription.Location = new System.Drawing.Point(363, 160);
            this.newregiondescription.Name = "newregiondescription";
            this.newregiondescription.Size = new System.Drawing.Size(122, 13);
            this.newregiondescription.TabIndex = 12;
            this.newregiondescription.Text = "New Region Description";
            // 
            // newdesc
            // 
            this.newdesc.Location = new System.Drawing.Point(491, 153);
            this.newdesc.Name = "newdesc";
            this.newdesc.Size = new System.Drawing.Size(112, 20);
            this.newdesc.TabIndex = 13;
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(528, 220);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(75, 23);
            this.update.TabIndex = 14;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(614, 257);
            this.Controls.Add(this.update);
            this.Controls.Add(this.newdesc);
            this.Controls.Add(this.newregiondescription);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.insert);
            this.Controls.Add(this.regionid);
            this.Controls.Add(this.regiondescription);
            this.Controls.Add(this.desc);
            this.Controls.Add(this.region);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.view);
            this.Controls.Add(this.outputview);
            this.Controls.Add(this.testconnect);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button testconnect;
        private System.Windows.Forms.TextBox outputview;
        private System.Windows.Forms.Button view;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.TextBox region;
        private System.Windows.Forms.TextBox desc;
        private System.Windows.Forms.Label regiondescription;
        private System.Windows.Forms.Label regionid;
        private System.Windows.Forms.Button insert;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Label newregiondescription;
        private System.Windows.Forms.TextBox newdesc;
        private System.Windows.Forms.Button update;
    }
}

