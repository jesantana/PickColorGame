using System;
using System.Drawing;
using System.Collections;

namespace Colores
{
	/// <summary>
	/// Summary description for Juego.
	/// </summary>
	public class Juego1
	{
		Colores[] colpos;
		Colores[][] colres;
		Colores[][] puntos;
		public Colores[] answer;
		int altura;
		
		public Juego1(int posibles,int reales,Paleta p,int largo)
		{
			if(posibles<6) posibles=6;
			else if(posibles>12) posibles=12;
			if(reales<4) reales=4;
			else if(reales>8)reales=8;
			
			colpos=new Colores[posibles];
			colres=new Colores[largo][];
			puntos=new Colores[largo][];
			for(int i=0;i<largo;i++){
			colres[i]=new Colores[reales];
			puntos[i]=new Colores[reales];
			}
		answer=new Colores[reales];
			p.Llena(colpos);
			p.LlenaAleatoriamenteSinRep(answer,colpos.Length-1);
			altura=largo-1;
		}
		public Juego1(int posibles,int reales,Paleta p):this(posibles,reales,p,12){;}
		
		public Colores[] PosiblesColores
		{
			get{return this.colpos;}
		}
	
		public virtual int EvaluaCol(Colores[] resp)
		{
			bool[] marcans=new bool[resp.Length];
			bool[] marcresp=new bool[resp.Length];
			int inc=0;int negros=0;
			int x=new Random().Next(resp.Length);
			for(int i=0;i<resp.Length;i++)
			{
				if(this.answer[(x+i)%resp.Length]==resp[(x+i)%resp.Length])
				{
				marcans[(x+i)%resp.Length]=true;
				marcresp[(x+i)%resp.Length]=true;
				this.puntos[this.altura][inc++]=new Colores("negro",Color.Black);
				negros++;
				}
			}
			if(negros==resp.Length)return 1;
			for(int i=0;i<resp.Length;i++)
			{
				if(!marcans[(x+i)%resp.Length])
				{
					for(int j=0;j<resp.Length;j++)
					{
						if(this.answer[(x+i)%resp.Length]==resp[(x+j)%resp.Length] && !marcresp[(x+j)%resp.Length])
						{
							marcans[(x+i)%resp.Length]=true;
							marcresp[(x+j)%resp.Length]=true;
							this.puntos[this.altura][inc++]=new Colores("blanco",Color.White);
							break;
						}
					}
				}
			}
		this.colres[altura]=resp;
		this.altura--;
		if(altura!=-1)return 0;
		return -1;
	}
		public int Ancho{
			get {return answer.Length;}
		}
		public Colores[][] Preguntas{
			get{return colres;}
		}
		public Colores[][] Respuestas{
			get{return puntos;}
		}
		public int Altura{
			get{return altura;}
		}
	}
}