
namespace AdminAPP.Forms
{
    partial class ViewAuto
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
            this.textBoxCarTitle = new System.Windows.Forms.TextBox();
            this.labelAuto = new System.Windows.Forms.Label();
            this.labelNumber = new System.Windows.Forms.Label();
            this.textBoxNumberValue = new System.Windows.Forms.TextBox();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxCarTitle
            // 
            this.textBoxCarTitle.Location = new System.Drawing.Point(172, 39);
            this.textBoxCarTitle.Name = "textBoxCarTitle";
            this.textBoxCarTitle.Size = new System.Drawing.Size(148, 20);
            this.textBoxCarTitle.TabIndex = 0;
            // 
            // labelAuto
            // 
            this.labelAuto.AutoSize = true;
            this.labelAuto.Location = new System.Drawing.Point(43, 45);
            this.labelAuto.Name = "labelAuto";
            this.labelAuto.Size = new System.Drawing.Size(51, 13);
            this.labelAuto.TabIndex = 1;
            this.labelAuto.Text = "Машина:";
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.Location = new System.Drawing.Point(43, 97);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(44, 13);
            this.labelNumber.TabIndex = 5;
            this.labelNumber.Text = "Номер:";
            // 
            // textBoxNumberValue
            // 
            this.textBoxNumberValue.Location = new System.Drawing.Point(172, 91);
            this.textBoxNumberValue.Name = "textBoxNumberValue";
            this.textBoxNumberValue.Size = new System.Drawing.Size(148, 20);
            this.textBoxNumberValue.TabIndex = 4;
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.Location = new System.Drawing.Point(172, 152);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(148, 20);
            this.dateTimePickerDate.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Куплена:";
            // 
            // ViewAuto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 250);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePickerDate);
            this.Controls.Add(this.labelNumber);
            this.Controls.Add(this.textBoxNumberValue);
            this.Controls.Add(this.labelAuto);
            this.Controls.Add(this.textBoxCarTitle);
            this.Name = "ViewAuto";
            this.Text = "ViewAuto";
            this.Load += new System.EventHandler(this.ViewAuto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxCarTitle;
        private System.Windows.Forms.Label labelAuto;
        private System.Windows.Forms.Label labelNumber;
        private System.Windows.Forms.TextBox textBoxNumberValue;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.Label label4;
    }
}