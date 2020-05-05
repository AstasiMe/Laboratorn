namespace Laba_9_10
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            System.Windows.Forms.Label id_orderLabel;
            System.Windows.Forms.Label id_bookLabel;
            System.Windows.Forms.Label id_publLabel;
            System.Windows.Forms.Label countsLabel;
            System.Windows.Forms.Label priceLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.booksDataSet = new Laba_9_10.booksDataSet();
            this.orderlistBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderlistTableAdapter = new Laba_9_10.booksDataSetTableAdapters.orderlistTableAdapter();
            this.tableAdapterManager = new Laba_9_10.booksDataSetTableAdapters.TableAdapterManager();
            this.orderlistBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.orderlistBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.id_orderTextBox = new System.Windows.Forms.TextBox();
            this.id_bookTextBox = new System.Windows.Forms.TextBox();
            this.id_publTextBox = new System.Windows.Forms.TextBox();
            this.countsTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            id_orderLabel = new System.Windows.Forms.Label();
            id_bookLabel = new System.Windows.Forms.Label();
            id_publLabel = new System.Windows.Forms.Label();
            countsLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.booksDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderlistBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderlistBindingNavigator)).BeginInit();
            this.orderlistBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(44, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Таблица \"Заказы\"";
            // 
            // booksDataSet
            // 
            this.booksDataSet.DataSetName = "booksDataSet";
            this.booksDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // orderlistBindingSource
            // 
            this.orderlistBindingSource.DataMember = "orderlist";
            this.orderlistBindingSource.DataSource = this.booksDataSet;
            // 
            // orderlistTableAdapter
            // 
            this.orderlistTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.authorsTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.booksTableAdapter = null;
            this.tableAdapterManager.firmTableAdapter = null;
            this.tableAdapterManager.orderlistTableAdapter = this.orderlistTableAdapter;
            this.tableAdapterManager.ordersTableAdapter = null;
            this.tableAdapterManager.publishingTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Laba_9_10.booksDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // orderlistBindingNavigator
            // 
            this.orderlistBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.orderlistBindingNavigator.BindingSource = this.orderlistBindingSource;
            this.orderlistBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.orderlistBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.orderlistBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.orderlistBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.orderlistBindingNavigatorSaveItem});
            this.orderlistBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.orderlistBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.orderlistBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.orderlistBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.orderlistBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.orderlistBindingNavigator.Name = "orderlistBindingNavigator";
            this.orderlistBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.orderlistBindingNavigator.Size = new System.Drawing.Size(394, 38);
            this.orderlistBindingNavigator.TabIndex = 4;
            this.orderlistBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(34, 20);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(34, 20);
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
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 31);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(65, 25);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // orderlistBindingNavigatorSaveItem
            // 
            this.orderlistBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.orderlistBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("orderlistBindingNavigatorSaveItem.Image")));
            this.orderlistBindingNavigatorSaveItem.Name = "orderlistBindingNavigatorSaveItem";
            this.orderlistBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.orderlistBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.orderlistBindingNavigatorSaveItem.Click += new System.EventHandler(this.orderlistBindingNavigatorSaveItem_Click);
            // 
            // id_orderLabel
            // 
            id_orderLabel.AutoSize = true;
            id_orderLabel.Location = new System.Drawing.Point(40, 144);
            id_orderLabel.Name = "id_orderLabel";
            id_orderLabel.Size = new System.Drawing.Size(66, 20);
            id_orderLabel.TabIndex = 4;
            id_orderLabel.Text = "id order:";
            // 
            // id_orderTextBox
            // 
            this.id_orderTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderlistBindingSource, "id_order", true));
            this.id_orderTextBox.Location = new System.Drawing.Point(112, 141);
            this.id_orderTextBox.Name = "id_orderTextBox";
            this.id_orderTextBox.Size = new System.Drawing.Size(100, 26);
            this.id_orderTextBox.TabIndex = 5;
            // 
            // id_bookLabel
            // 
            id_bookLabel.AutoSize = true;
            id_bookLabel.Location = new System.Drawing.Point(42, 176);
            id_bookLabel.Name = "id_bookLabel";
            id_bookLabel.Size = new System.Drawing.Size(64, 20);
            id_bookLabel.TabIndex = 5;
            id_bookLabel.Text = "id book:";
            // 
            // id_bookTextBox
            // 
            this.id_bookTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderlistBindingSource, "id_book", true));
            this.id_bookTextBox.Location = new System.Drawing.Point(112, 173);
            this.id_bookTextBox.Name = "id_bookTextBox";
            this.id_bookTextBox.Size = new System.Drawing.Size(100, 26);
            this.id_bookTextBox.TabIndex = 6;
            // 
            // id_publLabel
            // 
            id_publLabel.AutoSize = true;
            id_publLabel.Location = new System.Drawing.Point(38, 208);
            id_publLabel.Name = "id_publLabel";
            id_publLabel.Size = new System.Drawing.Size(59, 20);
            id_publLabel.TabIndex = 6;
            id_publLabel.Text = "id publ:";
            // 
            // id_publTextBox
            // 
            this.id_publTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderlistBindingSource, "id_publ", true));
            this.id_publTextBox.Location = new System.Drawing.Point(103, 205);
            this.id_publTextBox.Name = "id_publTextBox";
            this.id_publTextBox.Size = new System.Drawing.Size(109, 26);
            this.id_publTextBox.TabIndex = 7;
            // 
            // countsLabel
            // 
            countsLabel.AutoSize = true;
            countsLabel.Location = new System.Drawing.Point(45, 240);
            countsLabel.Name = "countsLabel";
            countsLabel.Size = new System.Drawing.Size(61, 20);
            countsLabel.TabIndex = 8;
            countsLabel.Text = "counts:";
            // 
            // countsTextBox
            // 
            this.countsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderlistBindingSource, "counts", true));
            this.countsTextBox.Location = new System.Drawing.Point(112, 237);
            this.countsTextBox.Name = "countsTextBox";
            this.countsTextBox.Size = new System.Drawing.Size(100, 26);
            this.countsTextBox.TabIndex = 9;
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new System.Drawing.Point(39, 272);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(47, 20);
            priceLabel.TabIndex = 10;
            priceLabel.Text = "price:";
            // 
            // priceTextBox
            // 
            this.priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderlistBindingSource, "price", true));
            this.priceTextBox.Location = new System.Drawing.Point(92, 269);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(120, 26);
            this.priceTextBox.TabIndex = 11;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 357);
            this.Controls.Add(priceLabel);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(countsLabel);
            this.Controls.Add(this.countsTextBox);
            this.Controls.Add(id_publLabel);
            this.Controls.Add(this.id_publTextBox);
            this.Controls.Add(id_bookLabel);
            this.Controls.Add(this.id_bookTextBox);
            this.Controls.Add(id_orderLabel);
            this.Controls.Add(this.id_orderTextBox);
            this.Controls.Add(this.orderlistBindingNavigator);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form5";
            this.Text = "Таблица \"Заказы\"";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.booksDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderlistBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderlistBindingNavigator)).EndInit();
            this.orderlistBindingNavigator.ResumeLayout(false);
            this.orderlistBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private booksDataSet booksDataSet;
        private System.Windows.Forms.BindingSource orderlistBindingSource;
        private booksDataSetTableAdapters.orderlistTableAdapter orderlistTableAdapter;
        private booksDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator orderlistBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton orderlistBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox id_orderTextBox;
        private System.Windows.Forms.TextBox id_bookTextBox;
        private System.Windows.Forms.TextBox id_publTextBox;
        private System.Windows.Forms.TextBox countsTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
    }
}