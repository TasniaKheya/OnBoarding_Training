namespace DataCollection
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnArray = new Button();
            txtBox = new TextBox();
            btnList = new Button();
            btnAddArrayData = new Button();
            btnAddListData = new Button();
            label1 = new Label();
            btnDictionary = new Button();
            btnAddDictionData = new Button();
            SuspendLayout();
            // 
            // btnArray
            // 
            btnArray.BackColor = Color.MediumPurple;
            btnArray.Location = new Point(28, 392);
            btnArray.Name = "btnArray";
            btnArray.Size = new Size(82, 46);
            btnArray.TabIndex = 0;
            btnArray.Text = "ShowArray";
            btnArray.UseVisualStyleBackColor = false;
            btnArray.Click += btnArray_Click;
            // 
            // txtBox
            // 
            txtBox.Location = new Point(12, 53);
            txtBox.Multiline = true;
            txtBox.Name = "txtBox";
            txtBox.Size = new Size(776, 41);
            txtBox.TabIndex = 1;
            // 
            // btnList
            // 
            btnList.BackColor = Color.FromArgb(255, 128, 255);
            btnList.Location = new Point(116, 392);
            btnList.Name = "btnList";
            btnList.Size = new Size(74, 46);
            btnList.TabIndex = 2;
            btnList.Text = "ShowList";
            btnList.UseVisualStyleBackColor = false;
            btnList.Click += btnList_Click;
            // 
            // btnAddArrayData
            // 
            btnAddArrayData.BackColor = Color.DarkSalmon;
            btnAddArrayData.Location = new Point(643, 288);
            btnAddArrayData.Name = "btnAddArrayData";
            btnAddArrayData.Size = new Size(145, 46);
            btnAddArrayData.TabIndex = 3;
            btnAddArrayData.Text = "AddDataInArray";
            btnAddArrayData.UseVisualStyleBackColor = false;
            btnAddArrayData.Click += btnAddArrayData_Click;
            // 
            // btnAddListData
            // 
            btnAddListData.BackColor = Color.Khaki;
            btnAddListData.Location = new Point(643, 340);
            btnAddListData.Name = "btnAddListData";
            btnAddListData.Size = new Size(145, 46);
            btnAddListData.TabIndex = 4;
            btnAddListData.Text = "AddDataInList";
            btnAddListData.UseVisualStyleBackColor = false;
            btnAddListData.Click += btnAddListData_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 23);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 5;
            label1.Text = "Array Data";
            // 
            // btnDictionary
            // 
            btnDictionary.BackColor = Color.PaleTurquoise;
            btnDictionary.Location = new Point(196, 392);
            btnDictionary.Name = "btnDictionary";
            btnDictionary.Size = new Size(98, 46);
            btnDictionary.TabIndex = 6;
            btnDictionary.Text = "ShowDictionary";
            btnDictionary.UseVisualStyleBackColor = false;
            btnDictionary.Click += btnDictionary_Click;
            // 
            // btnAddDictionData
            // 
            btnAddDictionData.BackColor = Color.LightGreen;
            btnAddDictionData.Location = new Point(643, 392);
            btnAddDictionData.Name = "btnAddDictionData";
            btnAddDictionData.Size = new Size(145, 46);
            btnAddDictionData.TabIndex = 7;
            btnAddDictionData.Text = "AddDictionaryData";
            btnAddDictionData.UseVisualStyleBackColor = false;
            btnAddDictionData.Click += btnAddDictionData_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAddDictionData);
            Controls.Add(btnDictionary);
            Controls.Add(label1);
            Controls.Add(btnAddListData);
            Controls.Add(btnAddArrayData);
            Controls.Add(btnList);
            Controls.Add(txtBox);
            Controls.Add(btnArray);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnArray;
        private TextBox txtBox;
        private Button btnList;
        private Button btnAddArrayData;
        private Button btnAddListData;
        private Label label1;
        private Button btnDictionary;
        private Button btnAddDictionData;
    }
}
