/*
 * Created by SharpDevelop.
 * User: CAI
 * Date: 16/10/2018
 * Time: 01:34 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections;
using System.Collections.Generic;

namespace micritos
{
	/// <summary>
	/// Description of recorridos.
	/// </summary>
	public class recorridos
	{
		
		public recorridos(List<terminal> lista_terminales){
			List<terminal> lista_izq=new List<terminal>(lista_terminales);
			List<terminal> lista_der=new List<terminal>();
			int opcion;
			Console.WriteLine("Seleccione las terminales y oprima 0 para finalizar.");
			lista_izq=lista_terminales;
			do{
			int puntero=1;
			for(int i= 0;i<=lista_izq.Count-1;i++){
				Console.WriteLine(puntero + ")" + lista_izq[i].Terminal);
				puntero++;
			}
			opcion=int.Parse(Console.ReadLine());
			}while(opcion != 0);
		}
	}
}
