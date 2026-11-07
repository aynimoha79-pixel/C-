namespace Lucky_Cafe_Order
{
    partial class Form2
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
            lblResult = new Label();
            btnClear = new Button();
            chkStudent = new CheckBox();
            txtQuantity = new TextBox();
            lblQuantity = new Label();
            grp2 = new GroupBox();
            rdoJuice = new RadioButton();
            rdoCoffee = new RadioButton();
            rdoTea = new RadioButton();
            btnLoad = new Button();
            btnSave = new Button();
            btnCalculate = new Button();
            lstOrder = new ListBox();
            label5 = new Label();
            txtCustomerName = new TextBox();
            lblCustomerName = new Label();
            lblTotalPrice = new Label();
            lblTitle = new Label();
            lblCustomerInformation = new Label();
            grp1 = new GroupBox();
            grp3 = new GroupBox();
            grp2.SuspendLayout();
            grp1.SuspendLayout();
            grp3.SuspendLayout();
            SuspendLayout();
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.BackColor = Color.Olive;
            lblResult.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblResult.Location = new Point(18, 66);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(159, 30);
            lblResult.TabIndex = 19;
            lblResult.Text = "Lucky Message";
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Gray;
            btnClear.Location = new Point(779, 469);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(140, 59);
            btnClear.TabIndex = 17;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // chkStudent
            // 
            chkStudent.AutoSize = true;
            chkStudent.Location = new Point(284, 358);
            chkStudent.Name = "chkStudent";
            chkStudent.Size = new Size(247, 29);
            chkStudent.TabIndex = 6;
            chkStudent.Text = "Student member(10% Off)";
            chkStudent.UseVisualStyleBackColor = true;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(142, 356);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(88, 31);
            txtQuantity.TabIndex = 5;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblQuantity.Location = new Point(28, 345);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(100, 30);
            lblQuantity.TabIndex = 4;
            lblQuantity.Text = "Quantity:";
            // 
            // grp2
            // 
            grp2.Controls.Add(rdoJuice);
            grp2.Controls.Add(rdoCoffee);
            grp2.Controls.Add(rdoTea);
            grp2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grp2.ForeColor = Color.FromArgb(128, 128, 255);
            grp2.Location = new Point(37, 165);
            grp2.Name = "grp2";
            grp2.Size = new Size(316, 158);
            grp2.TabIndex = 3;
            grp2.TabStop = false;
            grp2.Text = "Drink Type";
            // 
            // rdoJuice
            // 
            rdoJuice.AutoSize = true;
            rdoJuice.ForeColor = Color.Black;
            rdoJuice.Location = new Point(16, 116);
            rdoJuice.Name = "rdoJuice";
            rdoJuice.Size = new Size(123, 34);
            rdoJuice.TabIndex = 2;
            rdoJuice.TabStop = true;
            rdoJuice.Text = "Juice($3)";
            rdoJuice.UseVisualStyleBackColor = true;
            // 
            // rdoCoffee
            // 
            rdoCoffee.AutoSize = true;
            rdoCoffee.ForeColor = Color.Black;
            rdoCoffee.Location = new Point(16, 76);
            rdoCoffee.Name = "rdoCoffee";
            rdoCoffee.Size = new Size(141, 34);
            rdoCoffee.TabIndex = 1;
            rdoCoffee.TabStop = true;
            rdoCoffee.Text = "Coffee($2)";
            rdoCoffee.UseVisualStyleBackColor = true;
            // 
            // rdoTea
            // 
            rdoTea.AutoSize = true;
            rdoTea.ForeColor = Color.Black;
            rdoTea.Location = new Point(16, 36);
            rdoTea.Name = "rdoTea";
            rdoTea.Size = new Size(109, 34);
            rdoTea.TabIndex = 0;
            rdoTea.TabStop = true;
            rdoTea.Text = "Tea($1)";
            rdoTea.UseVisualStyleBackColor = true;
            // 
            // btnLoad
            // 
            btnLoad.BackColor = Color.Olive;
            btnLoad.Location = new Point(533, 469);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(174, 59);
            btnLoad.TabIndex = 16;
            btnLoad.Text = "Load from file";
            btnLoad.UseVisualStyleBackColor = false;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Teal;
            btnSave.Location = new Point(301, 469);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(185, 49);
            btnSave.TabIndex = 15;
            btnSave.Text = "Save to file";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCalculate
            // 
            btnCalculate.BackColor = Color.FromArgb(128, 64, 64);
            btnCalculate.Location = new Point(51, 469);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(185, 49);
            btnCalculate.TabIndex = 14;
            btnCalculate.Text = "Calculate Order";
            btnCalculate.UseVisualStyleBackColor = false;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // lstOrder
            // 
            lstOrder.FormattingEnabled = true;
            lstOrder.Location = new Point(651, 82);
            lstOrder.Name = "lstOrder";
            lstOrder.Size = new Size(341, 279);
            lstOrder.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(736, 36);
            label5.Name = "label5";
            label5.Size = new Size(117, 32);
            label5.TabIndex = 12;
            label5.Text = "Order List";
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(37, 128);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(366, 31);
            txtCustomerName.TabIndex = 2;
            // 
            // lblCustomerName
            // 
            lblCustomerName.AutoSize = true;
            lblCustomerName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCustomerName.Location = new Point(28, 86);
            lblCustomerName.Name = "lblCustomerName";
            lblCustomerName.Size = new Size(193, 32);
            lblCustomerName.TabIndex = 1;
            lblCustomerName.Text = "Customer Name:";
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.AutoSize = true;
            lblTotalPrice.BackColor = Color.FromArgb(192, 192, 255);
            lblTotalPrice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalPrice.Location = new Point(18, 14);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.Size = new Size(178, 32);
            lblTotalPrice.TabIndex = 18;
            lblTotalPrice.Text = "TotalPrice:$0.00";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(271, 5);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(276, 45);
            lblTitle.TabIndex = 10;
            lblTitle.Text = "Lucky Cafe Orders";
            // 
            // lblCustomerInformation
            // 
            lblCustomerInformation.AutoSize = true;
            lblCustomerInformation.BackColor = Color.FromArgb(128, 128, 255);
            lblCustomerInformation.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCustomerInformation.Location = new Point(28, 27);
            lblCustomerInformation.Name = "lblCustomerInformation";
            lblCustomerInformation.Size = new Size(288, 38);
            lblCustomerInformation.TabIndex = 0;
            lblCustomerInformation.Text = "Customer Information";
            // 
            // grp1
            // 
            grp1.Controls.Add(chkStudent);
            grp1.Controls.Add(txtQuantity);
            grp1.Controls.Add(lblQuantity);
            grp1.Controls.Add(grp2);
            grp1.Controls.Add(txtCustomerName);
            grp1.Controls.Add(lblCustomerName);
            grp1.Controls.Add(lblCustomerInformation);
            grp1.Location = new Point(34, 53);
            grp1.Name = "grp1";
            grp1.Size = new Size(529, 397);
            grp1.TabIndex = 11;
            grp1.TabStop = false;
            // 
            // grp3
            // 
            grp3.Controls.Add(lblResult);
            grp3.Controls.Add(lblTotalPrice);
            grp3.Location = new Point(59, 523);
            grp3.Name = "grp3";
            grp3.Size = new Size(347, 105);
            grp3.TabIndex = 20;
            grp3.TabStop = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1026, 628);
            Controls.Add(grp3);
            Controls.Add(btnClear);
            Controls.Add(btnLoad);
            Controls.Add(btnSave);
            Controls.Add(btnCalculate);
            Controls.Add(lstOrder);
            Controls.Add(label5);
            Controls.Add(lblTitle);
            Controls.Add(grp1);
            Name = "Form2";
            Text = "Form2";
            grp2.ResumeLayout(false);
            grp2.PerformLayout();
            grp1.ResumeLayout(false);
            grp1.PerformLayout();
            grp3.ResumeLayout(false);
            grp3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblResult;
        private Button btnClear;
        private CheckBox chkStudent;
        private TextBox txtQuantity;
        private Label lblQuantity;
        private GroupBox grp2;
        private RadioButton rdoJuice;
        private RadioButton rdoCoffee;
        private RadioButton rdoTea;
        private Button btnLoad;
        private Button btnSave;
        private Button btnCalculate;
        private ListBox lstOrder;
        private Label label5;
        private TextBox txtCustomerName;
        private Label lblCustomerName;
        private Label lblTotalPrice;
        private Label lblTitle;
        private Label lblCustomerInformation;
        private GroupBox grp1;
        private GroupBox grp3;
    }
}