namespace tokenizer
{
    partial class MainForm
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
            if(disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbDefs = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbTokens = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonAction = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lvOutput = new System.Windows.Forms.ListView();
            this.colValue = new System.Windows.Forms.ColumnHeader();
            this.colToken = new System.Windows.Forms.ColumnHeader();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add( this.tbDefs );
            this.groupBox1.Location = new System.Drawing.Point( 13, 13 );
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size( 388, 200 );
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Definitions";
            // 
            // tbDefs
            // 
            this.tbDefs.AcceptsReturn = true;
            this.tbDefs.AcceptsTab = true;
            this.tbDefs.Location = new System.Drawing.Point( 7, 21 );
            this.tbDefs.Multiline = true;
            this.tbDefs.Name = "tbDefs";
            this.tbDefs.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbDefs.Size = new System.Drawing.Size( 375, 173 );
            this.tbDefs.TabIndex = 0;
            this.tbDefs.TabStop = false;
            this.tbDefs.Text = "DIGIT\t[0-9]\r\nLETT\t[a-zA-Z]\r\nDOT\t\\.\r\nDQUOT\t\\\"\r\nSQUOT\t\\\'\r\nSPACE\t[\\t\\s]";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add( this.tbTokens );
            this.groupBox2.Location = new System.Drawing.Point( 13, 220 );
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size( 388, 225 );
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tokens";
            // 
            // tbTokens
            // 
            this.tbTokens.AcceptsReturn = true;
            this.tbTokens.AcceptsTab = true;
            this.tbTokens.Location = new System.Drawing.Point( 7, 21 );
            this.tbTokens.Multiline = true;
            this.tbTokens.Name = "tbTokens";
            this.tbTokens.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbTokens.Size = new System.Drawing.Size( 375, 198 );
            this.tbTokens.TabIndex = 0;
            this.tbTokens.TabStop = false;
            this.tbTokens.Text = "(DIGIT)+\t\t\tVALUE\r\n(LETT)+(DIGIT)*\t\tIDENT\r\n(DQUOT)(LETT)+(DQUOT)\tSTRING\r\n(SQUOT)(L" +
                "ETT)(SQUOT)\tCHAR\r\n(DIGIT)+(DOT)(DIGIT)*\tDOUBLE\r\n(SPACE)+\t\tWHITE";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add( this.lvOutput );
            this.groupBox3.Controls.Add( this.buttonAction );
            this.groupBox3.Controls.Add( this.label2 );
            this.groupBox3.Controls.Add( this.tbInput );
            this.groupBox3.Controls.Add( this.label1 );
            this.groupBox3.Location = new System.Drawing.Point( 408, 13 );
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size( 344, 432 );
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Options";
            // 
            // buttonAction
            // 
            this.buttonAction.Location = new System.Drawing.Point( 213, 403 );
            this.buttonAction.Name = "buttonAction";
            this.buttonAction.Size = new System.Drawing.Size( 125, 23 );
            this.buttonAction.TabIndex = 4;
            this.buttonAction.Text = "&Action";
            this.buttonAction.UseVisualStyleBackColor = true;
            this.buttonAction.Click += new System.EventHandler( this.buttonAction_Click );
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point( 10, 153 );
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size( 45, 13 );
            this.label2.TabIndex = 2;
            this.label2.Text = "Output:";
            // 
            // tbInput
            // 
            this.tbInput.Location = new System.Drawing.Point( 10, 38 );
            this.tbInput.Multiline = true;
            this.tbInput.Name = "tbInput";
            this.tbInput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbInput.Size = new System.Drawing.Size( 328, 92 );
            this.tbInput.TabIndex = 1;
            this.tbInput.Text = "ala ala105 105 105.5 \"napis\" \'x\'";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point( 7, 21 );
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size( 60, 13 );
            this.label1.TabIndex = 0;
            this.label1.Text = "Input text:";
            // 
            // lvOutput
            // 
            this.lvOutput.Columns.AddRange( new System.Windows.Forms.ColumnHeader[] {
            this.colValue,
            this.colToken} );
            this.lvOutput.FullRowSelect = true;
            this.lvOutput.GridLines = true;
            this.lvOutput.Location = new System.Drawing.Point( 13, 170 );
            this.lvOutput.MultiSelect = false;
            this.lvOutput.Name = "lvOutput";
            this.lvOutput.Size = new System.Drawing.Size( 325, 227 );
            this.lvOutput.TabIndex = 5;
            this.lvOutput.UseCompatibleStateImageBehavior = false;
            this.lvOutput.View = System.Windows.Forms.View.Details;
            // 
            // colValue
            // 
            this.colValue.Text = "Value";
            this.colValue.Width = 180;
            // 
            // colToken
            // 
            this.colToken.Text = "Token";
            this.colToken.Width = 140;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size( 764, 457 );
            this.Controls.Add( this.groupBox3 );
            this.Controls.Add( this.groupBox2 );
            this.Controls.Add( this.groupBox1 );
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.groupBox1.ResumeLayout( false );
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout( false );
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout( false );
            this.groupBox3.PerformLayout();
            this.ResumeLayout( false );

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbDefs;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbTokens;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonAction;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvOutput;
        private System.Windows.Forms.ColumnHeader colValue;
        private System.Windows.Forms.ColumnHeader colToken;
    }
}

