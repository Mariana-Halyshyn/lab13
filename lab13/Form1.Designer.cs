namespace lab13
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        // Очищення ресурсів
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.listBoxNonGeneric = new System.Windows.Forms.ListBox();
            this.listBoxGeneric = new System.Windows.Forms.ListBox();
            this.btnShowElement = new System.Windows.Forms.Button();
            this.txtIndex = new System.Windows.Forms.TextBox();
            this.btnShowSorted = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(25, 25);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(150, 23);
            this.txtInput.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(190, 25);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(120, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Додати число";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // listBoxNonGeneric
            // 
            this.listBoxNonGeneric.FormattingEnabled = true;
            this.listBoxNonGeneric.ItemHeight = 15;
            this.listBoxNonGeneric.Location = new System.Drawing.Point(25, 70);
            this.listBoxNonGeneric.Name = "listBoxNonGeneric";
            this.listBoxNonGeneric.Size = new System.Drawing.Size(140, 200);
            this.listBoxNonGeneric.TabIndex = 2;
            // 
            // listBoxGeneric
            // 
            this.listBoxGeneric.FormattingEnabled = true;
            this.listBoxGeneric.ItemHeight = 15;
            this.listBoxGeneric.Location = new System.Drawing.Point(190, 70);
            this.listBoxGeneric.Name = "listBoxGeneric";
            this.listBoxGeneric.Size = new System.Drawing.Size(140, 200);
            this.listBoxGeneric.TabIndex = 3;
            // 
            // btnShowElement
            // 
            this.btnShowElement.Location = new System.Drawing.Point(350, 70);
            this.btnShowElement.Name = "btnShowElement";
            this.btnShowElement.Size = new System.Drawing.Size(150, 23);
            this.btnShowElement.TabIndex = 4;
            this.btnShowElement.Text = "Показати елемент";
            this.btnShowElement.UseVisualStyleBackColor = true;
            this.btnShowElement.Click += new System.EventHandler(this.btnShowElement_Click);
            // 
            // txtIndex
            // 
            this.txtIndex.Location = new System.Drawing.Point(350, 100);
            this.txtIndex.Name = "txtIndex";
            this.txtIndex.Size = new System.Drawing.Size(150, 23);
            this.txtIndex.TabIndex = 5;
            // 
            // btnShowSorted
            // 
            this.btnShowSorted.Location = new System.Drawing.Point(350, 140);
            this.btnShowSorted.Name = "btnShowSorted";
            this.btnShowSorted.Size = new System.Drawing.Size(150, 23);
            this.btnShowSorted.TabIndex = 6;
            this.btnShowSorted.Text = "Сортувати масив";
            this.btnShowSorted.UseVisualStyleBackColor = true;
            this.btnShowSorted.Click += new System.EventHandler(this.btnShowSorted_Click);
            // 
            // lblResult
            // 
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResult.Location = new System.Drawing.Point(25, 290);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(475, 50);
            this.lblResult.TabIndex = 7;
            this.lblResult.Text = "Результат:";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(534, 361);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnShowSorted);
            this.Controls.Add(this.txtIndex);
            this.Controls.Add(this.btnShowElement);
            this.Controls.Add(this.listBoxGeneric);
            this.Controls.Add(this.listBoxNonGeneric);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtInput);
            this.Name = "Form1";
            this.Text = "Lab13 - Комплексні числа";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox listBoxNonGeneric;
        private System.Windows.Forms.ListBox listBoxGeneric;
        private System.Windows.Forms.Button btnShowElement;
        private System.Windows.Forms.TextBox txtIndex;
        private System.Windows.Forms.Button btnShowSorted;
        private System.Windows.Forms.Label lblResult;
    }
}
