namespace APM_PiKPO
{
    partial class OrdersEdit
    {
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.сbStatus = new System.Windows.Forms.ComboBox();
            this.cbService = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.cbClients = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // сbStatus
            // 
            this.сbStatus.BackColor = System.Drawing.Color.White;
            this.сbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.сbStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.сbStatus.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.сbStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.сbStatus.FormattingEnabled = true;
            this.сbStatus.Items.AddRange(new object[] {
            "В очереди",
            "В процессе",
            "Готово"});
            this.сbStatus.Location = new System.Drawing.Point(158, 112);
            this.сbStatus.Name = "сbStatus";
            this.сbStatus.Size = new System.Drawing.Size(207, 29);
            this.сbStatus.TabIndex = 22;
            // 
            // cbService
            // 
            this.cbService.BackColor = System.Drawing.Color.White;
            this.cbService.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbService.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbService.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbService.FormattingEnabled = true;
            this.cbService.Location = new System.Drawing.Point(158, 40);
            this.cbService.Name = "cbService";
            this.cbService.Size = new System.Drawing.Size(207, 29);
            this.cbService.TabIndex = 21;
            this.cbService.SelectedIndexChanged += new System.EventHandler(this.cbService_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.label1.Location = new System.Drawing.Point(91, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 21);
            this.label1.TabIndex = 20;
            this.label1.Text = "Статус";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.label5.Location = new System.Drawing.Point(48, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 21);
            this.label5.TabIndex = 19;
            this.label5.Text = "Дата заказа";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.label2.Location = new System.Drawing.Point(89, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 21);
            this.label2.TabIndex = 18;
            this.label2.Text = "Услуга";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.label4.Location = new System.Drawing.Point(84, 1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 21);
            this.label4.TabIndex = 17;
            this.label4.Text = "Клиент";
            // 
            // datePicker
            // 
            this.datePicker.BackColor = System.Drawing.Color.White;
            this.datePicker.CustomFormat = "yyyy-MM-dd";
            this.datePicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datePicker.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.datePicker.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePicker.Location = new System.Drawing.Point(158, 76);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(207, 29);
            this.datePicker.TabIndex = 9;
            // 
            // cbClients
            // 
            this.cbClients.BackColor = System.Drawing.Color.White;
            this.cbClients.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbClients.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbClients.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbClients.FormattingEnabled = true;
            this.cbClients.Location = new System.Drawing.Point(158, 4);
            this.cbClients.Name = "cbClients";
            this.cbClients.Size = new System.Drawing.Size(207, 29);
            this.cbClients.TabIndex = 13;
            this.cbClients.SelectedIndexChanged += new System.EventHandler(this.cbClients_SelectedIndexChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58F));
            this.tableLayoutPanel1.Controls.Add(this.cbClients, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.datePicker, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.cbService, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.сbStatus, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(369, 299);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // OrdersEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "OrdersEdit";
            this.Size = new System.Drawing.Size(369, 299);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox сbStatus;
        private System.Windows.Forms.ComboBox cbService;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.ComboBox cbClients;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

