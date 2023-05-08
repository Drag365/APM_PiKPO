using APM_PiKPO.DAL;
using APM_PiKPO.Properties;
using System.Drawing;
using System.Windows.Forms;

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
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.btnSortByStatus = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btnSortByDate = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnSortByClients = new System.Windows.Forms.Button();
            this.btnClientsSortByName = new System.Windows.Forms.Button();
            this.panel11 = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.btnClients = new System.Windows.Forms.RadioButton();
            this.btnServices = new System.Windows.Forms.RadioButton();
            this.btnOrders = new System.Windows.Forms.RadioButton();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cbClientFilter = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnShowAll = new System.Windows.Forms.Button();
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
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel11.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel5, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel5, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1280, 557);
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
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 302);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(366, 46);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnAddClient);
            this.panel2.Controls.Add(this.btnAddService);
            this.panel2.Controls.Add(this.btnAddOrder);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(114, 40);
            this.panel2.TabIndex = 3;
            // 
            // btnAddClient
            // 
            this.btnAddClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnAddClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddClient.FlatAppearance.BorderSize = 0;
            this.btnAddClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddClient.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddClient.ForeColor = System.Drawing.Color.White;
            this.btnAddClient.Location = new System.Drawing.Point(0, 0);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(114, 40);
            this.btnAddClient.TabIndex = 4;
            this.btnAddClient.Text = "Добавить клиента";
            this.btnAddClient.UseVisualStyleBackColor = false;
            this.btnAddClient.Click += new System.EventHandler(this.btnAddClient_Click);
            // 
            // btnAddService
            // 
            this.btnAddService.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnAddService.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddService.FlatAppearance.BorderSize = 0;
            this.btnAddService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddService.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddService.ForeColor = System.Drawing.Color.White;
            this.btnAddService.Location = new System.Drawing.Point(0, 0);
            this.btnAddService.Name = "btnAddService";
            this.btnAddService.Size = new System.Drawing.Size(114, 40);
            this.btnAddService.TabIndex = 13;
            this.btnAddService.Text = "Добавить услугу";
            this.btnAddService.UseVisualStyleBackColor = false;
            this.btnAddService.Click += new System.EventHandler(this.btnAddService_Click);
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnAddOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddOrder.FlatAppearance.BorderSize = 0;
            this.btnAddOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddOrder.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddOrder.ForeColor = System.Drawing.Color.White;
            this.btnAddOrder.Location = new System.Drawing.Point(0, 0);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(114, 40);
            this.btnAddOrder.TabIndex = 14;
            this.btnAddOrder.Text = "Добавить заказ";
            this.btnAddOrder.UseVisualStyleBackColor = false;
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnSaveClient);
            this.panel3.Controls.Add(this.btnSaveService);
            this.panel3.Controls.Add(this.btnSaveOrder);
            this.panel3.Location = new System.Drawing.Point(123, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(114, 40);
            this.panel3.TabIndex = 4;
            // 
            // btnSaveClient
            // 
            this.btnSaveClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnSaveClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSaveClient.FlatAppearance.BorderSize = 0;
            this.btnSaveClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveClient.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSaveClient.ForeColor = System.Drawing.Color.White;
            this.btnSaveClient.Location = new System.Drawing.Point(0, 0);
            this.btnSaveClient.Name = "btnSaveClient";
            this.btnSaveClient.Size = new System.Drawing.Size(114, 40);
            this.btnSaveClient.TabIndex = 5;
            this.btnSaveClient.Text = "Сохранить клиента";
            this.btnSaveClient.UseVisualStyleBackColor = false;
            this.btnSaveClient.Click += new System.EventHandler(this.btnSaveClient_Click);
            // 
            // btnSaveService
            // 
            this.btnSaveService.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnSaveService.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSaveService.FlatAppearance.BorderSize = 0;
            this.btnSaveService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveService.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSaveService.ForeColor = System.Drawing.Color.White;
            this.btnSaveService.Location = new System.Drawing.Point(0, 0);
            this.btnSaveService.Name = "btnSaveService";
            this.btnSaveService.Size = new System.Drawing.Size(114, 40);
            this.btnSaveService.TabIndex = 13;
            this.btnSaveService.Text = "Сохранить услугу";
            this.btnSaveService.UseVisualStyleBackColor = false;
            this.btnSaveService.Click += new System.EventHandler(this.btnSaveService_Click);
            // 
            // btnSaveOrder
            // 
            this.btnSaveOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnSaveOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSaveOrder.FlatAppearance.BorderSize = 0;
            this.btnSaveOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveOrder.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSaveOrder.ForeColor = System.Drawing.Color.White;
            this.btnSaveOrder.Location = new System.Drawing.Point(0, 0);
            this.btnSaveOrder.Name = "btnSaveOrder";
            this.btnSaveOrder.Size = new System.Drawing.Size(114, 40);
            this.btnSaveOrder.TabIndex = 14;
            this.btnSaveOrder.Text = "Сохранить заказ";
            this.btnSaveOrder.UseVisualStyleBackColor = false;
            this.btnSaveOrder.Click += new System.EventHandler(this.btnSaveOrder_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnDelClient);
            this.panel4.Controls.Add(this.btnDelService);
            this.panel4.Controls.Add(this.btnDelOrder);
            this.panel4.Location = new System.Drawing.Point(243, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(120, 40);
            this.panel4.TabIndex = 5;
            // 
            // btnDelClient
            // 
            this.btnDelClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnDelClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDelClient.FlatAppearance.BorderSize = 0;
            this.btnDelClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelClient.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDelClient.ForeColor = System.Drawing.Color.White;
            this.btnDelClient.Location = new System.Drawing.Point(0, 0);
            this.btnDelClient.Name = "btnDelClient";
            this.btnDelClient.Size = new System.Drawing.Size(120, 40);
            this.btnDelClient.TabIndex = 6;
            this.btnDelClient.Text = "Удалить клиента";
            this.btnDelClient.UseVisualStyleBackColor = false;
            this.btnDelClient.Click += new System.EventHandler(this.btnDelClient_Click);
            // 
            // btnDelService
            // 
            this.btnDelService.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnDelService.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDelService.FlatAppearance.BorderSize = 0;
            this.btnDelService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelService.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDelService.ForeColor = System.Drawing.Color.White;
            this.btnDelService.Location = new System.Drawing.Point(0, 0);
            this.btnDelService.Name = "btnDelService";
            this.btnDelService.Size = new System.Drawing.Size(120, 40);
            this.btnDelService.TabIndex = 13;
            this.btnDelService.Text = "Удалить услугу";
            this.btnDelService.UseVisualStyleBackColor = false;
            this.btnDelService.Click += new System.EventHandler(this.btnDelService_Click);
            // 
            // btnDelOrder
            // 
            this.btnDelOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnDelOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDelOrder.FlatAppearance.BorderSize = 0;
            this.btnDelOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelOrder.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDelOrder.ForeColor = System.Drawing.Color.White;
            this.btnDelOrder.Location = new System.Drawing.Point(0, 0);
            this.btnDelOrder.Name = "btnDelOrder";
            this.btnDelOrder.Size = new System.Drawing.Size(120, 40);
            this.btnDelOrder.TabIndex = 14;
            this.btnDelOrder.Text = "Удалить заказ";
            this.btnDelOrder.UseVisualStyleBackColor = false;
            this.btnDelOrder.Click += new System.EventHandler(this.btnDelOrder_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DataSource = this.bsUser;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(381, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(899, 499);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(381, 508);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(899, 46);
            this.panel5.TabIndex = 5;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.tableLayoutPanel4);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(899, 46);
            this.panel6.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel4.ColumnCount = 4;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.Controls.Add(this.panel10, 3, 0);
            this.tableLayoutPanel4.Controls.Add(this.panel9, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.panel8, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.panel11, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(899, 46);
            this.tableLayoutPanel4.TabIndex = 9;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.btnSortByStatus);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(676, 4);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(219, 38);
            this.panel10.TabIndex = 3;
            // 
            // btnSortByStatus
            // 
            this.btnSortByStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnSortByStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSortByStatus.FlatAppearance.BorderSize = 0;
            this.btnSortByStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSortByStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSortByStatus.ForeColor = System.Drawing.Color.White;
            this.btnSortByStatus.Location = new System.Drawing.Point(0, 0);
            this.btnSortByStatus.Name = "btnSortByStatus";
            this.btnSortByStatus.Size = new System.Drawing.Size(219, 38);
            this.btnSortByStatus.TabIndex = 13;
            this.btnSortByStatus.Text = "Отсортировать по статусу";
            this.btnSortByStatus.UseVisualStyleBackColor = false;
            this.btnSortByStatus.Visible = false;
            this.btnSortByStatus.Click += new System.EventHandler(this.btnSortByStatus_Click);
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.btnSortByDate);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(452, 4);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(217, 38);
            this.panel9.TabIndex = 2;
            // 
            // btnSortByDate
            // 
            this.btnSortByDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnSortByDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSortByDate.FlatAppearance.BorderSize = 0;
            this.btnSortByDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSortByDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSortByDate.ForeColor = System.Drawing.Color.White;
            this.btnSortByDate.Location = new System.Drawing.Point(0, 0);
            this.btnSortByDate.Name = "btnSortByDate";
            this.btnSortByDate.Size = new System.Drawing.Size(217, 38);
            this.btnSortByDate.TabIndex = 7;
            this.btnSortByDate.Text = "Отсортировать по дате";
            this.btnSortByDate.UseVisualStyleBackColor = false;
            this.btnSortByDate.Click += new System.EventHandler(this.btnSortByDate_Click);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.btnSortByClients);
            this.panel8.Controls.Add(this.btnClientsSortByName);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(228, 4);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(217, 38);
            this.panel8.TabIndex = 1;
            // 
            // btnSortByClients
            // 
            this.btnSortByClients.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnSortByClients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSortByClients.FlatAppearance.BorderSize = 0;
            this.btnSortByClients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSortByClients.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSortByClients.ForeColor = System.Drawing.Color.White;
            this.btnSortByClients.Location = new System.Drawing.Point(0, 0);
            this.btnSortByClients.Name = "btnSortByClients";
            this.btnSortByClients.Size = new System.Drawing.Size(217, 38);
            this.btnSortByClients.TabIndex = 13;
            this.btnSortByClients.Text = "Отсортировать по клиентам";
            this.btnSortByClients.UseVisualStyleBackColor = false;
            this.btnSortByClients.Visible = false;
            this.btnSortByClients.Click += new System.EventHandler(this.btnSortByClients_Click);
            // 
            // btnClientsSortByName
            // 
            this.btnClientsSortByName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnClientsSortByName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClientsSortByName.FlatAppearance.BorderSize = 0;
            this.btnClientsSortByName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientsSortByName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClientsSortByName.ForeColor = System.Drawing.Color.White;
            this.btnClientsSortByName.Location = new System.Drawing.Point(0, 0);
            this.btnClientsSortByName.Name = "btnClientsSortByName";
            this.btnClientsSortByName.Size = new System.Drawing.Size(217, 38);
            this.btnClientsSortByName.TabIndex = 7;
            this.btnClientsSortByName.Text = "Отсортировать по Фамилии и Имени";
            this.btnClientsSortByName.UseVisualStyleBackColor = false;
            this.btnClientsSortByName.Click += new System.EventHandler(this.btnSortByClients_Click);
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.btnRefresh);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel11.Location = new System.Drawing.Point(4, 4);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(217, 38);
            this.panel11.TabIndex = 0;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnRefresh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(0, 0);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(217, 38);
            this.btnRefresh.TabIndex = 7;
            this.btnRefresh.Text = "Обновить таблицу";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.panel7, 0, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 145F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(372, 499);
            this.tableLayoutPanel3.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Controls.Add(this.clientsEdit1);
            this.panel1.Controls.Add(this.ordersEdit1);
            this.panel1.Controls.Add(this.sevicesEdit1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(366, 348);
            this.panel1.TabIndex = 5;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tableLayoutPanel5.Controls.Add(this.btnClients, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.btnServices, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.btnOrders, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 508);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(372, 46);
            this.tableLayoutPanel5.TabIndex = 13;
            // 
            // btnClients
            // 
            this.btnClients.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnClients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClients.FlatAppearance.BorderSize = 0;
            this.btnClients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClients.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnClients.ForeColor = System.Drawing.Color.White;
            this.btnClients.Location = new System.Drawing.Point(4, 4);
            this.btnClients.Name = "btnClients";
            this.btnClients.Padding = new System.Windows.Forms.Padding(12, 0, 0, 2);
            this.btnClients.Size = new System.Drawing.Size(115, 38);
            this.btnClients.TabIndex = 12;
            this.btnClients.Text = "Клиенты";
            this.btnClients.UseVisualStyleBackColor = false;
            this.btnClients.Click += new System.EventHandler(this.btnClients_Click);
            // 
            // btnServices
            // 
            this.btnServices.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnServices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnServices.FlatAppearance.BorderSize = 0;
            this.btnServices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServices.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnServices.ForeColor = System.Drawing.Color.White;
            this.btnServices.Location = new System.Drawing.Point(248, 4);
            this.btnServices.Name = "btnServices";
            this.btnServices.Padding = new System.Windows.Forms.Padding(12, 0, 0, 2);
            this.btnServices.Size = new System.Drawing.Size(120, 38);
            this.btnServices.TabIndex = 9;
            this.btnServices.Text = "Услуги";
            this.btnServices.UseVisualStyleBackColor = false;
            this.btnServices.CheckedChanged += new System.EventHandler(this.btnServices_CheckedChanged);
            // 
            // btnOrders
            // 
            this.btnOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOrders.FlatAppearance.BorderSize = 0;
            this.btnOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrders.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnOrders.ForeColor = System.Drawing.Color.White;
            this.btnOrders.Location = new System.Drawing.Point(126, 4);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Padding = new System.Windows.Forms.Padding(12, 0, 0, 2);
            this.btnOrders.Size = new System.Drawing.Size(115, 38);
            this.btnOrders.TabIndex = 11;
            this.btnOrders.Text = "Заказы";
            this.btnOrders.UseVisualStyleBackColor = false;
            this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.btnShowAll);
            this.panel7.Controls.Add(this.label1);
            this.panel7.Controls.Add(this.cbClientFilter);
            this.panel7.Controls.Add(this.btnSearch);
            this.panel7.Location = new System.Drawing.Point(3, 357);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(366, 139);
            this.panel7.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.label1.Location = new System.Drawing.Point(78, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 21);
            this.label1.TabIndex = 23;
            this.label1.Text = "Клиент";
            this.label1.Visible = false;
            // 
            // cbClientFilter
            // 
            this.cbClientFilter.BackColor = System.Drawing.Color.White;
            this.cbClientFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClientFilter.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbClientFilter.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbClientFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbClientFilter.FormattingEnabled = true;
            this.cbClientFilter.Location = new System.Drawing.Point(153, 5);
            this.cbClientFilter.Name = "cbClientFilter";
            this.cbClientFilter.Size = new System.Drawing.Size(207, 29);
            this.cbClientFilter.TabIndex = 22;
            this.cbClientFilter.Visible = false;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(185, 40);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(178, 45);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Показать заказы выбранного клиента";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Visible = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnShowAll
            // 
            this.btnShowAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnShowAll.FlatAppearance.BorderSize = 0;
            this.btnShowAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowAll.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnShowAll.ForeColor = System.Drawing.Color.White;
            this.btnShowAll.Location = new System.Drawing.Point(185, 91);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(178, 45);
            this.btnShowAll.TabIndex = 24;
            this.btnShowAll.Text = "Показать всех клиентов";
            this.btnShowAll.UseVisualStyleBackColor = false;
            this.btnShowAll.Visible = false;
            this.btnShowAll.Click += new System.EventHandler(this.btnSortByClients_Click);
            // 
            // clientsEdit1
            // 
            this.clientsEdit1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.clientsEdit1.Client = null;
            this.clientsEdit1.Location = new System.Drawing.Point(0, 0);
            this.clientsEdit1.Name = "clientsEdit1";
            this.clientsEdit1.Size = new System.Drawing.Size(365, 296);
            this.clientsEdit1.TabIndex = 5;
            // 
            // ordersEdit1
            // 
            this.ordersEdit1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ordersEdit1.Location = new System.Drawing.Point(0, 0);
            this.ordersEdit1.Name = "ordersEdit1";
            this.ordersEdit1.Order = null;
            this.ordersEdit1.Size = new System.Drawing.Size(365, 296);
            this.ordersEdit1.TabIndex = 6;
            this.ordersEdit1.Visible = false;
            // 
            // sevicesEdit1
            // 
            this.sevicesEdit1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sevicesEdit1.Location = new System.Drawing.Point(0, 0);
            this.sevicesEdit1.Name = "sevicesEdit1";
            this.sevicesEdit1.Service = null;
            this.sevicesEdit1.Size = new System.Drawing.Size(365, 296);
            this.sevicesEdit1.TabIndex = 10;
            this.sevicesEdit1.Visible = false;
            // 
            // PhotoCenterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1284, 561);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "PhotoCenterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Фотоцентр \'Сильный муравей\'";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsUser)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.BindingSource bsUser;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton btnServices;
        private ClientsEdit clientsEdit1;
        private OrdersEdit ordersEdit1;
        private TablesEditors.ServicesEdit sevicesEdit1;
        private Button btnAddClient;
        private Button btnSaveClient;
        private Button btnDelClient;
        private RadioButton btnClients;
        private RadioButton btnOrders;
        private Panel panel7;
        private Button btnSearch;
        private Button btnAddService;
        private Button btnAddOrder;
        private Button btnSaveService;
        private Button btnSaveOrder;
        private Button btnDelService;
        private Button btnDelOrder;
        private DataGridView dataGridView1;
        private Panel panel5;
        private Panel panel6;
        private TableLayoutPanel tableLayoutPanel4;
        private Panel panel10;
        private Button btnSortByStatus;
        private Panel panel9;
        private Button btnSortByDate;
        private Panel panel8;
        private Button btnClientsSortByName;
        private Button btnSortByClients;
        private Panel panel11;
        private Button btnRefresh;
        private ComboBox cbClientFilter;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel5;
        private Button btnShowAll;
    }
}

