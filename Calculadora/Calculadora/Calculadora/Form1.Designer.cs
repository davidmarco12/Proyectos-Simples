namespace Calculadora
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.versionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMC = new System.Windows.Forms.Button();
            this.siete = new System.Windows.Forms.Button();
            this.raiz = new System.Windows.Forms.Button();
            this.Signo = new System.Windows.Forms.Button();
            this.BorrarTodo = new System.Windows.Forms.Button();
            this.borrarAct = new System.Windows.Forms.Button();
            this.borrarNum = new System.Windows.Forms.Button();
            this.btnMmenos = new System.Windows.Forms.Button();
            this.btnMmas = new System.Windows.Forms.Button();
            this.btnMS = new System.Windows.Forms.Button();
            this.btnMR = new System.Windows.Forms.Button();
            this.cuatro = new System.Windows.Forms.Button();
            this.porcentaje = new System.Windows.Forms.Button();
            this.div = new System.Windows.Forms.Button();
            this.nueve = new System.Windows.Forms.Button();
            this.ocho = new System.Windows.Forms.Button();
            this.cinco = new System.Windows.Forms.Button();
            this.seis = new System.Windows.Forms.Button();
            this.multi = new System.Windows.Forms.Button();
            this.Inverso = new System.Windows.Forms.Button();
            this.igual = new System.Windows.Forms.Button();
            this.uno = new System.Windows.Forms.Button();
            this.dos = new System.Windows.Forms.Button();
            this.tres = new System.Windows.Forms.Button();
            this.resta = new System.Windows.Forms.Button();
            this.cero = new System.Windows.Forms.Button();
            this.coma = new System.Windows.Forms.Button();
            this.suma = new System.Windows.Forms.Button();
            this.lblNum = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ayudaToolStripMenuItem,
            this.versionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(230, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            this.ayudaToolStripMenuItem.Click += new System.EventHandler(this.ayudaToolStripMenuItem_Click);
            // 
            // versionToolStripMenuItem
            // 
            this.versionToolStripMenuItem.Name = "versionToolStripMenuItem";
            this.versionToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.versionToolStripMenuItem.Text = "Version";
            this.versionToolStripMenuItem.Click += new System.EventHandler(this.versionToolStripMenuItem_Click);
            // 
            // btnMC
            // 
            this.btnMC.Location = new System.Drawing.Point(12, 79);
            this.btnMC.Name = "btnMC";
            this.btnMC.Size = new System.Drawing.Size(38, 29);
            this.btnMC.TabIndex = 1;
            this.btnMC.Text = "MC";
            this.btnMC.UseVisualStyleBackColor = true;
            this.btnMC.Click += new System.EventHandler(this.btnMC_Click);
            // 
            // siete
            // 
            this.siete.Location = new System.Drawing.Point(12, 149);
            this.siete.Name = "siete";
            this.siete.Size = new System.Drawing.Size(38, 29);
            this.siete.TabIndex = 2;
            this.siete.Text = "7";
            this.siete.UseVisualStyleBackColor = true;
            this.siete.Click += new System.EventHandler(this.siete_Click);
            // 
            // raiz
            // 
            this.raiz.Location = new System.Drawing.Point(185, 114);
            this.raiz.Name = "raiz";
            this.raiz.Size = new System.Drawing.Size(38, 29);
            this.raiz.TabIndex = 3;
            this.raiz.Text = "√";
            this.raiz.UseVisualStyleBackColor = true;
            this.raiz.Click += new System.EventHandler(this.raiz_Click);
            // 
            // Signo
            // 
            this.Signo.Location = new System.Drawing.Point(144, 114);
            this.Signo.Name = "Signo";
            this.Signo.Size = new System.Drawing.Size(38, 29);
            this.Signo.TabIndex = 4;
            this.Signo.Text = "+-";
            this.Signo.UseVisualStyleBackColor = true;
            this.Signo.Click += new System.EventHandler(this.Signo_Click);
            // 
            // BorrarTodo
            // 
            this.BorrarTodo.Location = new System.Drawing.Point(100, 114);
            this.BorrarTodo.Name = "BorrarTodo";
            this.BorrarTodo.Size = new System.Drawing.Size(38, 29);
            this.BorrarTodo.TabIndex = 5;
            this.BorrarTodo.Text = "C";
            this.BorrarTodo.UseVisualStyleBackColor = true;
            this.BorrarTodo.Click += new System.EventHandler(this.BorrarTodo_Click);
            // 
            // borrarAct
            // 
            this.borrarAct.Location = new System.Drawing.Point(56, 114);
            this.borrarAct.Name = "borrarAct";
            this.borrarAct.Size = new System.Drawing.Size(38, 29);
            this.borrarAct.TabIndex = 6;
            this.borrarAct.Text = "CE";
            this.borrarAct.UseVisualStyleBackColor = true;
            this.borrarAct.Click += new System.EventHandler(this.borrarAct_Click);
            // 
            // borrarNum
            // 
            this.borrarNum.Location = new System.Drawing.Point(12, 114);
            this.borrarNum.Name = "borrarNum";
            this.borrarNum.Size = new System.Drawing.Size(38, 29);
            this.borrarNum.TabIndex = 7;
            this.borrarNum.Text = "<--";
            this.borrarNum.UseVisualStyleBackColor = true;
            this.borrarNum.Click += new System.EventHandler(this.borrarNum_Click);
            // 
            // btnMmenos
            // 
            this.btnMmenos.Location = new System.Drawing.Point(185, 79);
            this.btnMmenos.Name = "btnMmenos";
            this.btnMmenos.Size = new System.Drawing.Size(38, 29);
            this.btnMmenos.TabIndex = 8;
            this.btnMmenos.Text = "M-";
            this.btnMmenos.UseVisualStyleBackColor = true;
            this.btnMmenos.Click += new System.EventHandler(this.btnMmenos_Click);
            // 
            // btnMmas
            // 
            this.btnMmas.Location = new System.Drawing.Point(144, 79);
            this.btnMmas.Name = "btnMmas";
            this.btnMmas.Size = new System.Drawing.Size(38, 29);
            this.btnMmas.TabIndex = 9;
            this.btnMmas.Text = "M+";
            this.btnMmas.UseVisualStyleBackColor = true;
            this.btnMmas.Click += new System.EventHandler(this.btnMmas_Click);
            // 
            // btnMS
            // 
            this.btnMS.Location = new System.Drawing.Point(100, 79);
            this.btnMS.Name = "btnMS";
            this.btnMS.Size = new System.Drawing.Size(38, 29);
            this.btnMS.TabIndex = 10;
            this.btnMS.Text = "MS";
            this.btnMS.UseVisualStyleBackColor = true;
            this.btnMS.Click += new System.EventHandler(this.btnMS_Click);
            // 
            // btnMR
            // 
            this.btnMR.Location = new System.Drawing.Point(56, 79);
            this.btnMR.Name = "btnMR";
            this.btnMR.Size = new System.Drawing.Size(38, 29);
            this.btnMR.TabIndex = 11;
            this.btnMR.Text = "MR";
            this.btnMR.UseVisualStyleBackColor = true;
            this.btnMR.Click += new System.EventHandler(this.btnMR_Click);
            // 
            // cuatro
            // 
            this.cuatro.Location = new System.Drawing.Point(12, 184);
            this.cuatro.Name = "cuatro";
            this.cuatro.Size = new System.Drawing.Size(38, 29);
            this.cuatro.TabIndex = 12;
            this.cuatro.Text = "4";
            this.cuatro.UseVisualStyleBackColor = true;
            this.cuatro.Click += new System.EventHandler(this.cuatro_Click);
            // 
            // porcentaje
            // 
            this.porcentaje.Location = new System.Drawing.Point(185, 149);
            this.porcentaje.Name = "porcentaje";
            this.porcentaje.Size = new System.Drawing.Size(38, 29);
            this.porcentaje.TabIndex = 13;
            this.porcentaje.Text = "%";
            this.porcentaje.UseVisualStyleBackColor = true;
            this.porcentaje.Click += new System.EventHandler(this.porcentaje_Click);
            // 
            // div
            // 
            this.div.Location = new System.Drawing.Point(144, 149);
            this.div.Name = "div";
            this.div.Size = new System.Drawing.Size(38, 29);
            this.div.TabIndex = 14;
            this.div.Text = "/";
            this.div.UseVisualStyleBackColor = true;
            this.div.Click += new System.EventHandler(this.div_Click);
            // 
            // nueve
            // 
            this.nueve.Location = new System.Drawing.Point(100, 149);
            this.nueve.Name = "nueve";
            this.nueve.Size = new System.Drawing.Size(38, 29);
            this.nueve.TabIndex = 15;
            this.nueve.Text = "9";
            this.nueve.UseVisualStyleBackColor = true;
            this.nueve.Click += new System.EventHandler(this.nueve_Click);
            // 
            // ocho
            // 
            this.ocho.Location = new System.Drawing.Point(56, 149);
            this.ocho.Name = "ocho";
            this.ocho.Size = new System.Drawing.Size(38, 29);
            this.ocho.TabIndex = 16;
            this.ocho.Text = "8";
            this.ocho.UseVisualStyleBackColor = true;
            this.ocho.Click += new System.EventHandler(this.ocho_Click);
            // 
            // cinco
            // 
            this.cinco.Location = new System.Drawing.Point(56, 184);
            this.cinco.Name = "cinco";
            this.cinco.Size = new System.Drawing.Size(38, 29);
            this.cinco.TabIndex = 17;
            this.cinco.Text = "5";
            this.cinco.UseVisualStyleBackColor = true;
            this.cinco.Click += new System.EventHandler(this.cinco_Click);
            // 
            // seis
            // 
            this.seis.Location = new System.Drawing.Point(100, 184);
            this.seis.Name = "seis";
            this.seis.Size = new System.Drawing.Size(38, 29);
            this.seis.TabIndex = 18;
            this.seis.Text = "6";
            this.seis.UseVisualStyleBackColor = true;
            this.seis.Click += new System.EventHandler(this.button18_Click);
            // 
            // multi
            // 
            this.multi.Location = new System.Drawing.Point(144, 184);
            this.multi.Name = "multi";
            this.multi.Size = new System.Drawing.Size(38, 29);
            this.multi.TabIndex = 19;
            this.multi.Text = "*";
            this.multi.UseVisualStyleBackColor = true;
            this.multi.Click += new System.EventHandler(this.multi_Click);
            // 
            // Inverso
            // 
            this.Inverso.Location = new System.Drawing.Point(185, 184);
            this.Inverso.Name = "Inverso";
            this.Inverso.Size = new System.Drawing.Size(38, 29);
            this.Inverso.TabIndex = 20;
            this.Inverso.Text = "1/x";
            this.Inverso.UseVisualStyleBackColor = true;
            this.Inverso.Click += new System.EventHandler(this.Inverso_Click);
            // 
            // igual
            // 
            this.igual.Location = new System.Drawing.Point(185, 219);
            this.igual.Name = "igual";
            this.igual.Size = new System.Drawing.Size(38, 61);
            this.igual.TabIndex = 21;
            this.igual.Text = "=";
            this.igual.UseVisualStyleBackColor = true;
            this.igual.Click += new System.EventHandler(this.igual_Click);
            // 
            // uno
            // 
            this.uno.Location = new System.Drawing.Point(12, 219);
            this.uno.Name = "uno";
            this.uno.Size = new System.Drawing.Size(38, 29);
            this.uno.TabIndex = 22;
            this.uno.Text = "1";
            this.uno.UseVisualStyleBackColor = true;
            this.uno.Click += new System.EventHandler(this.uno_Click);
            // 
            // dos
            // 
            this.dos.Location = new System.Drawing.Point(56, 219);
            this.dos.Name = "dos";
            this.dos.Size = new System.Drawing.Size(38, 29);
            this.dos.TabIndex = 23;
            this.dos.Text = "2";
            this.dos.UseVisualStyleBackColor = true;
            this.dos.Click += new System.EventHandler(this.dos_Click);
            // 
            // tres
            // 
            this.tres.Location = new System.Drawing.Point(100, 219);
            this.tres.Name = "tres";
            this.tres.Size = new System.Drawing.Size(38, 29);
            this.tres.TabIndex = 24;
            this.tres.Text = "3";
            this.tres.UseVisualStyleBackColor = true;
            this.tres.Click += new System.EventHandler(this.tres_Click);
            // 
            // resta
            // 
            this.resta.Location = new System.Drawing.Point(144, 219);
            this.resta.Name = "resta";
            this.resta.Size = new System.Drawing.Size(38, 29);
            this.resta.TabIndex = 25;
            this.resta.Text = "-";
            this.resta.UseVisualStyleBackColor = true;
            this.resta.Click += new System.EventHandler(this.resta_Click);
            // 
            // cero
            // 
            this.cero.Location = new System.Drawing.Point(12, 251);
            this.cero.Name = "cero";
            this.cero.Size = new System.Drawing.Size(82, 29);
            this.cero.TabIndex = 26;
            this.cero.Text = "0";
            this.cero.UseVisualStyleBackColor = true;
            this.cero.Click += new System.EventHandler(this.cero_Click);
            // 
            // coma
            // 
            this.coma.Location = new System.Drawing.Point(100, 251);
            this.coma.Name = "coma";
            this.coma.Size = new System.Drawing.Size(38, 29);
            this.coma.TabIndex = 27;
            this.coma.Text = ",";
            this.coma.UseVisualStyleBackColor = true;
            this.coma.Click += new System.EventHandler(this.coma_Click);
            // 
            // suma
            // 
            this.suma.Location = new System.Drawing.Point(144, 251);
            this.suma.Name = "suma";
            this.suma.Size = new System.Drawing.Size(38, 29);
            this.suma.TabIndex = 28;
            this.suma.Text = "+";
            this.suma.UseVisualStyleBackColor = true;
            this.suma.Click += new System.EventHandler(this.suma_Click);
            // 
            // lblNum
            // 
            this.lblNum.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum.Location = new System.Drawing.Point(12, 24);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(206, 38);
            this.lblNum.TabIndex = 29;
            this.lblNum.Text = "0";
            this.lblNum.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(135, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 18);
            this.label1.TabIndex = 30;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 292);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNum);
            this.Controls.Add(this.suma);
            this.Controls.Add(this.coma);
            this.Controls.Add(this.cero);
            this.Controls.Add(this.resta);
            this.Controls.Add(this.tres);
            this.Controls.Add(this.dos);
            this.Controls.Add(this.uno);
            this.Controls.Add(this.igual);
            this.Controls.Add(this.Inverso);
            this.Controls.Add(this.multi);
            this.Controls.Add(this.seis);
            this.Controls.Add(this.cinco);
            this.Controls.Add(this.ocho);
            this.Controls.Add(this.nueve);
            this.Controls.Add(this.div);
            this.Controls.Add(this.porcentaje);
            this.Controls.Add(this.cuatro);
            this.Controls.Add(this.btnMR);
            this.Controls.Add(this.btnMS);
            this.Controls.Add(this.btnMmas);
            this.Controls.Add(this.btnMmenos);
            this.Controls.Add(this.borrarNum);
            this.Controls.Add(this.borrarAct);
            this.Controls.Add(this.BorrarTodo);
            this.Controls.Add(this.Signo);
            this.Controls.Add(this.raiz);
            this.Controls.Add(this.siete);
            this.Controls.Add(this.btnMC);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora Simple";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button btnMC;
        private System.Windows.Forms.Button siete;
        private System.Windows.Forms.Button raiz;
        private System.Windows.Forms.Button Signo;
        private System.Windows.Forms.Button BorrarTodo;
        private System.Windows.Forms.Button borrarAct;
        private System.Windows.Forms.Button borrarNum;
        private System.Windows.Forms.Button btnMmenos;
        private System.Windows.Forms.Button btnMmas;
        private System.Windows.Forms.Button btnMS;
        private System.Windows.Forms.Button btnMR;
        private System.Windows.Forms.Button cuatro;
        private System.Windows.Forms.Button porcentaje;
        private System.Windows.Forms.Button div;
        private System.Windows.Forms.Button nueve;
        private System.Windows.Forms.Button ocho;
        private System.Windows.Forms.Button cinco;
        private System.Windows.Forms.Button seis;
        private System.Windows.Forms.Button multi;
        private System.Windows.Forms.Button Inverso;
        private System.Windows.Forms.Button igual;
        private System.Windows.Forms.Button uno;
        private System.Windows.Forms.Button dos;
        private System.Windows.Forms.Button tres;
        private System.Windows.Forms.Button resta;
        private System.Windows.Forms.Button cero;
        private System.Windows.Forms.Button coma;
        private System.Windows.Forms.Button suma;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.ToolStripMenuItem versionToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}

