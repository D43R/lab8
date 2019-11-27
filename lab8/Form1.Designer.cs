namespace lab8
{
    partial class MainForm
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
            this.OpenDBbutton = new System.Windows.Forms.Button();
            this.AddItemButton = new System.Windows.Forms.Button();
            this.SearchOrDeleteTextBox = new System.Windows.Forms.TextBox();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.SaveDBButton = new System.Windows.Forms.Button();
            this.EditElem = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.DBOutput = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.countOnRouteLabel = new System.Windows.Forms.Label();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DBOutput)).BeginInit();
            this.SuspendLayout();
            // 
            // OpenDBbutton
            // 
            this.OpenDBbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OpenDBbutton.Location = new System.Drawing.Point(551, 12);
            this.OpenDBbutton.Name = "OpenDBbutton";
            this.OpenDBbutton.Size = new System.Drawing.Size(237, 44);
            this.OpenDBbutton.TabIndex = 0;
            this.OpenDBbutton.Text = "Открыть базу данных";
            this.OpenDBbutton.UseVisualStyleBackColor = true;
            this.OpenDBbutton.Click += new System.EventHandler(this.OpenDBbutton_Click);
            // 
            // AddItemButton
            // 
            this.AddItemButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddItemButton.Location = new System.Drawing.Point(551, 62);
            this.AddItemButton.Name = "AddItemButton";
            this.AddItemButton.Size = new System.Drawing.Size(237, 44);
            this.AddItemButton.TabIndex = 1;
            this.AddItemButton.Text = "Добавить элемент";
            this.AddItemButton.UseVisualStyleBackColor = true;
            this.AddItemButton.Click += new System.EventHandler(this.AddItemButton_Click);
            // 
            // SearchOrDeleteTextBox
            // 
            this.SearchOrDeleteTextBox.Location = new System.Drawing.Point(551, 197);
            this.SearchOrDeleteTextBox.Name = "SearchOrDeleteTextBox";
            this.SearchOrDeleteTextBox.Size = new System.Drawing.Size(181, 20);
            this.SearchOrDeleteTextBox.TabIndex = 4;
            this.SearchOrDeleteTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SearchOrDeleteTextBox_KeyPress);
            // 
            // SearchLabel
            // 
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchLabel.Location = new System.Drawing.Point(548, 162);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(164, 32);
            this.SearchLabel.TabIndex = 5;
            this.SearchLabel.Text = "Поиск или удаление по \r\nномеру автобуса";
            // 
            // SaveDBButton
            // 
            this.SaveDBButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveDBButton.Location = new System.Drawing.Point(551, 272);
            this.SaveDBButton.Name = "SaveDBButton";
            this.SaveDBButton.Size = new System.Drawing.Size(237, 44);
            this.SaveDBButton.TabIndex = 6;
            this.SaveDBButton.Text = "Сохранить базу данных";
            this.SaveDBButton.UseVisualStyleBackColor = true;
            this.SaveDBButton.Click += new System.EventHandler(this.SaveDBButton_Click);
            // 
            // EditElem
            // 
            this.EditElem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditElem.Location = new System.Drawing.Point(551, 112);
            this.EditElem.Name = "EditElem";
            this.EditElem.Size = new System.Drawing.Size(237, 44);
            this.EditElem.TabIndex = 13;
            this.EditElem.Text = "Редактировать элемент";
            this.EditElem.UseVisualStyleBackColor = true;
            this.EditElem.Click += new System.EventHandler(this.EditElem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // DBOutput
            // 
            this.DBOutput.AllowUserToAddRows = false;
            this.DBOutput.AllowUserToDeleteRows = false;
            this.DBOutput.AllowUserToResizeColumns = false;
            this.DBOutput.AllowUserToResizeRows = false;
            this.DBOutput.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DBOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DBOutput.Location = new System.Drawing.Point(10, 12);
            this.DBOutput.MultiSelect = false;
            this.DBOutput.Name = "DBOutput";
            this.DBOutput.ReadOnly = true;
            this.DBOutput.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DBOutput.Size = new System.Drawing.Size(532, 426);
            this.DBOutput.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(548, 330);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Кол-во автобусов на маршруте:";
            // 
            // countOnRouteLabel
            // 
            this.countOnRouteLabel.AutoSize = true;
            this.countOnRouteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countOnRouteLabel.Location = new System.Drawing.Point(760, 330);
            this.countOnRouteLabel.Name = "countOnRouteLabel";
            this.countOnRouteLabel.Size = new System.Drawing.Size(15, 16);
            this.countOnRouteLabel.TabIndex = 16;
            this.countOnRouteLabel.Text = "0";
            // 
            // DeleteButton
            // 
            this.DeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteButton.Image = global::lab8.Properties.Resources.icons8_удалить_35;
            this.DeleteButton.Location = new System.Drawing.Point(607, 223);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(50, 43);
            this.DeleteButton.TabIndex = 12;
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchButton.Image = global::lab8.Properties.Resources.icons8_поиск_40;
            this.SearchButton.Location = new System.Drawing.Point(551, 223);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(50, 43);
            this.SearchButton.TabIndex = 3;
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.countOnRouteLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DBOutput);
            this.Controls.Add(this.EditElem);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.SaveDBButton);
            this.Controls.Add(this.SearchLabel);
            this.Controls.Add(this.SearchOrDeleteTextBox);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.AddItemButton);
            this.Controls.Add(this.OpenDBbutton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "База данных";
            ((System.ComponentModel.ISupportInitialize)(this.DBOutput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OpenDBbutton;
        private System.Windows.Forms.Button AddItemButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox SearchOrDeleteTextBox;
        private System.Windows.Forms.Label SearchLabel;
        private System.Windows.Forms.Button SaveDBButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button EditElem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.DataGridView DBOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label countOnRouteLabel;
    }
}

