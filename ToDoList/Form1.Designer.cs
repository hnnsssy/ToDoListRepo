﻿namespace ToDoList
{
    partial class Form1
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
            this.toDoList = new System.Windows.Forms.CheckedListBox();
            this.button_Add = new System.Windows.Forms.Button();
            this.button_Edit = new System.Windows.Forms.Button();
            this.button_Remove = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_EndDt = new System.Windows.Forms.Label();
            this.label_StartDt = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toDoList
            // 
            this.toDoList.FormattingEnabled = true;
            this.toDoList.Location = new System.Drawing.Point(12, 12);
            this.toDoList.Name = "toDoList";
            this.toDoList.Size = new System.Drawing.Size(163, 139);
            this.toDoList.TabIndex = 0;
            this.toDoList.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.toDoList_ItemCheck);
            this.toDoList.SelectedIndexChanged += new System.EventHandler(this.toDoList_SelectedIndexChanged);
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(6, 19);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(100, 23);
            this.button_Add.TabIndex = 1;
            this.button_Add.Text = "Add";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // button_Edit
            // 
            this.button_Edit.Location = new System.Drawing.Point(6, 48);
            this.button_Edit.Name = "button_Edit";
            this.button_Edit.Size = new System.Drawing.Size(100, 23);
            this.button_Edit.TabIndex = 2;
            this.button_Edit.Text = "Edit";
            this.button_Edit.UseVisualStyleBackColor = true;
            this.button_Edit.Click += new System.EventHandler(this.button_Edit_Click);
            // 
            // button_Remove
            // 
            this.button_Remove.Location = new System.Drawing.Point(6, 77);
            this.button_Remove.Name = "button_Remove";
            this.button_Remove.Size = new System.Drawing.Size(100, 23);
            this.button_Remove.TabIndex = 3;
            this.button_Remove.Text = "Remove";
            this.button_Remove.UseVisualStyleBackColor = true;
            this.button_Remove.Click += new System.EventHandler(this.button_Remove_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_Add);
            this.groupBox1.Controls.Add(this.button_Remove);
            this.groupBox1.Controls.Add(this.button_Edit);
            this.groupBox1.Location = new System.Drawing.Point(181, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(112, 109);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Panel";
            // 
            // label_EndDt
            // 
            this.label_EndDt.AutoSize = true;
            this.label_EndDt.Location = new System.Drawing.Point(178, 139);
            this.label_EndDt.Name = "label_EndDt";
            this.label_EndDt.Size = new System.Drawing.Size(55, 13);
            this.label_EndDt.TabIndex = 8;
            this.label_EndDt.Text = "End Date:";
            // 
            // label_StartDt
            // 
            this.label_StartDt.AutoSize = true;
            this.label_StartDt.Location = new System.Drawing.Point(178, 124);
            this.label_StartDt.Name = "label_StartDt";
            this.label_StartDt.Size = new System.Drawing.Size(61, 13);
            this.label_StartDt.TabIndex = 7;
            this.label_StartDt.Text = "Start Date: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 165);
            this.Controls.Add(this.label_EndDt);
            this.Controls.Add(this.label_StartDt);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toDoList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox toDoList;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Button button_Edit;
        private System.Windows.Forms.Button button_Remove;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_EndDt;
        private System.Windows.Forms.Label label_StartDt;
    }
}

