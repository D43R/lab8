namespace lab8
{
    partial class AddElem
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
            this.CancelBut = new System.Windows.Forms.Button();
            this.OKBut = new System.Windows.Forms.Button();
            this.OnRoute = new System.Windows.Forms.RadioButton();
            this.InPark = new System.Windows.Forms.RadioButton();
            this.DriverNameTextBox = new System.Windows.Forms.TextBox();
            this.BusNumTextBox = new System.Windows.Forms.TextBox();
            this.routeNumTextBox = new System.Windows.Forms.TextBox();
            this.BusState = new System.Windows.Forms.Label();
            this.DriverNameLable = new System.Windows.Forms.Label();
            this.BusNumLable = new System.Windows.Forms.Label();
            this.RouteNumLable = new System.Windows.Forms.Label();
            this.AddRandomElement = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CancelBut
            // 
            this.CancelBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelBut.Location = new System.Drawing.Point(270, 122);
            this.CancelBut.Name = "CancelBut";
            this.CancelBut.Size = new System.Drawing.Size(88, 32);
            this.CancelBut.TabIndex = 21;
            this.CancelBut.Text = "Отмена";
            this.CancelBut.UseVisualStyleBackColor = true;
            this.CancelBut.Click += new System.EventHandler(this.CancelBut_Click_1);
            // 
            // OKBut
            // 
            this.OKBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OKBut.Location = new System.Drawing.Point(14, 122);
            this.OKBut.Name = "OKBut";
            this.OKBut.Size = new System.Drawing.Size(88, 32);
            this.OKBut.TabIndex = 20;
            this.OKBut.Text = "ОК";
            this.OKBut.UseVisualStyleBackColor = true;
            this.OKBut.Click += new System.EventHandler(this.OKBut_Click);
            // 
            // OnRoute
            // 
            this.OnRoute.AutoSize = true;
            this.OnRoute.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OnRoute.Location = new System.Drawing.Point(246, 87);
            this.OnRoute.Name = "OnRoute";
            this.OnRoute.Size = new System.Drawing.Size(112, 20);
            this.OnRoute.TabIndex = 19;
            this.OnRoute.TabStop = true;
            this.OnRoute.Text = "На маршруте";
            this.OnRoute.UseVisualStyleBackColor = true;
            // 
            // InPark
            // 
            this.InPark.AutoSize = true;
            this.InPark.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InPark.Location = new System.Drawing.Point(163, 87);
            this.InPark.Name = "InPark";
            this.InPark.Size = new System.Drawing.Size(77, 20);
            this.InPark.TabIndex = 18;
            this.InPark.TabStop = true;
            this.InPark.Text = "В парке";
            this.InPark.UseVisualStyleBackColor = true;
            // 
            // DriverNameTextBox
            // 
            this.DriverNameTextBox.Location = new System.Drawing.Point(163, 61);
            this.DriverNameTextBox.Name = "DriverNameTextBox";
            this.DriverNameTextBox.Size = new System.Drawing.Size(195, 20);
            this.DriverNameTextBox.TabIndex = 17;
            this.DriverNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DriverNameTextBox_KeyPress);
            // 
            // BusNumTextBox
            // 
            this.BusNumTextBox.Location = new System.Drawing.Point(163, 35);
            this.BusNumTextBox.Name = "BusNumTextBox";
            this.BusNumTextBox.Size = new System.Drawing.Size(195, 20);
            this.BusNumTextBox.TabIndex = 16;
            this.BusNumTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BusNumTextBox_KeyPress);
            // 
            // routeNumTextBox
            // 
            this.routeNumTextBox.Location = new System.Drawing.Point(163, 9);
            this.routeNumTextBox.Name = "routeNumTextBox";
            this.routeNumTextBox.Size = new System.Drawing.Size(195, 20);
            this.routeNumTextBox.TabIndex = 15;
            this.routeNumTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RouteNumTextBox_KeyPress);
            // 
            // BusState
            // 
            this.BusState.AutoSize = true;
            this.BusState.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BusState.Location = new System.Drawing.Point(14, 87);
            this.BusState.Name = "BusState";
            this.BusState.Size = new System.Drawing.Size(143, 16);
            this.BusState.TabIndex = 14;
            this.BusState.Text = "Состояние автобуса";
            // 
            // DriverNameLable
            // 
            this.DriverNameLable.AutoSize = true;
            this.DriverNameLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DriverNameLable.Location = new System.Drawing.Point(53, 61);
            this.DriverNameLable.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.DriverNameLable.Name = "DriverNameLable";
            this.DriverNameLable.Size = new System.Drawing.Size(104, 16);
            this.DriverNameLable.TabIndex = 13;
            this.DriverNameLable.Text = "ФИО водителя";
            // 
            // BusNumLable
            // 
            this.BusNumLable.AutoSize = true;
            this.BusNumLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BusNumLable.Location = new System.Drawing.Point(41, 35);
            this.BusNumLable.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.BusNumLable.Name = "BusNumLable";
            this.BusNumLable.Size = new System.Drawing.Size(116, 16);
            this.BusNumLable.TabIndex = 12;
            this.BusNumLable.Text = "Номер автобуса";
            // 
            // RouteNumLable
            // 
            this.RouteNumLable.AutoSize = true;
            this.RouteNumLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RouteNumLable.Location = new System.Drawing.Point(38, 9);
            this.RouteNumLable.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.RouteNumLable.Name = "RouteNumLable";
            this.RouteNumLable.Size = new System.Drawing.Size(119, 16);
            this.RouteNumLable.TabIndex = 11;
            this.RouteNumLable.Text = "Номер маршрута";
            // 
            // AddRandomElement
            // 
            this.AddRandomElement.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddRandomElement.Location = new System.Drawing.Point(108, 122);
            this.AddRandomElement.Name = "AddRandomElement";
            this.AddRandomElement.Size = new System.Drawing.Size(156, 32);
            this.AddRandomElement.TabIndex = 22;
            this.AddRandomElement.Text = "Случайный элемент";
            this.AddRandomElement.UseVisualStyleBackColor = true;
            this.AddRandomElement.Click += new System.EventHandler(this.Button1_Click);
            // 
            // AddElem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 163);
            this.Controls.Add(this.AddRandomElement);
            this.Controls.Add(this.CancelBut);
            this.Controls.Add(this.OKBut);
            this.Controls.Add(this.OnRoute);
            this.Controls.Add(this.InPark);
            this.Controls.Add(this.DriverNameTextBox);
            this.Controls.Add(this.BusNumTextBox);
            this.Controls.Add(this.routeNumTextBox);
            this.Controls.Add(this.BusState);
            this.Controls.Add(this.DriverNameLable);
            this.Controls.Add(this.BusNumLable);
            this.Controls.Add(this.RouteNumLable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "AddElem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить элемент";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddElem_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelBut;
        private System.Windows.Forms.Button OKBut;
        private System.Windows.Forms.RadioButton OnRoute;
        private System.Windows.Forms.RadioButton InPark;
        public System.Windows.Forms.TextBox DriverNameTextBox;
        public System.Windows.Forms.TextBox BusNumTextBox;
        public System.Windows.Forms.TextBox routeNumTextBox;
        private System.Windows.Forms.Label BusState;
        private System.Windows.Forms.Label DriverNameLable;
        private System.Windows.Forms.Label BusNumLable;
        private System.Windows.Forms.Label RouteNumLable;
        private System.Windows.Forms.Button AddRandomElement;
    }
}