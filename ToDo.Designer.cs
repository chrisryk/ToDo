namespace ToDo
{
    partial class ToDo
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
            this.gvTasks = new System.Windows.Forms.DataGridView();
            this.btnShowTasks = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lbTitle = new System.Windows.Forms.Label();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.lbDesc = new System.Windows.Forms.Label();
            this.tbDesc = new System.Windows.Forms.TextBox();
            this.gbOptions = new System.Windows.Forms.GroupBox();
            this.radioPending = new System.Windows.Forms.RadioButton();
            this.radioUnderway = new System.Windows.Forms.RadioButton();
            this.radioDone = new System.Windows.Forms.RadioButton();
            this.btnDelete = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lbStatusEdit = new System.Windows.Forms.Label();
            this.btnClearEdit = new System.Windows.Forms.Button();
            this.tbDescEdit = new System.Windows.Forms.TextBox();
            this.lbDescEdit = new System.Windows.Forms.Label();
            this.tbTitleEdit = new System.Windows.Forms.TextBox();
            this.lbTitleEdit = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.cbStatusEdit = new System.Windows.Forms.ComboBox();
            this.btnClearAdd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvTasks)).BeginInit();
            this.gbOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gvTasks
            // 
            this.gvTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvTasks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvTasks.Location = new System.Drawing.Point(0, 0);
            this.gvTasks.Name = "gvTasks";
            this.gvTasks.RowHeadersWidth = 62;
            this.gvTasks.RowTemplate.Height = 28;
            this.gvTasks.Size = new System.Drawing.Size(1225, 338);
            this.gvTasks.TabIndex = 0;
            // 
            // btnShowTasks
            // 
            this.btnShowTasks.Location = new System.Drawing.Point(399, 2);
            this.btnShowTasks.Name = "btnShowTasks";
            this.btnShowTasks.Size = new System.Drawing.Size(97, 49);
            this.btnShowTasks.TabIndex = 1;
            this.btnShowTasks.Text = "SHOW";
            this.btnShowTasks.UseVisualStyleBackColor = true;
            this.btnShowTasks.Click += new System.EventHandler(this.btnShowTasks_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 109);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(97, 49);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Location = new System.Drawing.Point(191, 112);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(52, 20);
            this.lbTitle.TabIndex = 3;
            this.lbTitle.Text = "TITLE";
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(249, 109);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(309, 26);
            this.tbTitle.TabIndex = 4;
            // 
            // lbDesc
            // 
            this.lbDesc.AutoSize = true;
            this.lbDesc.Location = new System.Drawing.Point(125, 146);
            this.lbDesc.Name = "lbDesc";
            this.lbDesc.Size = new System.Drawing.Size(118, 20);
            this.lbDesc.TabIndex = 5;
            this.lbDesc.Text = "DESCRIPTION";
            // 
            // tbDesc
            // 
            this.tbDesc.Location = new System.Drawing.Point(249, 143);
            this.tbDesc.Name = "tbDesc";
            this.tbDesc.Size = new System.Drawing.Size(309, 26);
            this.tbDesc.TabIndex = 6;
            // 
            // gbOptions
            // 
            this.gbOptions.Controls.Add(this.radioPending);
            this.gbOptions.Controls.Add(this.radioUnderway);
            this.gbOptions.Controls.Add(this.radioDone);
            this.gbOptions.Location = new System.Drawing.Point(165, 185);
            this.gbOptions.Name = "gbOptions";
            this.gbOptions.Size = new System.Drawing.Size(393, 66);
            this.gbOptions.TabIndex = 7;
            this.gbOptions.TabStop = false;
            this.gbOptions.Text = "STATUS";
            // 
            // radioPending
            // 
            this.radioPending.AutoSize = true;
            this.radioPending.Checked = true;
            this.radioPending.Location = new System.Drawing.Point(6, 25);
            this.radioPending.Name = "radioPending";
            this.radioPending.Size = new System.Drawing.Size(91, 24);
            this.radioPending.TabIndex = 2;
            this.radioPending.TabStop = true;
            this.radioPending.Tag = "2";
            this.radioPending.Text = "pending";
            this.radioPending.UseVisualStyleBackColor = true;
            // 
            // radioUnderway
            // 
            this.radioUnderway.AutoSize = true;
            this.radioUnderway.Location = new System.Drawing.Point(154, 25);
            this.radioUnderway.Name = "radioUnderway";
            this.radioUnderway.Size = new System.Drawing.Size(102, 24);
            this.radioUnderway.TabIndex = 1;
            this.radioUnderway.Tag = "3";
            this.radioUnderway.Text = "underway";
            this.radioUnderway.UseVisualStyleBackColor = true;
            // 
            // radioDone
            // 
            this.radioDone.AutoSize = true;
            this.radioDone.Location = new System.Drawing.Point(317, 25);
            this.radioDone.Name = "radioDone";
            this.radioDone.Size = new System.Drawing.Size(70, 24);
            this.radioDone.TabIndex = 0;
            this.radioDone.Tag = "1";
            this.radioDone.Text = "done";
            this.radioDone.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(729, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(97, 49);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.gvTasks);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnSave);
            this.splitContainer1.Panel2.Controls.Add(this.lbStatusEdit);
            this.splitContainer1.Panel2.Controls.Add(this.btnClearEdit);
            this.splitContainer1.Panel2.Controls.Add(this.tbDescEdit);
            this.splitContainer1.Panel2.Controls.Add(this.lbDescEdit);
            this.splitContainer1.Panel2.Controls.Add(this.tbTitleEdit);
            this.splitContainer1.Panel2.Controls.Add(this.lbTitleEdit);
            this.splitContainer1.Panel2.Controls.Add(this.btnEdit);
            this.splitContainer1.Panel2.Controls.Add(this.cbStatusEdit);
            this.splitContainer1.Panel2.Controls.Add(this.btnClearAdd);
            this.splitContainer1.Panel2.Controls.Add(this.btnShowTasks);
            this.splitContainer1.Panel2.Controls.Add(this.gbOptions);
            this.splitContainer1.Panel2.Controls.Add(this.btnDelete);
            this.splitContainer1.Panel2.Controls.Add(this.tbDesc);
            this.splitContainer1.Panel2.Controls.Add(this.btnAdd);
            this.splitContainer1.Panel2.Controls.Add(this.lbDesc);
            this.splitContainer1.Panel2.Controls.Add(this.tbTitle);
            this.splitContainer1.Panel2.Controls.Add(this.lbTitle);
            this.splitContainer1.Size = new System.Drawing.Size(1225, 676);
            this.splitContainer1.SplitterDistance = 338;
            this.splitContainer1.TabIndex = 9;
            // 
            // lbStatusEdit
            // 
            this.lbStatusEdit.AutoSize = true;
            this.lbStatusEdit.Location = new System.Drawing.Point(819, 178);
            this.lbStatusEdit.Name = "lbStatusEdit";
            this.lbStatusEdit.Size = new System.Drawing.Size(72, 20);
            this.lbStatusEdit.TabIndex = 19;
            this.lbStatusEdit.Text = "STATUS";
            // 
            // btnClearEdit
            // 
            this.btnClearEdit.Location = new System.Drawing.Point(658, 161);
            this.btnClearEdit.Name = "btnClearEdit";
            this.btnClearEdit.Size = new System.Drawing.Size(97, 49);
            this.btnClearEdit.TabIndex = 18;
            this.btnClearEdit.Text = "CLEAR";
            this.btnClearEdit.UseVisualStyleBackColor = true;
            this.btnClearEdit.Click += new System.EventHandler(this.btnClearEdit_Click);
            // 
            // tbDescEdit
            // 
            this.tbDescEdit.Location = new System.Drawing.Point(897, 140);
            this.tbDescEdit.Name = "tbDescEdit";
            this.tbDescEdit.Size = new System.Drawing.Size(309, 26);
            this.tbDescEdit.TabIndex = 15;
            // 
            // lbDescEdit
            // 
            this.lbDescEdit.AutoSize = true;
            this.lbDescEdit.Location = new System.Drawing.Point(773, 143);
            this.lbDescEdit.Name = "lbDescEdit";
            this.lbDescEdit.Size = new System.Drawing.Size(118, 20);
            this.lbDescEdit.TabIndex = 14;
            this.lbDescEdit.Text = "DESCRIPTION";
            // 
            // tbTitleEdit
            // 
            this.tbTitleEdit.Location = new System.Drawing.Point(897, 106);
            this.tbTitleEdit.Name = "tbTitleEdit";
            this.tbTitleEdit.Size = new System.Drawing.Size(309, 26);
            this.tbTitleEdit.TabIndex = 13;
            // 
            // lbTitleEdit
            // 
            this.lbTitleEdit.AutoSize = true;
            this.lbTitleEdit.Location = new System.Drawing.Point(839, 109);
            this.lbTitleEdit.Name = "lbTitleEdit";
            this.lbTitleEdit.Size = new System.Drawing.Size(52, 20);
            this.lbTitleEdit.TabIndex = 12;
            this.lbTitleEdit.Text = "TITLE";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(564, 3);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(97, 49);
            this.btnEdit.TabIndex = 11;
            this.btnEdit.Text = "EDIT";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // cbStatusEdit
            // 
            this.cbStatusEdit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatusEdit.FormattingEnabled = true;
            this.cbStatusEdit.Location = new System.Drawing.Point(897, 172);
            this.cbStatusEdit.Name = "cbStatusEdit";
            this.cbStatusEdit.Size = new System.Drawing.Size(121, 28);
            this.cbStatusEdit.TabIndex = 10;
            // 
            // btnClearAdd
            // 
            this.btnClearAdd.Location = new System.Drawing.Point(12, 164);
            this.btnClearAdd.Name = "btnClearAdd";
            this.btnClearAdd.Size = new System.Drawing.Size(97, 49);
            this.btnClearAdd.TabIndex = 9;
            this.btnClearAdd.Text = "CLEAR";
            this.btnClearAdd.UseVisualStyleBackColor = true;
            this.btnClearAdd.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(658, 106);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(97, 49);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // ToDo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 676);
            this.Controls.Add(this.splitContainer1);
            this.Name = "ToDo";
            this.Text = "ToDo";
            this.Load += new System.EventHandler(this.ToDo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvTasks)).EndInit();
            this.gbOptions.ResumeLayout(false);
            this.gbOptions.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gvTasks;
        private System.Windows.Forms.Button btnShowTasks;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.Label lbDesc;
        private System.Windows.Forms.TextBox tbDesc;
        private System.Windows.Forms.GroupBox gbOptions;
        private System.Windows.Forms.RadioButton radioPending;
        private System.Windows.Forms.RadioButton radioUnderway;
        private System.Windows.Forms.RadioButton radioDone;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnClearAdd;
        private System.Windows.Forms.ComboBox cbStatusEdit;
        private System.Windows.Forms.Button btnClearEdit;
        private System.Windows.Forms.TextBox tbDescEdit;
        private System.Windows.Forms.Label lbDescEdit;
        private System.Windows.Forms.TextBox tbTitleEdit;
        private System.Windows.Forms.Label lbTitleEdit;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label lbStatusEdit;
        private System.Windows.Forms.Button btnSave;
    }
}

