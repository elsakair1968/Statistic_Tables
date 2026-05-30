using System;
using System.Windows.Forms;

namespace Statistic_Table
{
    partial class Prosecution_Partial
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnRefresh = new System.Windows.Forms.Button();
            this.BtnNew = new System.Windows.Forms.Button();
            this.CmbList = new System.Windows.Forms.ComboBox();
            this.ChkActive = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvProsecutions = new System.Windows.Forms.DataGridView();
            this.BtnPrint = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnReturn = new System.Windows.Forms.Button();
            this.TxtNotes = new System.Windows.Forms.TextBox();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.TxtNumber = new System.Windows.Forms.TextBox();
            this.TxtCode = new System.Windows.Forms.TextBox();
            this.TxtID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProsecutions)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnRefresh);
            this.panel1.Controls.Add(this.BtnNew);
            this.panel1.Controls.Add(this.CmbList);
            this.panel1.Controls.Add(this.ChkActive);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.TxtSearch);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.dgvProsecutions);
            this.panel1.Controls.Add(this.BtnPrint);
            this.panel1.Controls.Add(this.BtnDelete);
            this.panel1.Controls.Add(this.BtnSave);
            this.panel1.Controls.Add(this.BtnEdit);
            this.panel1.Controls.Add(this.BtnReturn);
            this.panel1.Controls.Add(this.TxtNotes);
            this.panel1.Controls.Add(this.TxtName);
            this.panel1.Controls.Add(this.TxtNumber);
            this.panel1.Controls.Add(this.TxtCode);
            this.panel1.Controls.Add(this.TxtID);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(734, 713);
            this.panel1.TabIndex = 0;
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnRefresh.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BtnRefresh.Image = global::Statistic_Table.Properties.Resources.Double_J_Design_Super_Mono_3d_Button_round_reload_48;
            this.BtnRefresh.Location = new System.Drawing.Point(313, 262);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(54, 54);
            this.BtnRefresh.TabIndex = 26;
            this.BtnRefresh.UseVisualStyleBackColor = false;
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // BtnNew
            // 
            this.BtnNew.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnNew.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BtnNew.Image = global::Statistic_Table.Properties.Resources.Double_J_Design_Super_Mono_3d_Edit_new_document_48;
            this.BtnNew.Location = new System.Drawing.Point(253, 262);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(54, 54);
            this.BtnNew.TabIndex = 25;
            this.BtnNew.UseVisualStyleBackColor = false;
            // 
            // CmbList
            // 
            this.CmbList.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CmbList.Font = new System.Drawing.Font("SKR HEAD1", 14F, System.Drawing.FontStyle.Bold);
            this.CmbList.FormattingEnabled = true;
            this.CmbList.Location = new System.Drawing.Point(13, 112);
            this.CmbList.Name = "CmbList";
            this.CmbList.Size = new System.Drawing.Size(346, 37);
            this.CmbList.TabIndex = 24;
            // 
            // ChkActive
            // 
            this.ChkActive.Font = new System.Drawing.Font("SKR HEAD1", 20.25F, System.Drawing.FontStyle.Bold);
            this.ChkActive.Location = new System.Drawing.Point(433, 269);
            this.ChkActive.Name = "ChkActive";
            this.ChkActive.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ChkActive.Size = new System.Drawing.Size(112, 40);
            this.ChkActive.TabIndex = 23;
            this.ChkActive.Text = "مفعل";
            this.ChkActive.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label7.Font = new System.Drawing.Font("SKR HEAD1", 20.25F);
            this.label7.Location = new System.Drawing.Point(551, 269);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(170, 40);
            this.label7.TabIndex = 22;
            this.label7.Text = "الحالة";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TxtSearch
            // 
            this.TxtSearch.Font = new System.Drawing.Font("SKR HEAD1", 14F, System.Drawing.FontStyle.Bold);
            this.TxtSearch.Location = new System.Drawing.Point(13, 325);
            this.TxtSearch.Multiline = true;
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TxtSearch.Size = new System.Drawing.Size(532, 40);
            this.TxtSearch.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label8.Font = new System.Drawing.Font("SKR HEAD1", 20.25F);
            this.label8.Location = new System.Drawing.Point(551, 322);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(170, 40);
            this.label8.TabIndex = 20;
            this.label8.Text = "بحث";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgvProsecutions
            // 
            this.dgvProsecutions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProsecutions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvProsecutions.Location = new System.Drawing.Point(0, 371);
            this.dgvProsecutions.Name = "dgvProsecutions";
            this.dgvProsecutions.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvProsecutions.Size = new System.Drawing.Size(734, 307);
            this.dgvProsecutions.TabIndex = 19;
            // 
            // BtnPrint
            // 
            this.BtnPrint.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnPrint.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BtnPrint.Image = global::Statistic_Table.Properties.Resources.Double_J_Design_Super_Mono_3d_Printer_48;
            this.BtnPrint.Location = new System.Drawing.Point(13, 262);
            this.BtnPrint.Name = "BtnPrint";
            this.BtnPrint.Size = new System.Drawing.Size(54, 54);
            this.BtnPrint.TabIndex = 18;
            this.BtnPrint.UseVisualStyleBackColor = false;
            this.BtnPrint.Click += new System.EventHandler(this.BtnPrint_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnDelete.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BtnDelete.Image = global::Statistic_Table.Properties.Resources.Double_J_Design_Super_Mono_3d_Edit_scissor_cut_48;
            this.BtnDelete.Location = new System.Drawing.Point(73, 262);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(54, 54);
            this.BtnDelete.TabIndex = 17;
            this.BtnDelete.UseVisualStyleBackColor = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnSave.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BtnSave.Image = global::Statistic_Table.Properties.Resources.Double_J_Design_Super_Mono_3d_Floppy_save_48;
            this.BtnSave.Location = new System.Drawing.Point(133, 262);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(54, 54);
            this.BtnSave.TabIndex = 16;
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnEdit.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BtnEdit.Image = global::Statistic_Table.Properties.Resources.Double_J_Design_Super_Mono_3d_Edit_48;
            this.BtnEdit.Location = new System.Drawing.Point(193, 262);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(54, 54);
            this.BtnEdit.TabIndex = 15;
            this.BtnEdit.UseVisualStyleBackColor = false;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnReturn
            // 
            this.BtnReturn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnReturn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BtnReturn.Image = global::Statistic_Table.Properties.Resources.Double_J_Design_Super_Mono_3d_Button_round_start_48;
            this.BtnReturn.Location = new System.Drawing.Point(373, 262);
            this.BtnReturn.Name = "BtnReturn";
            this.BtnReturn.Size = new System.Drawing.Size(54, 54);
            this.BtnReturn.TabIndex = 12;
            this.BtnReturn.UseVisualStyleBackColor = false;
            this.BtnReturn.Click += new System.EventHandler(this.BtnReturn_Click);
            // 
            // TxtNotes
            // 
            this.TxtNotes.Font = new System.Drawing.Font("SKR HEAD1", 14F, System.Drawing.FontStyle.Bold);
            this.TxtNotes.Location = new System.Drawing.Point(13, 219);
            this.TxtNotes.Multiline = true;
            this.TxtNotes.Name = "TxtNotes";
            this.TxtNotes.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TxtNotes.Size = new System.Drawing.Size(532, 40);
            this.TxtNotes.TabIndex = 11;
            // 
            // TxtName
            // 
            this.TxtName.Font = new System.Drawing.Font("SKR HEAD1", 14F, System.Drawing.FontStyle.Bold);
            this.TxtName.Location = new System.Drawing.Point(13, 167);
            this.TxtName.Multiline = true;
            this.TxtName.Name = "TxtName";
            this.TxtName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TxtName.Size = new System.Drawing.Size(533, 40);
            this.TxtName.TabIndex = 10;
            // 
            // TxtNumber
            // 
            this.TxtNumber.Font = new System.Drawing.Font("SKR HEAD1", 14F, System.Drawing.FontStyle.Bold);
            this.TxtNumber.Location = new System.Drawing.Point(365, 113);
            this.TxtNumber.Multiline = true;
            this.TxtNumber.Name = "TxtNumber";
            this.TxtNumber.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TxtNumber.Size = new System.Drawing.Size(180, 40);
            this.TxtNumber.TabIndex = 9;
            // 
            // TxtCode
            // 
            this.TxtCode.Font = new System.Drawing.Font("SKR HEAD1", 14F, System.Drawing.FontStyle.Bold);
            this.TxtCode.Location = new System.Drawing.Point(13, 59);
            this.TxtCode.Multiline = true;
            this.TxtCode.Name = "TxtCode";
            this.TxtCode.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TxtCode.Size = new System.Drawing.Size(180, 40);
            this.TxtCode.TabIndex = 8;
            // 
            // TxtID
            // 
            this.TxtID.Font = new System.Drawing.Font("SKR HEAD1", 14F, System.Drawing.FontStyle.Bold);
            this.TxtID.Location = new System.Drawing.Point(365, 60);
            this.TxtID.Multiline = true;
            this.TxtID.Name = "TxtID";
            this.TxtID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TxtID.Size = new System.Drawing.Size(180, 40);
            this.TxtID.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label6.Font = new System.Drawing.Font("SKR HEAD1", 20.25F);
            this.label6.Location = new System.Drawing.Point(551, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 40);
            this.label6.TabIndex = 6;
            this.label6.Text = "ملاحظـــات";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label5.Font = new System.Drawing.Font("SKR HEAD1", 20.25F);
            this.label5.Location = new System.Drawing.Point(551, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 40);
            this.label5.TabIndex = 5;
            this.label5.Text = "اسم النيابة";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label4.Font = new System.Drawing.Font("SKR HEAD1", 20.25F);
            this.label4.Location = new System.Drawing.Point(551, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 40);
            this.label4.TabIndex = 4;
            this.label4.Text = "رقم النيابة";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(199, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 40);
            this.label3.TabIndex = 3;
            this.label3.Text = "Code";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(551, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 40);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 678);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(734, 35);
            this.panel3.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(734, 45);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("KHREIM-A3", 24F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(734, 45);
            this.label1.TabIndex = 2;
            this.label1.Text = "قائمة النيابات الابتدائية والجزئية";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Prosecution_Partial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 42F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 713);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("SKR HEAD1", 20.25F);
            this.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.Name = "Prosecution_Partial";
            this.RightToLeftLayout = true;
            this.Text = "نظام الاحصاء والتوثيق";
            this.Load += new System.EventHandler(this.Prosecution_Partial_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProsecutions)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnReturn;
        private System.Windows.Forms.TextBox TxtNotes;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.TextBox TxtNumber;
        private System.Windows.Forms.TextBox TxtCode;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnPrint;
        private System.Windows.Forms.DataGridView dgvProsecutions;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox CmbList;
        private System.Windows.Forms.CheckBox ChkActive;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BtnNew;
        private System.Windows.Forms.Button BtnRefresh;
        //private readonly EventHandler BtnNew_Click;
        //private readonly EventHandler TxtNumber_TextChanged;
        //private readonly EventHandler TxtID_TextChanged;

        public PaintEventHandler panel1_Paint { get; private set; }

        private void BtnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

