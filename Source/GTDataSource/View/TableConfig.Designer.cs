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
            this.dgvSelectTable = new System.Windows.Forms.DataGridView();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.btnBack = new MetroFramework.Controls.MetroButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pnGenAuto = new System.Windows.Forms.Panel();
            this.cbbReset = new System.Windows.Forms.ComboBox();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbOutputType = new MetroFramework.Controls.MetroComboBox();
            this.cbbGenMethod = new MetroFramework.Controls.MetroComboBox();
            this.dgvManual = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectTable)).BeginInit();
            this.pnGenAuto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManual)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSelectTable
            // 
            this.dgvSelectTable.AllowUserToAddRows = false;
            this.dgvSelectTable.AllowUserToDeleteRows = false;
            this.dgvSelectTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSelectTable.Location = new System.Drawing.Point(0, 62);
            this.dgvSelectTable.Margin = new System.Windows.Forms.Padding(4);
            this.dgvSelectTable.Name = "dgvSelectTable";
            this.dgvSelectTable.Size = new System.Drawing.Size(976, 323);
            this.dgvSelectTable.TabIndex = 0;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(899, 573);
            this.metroButton1.Margin = new System.Windows.Forms.Padding(4);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(115, 34);
            this.metroButton1.TabIndex = 10;
            this.metroButton1.Text = "Generate";
            this.metroButton1.UseSelectable = true;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(764, 573);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(115, 34);
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "Back";
            this.btnBack.UseSelectable = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(482, 89);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Output type";
            // 
            // pnGenAuto
            // 
            this.pnGenAuto.Controls.Add(this.cbbReset);
            this.pnGenAuto.Controls.Add(this.metroButton2);
            this.pnGenAuto.Controls.Add(this.dgvSelectTable);
            this.pnGenAuto.Controls.Add(this.dgvManual);
            this.pnGenAuto.Location = new System.Drawing.Point(45, 156);
            this.pnGenAuto.Margin = new System.Windows.Forms.Padding(4);
            this.pnGenAuto.Name = "pnGenAuto";
            this.pnGenAuto.Size = new System.Drawing.Size(976, 388);
            this.pnGenAuto.TabIndex = 7;
            // 
            // cbbReset
            // 
            this.cbbReset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbReset.FormattingEnabled = true;
            this.cbbReset.Location = new System.Drawing.Point(3, 31);
            this.cbbReset.Name = "cbbReset";
            this.cbbReset.Size = new System.Drawing.Size(132, 24);
            this.cbbReset.TabIndex = 17;
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(901, 26);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(75, 23);
            this.metroButton2.TabIndex = 9;
            this.metroButton2.Text = "Select all";
            this.metroButton2.UseSelectable = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 94);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Generation method";
            // 
            // cbbOutputType
            // 
            this.cbbOutputType.FormattingEnabled = true;
            this.cbbOutputType.ItemHeight = 23;
            this.cbbOutputType.Location = new System.Drawing.Point(587, 85);
            this.cbbOutputType.Name = "cbbOutputType";
            this.cbbOutputType.Size = new System.Drawing.Size(187, 29);
            this.cbbOutputType.TabIndex = 13;
            this.cbbOutputType.UseSelectable = true;
            // 
            // cbbGenMethod
            // 
            this.cbbGenMethod.FormattingEnabled = true;
            this.cbbGenMethod.ItemHeight = 23;
            this.cbbGenMethod.Location = new System.Drawing.Point(193, 85);
            this.cbbGenMethod.Name = "cbbGenMethod";
            this.cbbGenMethod.Size = new System.Drawing.Size(171, 29);
            this.cbbGenMethod.TabIndex = 16;
            this.cbbGenMethod.UseSelectable = true;
            this.cbbGenMethod.SelectedIndexChanged += new System.EventHandler(this.cbbGenMethod_SelectedIndexChanged);
            // 
            // dgvManual
            // 
            this.dgvManual.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvManual.Location = new System.Drawing.Point(0, 62);
            this.dgvManual.Name = "dgvManual";
            this.dgvManual.Size = new System.Drawing.Size(976, 323);
            this.dgvManual.TabIndex = 18;
            // 
            // TableConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 636);
            this.Controls.Add(this.cbbGenMethod);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbOutputType);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pnGenAuto);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "TableConfig";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.Text = "Config generate data";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TableConfig_FormClosed);
            this.Load += new System.EventHandler(this.TableConfig_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectTable)).EndInit();
            this.pnGenAuto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvManual)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSelectTable;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton btnBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnGenAuto;
        private MetroFramework.Controls.MetroButton metroButton2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbReset;
        private MetroFramework.Controls.MetroComboBox cbbOutputType;
        private MetroFramework.Controls.MetroComboBox cbbGenMethod;
        private System.Windows.Forms.DataGridView dgvManual;
    }
}