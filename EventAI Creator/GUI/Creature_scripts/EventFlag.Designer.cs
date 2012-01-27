﻿namespace EventAI_Creator
{
    partial class EventFlag
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
            this.button_flag_ok = new System.Windows.Forms.Button();
            this.checkedListBox_flags = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // button_flag_ok
            // 
            this.button_flag_ok.Location = new System.Drawing.Point(238, 158);
            this.button_flag_ok.Name = "button_flag_ok";
            this.button_flag_ok.Size = new System.Drawing.Size(75, 23);
            this.button_flag_ok.TabIndex = 0;
            this.button_flag_ok.Text = "OK";
            this.button_flag_ok.UseVisualStyleBackColor = true;
            this.button_flag_ok.Click += new System.EventHandler(this.button_flag_ok_Click);
            // 
            // checkedListBox_flags
            // 
            this.checkedListBox_flags.CheckOnClick = true;
            this.checkedListBox_flags.FormattingEnabled = true;
            this.checkedListBox_flags.Items.AddRange(new object[] {
            "REPEATABLE              Event repeats (Does not repeat if this flag is not set)",
            "DIFFICULTY_0             Event occurs in instance difficulty 0 (will not occur if" +
                " not set)",
            "DIFFICULTY_1             Event occurs in instance difficulty 1 (will not occur if" +
                " not set)",
            "DIFFICULTY_2             Event occurs in instance difficulty 2 (will not occur if" +
                " not set)",
            "DIFFICULTY_3             Event occurs in instance difficulty 3 (will not occur if" +
                " not set)",
            "RANDOM_ACTION      At event occur execute one random action from event actions in" +
                "stead all actions.",
            "DUMMY_FLAG             Not used",
            "DEBUG_ONLY             Prevents events from occuring on Release builds. Useful fo" +
                "r testing new features."});
            this.checkedListBox_flags.Location = new System.Drawing.Point(13, 12);
            this.checkedListBox_flags.Name = "checkedListBox_flags";
            this.checkedListBox_flags.Size = new System.Drawing.Size(525, 139);
            this.checkedListBox_flags.TabIndex = 1;
            // 
            // EventFlag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 193);
            this.Controls.Add(this.checkedListBox_flags);
            this.Controls.Add(this.button_flag_ok);
            this.Name = "EventFlag";
            this.ShowIcon = false;
            this.Text = "Event Flag Selection";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_flag_ok;
        private System.Windows.Forms.CheckedListBox checkedListBox_flags;
    }
}