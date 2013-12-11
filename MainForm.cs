
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace practica6
{
	
	public partial class MainForm : Form
	{
		public int acierto = 0;
		
		public MainForm()
		{
			InitializeComponent();
		}
		
		void RadioButton2CheckedChanged(object sender, EventArgs e)
		{	
		}
		void Button1Click(object sender, EventArgs e)
		{
			string codigo = id1.Text;
			string nombre = id2.Text;
						
			if(this.id3.Checked){
				acierto ++;
			}
			if(this.id4.Checked){
				//acierto ++;
			}
			if(this.id5.Checked){
				//acierto ++;
			}
			if(this.id6.Checked){
				acierto ++;
			}
			if(this.id7.Checked){
				acierto ++;
			}
			if(this.id8.Checked){
				acierto ++;
			}
			if(this.id9.Checked){
				acierto ++;
			}
			if(this.id10.Checked){
				acierto ++;
			}
			
			if(this.id11.Text == "31"){
	       	acierto ++;
	       }
	       if (id12.SelectionEnd.ToShortDateString() == "07/05/1945"){
	       acierto ++;
	       }
	
			MessageBox.Show("Codigo:"+codigo + "\nNombre:"+nombre +"\nAciertos:" + acierto);
			
			acierto=0;
		}
	}
}
