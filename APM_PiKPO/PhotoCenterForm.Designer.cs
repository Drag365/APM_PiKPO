namespace APM_PiKPO
{
    partial class PhotoCenterForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAddClient = new System.Windows.Forms.Button();
            this.btnAddService = new System.Windows.Forms.Button();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSaveClient = new System.Windows.Forms.Button();
            this.btnSaveService = new System.Windows.Forms.Button();
            this.btnSaveOrder = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnDelClient = new System.Windows.Forms.Button();
            this.btnDelService = new System.Windows.Forms.Button();
            this.btnDelOrder = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bsUser = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnServices = new System.Windows.Forms.RadioButton();
            this.btnOrders = new System.Windows.Forms.RadioButton();
            this.btnClients = new System.Windows.Forms.RadioButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.clientsEdit1 = new APM_PiKPO.ClientsEdit();
            this.ordersEdit1 = new APM_PiKPO.OrdersEdit();
            this.sevicesEdit1 = new APM_PiKPO.TablesEditors.ServicesEdit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsUser)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel5, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1007, 557);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tableLayoutPanel2.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel3, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel4, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 508);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(372, 46);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnAddClient);
            this.panel2.Controls.Add(this.btnAddService);
            this.panel2.Controls.Add(this.btnAddOrder);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(116, 40);
            this.panel2.TabIndex = 3;
            // 
            // btnAddClient
            // 
            this.btnAddClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddClient.Location = new System.Drawing.Point(0, 0);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(116, 40);
            this.btnAddClient.TabIndex = 0;
            this.btnAddClient.Text = "Добавить клиента";
            this.btnAddClient.UseVisualStyleBackColor = true;
            this.btnAddClient.Click += new System.EventHandler(this.btnAddClient_Click);
            // 
            // btnAddService
            // 
            this.btnAddService.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddService.Location = new System.Drawing.Point(0, 0);
            this.btnAddService.Name = "btnAddService";
            this.btnAddService.Size = new System.Drawing.Size(116, 40);
            this.btnAddService.TabIndex = 1;
            this.btnAddService.Text = "Добавить услугу";
            this.btnAddService.UseVisualStyleBackColor = true;
            this.btnAddService.Click += new System.EventHandler(this.btnAddService_Click);
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddOrder.Location = new System.Drawing.Point(0, 0);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(116, 40);
            this.btnAddOrder.TabIndex = 1;
            this.btnAddOrder.Text = "Добавить заказ";
            this.btnAddOrder.UseVisualStyleBackColor = true;
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnSaveClient);
            this.panel3.Controls.Add(this.btnSaveService);
            this.panel3.Controls.Add(this.btnSaveOrder);
            this.panel3.Location = new System.Drawing.Point(125, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(116, 40);
            this.panel3.TabIndex = 4;
            // 
            // btnSaveClient
            // 
            this.btnSaveClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSaveClient.Location = new System.Drawing.Point(0, 0);
            this.btnSaveClient.Name = "btnSaveClient";
            this.btnSaveClient.Size = new System.Drawing.Size(116, 40);
            this.btnSaveClient.TabIndex = 1;
            this.btnSaveClient.Text = "Сохранить клиента";
            this.btnSaveClient.UseVisualStyleBackColor = true;
            this.btnSaveClient.Click += new System.EventHandler(this.btnSaveClient_Click);
            // 
            // btnSaveService
            // 
            this.btnSaveService.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSaveService.Location = new System.Drawing.Point(0, 0);
            this.btnSaveService.Name = "btnSaveService";
            this.btnSaveService.Size = new System.Drawing.Size(116, 40);
            this.btnSaveService.TabIndex = 3;
            this.btnSaveService.Text = "Сохранить услугу";
            this.btnSaveService.UseVisualStyleBackColor = true;
            this.btnSaveService.Click += new System.EventHandler(this.btnSaveService_Click);
            // 
            // btnSaveOrder
            // 
            this.btnSaveOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSaveOrder.Location = new System.Drawing.Point(0, 0);
            this.btnSaveOrder.Name = "btnSaveOrder";
            this.btnSaveOrder.Size = new System.Drawing.Size(116, 40);
            this.btnSaveOrder.TabIndex = 2;
            this.btnSaveOrder.Text = "Сохранить заказ";
            this.btnSaveOrder.UseVisualStyleBackColor = true;
            this.btnSaveOrder.Click += new System.EventHandler(this.btnSaveOrder_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnDelClient);
            this.panel4.Controls.Add(this.btnDelService);
            this.panel4.Controls.Add(this.btnDelOrder);
            this.panel4.Location = new System.Drawing.Point(247, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(122, 40);
            this.panel4.TabIndex = 5;
            // 
            // btnDelClient
            // 
            this.btnDelClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDelClient.Location = new System.Drawing.Point(0, 0);
            this.btnDelClient.Name = "btnDelClient";
            this.btnDelClient.Size = new System.Drawing.Size(122, 40);
            this.btnDelClient.TabIndex = 2;
            this.btnDelClient.Text = "Удалить клиента";
            this.btnDelClient.UseVisualStyleBackColor = true;
            this.btnDelClient.Click += new System.EventHandler(this.btnDelClient_Click);
            // 
            // btnDelService
            // 
            this.btnDelService.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDelService.Location = new System.Drawing.Point(0, 0);
            this.btnDelService.Name = "btnDelService";
            this.btnDelService.Size = new System.Drawing.Size(122, 40);
            this.btnDelService.TabIndex = 4;
            this.btnDelService.Text = "Удалить услугу";
            this.btnDelService.UseVisualStyleBackColor = true;
            this.btnDelService.Click += new System.EventHandler(this.btnDelService_Click);
            // 
            // btnDelOrder
            // 
            this.btnDelOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDelOrder.Location = new System.Drawing.Point(0, 0);
            this.btnDelOrder.Name = "btnDelOrder";
            this.btnDelOrder.Size = new System.Drawing.Size(122, 40);
            this.btnDelOrder.TabIndex = 3;
            this.btnDelOrder.Text = "Удалить заказ";
            this.btnDelOrder.UseVisualStyleBackColor = true;
            this.btnDelOrder.Click += new System.EventHandler(this.btnDelOrder_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DataSource = this.bsUser;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(381, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(623, 499);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.btnServices);
            this.panel1.Controls.Add(this.btnOrders);
            this.panel1.Controls.Add(this.btnClients);
            this.panel1.Controls.Add(this.clientsEdit1);
            this.panel1.Controls.Add(this.ordersEdit1);
            this.panel1.Controls.Add(this.sevicesEdit1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(372, 499);
            this.panel1.TabIndex = 4;
            // 
            // btnServices
            // 
            this.btnServices.AutoSize = true;
            this.btnServices.Font = new System.Drawing.Font("Microsoft Yi Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServices.Location = new System.Drawing.Point(290, 415);
            this.btnServices.Name = "btnServices";
            this.btnServices.Size = new System.Drawing.Size(71, 23);
            this.btnServices.TabIndex = 9;
            this.btnServices.Text = "Услуги";
            this.btnServices.UseVisualStyleBackColor = true;
            this.btnServices.CheckedChanged += new System.EventHandler(this.btnServices_CheckedChanged);
            // 
            // btnOrders
            // 
            this.btnOrders.AutoSize = true;
            this.btnOrders.Font = new System.Drawing.Font("Microsoft Yi Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrders.Location = new System.Drawing.Point(143, 415);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(76, 23);
            this.btnOrders.TabIndex = 8;
            this.btnOrders.Text = "Заказы";
            this.btnOrders.UseVisualStyleBackColor = true;
            this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click);
            // 
            // btnClients
            // 
            this.btnClients.AutoSize = true;
            this.btnClients.Checked = true;
            this.btnClients.Font = new System.Drawing.Font("Microsoft Yi Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClients.Location = new System.Drawing.Point(9, 415);
            this.btnClients.Name = "btnClients";
            this.btnClients.Size = new System.Drawing.Size(85, 23);
            this.btnClients.TabIndex = 7;
            this.btnClients.TabStop = true;
            this.btnClients.Text = "Клиенты";
            this.btnClients.UseVisualStyleBackColor = true;
            this.btnClients.Click += new System.EventHandler(this.btnClients_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnRefresh);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(381, 508);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(623, 46);
            this.panel5.TabIndex = 5;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRefresh.Location = new System.Drawing.Point(0, 0);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(623, 46);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Обновить таблицу";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // clientsEdit1
            // 
            this.clientsEdit1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.clientsEdit1.Client = null;
            this.clientsEdit1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clientsEdit1.Location = new System.Drawing.Point(0, 0);
            this.clientsEdit1.Name = "clientsEdit1";
            this.clientsEdit1.Size = new System.Drawing.Size(372, 499);
            this.clientsEdit1.TabIndex = 5;
            // 
            // ordersEdit1
            // 
            this.ordersEdit1.Location = new System.Drawing.Point(9, 3);
            this.ordersEdit1.Name = "ordersEdit1";
            this.ordersEdit1.Order = null;
            this.ordersEdit1.Size = new System.Drawing.Size(364, 374);
            this.ordersEdit1.TabIndex = 6;
            this.ordersEdit1.Visible = false;
            // 
            // sevicesEdit1
            // 
            this.sevicesEdit1.Location = new System.Drawing.Point(36, 3);
            this.sevicesEdit1.Name = "sevicesEdit1";
            this.sevicesEdit1.Service = null;
            this.sevicesEdit1.Size = new System.Drawing.Size(337, 374);
            this.sevicesEdit1.TabIndex = 10;
            this.sevicesEdit1.Visible = false;
            // 
            // PhotoCenterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 561);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "PhotoCenterForm";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsUser)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bsUser;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnDelClient;
        private System.Windows.Forms.Button btnSaveClient;
        private System.Windows.Forms.Button btnAddClient;
        private System.Windows.Forms.Panel panel1;
        private ClientsEdit clientsEdit1;
        private OrdersEdit ordersEdit1;
        private System.Windows.Forms.RadioButton btnServices;
        private System.Windows.Forms.RadioButton btnOrders;
        private System.Windows.Forms.RadioButton btnClients;
        private TablesEditors.ServicesEdit sevicesEdit1;
        private System.Windows.Forms.Button btnAddOrder;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAddService;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnSaveOrder;
        private System.Windows.Forms.Button btnSaveService;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnDelService;
        private System.Windows.Forms.Button btnDelOrder;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnRefresh;
    }
}

