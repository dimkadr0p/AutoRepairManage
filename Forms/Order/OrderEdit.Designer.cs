
namespace AdminAPP.Forms
{
    partial class CreateOrderForm
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
            this.labelPerson = new System.Windows.Forms.Label();
            this.comboBoxPerson = new System.Windows.Forms.ComboBox();
            this.comboBoxCar = new System.Windows.Forms.ComboBox();
            this.labelCar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.checkBoxStatus = new System.Windows.Forms.CheckBox();
            this.buttonAction = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelPerson
            // 
            this.labelPerson.AutoSize = true;
            this.labelPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPerson.Location = new System.Drawing.Point(40, 31);
            this.labelPerson.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPerson.Name = "labelPerson";
            this.labelPerson.Size = new System.Drawing.Size(87, 25);
            this.labelPerson.TabIndex = 0;
            this.labelPerson.Text = "Клиент:";
            // 
            // comboBoxPerson
            // 
            this.comboBoxPerson.FormattingEnabled = true;
            this.comboBoxPerson.Location = new System.Drawing.Point(160, 33);
            this.comboBoxPerson.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxPerson.Name = "comboBoxPerson";
            this.comboBoxPerson.Size = new System.Drawing.Size(161, 24);
            this.comboBoxPerson.TabIndex = 1;
            // 
            // comboBoxCar
            // 
            this.comboBoxCar.FormattingEnabled = true;
            this.comboBoxCar.Location = new System.Drawing.Point(213, 98);
            this.comboBoxCar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxCar.Name = "comboBoxCar";
            this.comboBoxCar.Size = new System.Drawing.Size(161, 24);
            this.comboBoxCar.TabIndex = 3;
            // 
            // labelCar
            // 
            this.labelCar.AutoSize = true;
            this.labelCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCar.Location = new System.Drawing.Point(40, 96);
            this.labelCar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCar.Name = "labelCar";
            this.labelCar.Size = new System.Drawing.Size(136, 25);
            this.labelCar.TabIndex = 2;
            this.labelCar.Text = "Автомобиль:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(441, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Дата:";
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.Location = new System.Drawing.Point(561, 31);
            this.dateTimePickerDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(209, 22);
            this.dateTimePickerDate.TabIndex = 5;
            // 
            // checkBoxStatus
            // 
            this.checkBoxStatus.AutoSize = true;
            this.checkBoxStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxStatus.Location = new System.Drawing.Point(45, 159);
            this.checkBoxStatus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxStatus.Name = "checkBoxStatus";
            this.checkBoxStatus.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxStatus.Size = new System.Drawing.Size(106, 29);
            this.checkBoxStatus.TabIndex = 7;
            this.checkBoxStatus.Text = ":Статус";
            this.checkBoxStatus.UseVisualStyleBackColor = true;
            // 
            // buttonAction
            // 
            this.buttonAction.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonAction.Location = new System.Drawing.Point(45, 222);
            this.buttonAction.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAction.Name = "buttonAction";
            this.buttonAction.Size = new System.Drawing.Size(160, 49);
            this.buttonAction.TabIndex = 10;
            this.buttonAction.Text = "Создать";
            this.buttonAction.UseVisualStyleBackColor = true;
            this.buttonAction.Click += new System.EventHandler(this.buttonAction_Click);
            // 
            // CreateOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 286);
            this.Controls.Add(this.buttonAction);
            this.Controls.Add(this.checkBoxStatus);
            this.Controls.Add(this.dateTimePickerDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxCar);
            this.Controls.Add(this.labelCar);
            this.Controls.Add(this.comboBoxPerson);
            this.Controls.Add(this.labelPerson);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CreateOrderForm";
            this.Text = "Создать заказ";
            this.Load += new System.EventHandler(this.CreateOrderForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPerson;
        private System.Windows.Forms.ComboBox comboBoxPerson;
        private System.Windows.Forms.ComboBox comboBoxCar;
        private System.Windows.Forms.Label labelCar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.CheckBox checkBoxStatus;
        private System.Windows.Forms.Button buttonAction;
    }
}