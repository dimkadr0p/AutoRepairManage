
namespace AdminAPP
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageOrder = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.order_ViewDataGridView = new System.Windows.Forms.DataGridView();
            this.ColumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.auto_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.client_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.order_ViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.autoRepairShopDataSet = new AdminAPP.AutoRepairShopDataSet();
            this.order_ViewBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonUploadBase = new System.Windows.Forms.ToolStripButton();
            this.panelOrderDetail = new System.Windows.Forms.Panel();
            this.buttonChangeOrder = new System.Windows.Forms.Button();
            this.buttonDeleteOrder = new System.Windows.Forms.Button();
            this.buttonAddOrder = new System.Windows.Forms.Button();
            this.linkLabelClient = new System.Windows.Forms.LinkLabel();
            this.linkLabelAuto = new System.Windows.Forms.LinkLabel();
            this.panelService = new System.Windows.Forms.Panel();
            this.contextMenuStripServiceOrder = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.changeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelWorkerValue = new System.Windows.Forms.Label();
            this.labelWorker = new System.Windows.Forms.Label();
            this.labelPriceValue = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.comboBoxListService = new System.Windows.Forms.ComboBox();
            this.labelListService = new System.Windows.Forms.Label();
            this.personBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.companyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.postBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.workerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.serviceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.modelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.autoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStripHeader = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.order_ViewTableAdapter = new AdminAPP.AutoRepairShopDataSetTableAdapters.Order_ViewTableAdapter();
            this.tableAdapterManager = new AdminAPP.AutoRepairShopDataSetTableAdapters.TableAdapterManager();
            this.personTableAdapter = new AdminAPP.AutoRepairShopDataSetTableAdapters.PersonTableAdapter();
            this.companyTableAdapter = new AdminAPP.AutoRepairShopDataSetTableAdapters.CompanyTableAdapter();
            this.workerTableAdapter = new AdminAPP.AutoRepairShopDataSetTableAdapters.WorkerTableAdapter();
            this.postTableAdapter = new AdminAPP.AutoRepairShopDataSetTableAdapters.PostTableAdapter();
            this.autoRepairShopDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.serviceTableAdapter = new AdminAPP.AutoRepairShopDataSetTableAdapters.ServiceTableAdapter();
            this.brandAutoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.brandAutoTableAdapter = new AdminAPP.AutoRepairShopDataSetTableAdapters.BrandAutoTableAdapter();
            this.autoTableAdapter = new AdminAPP.AutoRepairShopDataSetTableAdapters.AutoTableAdapter();
            this.modelTableAdapter = new AdminAPP.AutoRepairShopDataSetTableAdapters.ModelTableAdapter();
            this.tabControl.SuspendLayout();
            this.tabPageOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.order_ViewDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.order_ViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoRepairShopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.order_ViewBindingNavigator)).BeginInit();
            this.order_ViewBindingNavigator.SuspendLayout();
            this.panelOrderDetail.SuspendLayout();
            this.panelService.SuspendLayout();
            this.contextMenuStripServiceOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoBindingSource)).BeginInit();
            this.menuStripHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.autoRepairShopDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brandAutoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageOrder);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 24);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1093, 563);
            this.tabControl.TabIndex = 0;
            // 
            // tabPageOrder
            // 
            this.tabPageOrder.Controls.Add(this.splitContainer1);
            this.tabPageOrder.Location = new System.Drawing.Point(4, 22);
            this.tabPageOrder.Name = "tabPageOrder";
            this.tabPageOrder.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOrder.Size = new System.Drawing.Size(1085, 537);
            this.tabPageOrder.TabIndex = 0;
            this.tabPageOrder.Text = "Заказы";
            this.tabPageOrder.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.Controls.Add(this.order_ViewDataGridView);
            this.splitContainer1.Panel1.Controls.Add(this.order_ViewBindingNavigator);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panelOrderDetail);
            this.splitContainer1.Panel2.Controls.Add(this.panelService);
            this.splitContainer1.Size = new System.Drawing.Size(1079, 531);
            this.splitContainer1.SplitterDistance = 756;
            this.splitContainer1.TabIndex = 0;
            // 
            // order_ViewDataGridView
            // 
            this.order_ViewDataGridView.AutoGenerateColumns = false;
            this.order_ViewDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.order_ViewDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnID,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn4,
            this.auto_id,
            this.client_id});
            this.order_ViewDataGridView.DataSource = this.order_ViewBindingSource;
            this.order_ViewDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.order_ViewDataGridView.Location = new System.Drawing.Point(0, 25);
            this.order_ViewDataGridView.Name = "order_ViewDataGridView";
            this.order_ViewDataGridView.Size = new System.Drawing.Size(756, 506);
            this.order_ViewDataGridView.TabIndex = 0;
            this.order_ViewDataGridView.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.order_ViewDataGridView_RowEnter);
            // 
            // ColumnID
            // 
            this.ColumnID.DataPropertyName = "id";
            this.ColumnID.HeaderText = "ID";
            this.ColumnID.Name = "ColumnID";
            this.ColumnID.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Клиент";
            this.dataGridViewTextBoxColumn2.HeaderText = "Клиент";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Дата посещения";
            this.dataGridViewTextBoxColumn3.HeaderText = "Дата посещения";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Статус обращения";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Статус обращения";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Итого";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn4.HeaderText = "Итого";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // auto_id
            // 
            this.auto_id.DataPropertyName = "auto_id";
            this.auto_id.HeaderText = "auto_id";
            this.auto_id.Name = "auto_id";
            this.auto_id.Visible = false;
            // 
            // client_id
            // 
            this.client_id.DataPropertyName = "client_id";
            this.client_id.HeaderText = "client_id";
            this.client_id.Name = "client_id";
            this.client_id.Visible = false;
            // 
            // order_ViewBindingSource
            // 
            this.order_ViewBindingSource.DataMember = "Order_View";
            this.order_ViewBindingSource.DataSource = this.autoRepairShopDataSet;
            // 
            // autoRepairShopDataSet
            // 
            this.autoRepairShopDataSet.DataSetName = "AutoRepairShopDataSet";
            this.autoRepairShopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // order_ViewBindingNavigator
            // 
            this.order_ViewBindingNavigator.AddNewItem = null;
            this.order_ViewBindingNavigator.BindingSource = this.order_ViewBindingSource;
            this.order_ViewBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.order_ViewBindingNavigator.DeleteItem = null;
            this.order_ViewBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.toolStripButtonUploadBase});
            this.order_ViewBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.order_ViewBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.order_ViewBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.order_ViewBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.order_ViewBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.order_ViewBindingNavigator.Name = "order_ViewBindingNavigator";
            this.order_ViewBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.order_ViewBindingNavigator.Size = new System.Drawing.Size(756, 25);
            this.order_ViewBindingNavigator.TabIndex = 1;
            this.order_ViewBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonUploadBase
            // 
            this.toolStripButtonUploadBase.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonUploadBase.Image = global::AdminAPP.Properties.Resources.upload;
            this.toolStripButtonUploadBase.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonUploadBase.Name = "toolStripButtonUploadBase";
            this.toolStripButtonUploadBase.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonUploadBase.Text = "upload";
            this.toolStripButtonUploadBase.Click += new System.EventHandler(this.toolStripButtonUploadBase_Click);
            // 
            // panelOrderDetail
            // 
            this.panelOrderDetail.BackColor = System.Drawing.Color.LightGray;
            this.panelOrderDetail.Controls.Add(this.buttonChangeOrder);
            this.panelOrderDetail.Controls.Add(this.buttonDeleteOrder);
            this.panelOrderDetail.Controls.Add(this.buttonAddOrder);
            this.panelOrderDetail.Controls.Add(this.linkLabelClient);
            this.panelOrderDetail.Controls.Add(this.linkLabelAuto);
            this.panelOrderDetail.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelOrderDetail.Location = new System.Drawing.Point(0, 246);
            this.panelOrderDetail.Name = "panelOrderDetail";
            this.panelOrderDetail.Size = new System.Drawing.Size(319, 285);
            this.panelOrderDetail.TabIndex = 8;
            // 
            // buttonChangeOrder
            // 
            this.buttonChangeOrder.Location = new System.Drawing.Point(95, 71);
            this.buttonChangeOrder.Name = "buttonChangeOrder";
            this.buttonChangeOrder.Size = new System.Drawing.Size(139, 23);
            this.buttonChangeOrder.TabIndex = 4;
            this.buttonChangeOrder.Text = "Изменить объявление";
            this.buttonChangeOrder.UseVisualStyleBackColor = true;
            this.buttonChangeOrder.Click += new System.EventHandler(this.buttonChangeOrder_Click);
            // 
            // buttonDeleteOrder
            // 
            this.buttonDeleteOrder.Location = new System.Drawing.Point(174, 29);
            this.buttonDeleteOrder.Name = "buttonDeleteOrder";
            this.buttonDeleteOrder.Size = new System.Drawing.Size(139, 23);
            this.buttonDeleteOrder.TabIndex = 3;
            this.buttonDeleteOrder.Text = "Удалить объявление";
            this.buttonDeleteOrder.UseVisualStyleBackColor = true;
            this.buttonDeleteOrder.Click += new System.EventHandler(this.buttonDeleteOrder_Click);
            // 
            // buttonAddOrder
            // 
            this.buttonAddOrder.Location = new System.Drawing.Point(18, 29);
            this.buttonAddOrder.Name = "buttonAddOrder";
            this.buttonAddOrder.Size = new System.Drawing.Size(139, 23);
            this.buttonAddOrder.TabIndex = 2;
            this.buttonAddOrder.Text = "Создать объявление";
            this.buttonAddOrder.UseVisualStyleBackColor = true;
            this.buttonAddOrder.Click += new System.EventHandler(this.buttonAddOrder_Click);
            // 
            // linkLabelClient
            // 
            this.linkLabelClient.AutoSize = true;
            this.linkLabelClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabelClient.Location = new System.Drawing.Point(24, 247);
            this.linkLabelClient.Name = "linkLabelClient";
            this.linkLabelClient.Size = new System.Drawing.Size(133, 15);
            this.linkLabelClient.TabIndex = 1;
            this.linkLabelClient.TabStop = true;
            this.linkLabelClient.Text = "Подробнее о клиенте";
            this.linkLabelClient.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelClient_LinkClicked);
            // 
            // linkLabelAuto
            // 
            this.linkLabelAuto.AutoSize = true;
            this.linkLabelAuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabelAuto.Location = new System.Drawing.Point(24, 216);
            this.linkLabelAuto.Name = "linkLabelAuto";
            this.linkLabelAuto.Size = new System.Drawing.Size(120, 15);
            this.linkLabelAuto.TabIndex = 0;
            this.linkLabelAuto.TabStop = true;
            this.linkLabelAuto.Text = "Подробнее об авто";
            this.linkLabelAuto.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelAuto_LinkClicked);
            // 
            // panelService
            // 
            this.panelService.ContextMenuStrip = this.contextMenuStripServiceOrder;
            this.panelService.Controls.Add(this.labelWorkerValue);
            this.panelService.Controls.Add(this.labelWorker);
            this.panelService.Controls.Add(this.labelPriceValue);
            this.panelService.Controls.Add(this.labelPrice);
            this.panelService.Controls.Add(this.comboBoxListService);
            this.panelService.Controls.Add(this.labelListService);
            this.panelService.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelService.Location = new System.Drawing.Point(0, 0);
            this.panelService.Name = "panelService";
            this.panelService.Size = new System.Drawing.Size(319, 240);
            this.panelService.TabIndex = 7;
            // 
            // contextMenuStripServiceOrder
            // 
            this.contextMenuStripServiceOrder.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeToolStripMenuItem,
            this.addToolStripMenuItem,
            this.removeToolStripMenuItem});
            this.contextMenuStripServiceOrder.Name = "contextMenuStripWorker";
            this.contextMenuStripServiceOrder.Size = new System.Drawing.Size(129, 70);
            // 
            // changeToolStripMenuItem
            // 
            this.changeToolStripMenuItem.Name = "changeToolStripMenuItem";
            this.changeToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.changeToolStripMenuItem.Text = "Изменить";
            this.changeToolStripMenuItem.Click += new System.EventHandler(this.changeToolStripMenuItem_Click);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.addToolStripMenuItem.Text = "Добавить";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.removeToolStripMenuItem.Text = "Удалить";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // labelWorkerValue
            // 
            this.labelWorkerValue.AutoSize = true;
            this.labelWorkerValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWorkerValue.Location = new System.Drawing.Point(171, 193);
            this.labelWorkerValue.Name = "labelWorkerValue";
            this.labelWorkerValue.Size = new System.Drawing.Size(0, 16);
            this.labelWorkerValue.TabIndex = 6;
            // 
            // labelWorker
            // 
            this.labelWorker.AutoSize = true;
            this.labelWorker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWorker.Location = new System.Drawing.Point(23, 190);
            this.labelWorker.Name = "labelWorker";
            this.labelWorker.Size = new System.Drawing.Size(142, 20);
            this.labelWorker.TabIndex = 5;
            this.labelWorker.Text = "Ответственный:  ";
            // 
            // labelPriceValue
            // 
            this.labelPriceValue.AutoSize = true;
            this.labelPriceValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPriceValue.Location = new System.Drawing.Point(85, 131);
            this.labelPriceValue.Name = "labelPriceValue";
            this.labelPriceValue.Size = new System.Drawing.Size(184, 20);
            this.labelPriceValue.TabIndex = 4;
            this.labelPriceValue.Text = "посещение не выбрано";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPrice.Location = new System.Drawing.Point(23, 131);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(56, 20);
            this.labelPrice.TabIndex = 3;
            this.labelPrice.Text = "Цена: ";
            // 
            // comboBoxListService
            // 
            this.comboBoxListService.FormattingEnabled = true;
            this.comboBoxListService.Location = new System.Drawing.Point(89, 78);
            this.comboBoxListService.Name = "comboBoxListService";
            this.comboBoxListService.Size = new System.Drawing.Size(164, 21);
            this.comboBoxListService.TabIndex = 1;
            this.comboBoxListService.Text = "посещение не выбрано";
            this.comboBoxListService.SelectedIndexChanged += new System.EventHandler(this.comboBoxListService_SelectedIndexChanged);
            // 
            // labelListService
            // 
            this.labelListService.AutoSize = true;
            this.labelListService.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelListService.Location = new System.Drawing.Point(90, 25);
            this.labelListService.Name = "labelListService";
            this.labelListService.Size = new System.Drawing.Size(163, 25);
            this.labelListService.TabIndex = 0;
            this.labelListService.Text = "Список услуг:";
            // 
            // personBindingSource
            // 
            this.personBindingSource.DataMember = "Person";
            this.personBindingSource.DataSource = this.autoRepairShopDataSet;
            // 
            // companyBindingSource
            // 
            this.companyBindingSource.DataMember = "Company";
            this.companyBindingSource.DataSource = this.autoRepairShopDataSet;
            // 
            // postBindingSource
            // 
            this.postBindingSource.DataMember = "Post";
            this.postBindingSource.DataSource = this.autoRepairShopDataSet;
            // 
            // workerBindingSource
            // 
            this.workerBindingSource.DataMember = "Worker";
            this.workerBindingSource.DataSource = this.autoRepairShopDataSet;
            // 
            // serviceBindingSource
            // 
            this.serviceBindingSource.DataMember = "Service";
            this.serviceBindingSource.DataSource = this.autoRepairShopDataSet;
            // 
            // modelBindingSource
            // 
            this.modelBindingSource.DataMember = "Model";
            this.modelBindingSource.DataSource = this.autoRepairShopDataSet;
            // 
            // autoBindingSource
            // 
            this.autoBindingSource.DataMember = "Auto";
            this.autoBindingSource.DataSource = this.autoRepairShopDataSet;
            // 
            // menuStripHeader
            // 
            this.menuStripHeader.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStripHeader.Location = new System.Drawing.Point(0, 0);
            this.menuStripHeader.Name = "menuStripHeader";
            this.menuStripHeader.Size = new System.Drawing.Size(1093, 24);
            this.menuStripHeader.TabIndex = 0;
            this.menuStripHeader.Text = "menuStripMain";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.exitToolStripMenuItem.Text = "Выход";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.editToolStripMenuItem.Text = "Редактировать";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // order_ViewTableAdapter
            // 
            this.order_ViewTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AutoTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BrandAutoTableAdapter = null;
            this.tableAdapterManager.CompanyTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.ModelTableAdapter = null;
            this.tableAdapterManager.OrdersTableAdapter = null;
            this.tableAdapterManager.PermissionViewTableAdapter = null;
            this.tableAdapterManager.PersonTableAdapter = null;
            this.tableAdapterManager.PostTableAdapter = null;
            this.tableAdapterManager.ServiceOrderTableAdapter = null;
            this.tableAdapterManager.ServiceTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = AdminAPP.AutoRepairShopDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WorkerTableAdapter = null;
            // 
            // personTableAdapter
            // 
            this.personTableAdapter.ClearBeforeFill = true;
            // 
            // companyTableAdapter
            // 
            this.companyTableAdapter.ClearBeforeFill = true;
            // 
            // workerTableAdapter
            // 
            this.workerTableAdapter.ClearBeforeFill = true;
            // 
            // postTableAdapter
            // 
            this.postTableAdapter.ClearBeforeFill = true;
            // 
            // autoRepairShopDataSetBindingSource
            // 
            this.autoRepairShopDataSetBindingSource.DataSource = this.autoRepairShopDataSet;
            this.autoRepairShopDataSetBindingSource.Position = 0;
            // 
            // serviceTableAdapter
            // 
            this.serviceTableAdapter.ClearBeforeFill = true;
            // 
            // brandAutoBindingSource
            // 
            this.brandAutoBindingSource.DataMember = "BrandAuto";
            this.brandAutoBindingSource.DataSource = this.autoRepairShopDataSet;
            // 
            // brandAutoTableAdapter
            // 
            this.brandAutoTableAdapter.ClearBeforeFill = true;
            // 
            // autoTableAdapter
            // 
            this.autoTableAdapter.ClearBeforeFill = true;
            // 
            // modelTableAdapter
            // 
            this.modelTableAdapter.ClearBeforeFill = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 587);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStripHeader);
            this.MainMenuStrip = this.menuStripHeader;
            this.Name = "FormMain";
            this.Text = "AppDB";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPageOrder.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.order_ViewDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.order_ViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoRepairShopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.order_ViewBindingNavigator)).EndInit();
            this.order_ViewBindingNavigator.ResumeLayout(false);
            this.order_ViewBindingNavigator.PerformLayout();
            this.panelOrderDetail.ResumeLayout(false);
            this.panelOrderDetail.PerformLayout();
            this.panelService.ResumeLayout(false);
            this.panelService.PerformLayout();
            this.contextMenuStripServiceOrder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoBindingSource)).EndInit();
            this.menuStripHeader.ResumeLayout(false);
            this.menuStripHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.autoRepairShopDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brandAutoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageOrder;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.MenuStrip menuStripHeader;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private AutoRepairShopDataSet autoRepairShopDataSet;
        private System.Windows.Forms.BindingSource order_ViewBindingSource;
        private AutoRepairShopDataSetTableAdapters.Order_ViewTableAdapter order_ViewTableAdapter;
        private AutoRepairShopDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator order_ViewBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridView order_ViewDataGridView;
        private System.Windows.Forms.ComboBox comboBoxListService;
        private System.Windows.Forms.Label labelListService;
        private System.Windows.Forms.Label labelPriceValue;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelWorkerValue;
        private System.Windows.Forms.Label labelWorker;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripServiceOrder;
        private System.Windows.Forms.ToolStripMenuItem changeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.Panel panelOrderDetail;
        private System.Windows.Forms.Panel panelService;
        private System.Windows.Forms.LinkLabel linkLabelClient;
        private System.Windows.Forms.LinkLabel linkLabelAuto;
        private System.Windows.Forms.BindingSource personBindingSource;
        private AutoRepairShopDataSetTableAdapters.PersonTableAdapter personTableAdapter;
        private System.Windows.Forms.BindingSource companyBindingSource;
        private AutoRepairShopDataSetTableAdapters.CompanyTableAdapter companyTableAdapter;
        private System.Windows.Forms.BindingSource workerBindingSource;
        private AutoRepairShopDataSetTableAdapters.WorkerTableAdapter workerTableAdapter;
        private System.Windows.Forms.BindingSource postBindingSource;
        private AutoRepairShopDataSetTableAdapters.PostTableAdapter postTableAdapter;
        private System.Windows.Forms.BindingSource autoRepairShopDataSetBindingSource;
        private System.Windows.Forms.Button buttonDeleteOrder;
        private System.Windows.Forms.Button buttonAddOrder;
        private System.Windows.Forms.ToolStripButton toolStripButtonUploadBase;
        private System.Windows.Forms.Button buttonChangeOrder;
        private System.Windows.Forms.BindingSource serviceBindingSource;
        private AutoRepairShopDataSetTableAdapters.ServiceTableAdapter serviceTableAdapter;
        private System.Windows.Forms.BindingSource brandAutoBindingSource;
        private AutoRepairShopDataSetTableAdapters.BrandAutoTableAdapter brandAutoTableAdapter;
        private System.Windows.Forms.BindingSource autoBindingSource;
        private AutoRepairShopDataSetTableAdapters.AutoTableAdapter autoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn auto_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn client_id;
        private System.Windows.Forms.BindingSource modelBindingSource;
        private AutoRepairShopDataSetTableAdapters.ModelTableAdapter modelTableAdapter;
    }
}

