
namespace Taxi
{
    partial class DeleteOrderForm
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
            this.ord_del_btn_cancel = new System.Windows.Forms.Button();
            this.Del_ord_btn_ok = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ord_del_btn_cancel
            // 
            this.ord_del_btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ord_del_btn_cancel.Location = new System.Drawing.Point(180, 97);
            this.ord_del_btn_cancel.Name = "ord_del_btn_cancel";
            this.ord_del_btn_cancel.Size = new System.Drawing.Size(94, 34);
            this.ord_del_btn_cancel.TabIndex = 5;
            this.ord_del_btn_cancel.Text = "Нет";
            this.ord_del_btn_cancel.UseVisualStyleBackColor = true;
            // 
            // Del_ord_btn_ok
            // 
            this.Del_ord_btn_ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Del_ord_btn_ok.Location = new System.Drawing.Point(49, 97);
            this.Del_ord_btn_ok.Name = "Del_ord_btn_ok";
            this.Del_ord_btn_ok.Size = new System.Drawing.Size(94, 34);
            this.Del_ord_btn_ok.TabIndex = 4;
            this.Del_ord_btn_ok.Text = "Да";
            this.Del_ord_btn_ok.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Вы уверены что хотите удалить заказ?";
            // 
            // DeleteOrderForm
            // 
            this.AcceptButton = this.Del_ord_btn_ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ord_del_btn_cancel;
            this.ClientSize = new System.Drawing.Size(329, 170);
            this.ControlBox = false;
            this.Controls.Add(this.ord_del_btn_cancel);
            this.Controls.Add(this.Del_ord_btn_ok);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DeleteOrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Удаление заказа";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ord_del_btn_cancel;
        private System.Windows.Forms.Button Del_ord_btn_ok;
        private System.Windows.Forms.Label label1;
    }
}