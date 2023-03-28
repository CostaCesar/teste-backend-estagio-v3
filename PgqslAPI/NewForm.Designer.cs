
namespace PgsqlAPI
{
    partial class NewForm
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
            this.Box_Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ComBox_Model = new System.Windows.Forms.ComboBox();
            this.Button_Ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // Box_Name
            // 
            this.Box_Name.Location = new System.Drawing.Point(64, 13);
            this.Box_Name.Name = "Box_Name";
            this.Box_Name.Size = new System.Drawing.Size(227, 20);
            this.Box_Name.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Modelo:";
            // 
            // ComBox_Model
            // 
            this.ComBox_Model.FormattingEnabled = true;
            this.ComBox_Model.Location = new System.Drawing.Point(64, 43);
            this.ComBox_Model.Name = "ComBox_Model";
            this.ComBox_Model.Size = new System.Drawing.Size(227, 21);
            this.ComBox_Model.TabIndex = 3;
            this.ComBox_Model.Text = "Selecione";
            this.ComBox_Model.SelectedIndexChanged += new System.EventHandler(this.ComBox_Model_SelectedIndexChanged);
            // 
            // Button_Ok
            // 
            this.Button_Ok.Enabled = false;
            this.Button_Ok.Location = new System.Drawing.Point(115, 78);
            this.Button_Ok.Name = "Button_Ok";
            this.Button_Ok.Size = new System.Drawing.Size(75, 23);
            this.Button_Ok.TabIndex = 4;
            this.Button_Ok.Text = "Adicionar";
            this.Button_Ok.UseVisualStyleBackColor = true;
            this.Button_Ok.Click += new System.EventHandler(this.Button_Ok_Click);
            // 
            // NewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 113);
            this.Controls.Add(this.Button_Ok);
            this.Controls.Add(this.ComBox_Model);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Box_Name);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Novo equipamento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Box_Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ComBox_Model;
        private System.Windows.Forms.Button Button_Ok;
    }
}