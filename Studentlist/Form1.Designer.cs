namespace Studentlist
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.btnnew = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnms = new System.Windows.Forms.Button();
            this.btnmn = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.btnfirst = new System.Windows.Forms.Button();
            this.txtindex = new System.Windows.Forms.TextBox();
            this.btnclose = new System.Windows.Forms.Button();
            this.stuid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stuname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stuph = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(75, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label2.Location = new System.Drawing.Point(75, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 39);
            this.label2.TabIndex = 0;
            this.label2.Text = "Student Name ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label3.Location = new System.Drawing.Point(75, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 39);
            this.label3.TabIndex = 0;
            this.label3.Text = "Phone";
            // 
            // txtid
            // 
            this.txtid.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtid.Location = new System.Drawing.Point(337, 63);
            this.txtid.MaximumSize = new System.Drawing.Size(500, 50);
            this.txtid.MinimumSize = new System.Drawing.Size(300, 40);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(500, 36);
            this.txtid.TabIndex = 1;
            this.txtid.TextChanged += new System.EventHandler(this.txtid_TextChanged);
            // 
            // txtname
            // 
            this.txtname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtname.Location = new System.Drawing.Point(337, 163);
            this.txtname.MaximumSize = new System.Drawing.Size(500, 50);
            this.txtname.MinimumSize = new System.Drawing.Size(300, 40);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(500, 36);
            this.txtname.TabIndex = 1;
            this.txtname.TextChanged += new System.EventHandler(this.txtname_TextChanged);
            // 
            // txtphone
            // 
            this.txtphone.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtphone.Location = new System.Drawing.Point(337, 253);
            this.txtphone.MaximumSize = new System.Drawing.Size(500, 50);
            this.txtphone.MinimumSize = new System.Drawing.Size(300, 40);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(500, 36);
            this.txtphone.TabIndex = 1;
            this.txtphone.TextChanged += new System.EventHandler(this.txtphone_TextChanged);
            // 
            // btnnew
            // 
            this.btnnew.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnnew.Location = new System.Drawing.Point(930, 66);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(105, 56);
            this.btnnew.TabIndex = 2;
            this.btnnew.Text = "New";
            this.btnnew.UseVisualStyleBackColor = true;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // btnadd
            // 
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnadd.Location = new System.Drawing.Point(930, 164);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(105, 56);
            this.btnadd.TabIndex = 2;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btndelete
            // 
            this.btndelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btndelete.Location = new System.Drawing.Point(930, 249);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(105, 56);
            this.btndelete.TabIndex = 2;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnms
            // 
            this.btnms.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnms.Location = new System.Drawing.Point(879, 362);
            this.btnms.Name = "btnms";
            this.btnms.Size = new System.Drawing.Size(156, 56);
            this.btnms.TabIndex = 2;
            this.btnms.Text = "Move Last";
            this.btnms.UseVisualStyleBackColor = true;
            this.btnms.Click += new System.EventHandler(this.btnms_Click);
            // 
            // btnmn
            // 
            this.btnmn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnmn.Location = new System.Drawing.Point(724, 362);
            this.btnmn.Name = "btnmn";
            this.btnmn.Size = new System.Drawing.Size(149, 56);
            this.btnmn.TabIndex = 2;
            this.btnmn.Text = "Move Next";
            this.btnmn.UseVisualStyleBackColor = true;
            this.btnmn.Click += new System.EventHandler(this.btnmn_Click);
            // 
            // btnback
            // 
            this.btnback.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnback.Location = new System.Drawing.Point(448, 362);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(152, 56);
            this.btnback.TabIndex = 2;
            this.btnback.Text = "Move Back";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // btnfirst
            // 
            this.btnfirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnfirst.Location = new System.Drawing.Point(291, 362);
            this.btnfirst.Name = "btnfirst";
            this.btnfirst.Size = new System.Drawing.Size(151, 56);
            this.btnfirst.TabIndex = 2;
            this.btnfirst.Text = "Move First";
            this.btnfirst.UseVisualStyleBackColor = true;
            this.btnfirst.Click += new System.EventHandler(this.btnfirst_Click);
            // 
            // txtindex
            // 
            this.txtindex.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txtindex.Location = new System.Drawing.Point(618, 368);
            this.txtindex.MaximumSize = new System.Drawing.Size(400, 50);
            this.txtindex.MinimumSize = new System.Drawing.Size(100, 50);
            this.txtindex.Name = "txtindex";
            this.txtindex.Size = new System.Drawing.Size(100, 50);
            this.txtindex.TabIndex = 3;
            this.txtindex.TextChanged += new System.EventHandler(this.txtindex_TextChanged);
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.Color.Olive;
            this.btnclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btnclose.Location = new System.Drawing.Point(1071, 66);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(145, 51);
            this.btnclose.TabIndex = 4;
            this.btnclose.Text = "Close";
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // stuid
            // 
            this.stuid.HeaderText = "Student ID";
            this.stuid.MinimumWidth = 6;
            this.stuid.Name = "stuid";
            this.stuid.Width = 125;
            // 
            // stuname
            // 
            this.stuname.HeaderText = "Student Name";
            this.stuname.MinimumWidth = 6;
            this.stuname.Name = "stuname";
            this.stuname.Width = 125;
            // 
            // stuph
            // 
            this.stuph.HeaderText = "Student Phone";
            this.stuph.MinimumWidth = 6;
            this.stuph.Name = "stuph";
            this.stuph.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1812, 741);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.txtindex);
            this.Controls.Add(this.btnfirst);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btnmn);
            this.Controls.Add(this.btnms);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.btnnew);
            this.Controls.Add(this.txtphone);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnms;
        private System.Windows.Forms.Button btnmn;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button btnfirst;
        private System.Windows.Forms.TextBox txtindex;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.DataGridViewTextBoxColumn stuid;
        private System.Windows.Forms.DataGridViewTextBoxColumn stuname;
        private System.Windows.Forms.DataGridViewTextBoxColumn stuph;
    }
}

