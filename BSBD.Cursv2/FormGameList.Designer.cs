namespace BSBD.Cursv2
{
    partial class FormGameList
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGameList));
            this.diamondCasinoDataSet = new BSBD.Cursv2.DiamondCasinoDataSet();
            this.запись_игрыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.запись_игрыTableAdapter = new BSBD.Cursv2.DiamondCasinoDataSetTableAdapters.Запись_игрыTableAdapter();
            this.tableAdapterManager = new BSBD.Cursv2.DiamondCasinoDataSetTableAdapters.TableAdapterManager();
            this.запись_игрыBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.запись_игрыBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.запись_игрыDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.diamondCasinoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.запись_игрыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.запись_игрыBindingNavigator)).BeginInit();
            this.запись_игрыBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.запись_игрыDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // diamondCasinoDataSet
            // 
            this.diamondCasinoDataSet.DataSetName = "DiamondCasinoDataSet";
            this.diamondCasinoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // запись_игрыBindingSource
            // 
            this.запись_игрыBindingSource.DataMember = "Запись_игры";
            this.запись_игрыBindingSource.DataSource = this.diamondCasinoDataSet;
            // 
            // запись_игрыTableAdapter
            // 
            this.запись_игрыTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.RoleTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = BSBD.Cursv2.DiamondCasinoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Запись_игрыTableAdapter = this.запись_игрыTableAdapter;
            this.tableAdapterManager.ИграTableAdapter = null;
            this.tableAdapterManager.ИгрокTableAdapter = null;
            this.tableAdapterManager.КрупьеTableAdapter = null;
            this.tableAdapterManager.СтавкаTableAdapter = null;
            // 
            // запись_игрыBindingNavigator
            // 
            this.запись_игрыBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.запись_игрыBindingNavigator.BindingSource = this.запись_игрыBindingSource;
            this.запись_игрыBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.запись_игрыBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.запись_игрыBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.запись_игрыBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.запись_игрыBindingNavigatorSaveItem});
            this.запись_игрыBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.запись_игрыBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.запись_игрыBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.запись_игрыBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.запись_игрыBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.запись_игрыBindingNavigator.Name = "запись_игрыBindingNavigator";
            this.запись_игрыBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.запись_игрыBindingNavigator.Size = new System.Drawing.Size(800, 31);
            this.запись_игрыBindingNavigator.TabIndex = 0;
            this.запись_игрыBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 28);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // запись_игрыBindingNavigatorSaveItem
            // 
            this.запись_игрыBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.запись_игрыBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("запись_игрыBindingNavigatorSaveItem.Image")));
            this.запись_игрыBindingNavigatorSaveItem.Name = "запись_игрыBindingNavigatorSaveItem";
            this.запись_игрыBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 28);
            this.запись_игрыBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.запись_игрыBindingNavigatorSaveItem.Click += new System.EventHandler(this.запись_игрыBindingNavigatorSaveItem_Click);
            // 
            // запись_игрыDataGridView
            // 
            this.запись_игрыDataGridView.AutoGenerateColumns = false;
            this.запись_игрыDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.запись_игрыDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.запись_игрыDataGridView.DataSource = this.запись_игрыBindingSource;
            this.запись_игрыDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.запись_игрыDataGridView.Location = new System.Drawing.Point(0, 31);
            this.запись_игрыDataGridView.Name = "запись_игрыDataGridView";
            this.запись_игрыDataGridView.RowHeadersWidth = 51;
            this.запись_игрыDataGridView.RowTemplate.Height = 24;
            this.запись_игрыDataGridView.Size = new System.Drawing.Size(800, 419);
            this.запись_игрыDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_Игры";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID_Игры";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ID_Игрока";
            this.dataGridViewTextBoxColumn2.HeaderText = "ID_Игрока";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Сумма";
            this.dataGridViewTextBoxColumn3.HeaderText = "Сумма";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ID_ИгрокаВИгре";
            this.dataGridViewTextBoxColumn4.HeaderText = "ID_ИгрокаВИгре";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // FormGameList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.запись_игрыDataGridView);
            this.Controls.Add(this.запись_игрыBindingNavigator);
            this.Name = "FormGameList";
            this.Text = "Запись игры";
            this.Load += new System.EventHandler(this.FormGameList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.diamondCasinoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.запись_игрыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.запись_игрыBindingNavigator)).EndInit();
            this.запись_игрыBindingNavigator.ResumeLayout(false);
            this.запись_игрыBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.запись_игрыDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DiamondCasinoDataSet diamondCasinoDataSet;
        private System.Windows.Forms.BindingSource запись_игрыBindingSource;
        private DiamondCasinoDataSetTableAdapters.Запись_игрыTableAdapter запись_игрыTableAdapter;
        private DiamondCasinoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator запись_игрыBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton запись_игрыBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView запись_игрыDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}