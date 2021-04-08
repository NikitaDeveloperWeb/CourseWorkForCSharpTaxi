
namespace Taxi
{
    partial class DeleteWorkerForm
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
            this.del_wrk_btn_ok = new System.Windows.Forms.Button();
            this.wrk_btn_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(5, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Вы уверены что хотите удалить работника?";
            // 
            // del_wrk_btn_ok
            // 
            this.del_wrk_btn_ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.del_wrk_btn_ok.Location = new System.Drawing.Point(42, 114);
            this.del_wrk_btn_ok.Name = "del_wrk_btn_ok";
            this.del_wrk_btn_ok.Size = new System.Drawing.Size(94, 34);
            this.del_wrk_btn_ok.TabIndex = 1;
            this.del_wrk_btn_ok.Text = "Да";
            this.del_wrk_btn_ok.UseVisualStyleBackColor = true;
            // 
            // wrk_btn_cancel
            // 
            this.wrk_btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.wrk_btn_cancel.Location = new System.Drawing.Point(173, 114);
            this.wrk_btn_cancel.Name = "wrk_btn_cancel";
            this.wrk_btn_cancel.Size = new System.Drawing.Size(94, 34);
            this.wrk_btn_cancel.TabIndex = 2;
            this.wrk_btn_cancel.Text = "Нет";
            this.wrk_btn_cancel.UseVisualStyleBackColor = true;
            // 
            // DeleteWorkerForm
            // 
            this.AcceptButton = this.del_wrk_btn_ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.wrk_btn_cancel;
            this.ClientSize = new System.Drawing.Size(329, 170);
            this.ControlBox = false;
            this.Controls.Add(this.wrk_btn_cancel);
            this.Controls.Add(this.del_wrk_btn_ok);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "DeleteWorkerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Удаление работника";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button del_wrk_btn_ok;
        private System.Windows.Forms.Button wrk_btn_cancel;
    }
}