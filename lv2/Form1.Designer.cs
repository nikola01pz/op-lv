namespace lv2
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
            this.groupBoxType = new System.Windows.Forms.GroupBox();
            this.radioBtnDrawRectangle = new System.Windows.Forms.RadioButton();
            this.radioBtnDrawLine = new System.Windows.Forms.RadioButton();
            this.groupBoxGraphicalObjects = new System.Windows.Forms.GroupBox();
            this.radioBtnDrawEllipse = new System.Windows.Forms.RadioButton();
            this.radioBtnDrawCircle = new System.Windows.Forms.RadioButton();
            this.radioBtnDrawPolygon = new System.Windows.Forms.RadioButton();
            this.radioBtnBlackColor = new System.Windows.Forms.RadioButton();
            this.radioBtnRedColor = new System.Windows.Forms.RadioButton();
            this.radioBtnBlueColor = new System.Windows.Forms.RadioButton();
            this.groupBoxType.SuspendLayout();
            this.groupBoxGraphicalObjects.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxType
            // 
            this.groupBoxType.Controls.Add(this.radioBtnBlueColor);
            this.groupBoxType.Controls.Add(this.radioBtnRedColor);
            this.groupBoxType.Controls.Add(this.radioBtnBlackColor);
            this.groupBoxType.Location = new System.Drawing.Point(656, 161);
            this.groupBoxType.Name = "groupBoxType";
            this.groupBoxType.Size = new System.Drawing.Size(128, 99);
            this.groupBoxType.TabIndex = 0;
            this.groupBoxType.TabStop = false;
            this.groupBoxType.Text = "Color";
            this.groupBoxType.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // radioBtnDrawRectangle
            // 
            this.radioBtnDrawRectangle.AutoSize = true;
            this.radioBtnDrawRectangle.Location = new System.Drawing.Point(19, 88);
            this.radioBtnDrawRectangle.Name = "radioBtnDrawRectangle";
            this.radioBtnDrawRectangle.Size = new System.Drawing.Size(74, 17);
            this.radioBtnDrawRectangle.TabIndex = 2;
            this.radioBtnDrawRectangle.TabStop = true;
            this.radioBtnDrawRectangle.Text = "Rectangle";
            this.radioBtnDrawRectangle.UseVisualStyleBackColor = true;
            // 
            // radioBtnDrawLine
            // 
            this.radioBtnDrawLine.AutoSize = true;
            this.radioBtnDrawLine.Location = new System.Drawing.Point(19, 65);
            this.radioBtnDrawLine.Name = "radioBtnDrawLine";
            this.radioBtnDrawLine.Size = new System.Drawing.Size(45, 17);
            this.radioBtnDrawLine.TabIndex = 1;
            this.radioBtnDrawLine.TabStop = true;
            this.radioBtnDrawLine.Text = "Line";
            this.radioBtnDrawLine.UseVisualStyleBackColor = true;
            // 
            // groupBoxGraphicalObjects
            // 
            this.groupBoxGraphicalObjects.Controls.Add(this.radioBtnDrawPolygon);
            this.groupBoxGraphicalObjects.Controls.Add(this.radioBtnDrawRectangle);
            this.groupBoxGraphicalObjects.Controls.Add(this.radioBtnDrawCircle);
            this.groupBoxGraphicalObjects.Controls.Add(this.radioBtnDrawLine);
            this.groupBoxGraphicalObjects.Controls.Add(this.radioBtnDrawEllipse);
            this.groupBoxGraphicalObjects.Location = new System.Drawing.Point(656, 12);
            this.groupBoxGraphicalObjects.Name = "groupBoxGraphicalObjects";
            this.groupBoxGraphicalObjects.Size = new System.Drawing.Size(128, 143);
            this.groupBoxGraphicalObjects.TabIndex = 1;
            this.groupBoxGraphicalObjects.TabStop = false;
            this.groupBoxGraphicalObjects.Text = "Graphical objects";
            this.groupBoxGraphicalObjects.Enter += new System.EventHandler(this.groupBox1_Enter_1);
            // 
            // radioBtnDrawEllipse
            // 
            this.radioBtnDrawEllipse.AutoSize = true;
            this.radioBtnDrawEllipse.Location = new System.Drawing.Point(19, 19);
            this.radioBtnDrawEllipse.Name = "radioBtnDrawEllipse";
            this.radioBtnDrawEllipse.Size = new System.Drawing.Size(55, 17);
            this.radioBtnDrawEllipse.TabIndex = 0;
            this.radioBtnDrawEllipse.TabStop = true;
            this.radioBtnDrawEllipse.Text = "Ellipse";
            this.radioBtnDrawEllipse.UseVisualStyleBackColor = true;
            this.radioBtnDrawEllipse.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioBtnDrawCircle
            // 
            this.radioBtnDrawCircle.AutoSize = true;
            this.radioBtnDrawCircle.Location = new System.Drawing.Point(19, 42);
            this.radioBtnDrawCircle.Name = "radioBtnDrawCircle";
            this.radioBtnDrawCircle.Size = new System.Drawing.Size(51, 17);
            this.radioBtnDrawCircle.TabIndex = 1;
            this.radioBtnDrawCircle.TabStop = true;
            this.radioBtnDrawCircle.Text = "Circle";
            this.radioBtnDrawCircle.UseVisualStyleBackColor = true;
            this.radioBtnDrawCircle.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged_1);
            // 
            // radioBtnDrawPolygon
            // 
            this.radioBtnDrawPolygon.AutoSize = true;
            this.radioBtnDrawPolygon.Location = new System.Drawing.Point(19, 111);
            this.radioBtnDrawPolygon.Name = "radioBtnDrawPolygon";
            this.radioBtnDrawPolygon.Size = new System.Drawing.Size(63, 17);
            this.radioBtnDrawPolygon.TabIndex = 3;
            this.radioBtnDrawPolygon.TabStop = true;
            this.radioBtnDrawPolygon.Text = "Polygon";
            this.radioBtnDrawPolygon.UseVisualStyleBackColor = true;
            // 
            // radioBtnBlackColor
            // 
            this.radioBtnBlackColor.AutoSize = true;
            this.radioBtnBlackColor.Location = new System.Drawing.Point(19, 20);
            this.radioBtnBlackColor.Name = "radioBtnBlackColor";
            this.radioBtnBlackColor.Size = new System.Drawing.Size(52, 17);
            this.radioBtnBlackColor.TabIndex = 0;
            this.radioBtnBlackColor.TabStop = true;
            this.radioBtnBlackColor.Text = "Black";
            this.radioBtnBlackColor.UseVisualStyleBackColor = true;
            this.radioBtnBlackColor.CheckedChanged += new System.EventHandler(this.radioBtnBlackColor_CheckedChanged);
            // 
            // radioBtnRedColor
            // 
            this.radioBtnRedColor.AutoSize = true;
            this.radioBtnRedColor.Location = new System.Drawing.Point(19, 43);
            this.radioBtnRedColor.Name = "radioBtnRedColor";
            this.radioBtnRedColor.Size = new System.Drawing.Size(45, 17);
            this.radioBtnRedColor.TabIndex = 1;
            this.radioBtnRedColor.TabStop = true;
            this.radioBtnRedColor.Text = "Red";
            this.radioBtnRedColor.UseVisualStyleBackColor = true;
            this.radioBtnRedColor.CheckedChanged += new System.EventHandler(this.radioBtnRedColor_CheckedChanged);
            // 
            // radioBtnBlueColor
            // 
            this.radioBtnBlueColor.AutoSize = true;
            this.radioBtnBlueColor.Location = new System.Drawing.Point(19, 67);
            this.radioBtnBlueColor.Name = "radioBtnBlueColor";
            this.radioBtnBlueColor.Size = new System.Drawing.Size(46, 17);
            this.radioBtnBlueColor.TabIndex = 2;
            this.radioBtnBlueColor.TabStop = true;
            this.radioBtnBlueColor.Text = "Blue";
            this.radioBtnBlueColor.UseVisualStyleBackColor = true;
            this.radioBtnBlueColor.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxGraphicalObjects);
            this.Controls.Add(this.groupBoxType);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.groupBoxType.ResumeLayout(false);
            this.groupBoxType.PerformLayout();
            this.groupBoxGraphicalObjects.ResumeLayout(false);
            this.groupBoxGraphicalObjects.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxType;
        private System.Windows.Forms.RadioButton radioBtnDrawRectangle;
        private System.Windows.Forms.RadioButton radioBtnDrawLine;
        private System.Windows.Forms.GroupBox groupBoxGraphicalObjects;
        private System.Windows.Forms.RadioButton radioBtnDrawEllipse;
        private System.Windows.Forms.RadioButton radioBtnDrawCircle;
        private System.Windows.Forms.RadioButton radioBtnBlueColor;
        private System.Windows.Forms.RadioButton radioBtnRedColor;
        private System.Windows.Forms.RadioButton radioBtnBlackColor;
        private System.Windows.Forms.RadioButton radioBtnDrawPolygon;
    }
}

