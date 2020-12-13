
namespace FormsApp
{
    partial class PointForm
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
            this.bntSerialize = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.btnDeserialize = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bntSerialize
            // 
            this.bntSerialize.Location = new System.Drawing.Point(411, 370);
            this.bntSerialize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bntSerialize.Name = "bntSerialize";
            this.bntSerialize.Size = new System.Drawing.Size(144, 48);
            this.bntSerialize.TabIndex = 7;
            this.bntSerialize.Text = "Serialize";
            this.bntSerialize.UseVisualStyleBackColor = true;
            this.bntSerialize.Click += new System.EventHandler(this.bntSerialize_Click);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 16;
            this.listBox.Location = new System.Drawing.Point(81, 32);
            this.listBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(639, 292);
            this.listBox.TabIndex = 6;
            // 
            // btnDeserialize
            // 
            this.btnDeserialize.Location = new System.Drawing.Point(575, 370);
            this.btnDeserialize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeserialize.Name = "btnDeserialize";
            this.btnDeserialize.Size = new System.Drawing.Size(145, 48);
            this.btnDeserialize.TabIndex = 3;
            this.btnDeserialize.Text = "Deserialize";
            this.btnDeserialize.UseVisualStyleBackColor = true;
            this.btnDeserialize.Click += new System.EventHandler(this.btnDeserialize_Click);
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(249, 370);
            this.btnSort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(145, 48);
            this.btnSort.TabIndex = 4;
            this.btnSort.Text = "Sort";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(87, 370);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(145, 48);
            this.btnCreate.TabIndex = 5;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // PointForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bntSerialize);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.btnDeserialize);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.btnCreate);
            this.Name = "PointForm";
            this.Text = "PointForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bntSerialize;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button btnDeserialize;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Button btnCreate;
    }
}