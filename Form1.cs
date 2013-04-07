using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Colores
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		private System.Windows.Forms.PictureBox posibles;
		private System.Windows.Forms.PictureBox pregunta;
		private System.Windows.Forms.PictureBox respuesta;
		Juego1 game;
		Point flagpos,flagpreg;
		Colores[] aux;
		int marca;
		int h;
		private System.Windows.Forms.Button button1;
		bool poslock;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.MenuItem menuItem3;
		private System.Windows.Forms.MenuItem menuItem4;
		private System.Windows.Forms.MenuItem menuItem5;
		private System.Windows.Forms.MenuItem menuItem6;
		private System.Windows.Forms.MenuItem menuItem7;
		private System.Windows.Forms.MenuItem menuItem8;
		private System.Windows.Forms.MenuItem menuItem9;
		private System.Windows.Forms.MenuItem menuItem10;
		private System.Windows.Forms.MenuItem menuItem11;
		private System.Windows.Forms.MenuItem menuItem12;
		private System.Windows.Forms.MenuItem menuItem13;
		private System.Windows.Forms.MenuItem menuItem14;
		private System.Windows.Forms.MenuItem menuItem15;
		private System.Windows.Forms.MenuItem menuItem16;
		private System.Windows.Forms.MenuItem menuItem17;
		private System.Windows.Forms.MenuItem menuItem18;
		private System.Windows.Forms.MenuItem menuItem19;
		Paleta p;
		int colpos,colreal;
		

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			
			InitializeComponent();
			colpos=6;
			colreal=4;
			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.posibles = new System.Windows.Forms.PictureBox();
			this.pregunta = new System.Windows.Forms.PictureBox();
			this.respuesta = new System.Windows.Forms.PictureBox();
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.menuItem2 = new System.Windows.Forms.MenuItem();
			this.menuItem3 = new System.Windows.Forms.MenuItem();
			this.menuItem4 = new System.Windows.Forms.MenuItem();
			this.menuItem5 = new System.Windows.Forms.MenuItem();
			this.menuItem6 = new System.Windows.Forms.MenuItem();
			this.menuItem7 = new System.Windows.Forms.MenuItem();
			this.menuItem8 = new System.Windows.Forms.MenuItem();
			this.menuItem9 = new System.Windows.Forms.MenuItem();
			this.menuItem10 = new System.Windows.Forms.MenuItem();
			this.menuItem11 = new System.Windows.Forms.MenuItem();
			this.menuItem12 = new System.Windows.Forms.MenuItem();
			this.menuItem13 = new System.Windows.Forms.MenuItem();
			this.menuItem14 = new System.Windows.Forms.MenuItem();
			this.menuItem15 = new System.Windows.Forms.MenuItem();
			this.menuItem16 = new System.Windows.Forms.MenuItem();
			this.menuItem17 = new System.Windows.Forms.MenuItem();
			this.menuItem18 = new System.Windows.Forms.MenuItem();
			this.menuItem19 = new System.Windows.Forms.MenuItem();
			this.SuspendLayout();
			// 
			// posibles
			// 
			this.posibles.BackColor = System.Drawing.Color.Silver;
			this.posibles.Location = new System.Drawing.Point(55, 392);
			this.posibles.Name = "posibles";
			this.posibles.Size = new System.Drawing.Size(536, 56);
			this.posibles.TabIndex = 6;
			this.posibles.TabStop = false;
			this.posibles.Paint += new System.Windows.Forms.PaintEventHandler(this.posibles_Paint_1);
			this.posibles.MouseDown += new System.Windows.Forms.MouseEventHandler(this.posibles_MouseDown);
			// 
			// pregunta
			// 
			this.pregunta.BackColor = System.Drawing.Color.Silver;
			this.pregunta.Location = new System.Drawing.Point(327, 15);
			this.pregunta.Name = "pregunta";
			this.pregunta.Size = new System.Drawing.Size(250, 360);
			this.pregunta.TabIndex = 5;
			this.pregunta.TabStop = false;
			this.pregunta.Paint += new System.Windows.Forms.PaintEventHandler(this.pregunta_Paint);
			this.pregunta.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pregunta_MouseDown);
			// 
			// respuesta
			// 
			this.respuesta.BackColor = System.Drawing.Color.Silver;
			this.respuesta.Location = new System.Drawing.Point(55, 15);
			this.respuesta.Name = "respuesta";
			this.respuesta.Size = new System.Drawing.Size(250, 360);
			this.respuesta.TabIndex = 4;
			this.respuesta.TabStop = false;
			this.respuesta.Paint += new System.Windows.Forms.PaintEventHandler(this.respuesta_Paint);
			// 
			// button1
			// 
			this.button1.ForeColor = System.Drawing.Color.Black;
			this.button1.Location = new System.Drawing.Point(56, 456);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(152, 32);
			this.button1.TabIndex = 7;
			this.button1.Text = "&Revisar!!!";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label1
			// 
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(240, 464);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(384, 24);
			this.label1.TabIndex = 8;
			this.label1.Text = "label1";
			// 
			// mainMenu1
			// 
			this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem1,
																					  this.menuItem3,
																					  this.menuItem6});
			// 
			// menuItem1
			// 
			this.menuItem1.Index = 0;
			this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem2});
			this.menuItem1.Text = "Archivo";
			// 
			// menuItem2
			// 
			this.menuItem2.Index = 0;
			this.menuItem2.Text = "Salir";
			// 
			// menuItem3
			// 
			this.menuItem3.Index = 1;
			this.menuItem3.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem4,
																					  this.menuItem5});
			this.menuItem3.Text = "Opciones";
			// 
			// menuItem4
			// 
			this.menuItem4.Index = 0;
			this.menuItem4.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem8,
																					  this.menuItem9,
																					  this.menuItem10,
																					  this.menuItem11,
																					  this.menuItem12,
																					  this.menuItem13,
																					  this.menuItem14});
			this.menuItem4.Text = "Colores posibles";
			// 
			// menuItem5
			// 
			this.menuItem5.Index = 1;
			this.menuItem5.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem15,
																					  this.menuItem16,
																					  this.menuItem17,
																					  this.menuItem18,
																					  this.menuItem19});
			this.menuItem5.Text = "Colores reales";
			// 
			// menuItem6
			// 
			this.menuItem6.Index = 2;
			this.menuItem6.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem7});
			this.menuItem6.Text = "Ayuda";
			// 
			// menuItem7
			// 
			this.menuItem7.Index = 0;
			this.menuItem7.Text = "Acerca de ...";
			// 
			// menuItem8
			// 
			this.menuItem8.Index = 0;
			this.menuItem8.Text = "6";
			this.menuItem8.Click += new System.EventHandler(this.menuItem8_Click);
			// 
			// menuItem9
			// 
			this.menuItem9.Index = 1;
			this.menuItem9.Text = "7";
			this.menuItem9.Click += new System.EventHandler(this.menuItem8_Click);
			// 
			// menuItem10
			// 
			this.menuItem10.Index = 2;
			this.menuItem10.Text = "8";
			this.menuItem10.Click += new System.EventHandler(this.menuItem8_Click);
			// 
			// menuItem11
			// 
			this.menuItem11.Index = 3;
			this.menuItem11.Text = "9";
			this.menuItem11.Click += new System.EventHandler(this.menuItem8_Click);
			// 
			// menuItem12
			// 
			this.menuItem12.Index = 4;
			this.menuItem12.Text = "10";
			this.menuItem12.Click += new System.EventHandler(this.menuItem8_Click);
			// 
			// menuItem13
			// 
			this.menuItem13.Index = 5;
			this.menuItem13.Text = "11";
			this.menuItem13.Click += new System.EventHandler(this.menuItem8_Click);
			// 
			// menuItem14
			// 
			this.menuItem14.Index = 6;
			this.menuItem14.Text = "12";
			this.menuItem14.Click += new System.EventHandler(this.menuItem8_Click);
			// 
			// menuItem15
			// 
			this.menuItem15.Index = 0;
			this.menuItem15.Text = "4";
			this.menuItem15.Click += new System.EventHandler(this.menuItem15_Click);
			// 
			// menuItem16
			// 
			this.menuItem16.Index = 1;
			this.menuItem16.Text = "5";
			this.menuItem16.Click += new System.EventHandler(this.menuItem15_Click);
			// 
			// menuItem17
			// 
			this.menuItem17.Index = 2;
			this.menuItem17.Text = "6";
			this.menuItem17.Click += new System.EventHandler(this.menuItem15_Click);
			// 
			// menuItem18
			// 
			this.menuItem18.Index = 3;
			this.menuItem18.Text = "7";
			this.menuItem18.Click += new System.EventHandler(this.menuItem15_Click);
			// 
			// menuItem19
			// 
			this.menuItem19.Index = 4;
			this.menuItem19.Text = "8";
			this.menuItem19.Click += new System.EventHandler(this.menuItem15_Click);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(728, 510);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.label1,
																		  this.button1,
																		  this.posibles,
																		  this.pregunta,
																		  this.respuesta});
			this.ForeColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.Menu = this.mainMenu1;
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}
		
		private void DibujaFlecha(Graphics g,Point p){
		Pen b=new Pen(Color.Black);
		b.Width=3;
		g.DrawLine(b,p.X,p.Y,p.X+15,p.Y-5);
		g.DrawLine(b,p.X,p.Y,p.X+15,p.Y+5);
		g.DrawLine(b,p.X,p.Y,p.X+30,p.Y);
		}

		
			
		private void Form1_Load(object sender, System.EventArgs e)
		{
			p=new Paleta();
			game=new Juego1(colpos,colreal,p);
			aux=new Colores[game.Preguntas[0].Length];
			flagpreg=new Point(-100,-100);
			flagpos=flagpreg;
			marca=0;
			poslock=true;
			pregunta.Width=30*game.Ancho;
            respuesta.Width=30*game.Ancho;
			this.posibles.Width=pregunta.Left+pregunta.Width-respuesta.Left;
			this.posibles.Height=posibles.Width/game.PosiblesColores.Length-10;
			h=posibles.Width/game.PosiblesColores.Length;
			string s="";
			for(int i=0;i<game.answer.Length;i++)
			s=s+game.answer[i].Nombre+"  ";
			this.label1.Text="";
			this.label1.Text=s;
			this.posibles.Refresh();
			this.Refresh();
		}

		private void respuesta_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
			Graphics g=e.Graphics;
			SolidBrush b=new SolidBrush(Color.Wheat);
			for(int i=0;i<game.Respuestas.Length;i++)
			{
				for(int j=0;j<game.Respuestas[0].Length;j++)
				{
					if(game.Respuestas[i][j]==null) 
					{
						b.Color=Color.Gray;
						g.FillEllipse(b,(j*30)+5,(i*30)+5,10,10);}
					else 
					{
						b.Color=game.Respuestas[i][j].Codigo;
						g.FillEllipse(b,(j*30)+5,(i*30)+5,20,20); }
				}
			}
		
		}

		private void pregunta_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
			Graphics g=e.Graphics;
			SolidBrush b=new SolidBrush(Color.Gray);
			for(int i=0;i<game.Preguntas.Length;i++)
			{
				if(i==game.Altura)
				{
					for(int j=0;j<game.Preguntas[0].Length;j++)
					{
						if(this.aux[j]==null)
						{
							b.Color=Color.Gray;
							g.FillEllipse(b,(j*30)+5,(i*30)+5,20,20);}
						else
						{
							b.Color=aux[j].Codigo;
							g.FillEllipse(b,(j*30)+5,(i*30)+5,25,25); }
					}
				}
				
				else
				{
					for(int j=0;j<game.Preguntas[0].Length;j++)
					 {
						 if(game.Preguntas[i][j]==null)
						 {
							 b.Color=Color.Gray;
							 g.FillEllipse(b,(j*30)+5,(i*30)+5,20,20);}
						 else
						 {
							 b.Color=game.Preguntas[i][j].Codigo;
							 g.FillEllipse(b,(j*30)+5,(i*30)+5,25,25); }
					 }
					 }
			}
		}

		private void posibles_Paint_1(object sender, System.Windows.Forms.PaintEventArgs e)
		{
			Graphics g=e.Graphics;
			SolidBrush b;
			
			for(int i=0;i<game.PosiblesColores.Length;i++)
			{
				b=new SolidBrush(game.PosiblesColores[i].Codigo);
				g.FillEllipse(b,i*h+5,0,h-10,h-10);
			
			}
		}

		private void pregunta_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if(e.Button==MouseButtons.Left){
			
				if(Math.Abs(flagpreg.X-e.X)<=2 && Math.Abs(flagpreg.Y-e.Y)<=2) 
				{
					if(e.Y/30==game.Altura)
					{
						this.aux[e.X/30]=null;marca=e.X/30;
						this.Refresh();
						flagpreg.X=-100;
						flagpreg.Y=-100;
					}
					}	
				else
				{
					flagpreg.X=e.X;
					flagpreg.Y=e.Y;}
			}
		}

		private void posibles_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if(e.Button==MouseButtons.Left)
			{
				if(poslock && Math.Abs(flagpos.X-e.X)<=2 && Math.Abs(flagpos.Y-e.Y)<=2) 
				{
				aux[marca]=game.PosiblesColores[e.X/h];
				poslock=this.AvanzaLaMarca();
				this.Refresh();
				flagpos.X=-100;
				flagpos.Y=-100;
				}	
				else
				{
					flagpos.X=e.X;
					flagpos.Y=e.Y;}
			}
		
		}

		
		private bool AvanzaLaMarca(){
		for(int i=marca;i<aux.Length;i++)
			if(aux[i]==null){marca=i;return true;}
		marca=0;
		return false;
		
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			int x=game.EvaluaCol(aux);
			this.respuesta.Refresh();
			if(x==0)
			{
				poslock=true;
				aux=new Colores[game.Preguntas[0].Length];
				this.Refresh();
				}
			else if(x==1)
			{
				int intentos=12-game.Altura;
				Dialogo d=new Dialogo("Has ganado en "+intentos+" intentos");
				d.ShowDialog();
				this.OnLoad(new EventArgs());
      		}
			else
			{
				Dialogo d=new Dialogo("Has consumido todas tus posibilidades, Tu pierdes");
				d.ShowDialog();
				
				this.OnLoad(new EventArgs());
				this.Refresh();
			}
		}

		private void Form1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
			this.DibujaFlecha(e.Graphics,new Point(5+this.pregunta.Left+this.pregunta.Width,this.pregunta.Top+game.Altura*30+15));

		}

		private void menuItem8_Click(object sender, System.EventArgs e)
		{
		
		colpos=int.Parse(((MenuItem)sender).Text);
		this.OnLoad(new EventArgs());
         }

		private void menuItem15_Click(object sender, System.EventArgs e)
		{
			colreal=int.Parse(((MenuItem)sender).Text);
			this.OnLoad(new EventArgs());
		}
		
	}
}
