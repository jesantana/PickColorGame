using System;
using System.Collections;
using System.Drawing;

namespace Colores
{
	
	public class Paleta
	{
		Colores[] a;
		
		public Paleta()
		{
			a=new Colores[12];
			InicColor();
			
		}
	
		private void InicColor(){
		a[0]=new Colores("rojo",Color.Red);
        a[1]=new Colores("azul",Color.Blue);
		a[2]=new Colores("verde",Color.Green);
		a[3]=new Colores("rosado",Color.Pink);
        a[4]=new Colores("amarillo",Color.Yellow);
		a[5]=new Colores("violeta",Color.Purple);
		a[6]=new Colores("verdeclaro",Color.LightGreen);
		a[7]=new Colores("azulclaro",Color.LightBlue);
		a[8]=new Colores("carmelita",Color.Brown);
		a[9]=new Colores("naranja",Color.Orange);
		a[10]=new Colores("negro",Color.Black);
		a[11]=new Colores("blanco",Color.White);
		}
		
		public int Largo{
			get{return a.Length;}
		}
	
		public virtual void Llena(Colores[] c){
		if(c==null)throw new ArgumentNullException("Imposible rellenar arreglo nulo");
		if(c.Length>a.Length)throw new Exception();
		for(int i=0;i<c.Length;i++)
			c[i]=a[i];

		}
		
		public virtual void LlenaAleatoriamente(Colores[] c,int hasta){
			int x=0;
			if(c==null)throw new ArgumentNullException("Imposible rellenar arreglo nulo");
			if(c.Length>a.Length)throw new Exception();
			
				for(int i=0;i<c.Length;i++){
						x=new Random().Next(hasta+1);
			c[i]=a[x];}
			
		}

		public virtual void LlenaAleatoriamenteSinRep(Colores[] c,int hasta){
			int[] arr=new int[c.Length];
			int mark=0;
			int x=0;

			
				for(int i=0;i<c.Length;i++)
				{
					
					do
					{
						x=new Random().Next(hasta);
					}while(this.Pertenece(arr,x,mark));
					arr[mark++]=x;
					c[i]=a[x];
				}
			}
		
	
		
		protected virtual bool Pertenece(int[] arr,int elem,int hasta){
		for(int j=0;j<hasta;j++)
			if(arr[j]==elem)return true;
		return false;
		}
		
		public Colores this[int i]{
			get{return a[i];}
		}
	
	}
}
