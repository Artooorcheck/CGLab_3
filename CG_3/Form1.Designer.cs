
using System.Collections.Generic;
using System.Windows.Forms;

namespace CG_3
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.glControl1 = new OpenTK.GLControl();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Scale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Color = new System.Windows.Forms.DataGridViewImageColumn();
            this._position = new System.Windows.Forms.Label();
            this._scale = new System.Windows.Forms.Label();
            this._scaleX = new System.Windows.Forms.TextBox();
            this._scaleY = new System.Windows.Forms.TextBox();
            this._scaleZ = new System.Windows.Forms.TextBox();
            this._x = new System.Windows.Forms.Label();
            this._y = new System.Windows.Forms.Label();
            this._z = new System.Windows.Forms.Label();
            this._pz = new System.Windows.Forms.Label();
            this._py = new System.Windows.Forms.Label();
            this._px = new System.Windows.Forms.Label();
            this._positionZ = new System.Windows.Forms.TextBox();
            this._positionY = new System.Windows.Forms.TextBox();
            this._positionX = new System.Windows.Forms.TextBox();
            this._colorButton = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this._colorLabel = new System.Windows.Forms.Label();
            this._alphaLabel = new System.Windows.Forms.Label();
            this._alpha = new System.Windows.Forms.TextBox();
            this._addButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // glControl1
            // 
            this.glControl1.BackColor = System.Drawing.Color.Black;
            this.glControl1.Location = new System.Drawing.Point(13, 13);
            this.glControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.glControl1.Name = "glControl1";
            this.glControl1.Size = new System.Drawing.Size(774, 697);
            this.glControl1.TabIndex = 0;
            this.glControl1.VSync = false;
            this.glControl1.Load += new System.EventHandler(this.glControl1_Load);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Position,
            this.Scale,
            this.Color});
            this.dataGridView1.Location = new System.Drawing.Point(805, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(372, 150);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DeleteObject);
            // 
            // Position
            // 
            this.Position.HeaderText = "Position";
            this.Position.MinimumWidth = 6;
            this.Position.Name = "Position";
            this.Position.ReadOnly = true;
            // 
            // Scale
            // 
            this.Scale.HeaderText = "Scale";
            this.Scale.MinimumWidth = 6;
            this.Scale.Name = "Scale";
            this.Scale.ReadOnly = true;
            // 
            // Color
            // 
            this.Color.HeaderText = "Color";
            this.Color.MinimumWidth = 6;
            this.Color.Name = "Color";
            this.Color.ReadOnly = true;
            this.Color.Width = 40;
            // 
            // _position
            // 
            this._position.AutoSize = true;
            this._position.Location = new System.Drawing.Point(805, 201);
            this._position.Name = "_position";
            this._position.Size = new System.Drawing.Size(62, 17);
            this._position.TabIndex = 2;
            this._position.Text = "Position:";
            // 
            // _scale
            // 
            this._scale.AutoSize = true;
            this._scale.Location = new System.Drawing.Point(805, 254);
            this._scale.Name = "_scale";
            this._scale.Size = new System.Drawing.Size(47, 17);
            this._scale.TabIndex = 3;
            this._scale.Text = "Scale:";
            // 
            // _scaleX
            // 
            this._scaleX.Location = new System.Drawing.Point(848, 274);
            this._scaleX.Name = "_scaleX";
            this._scaleX.Size = new System.Drawing.Size(47, 22);
            this._scaleX.TabIndex = 4;
            // 
            // _scaleY
            // 
            this._scaleY.Location = new System.Drawing.Point(944, 274);
            this._scaleY.Name = "_scaleY";
            this._scaleY.Size = new System.Drawing.Size(47, 22);
            this._scaleY.TabIndex = 5;
            // 
            // _scaleZ
            // 
            this._scaleZ.Location = new System.Drawing.Point(1041, 274);
            this._scaleZ.Name = "_scaleZ";
            this._scaleZ.Size = new System.Drawing.Size(47, 22);
            this._scaleZ.TabIndex = 6;
            // 
            // _x
            // 
            this._x.AutoSize = true;
            this._x.Location = new System.Drawing.Point(821, 277);
            this._x.Name = "_x";
            this._x.Size = new System.Drawing.Size(21, 17);
            this._x.TabIndex = 7;
            this._x.Text = "X:";
            // 
            // _y
            // 
            this._y.AutoSize = true;
            this._y.Location = new System.Drawing.Point(917, 279);
            this._y.Name = "_y";
            this._y.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._y.Size = new System.Drawing.Size(21, 17);
            this._y.TabIndex = 8;
            this._y.Text = "Y:";
            // 
            // _z
            // 
            this._z.AutoSize = true;
            this._z.Location = new System.Drawing.Point(1014, 279);
            this._z.Name = "_z";
            this._z.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._z.Size = new System.Drawing.Size(21, 17);
            this._z.TabIndex = 9;
            this._z.Text = "Z:";
            // 
            // _pz
            // 
            this._pz.AutoSize = true;
            this._pz.Location = new System.Drawing.Point(1014, 229);
            this._pz.Name = "_pz";
            this._pz.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._pz.Size = new System.Drawing.Size(21, 17);
            this._pz.TabIndex = 15;
            this._pz.Text = "Z:";
            // 
            // _py
            // 
            this._py.AutoSize = true;
            this._py.Location = new System.Drawing.Point(917, 229);
            this._py.Name = "_py";
            this._py.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._py.Size = new System.Drawing.Size(21, 17);
            this._py.TabIndex = 14;
            this._py.Text = "Y:";
            // 
            // _px
            // 
            this._px.AutoSize = true;
            this._px.Location = new System.Drawing.Point(821, 227);
            this._px.Name = "_px";
            this._px.Size = new System.Drawing.Size(21, 17);
            this._px.TabIndex = 13;
            this._px.Text = "X:";
            // 
            // _positionZ
            // 
            this._positionZ.Location = new System.Drawing.Point(1041, 224);
            this._positionZ.Name = "_positionZ";
            this._positionZ.Size = new System.Drawing.Size(47, 22);
            this._positionZ.TabIndex = 12;
            // 
            // _positionY
            // 
            this._positionY.Location = new System.Drawing.Point(944, 224);
            this._positionY.Name = "_positionY";
            this._positionY.Size = new System.Drawing.Size(47, 22);
            this._positionY.TabIndex = 11;
            // 
            // _positionX
            // 
            this._positionX.Location = new System.Drawing.Point(848, 224);
            this._positionX.Name = "_positionX";
            this._positionX.Size = new System.Drawing.Size(47, 22);
            this._positionX.TabIndex = 10;
            // 
            // _colorButton
            // 
            this._colorButton.BackColor = System.Drawing.Color.White;
            this._colorButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this._colorButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this._colorButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this._colorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._colorButton.ForeColor = System.Drawing.Color.White;
            this._colorButton.Location = new System.Drawing.Point(902, 316);
            this._colorButton.Name = "_colorButton";
            this._colorButton.Size = new System.Drawing.Size(75, 23);
            this._colorButton.TabIndex = 16;
            this._colorButton.UseVisualStyleBackColor = false;
            this._colorButton.Click += new System.EventHandler(this._colorButton_Click);
            // 
            // _colorLabel
            // 
            this._colorLabel.AutoSize = true;
            this._colorLabel.Location = new System.Drawing.Point(836, 319);
            this._colorLabel.Name = "_colorLabel";
            this._colorLabel.Size = new System.Drawing.Size(45, 17);
            this._colorLabel.TabIndex = 17;
            this._colorLabel.Text = "Color:";
            // 
            // _alphaLabel
            // 
            this._alphaLabel.AutoSize = true;
            this._alphaLabel.Location = new System.Drawing.Point(988, 319);
            this._alphaLabel.Name = "_alphaLabel";
            this._alphaLabel.Size = new System.Drawing.Size(20, 17);
            this._alphaLabel.TabIndex = 18;
            this._alphaLabel.Text = "a:";
            // 
            // _alpha
            // 
            this._alpha.Location = new System.Drawing.Point(1017, 314);
            this._alpha.Name = "_alpha";
            this._alpha.Size = new System.Drawing.Size(47, 22);
            this._alpha.TabIndex = 19;
            // 
            // _addButton
            // 
            this._addButton.Location = new System.Drawing.Point(902, 360);
            this._addButton.Name = "_addButton";
            this._addButton.Size = new System.Drawing.Size(172, 23);
            this._addButton.TabIndex = 20;
            this._addButton.Text = "CREATE";
            this._addButton.UseVisualStyleBackColor = true;
            this._addButton.Click += new System.EventHandler(this._addButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 723);
            this.Controls.Add(this._addButton);
            this.Controls.Add(this._alpha);
            this.Controls.Add(this._alphaLabel);
            this.Controls.Add(this._colorLabel);
            this.Controls.Add(this._colorButton);
            this.Controls.Add(this._pz);
            this.Controls.Add(this._py);
            this.Controls.Add(this._px);
            this.Controls.Add(this._positionZ);
            this.Controls.Add(this._positionY);
            this.Controls.Add(this._positionX);
            this.Controls.Add(this._z);
            this.Controls.Add(this._y);
            this.Controls.Add(this._x);
            this.Controls.Add(this._scaleZ);
            this.Controls.Add(this._scaleY);
            this.Controls.Add(this._scaleX);
            this.Controls.Add(this._scale);
            this.Controls.Add(this._position);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.glControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OpenTK.GLControl glControl1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Position;
        private DataGridViewTextBoxColumn Scale;
        private DataGridViewImageColumn Color;
        private Label _position;
        private Label _scale;
        private TextBox _scaleX;
        private TextBox _scaleY;
        private TextBox _scaleZ;
        private Label _x;
        private Label _y;
        private Label _z;
        private Label _pz;
        private Label _py;
        private Label _px;
        private TextBox _positionZ;
        private TextBox _positionY;
        private TextBox _positionX;
        private Button _colorButton;
        private ColorDialog colorDialog1;
        private Label _colorLabel;
        private Label _alphaLabel;
        private TextBox _alpha;
        private Button _addButton;
    }
}

