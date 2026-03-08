namespace WinFormsApp1
{
    partial class frmOptimizer
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
            lblTitle = new Label();
            lblQuery = new Label();
            txtQuery = new RichTextBox();
            btnAnalysis = new Button();
            lblExecution = new Label();
            gridPlan = new DataGridView();
            lblSuggestions = new Label();
            listSuggestions = new ListBox();
            ((System.ComponentModel.ISupportInitialize)gridPlan).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.BackColor = Color.RoyalBlue;
            lblTitle.Dock = DockStyle.Top;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(886, 50);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "SQL Query Analyzer";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblQuery
            // 
            lblQuery.AutoSize = true;
            lblQuery.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQuery.Location = new Point(40, 80);
            lblQuery.Name = "lblQuery";
            lblQuery.Size = new Size(105, 17);
            lblQuery.TabIndex = 1;
            lblQuery.Text = "Enter Sql Query";
            // 
            // txtQuery
            // 
            txtQuery.BorderStyle = BorderStyle.FixedSingle;
            txtQuery.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtQuery.Location = new Point(40, 110);
            txtQuery.Name = "txtQuery";
            txtQuery.Size = new Size(800, 120);
            txtQuery.TabIndex = 2;
            txtQuery.Text = "";
            txtQuery.TextChanged += txtQuery_TextChanged;
            // 
            // btnAnalysis
            // 
            btnAnalysis.BackColor = Color.Gainsboro;
            btnAnalysis.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAnalysis.Location = new Point(378, 255);
            btnAnalysis.Name = "btnAnalysis";
            btnAnalysis.Size = new Size(118, 33);
            btnAnalysis.TabIndex = 3;
            btnAnalysis.Text = "Analyze Query              ";
            btnAnalysis.UseVisualStyleBackColor = false;
            btnAnalysis.Click += btnAnalysis_Click;
            // 
            // lblExecution
            // 
            lblExecution.AutoSize = true;
            lblExecution.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblExecution.Location = new Point(40, 302);
            lblExecution.Name = "lblExecution";
            lblExecution.Size = new Size(99, 17);
            lblExecution.TabIndex = 4;
            lblExecution.Text = "Execution Plan";
            // 
            // gridPlan
            // 
            gridPlan.AllowUserToAddRows = false;
            gridPlan.AllowUserToDeleteRows = false;
            gridPlan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridPlan.BackgroundColor = SystemColors.Control;
            gridPlan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridPlan.GridColor = SystemColors.Menu;
            gridPlan.Location = new Point(40, 332);
            gridPlan.Name = "gridPlan";
            gridPlan.ReadOnly = true;
            gridPlan.Size = new Size(800, 150);
            gridPlan.TabIndex = 5;
            // 
            // lblSuggestions
            // 
            lblSuggestions.AutoSize = true;
            lblSuggestions.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSuggestions.Location = new Point(40, 510);
            lblSuggestions.Name = "lblSuggestions";
            lblSuggestions.Size = new Size(168, 17);
            lblSuggestions.TabIndex = 6;
            lblSuggestions.Text = "Optimization Suggestions";
            // 
            // listSuggestions
            // 
            listSuggestions.FormattingEnabled = true;
            listSuggestions.Location = new Point(40, 541);
            listSuggestions.Name = "listSuggestions";
            listSuggestions.Size = new Size(800, 79);
            listSuggestions.TabIndex = 7;
            // 
            // frmOptimizer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(886, 651);
            Controls.Add(listSuggestions);
            Controls.Add(lblSuggestions);
            Controls.Add(gridPlan);
            Controls.Add(lblExecution);
            Controls.Add(btnAnalysis);
            Controls.Add(txtQuery);
            Controls.Add(lblQuery);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmOptimizer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SQL Query Analyzer";
            Load += frmOptimizer_Load;
            ((System.ComponentModel.ISupportInitialize)gridPlan).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblQuery;
        public RichTextBox txtQuery;
        private Button btnAnalysis;
        private Label lblExecution;
        private DataGridView gridPlan;
        private Label lblSuggestions;
        private ListBox listSuggestions;
    }
}
