namespace BSBD.Cursv2
{
    partial class FormPlayer
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
            System.Windows.Forms.Label iD_ИгрокаLabel;
            System.Windows.Forms.Label фLabel;
            System.Windows.Forms.Label иLabel;
            System.Windows.Forms.Label оLabel;
            System.Windows.Forms.Label паспортные_данныеLabel;
            System.Windows.Forms.Label реквизитыLabel;
            System.Windows.Forms.Label номер_телефонаLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPlayer));
            this.diamondCasinoDataSet = new BSBD.Cursv2.DiamondCasinoDataSet();
            this.игрокBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.игрокTableAdapter = new BSBD.Cursv2.DiamondCasinoDataSetTableAdapters.ИгрокTableAdapter();
            this.tableAdapterManager = new BSBD.Cursv2.DiamondCasinoDataSetTableAdapters.TableAdapterManager();
            this.игрокBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.игрокBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iD_ИгрокаTextBox = new System.Windows.Forms.TextBox();
            this.фTextBox = new System.Windows.Forms.TextBox();
            this.иTextBox = new System.Windows.Forms.TextBox();
            this.оTextBox = new System.Windows.Forms.TextBox();
            this.паспортные_данныеTextBox = new System.Windows.Forms.TextBox();
            this.реквизитыTextBox = new System.Windows.Forms.TextBox();
            this.номер_телефонаTextBox = new System.Windows.Forms.TextBox();
            iD_ИгрокаLabel = new System.Windows.Forms.Label();
            фLabel = new System.Windows.Forms.Label();
            иLabel = new System.Windows.Forms.Label();
            оLabel = new System.Windows.Forms.Label();
            паспортные_данныеLabel = new System.Windows.Forms.Label();
            реквизитыLabel = new System.Windows.Forms.Label();
            номер_телефонаLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.diamondCasinoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.игрокBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.игрокBindingNavigator)).BeginInit();
            this.игрокBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // iD_ИгрокаLabel
            // 
            iD_ИгрокаLabel.AutoSize = true;
            iD_ИгрокаLabel.Location = new System.Drawing.Point(24, 57);
            iD_ИгрокаLabel.Name = "iD_ИгрокаLabel";
            iD_ИгрокаLabel.Size = new System.Drawing.Size(73, 16);
            iD_ИгрокаLabel.TabIndex = 1;
            iD_ИгрокаLabel.Text = "ID Игрока:";
            // 
            // фLabel
            // 
            фLabel.AutoSize = true;
            фLabel.Location = new System.Drawing.Point(24, 85);
            фLabel.Name = "фLabel";
            фLabel.Size = new System.Drawing.Size(21, 16);
            фLabel.TabIndex = 3;
            фLabel.Text = "Ф:";
            // 
            // иLabel
            // 
            иLabel.AutoSize = true;
            иLabel.Location = new System.Drawing.Point(24, 113);
            иLabel.Name = "иLabel";
            иLabel.Size = new System.Drawing.Size(20, 16);
            иLabel.TabIndex = 5;
            иLabel.Text = "И:";
            // 
            // оLabel
            // 
            оLabel.AutoSize = true;
            оLabel.Location = new System.Drawing.Point(24, 141);
            оLabel.Name = "оLabel";
            оLabel.Size = new System.Drawing.Size(20, 16);
            оLabel.TabIndex = 7;
            оLabel.Text = "О:";
            // 
            // паспортные_данныеLabel
            // 
            паспортные_данныеLabel.AutoSize = true;
            паспортные_данныеLabel.Location = new System.Drawing.Point(24, 169);
            паспортные_данныеLabel.Name = "паспортные_данныеLabel";
            паспортные_данныеLabel.Size = new System.Drawing.Size(143, 16);
            паспортные_данныеLabel.TabIndex = 9;
            паспортные_данныеLabel.Text = "Паспортные данные:";
            // 
            // реквизитыLabel
            // 
            реквизитыLabel.AutoSize = true;
            реквизитыLabel.Location = new System.Drawing.Point(24, 197);
            реквизитыLabel.Name = "реквизитыLabel";
            реквизитыLabel.Size = new System.Drawing.Size(82, 16);
            реквизитыLabel.TabIndex = 11;
            реквизитыLabel.Text = "Реквизиты:";
            // 
            // номер_телефонаLabel
            // 
            номер_телефонаLabel.AutoSize = true;
            номер_телефонаLabel.Location = new System.Drawing.Point(24, 225);
            номер_телефонаLabel.Name = "номер_телефонаLabel";
            номер_телефонаLabel.Size = new System.Drawing.Size(122, 16);
            номер_телефонаLabel.TabIndex = 13;
            номер_телефонаLabel.Text = "Номер телефона:";
            // 
            // diamondCasinoDataSet
            // 
            this.diamondCasinoDataSet.DataSetName = "DiamondCasinoDataSet";
            this.diamondCasinoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // игрокBindingSource
            // 
            this.игрокBindingSource.DataMember = "Игрок";
            this.игрокBindingSource.DataSource = this.diamondCasinoDataSet;
            // 
            // игрокTableAdapter
            // 
            this.игрокTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.RoleTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = BSBD.Cursv2.DiamondCasinoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Запись_игрыTableAdapter = null;
            this.tableAdapterManager.ИграTableAdapter = null;
            this.tableAdapterManager.ИгрокTableAdapter = this.игрокTableAdapter;
            this.tableAdapterManager.КрупьеTableAdapter = null;
            this.tableAdapterManager.СтавкаTableAdapter = null;
            // 
            // игрокBindingNavigator
            // 
            this.игрокBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.игрокBindingNavigator.BindingSource = this.игрокBindingSource;
            this.игрокBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.игрокBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.игрокBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.игрокBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.игрокBindingNavigatorSaveItem});
            this.игрокBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.игрокBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.игрокBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.игрокBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.игрокBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.игрокBindingNavigator.Name = "игрокBindingNavigator";
            this.игрокBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.игрокBindingNavigator.Size = new System.Drawing.Size(800, 31);
            this.игрокBindingNavigator.TabIndex = 0;
            this.игрокBindingNavigator.Text = "bindingNavigator1";
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
            // игрокBindingNavigatorSaveItem
            // 
            this.игрокBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.игрокBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("игрокBindingNavigatorSaveItem.Image")));
            this.игрокBindingNavigatorSaveItem.Name = "игрокBindingNavigatorSaveItem";
            this.игрокBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 28);
            this.игрокBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.игрокBindingNavigatorSaveItem.Click += new System.EventHandler(this.игрокBindingNavigatorSaveItem_Click);
            // 
            // iD_ИгрокаTextBox
            // 
            this.iD_ИгрокаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.игрокBindingSource, "ID_Игрока", true));
            this.iD_ИгрокаTextBox.Location = new System.Drawing.Point(173, 54);
            this.iD_ИгрокаTextBox.Name = "iD_ИгрокаTextBox";
            this.iD_ИгрокаTextBox.Size = new System.Drawing.Size(100, 22);
            this.iD_ИгрокаTextBox.TabIndex = 2;
            // 
            // фTextBox
            // 
            this.фTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.игрокBindingSource, "Ф", true));
            this.фTextBox.Location = new System.Drawing.Point(173, 82);
            this.фTextBox.Name = "фTextBox";
            this.фTextBox.Size = new System.Drawing.Size(100, 22);
            this.фTextBox.TabIndex = 4;
            // 
            // иTextBox
            // 
            this.иTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.игрокBindingSource, "И", true));
            this.иTextBox.Location = new System.Drawing.Point(173, 110);
            this.иTextBox.Name = "иTextBox";
            this.иTextBox.Size = new System.Drawing.Size(100, 22);
            this.иTextBox.TabIndex = 6;
            // 
            // оTextBox
            // 
            this.оTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.игрокBindingSource, "О", true));
            this.оTextBox.Location = new System.Drawing.Point(173, 138);
            this.оTextBox.Name = "оTextBox";
            this.оTextBox.Size = new System.Drawing.Size(100, 22);
            this.оTextBox.TabIndex = 8;
            // 
            // паспортные_данныеTextBox
            // 
            this.паспортные_данныеTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.игрокBindingSource, "Паспортные_данные", true));
            this.паспортные_данныеTextBox.Location = new System.Drawing.Point(173, 166);
            this.паспортные_данныеTextBox.Name = "паспортные_данныеTextBox";
            this.паспортные_данныеTextBox.Size = new System.Drawing.Size(100, 22);
            this.паспортные_данныеTextBox.TabIndex = 10;
            // 
            // реквизитыTextBox
            // 
            this.реквизитыTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.игрокBindingSource, "Реквизиты", true));
            this.реквизитыTextBox.Location = new System.Drawing.Point(173, 194);
            this.реквизитыTextBox.Name = "реквизитыTextBox";
            this.реквизитыTextBox.Size = new System.Drawing.Size(100, 22);
            this.реквизитыTextBox.TabIndex = 12;
            // 
            // номер_телефонаTextBox
            // 
            this.номер_телефонаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.игрокBindingSource, "Номер_телефона", true));
            this.номер_телефонаTextBox.Location = new System.Drawing.Point(173, 222);
            this.номер_телефонаTextBox.Name = "номер_телефонаTextBox";
            this.номер_телефонаTextBox.Size = new System.Drawing.Size(100, 22);
            this.номер_телефонаTextBox.TabIndex = 14;
            // 
            // FormPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(iD_ИгрокаLabel);
            this.Controls.Add(this.iD_ИгрокаTextBox);
            this.Controls.Add(фLabel);
            this.Controls.Add(this.фTextBox);
            this.Controls.Add(иLabel);
            this.Controls.Add(this.иTextBox);
            this.Controls.Add(оLabel);
            this.Controls.Add(this.оTextBox);
            this.Controls.Add(паспортные_данныеLabel);
            this.Controls.Add(this.паспортные_данныеTextBox);
            this.Controls.Add(реквизитыLabel);
            this.Controls.Add(this.реквизитыTextBox);
            this.Controls.Add(номер_телефонаLabel);
            this.Controls.Add(this.номер_телефонаTextBox);
            this.Controls.Add(this.игрокBindingNavigator);
            this.Name = "FormPlayer";
            this.Text = " ";
            this.Load += new System.EventHandler(this.FormPlayer_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Stop);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Stop);
            ((System.ComponentModel.ISupportInitialize)(this.diamondCasinoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.игрокBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.игрокBindingNavigator)).EndInit();
            this.игрокBindingNavigator.ResumeLayout(false);
            this.игрокBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DiamondCasinoDataSet diamondCasinoDataSet;
        private System.Windows.Forms.BindingSource игрокBindingSource;
        private DiamondCasinoDataSetTableAdapters.ИгрокTableAdapter игрокTableAdapter;
        private DiamondCasinoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator игрокBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton игрокBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iD_ИгрокаTextBox;
        private System.Windows.Forms.TextBox фTextBox;
        private System.Windows.Forms.TextBox иTextBox;
        private System.Windows.Forms.TextBox оTextBox;
        private System.Windows.Forms.TextBox паспортные_данныеTextBox;
        private System.Windows.Forms.TextBox реквизитыTextBox;
        private System.Windows.Forms.TextBox номер_телефонаTextBox;
    }
}