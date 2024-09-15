namespace WinFormsApp1
{
    partial class Ventas
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
            components = new System.ComponentModel.Container();
            cb_clientes = new ComboBox();
            cb_vehiculo = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            label3 = new Label();
            tx_precio = new TextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            eliminarToolStripMenuItem = new ToolStripMenuItem();
            modificarToolStripMenuItem = new ToolStripMenuItem();
            listventa = new ListView();
            bt_cancel = new Button();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // cb_clientes
            // 
            cb_clientes.FormattingEnabled = true;
            cb_clientes.Location = new Point(12, 37);
            cb_clientes.Name = "cb_clientes";
            cb_clientes.Size = new Size(130, 23);
            cb_clientes.TabIndex = 0;
            // 
            // cb_vehiculo
            // 
            cb_vehiculo.FormattingEnabled = true;
            cb_vehiculo.Location = new Point(170, 37);
            cb_vehiculo.Name = "cb_vehiculo";
            cb_vehiculo.Size = new Size(135, 23);
            cb_vehiculo.TabIndex = 1;
            cb_vehiculo.SelectedIndexChanged += cb_vehiculo_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(170, 19);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 2;
            label1.Text = "Vehiculo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 19);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 3;
            label2.Text = "Cliente";
            // 
            // button1
            // 
            button1.Location = new Point(200, 89);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 72);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 5;
            label3.Text = "Precio";
            // 
            // tx_precio
            // 
            tx_precio.Location = new Point(12, 90);
            tx_precio.Name = "tx_precio";
            tx_precio.Size = new Size(130, 23);
            tx_precio.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { eliminarToolStripMenuItem, modificarToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(126, 48);
            // 
            // eliminarToolStripMenuItem
            // 
            eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            eliminarToolStripMenuItem.Size = new Size(125, 22);
            eliminarToolStripMenuItem.Text = "Eliminar";
            // 
            // modificarToolStripMenuItem
            // 
            modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            modificarToolStripMenuItem.Size = new Size(125, 22);
            modificarToolStripMenuItem.Text = "Modificar";
            // 
            // listventa
            // 
            listventa.Location = new Point(12, 132);
            listventa.Name = "listventa";
            listventa.Size = new Size(293, 99);
            listventa.TabIndex = 7;
            listventa.UseCompatibleStateImageBehavior = false;
            // 
            // bt_cancel
            // 
            bt_cancel.Location = new Point(200, 237);
            bt_cancel.Name = "bt_cancel";
            bt_cancel.Size = new Size(75, 23);
            bt_cancel.TabIndex = 4;
            bt_cancel.Text = "Cancelar";
            bt_cancel.UseVisualStyleBackColor = true;
            bt_cancel.Click += bt_cancel_Click;
            // 
            // Ventas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(316, 276);
            Controls.Add(bt_cancel);
            Controls.Add(listventa);
            Controls.Add(tx_precio);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cb_vehiculo);
            Controls.Add(cb_clientes);
            Name = "Ventas";
            Text = "Ventas";
            Load += Ventas_Load;
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cb_clientes;
        private ComboBox cb_vehiculo;
        private Label label1;
        private Label label2;
        private Button button1;
        private Label label3;
        private TextBox tx_precio;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem eliminarToolStripMenuItem;
        private ToolStripMenuItem modificarToolStripMenuItem;
        private ListView listventa;
        private Button bt_cancel;
    }
}