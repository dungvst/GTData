namespace GDataSource.View
{
    partial class TableConfig
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
            this.cbbGenMethod = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.dgvSelectTable = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectTable)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(368, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Configuration";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Generation method";
            // 
            // cbbGenMethod
            // 
            this.cbbGenMethod.AllowDrop = true;
            this.cbbGenMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbGenMethod.FormattingEnabled = true;
            this.cbbGenMethod.Location = new System.Drawing.Point(224, 110);
            this.cbbGenMethod.Name = "cbbGenMethod";
            this.cbbGenMethod.Size = new System.Drawing.Size(157, 21);
            this.cbbGenMethod.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(652, 541);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 37);
            this.button1.TabIndex = 4;
            this.button1.Text = "Generate";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(287, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Select and Edit table you want to generate data";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.dgvSelectTable);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(104, 156);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(680, 360);
            this.panel1.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(602, 21);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Select all";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // dgvSelectTable
            // 
            this.dgvSelectTable.AllowUserToAddRows = false;
            this.dgvSelectTable.AllowUserToDeleteRows = false;
            this.dgvSelectTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSelectTable.Location = new System.Drawing.Point(0, 50);
            this.dgvSelectTable.Name = "dgvSelectTable";
            this.dgvSelectTable.Size = new System.Drawing.Size(677, 293);
            this.dgvSelectTable.TabIndex = 0;
            // 
            // TableConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 599);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbbGenMethod);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TableConfig";
            this.Text = "TableConfig";
            this.Load += new System.EventHandler(this.TableConfig_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbGenMethod;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvSelectTable;
        private System.Windows.Forms.Button button2;
    }
}