/*
 * Created by SharpDevelop.
 * User: Alumnos
 * Date: 01/11/2013
 * Time: 01:11 a.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace practica6
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.id1 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.id2 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.id3 = new System.Windows.Forms.RadioButton();
			this.id4 = new System.Windows.Forms.RadioButton();
			this.id5 = new System.Windows.Forms.RadioButton();
			this.label4 = new System.Windows.Forms.Label();
			this.id6 = new System.Windows.Forms.CheckBox();
			this.id7 = new System.Windows.Forms.CheckBox();
			this.id8 = new System.Windows.Forms.CheckBox();
			this.id9 = new System.Windows.Forms.CheckBox();
			this.id10 = new System.Windows.Forms.CheckBox();
			this.label5 = new System.Windows.Forms.Label();
			this.id11 = new System.Windows.Forms.NumericUpDown();
			this.label6 = new System.Windows.Forms.Label();
			this.id12 = new System.Windows.Forms.MonthCalendar();
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.id11)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(22, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Codigo";
			// 
			// id1
			// 
			this.id1.Location = new System.Drawing.Point(81, 12);
			this.id1.Name = "id1";
			this.id1.Size = new System.Drawing.Size(100, 20);
			this.id1.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(22, 40);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "Nombre";
			// 
			// id2
			// 
			this.id2.Location = new System.Drawing.Point(81, 43);
			this.id2.Name = "id2";
			this.id2.Size = new System.Drawing.Size(100, 20);
			this.id2.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(12, 77);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 4;
			this.label3.Text = "1.Capital de Mexico";
			// 
			// id3
			// 
			this.id3.Location = new System.Drawing.Point(12, 103);
			this.id3.Name = "id3";
			this.id3.Size = new System.Drawing.Size(104, 24);
			this.id3.TabIndex = 5;
			this.id3.TabStop = true;
			this.id3.Text = "DF";
			this.id3.UseVisualStyleBackColor = true;
			// 
			// id4
			// 
			this.id4.Location = new System.Drawing.Point(54, 103);
			this.id4.Name = "id4";
			this.id4.Size = new System.Drawing.Size(104, 24);
			this.id4.TabIndex = 6;
			this.id4.TabStop = true;
			this.id4.Text = "Guadalajara";
			this.id4.UseVisualStyleBackColor = true;
			this.id4.CheckedChanged += new System.EventHandler(this.RadioButton2CheckedChanged);
			// 
			// id5
			// 
			this.id5.Location = new System.Drawing.Point(134, 103);
			this.id5.Name = "id5";
			this.id5.Size = new System.Drawing.Size(104, 24);
			this.id5.TabIndex = 7;
			this.id5.TabStop = true;
			this.id5.Text = "Monterrey";
			this.id5.UseVisualStyleBackColor = true;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(12, 152);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 8;
			this.label4.Text = "2.Pais de Europa";
			// 
			// id6
			// 
			this.id6.Location = new System.Drawing.Point(22, 178);
			this.id6.Name = "id6";
			this.id6.Size = new System.Drawing.Size(104, 24);
			this.id6.TabIndex = 9;
			this.id6.Text = "Portugal";
			this.id6.UseVisualStyleBackColor = true;
			// 
			// id7
			// 
			this.id7.Location = new System.Drawing.Point(22, 198);
			this.id7.Name = "id7";
			this.id7.Size = new System.Drawing.Size(104, 24);
			this.id7.TabIndex = 10;
			this.id7.Text = "Chile";
			this.id7.UseVisualStyleBackColor = true;
			// 
			// id8
			// 
			this.id8.Location = new System.Drawing.Point(22, 218);
			this.id8.Name = "id8";
			this.id8.Size = new System.Drawing.Size(104, 24);
			this.id8.TabIndex = 11;
			this.id8.Text = "Reino Unido";
			this.id8.UseVisualStyleBackColor = true;
			// 
			// id9
			// 
			this.id9.Location = new System.Drawing.Point(22, 238);
			this.id9.Name = "id9";
			this.id9.Size = new System.Drawing.Size(104, 24);
			this.id9.TabIndex = 12;
			this.id9.Text = "Macedonia";
			this.id9.UseVisualStyleBackColor = true;
			// 
			// id10
			// 
			this.id10.Location = new System.Drawing.Point(22, 259);
			this.id10.Name = "id10";
			this.id10.Size = new System.Drawing.Size(104, 24);
			this.id10.TabIndex = 13;
			this.id10.Text = "Autralia";
			this.id10.UseVisualStyleBackColor = true;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(12, 363);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(315, 23);
			this.label5.TabIndex = 14;
			this.label5.Text = "3.Cantidad de los estados de los que se Compone Mexico";
			// 
			// id11
			// 
			this.id11.Location = new System.Drawing.Point(22, 389);
			this.id11.Name = "id11";
			this.id11.Size = new System.Drawing.Size(49, 20);
			this.id11.TabIndex = 15;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(184, 141);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(249, 23);
			this.label6.TabIndex = 16;
			this.label6.Text = "4.Dia en que termino la segunda guerra mundial";
			// 
			// id12
			// 
			this.id12.Location = new System.Drawing.Point(200, 173);
			this.id12.Name = "id12";
			this.id12.TabIndex = 17;
			// 
			// button1
			// 
			this.button1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.button1.Location = new System.Drawing.Point(359, 362);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 18;
			this.button1.Text = "Terminar";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(445, 421);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.id12);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.id11);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.id10);
			this.Controls.Add(this.id9);
			this.Controls.Add(this.id8);
			this.Controls.Add(this.id7);
			this.Controls.Add(this.id6);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.id5);
			this.Controls.Add(this.id4);
			this.Controls.Add(this.id3);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.id2);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.id1);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "practica6";
			((System.ComponentModel.ISupportInitialize)(this.id11)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.MonthCalendar id12;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.NumericUpDown id11;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.CheckBox id10;
		private System.Windows.Forms.CheckBox id9;
		private System.Windows.Forms.CheckBox id8;
		private System.Windows.Forms.CheckBox id7;
		private System.Windows.Forms.CheckBox id6;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.RadioButton id5;
		private System.Windows.Forms.RadioButton id4;
		private System.Windows.Forms.RadioButton id3;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox id2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox id1;
		private System.Windows.Forms.Label label1;
	}
}
