namespace final_project_test
{
    partial class ToDoListForm
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
            this.tbx_ToDo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_add = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbx_ToDo
            // 
            this.tbx_ToDo.Font = new System.Drawing.Font("新細明體", 16F);
            this.tbx_ToDo.Location = new System.Drawing.Point(189, 136);
            this.tbx_ToDo.Name = "tbx_ToDo";
            this.tbx_ToDo.Size = new System.Drawing.Size(306, 39);
            this.tbx_ToDo.TabIndex = 0;
            this.tbx_ToDo.Click += new System.EventHandler(this.tbx_ToDo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 16F);
            this.label1.Location = new System.Drawing.Point(56, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "代辦事項:";
            // 
            // btn_add
            // 
            this.btn_add.AutoSize = true;
            this.btn_add.Font = new System.Drawing.Font("新細明體", 16F);
            this.btn_add.Location = new System.Drawing.Point(209, 229);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 37);
            this.btn_add.TabIndex = 2;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Font = new System.Drawing.Font("新細明體", 16F);
            this.button1.Location = new System.Drawing.Point(334, 229);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 37);
            this.button1.TabIndex = 3;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_add
            // 
            this.lbl_add.AutoSize = true;
            this.lbl_add.Location = new System.Drawing.Point(502, 159);
            this.lbl_add.Name = "lbl_add";
            this.lbl_add.Size = new System.Drawing.Size(49, 15);
            this.lbl_add.TabIndex = 4;
            this.lbl_add.Text = "lbl_add";
            // 
            // ToDoListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 314);
            this.Controls.Add(this.lbl_add);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbx_ToDo);
            this.Name = "ToDoListForm";
            this.Text = "新增代辦事項";
            this.Load += new System.EventHandler(this.ToDoListForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbx_ToDo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_add;
    }
}