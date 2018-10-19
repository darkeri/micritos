/*
 * Created by SharpDevelop.
 * User: CAI
 * Date: 16/10/2018
 * Time: 12:33 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections;

namespace micritos
{
	/// <summary>
	/// Description of omnibus.
	/// </summary>
	public class omnibus
	{
		
		private string marca,tipo;
		public string Marca{
			get{return marca;}
			set{marca=value;}
		}
		public string Tipo{
			get{return tipo;}
			set{tipo=value;}
		}
		public int Capacidad{
			get{return capacidad;}
			set{capacidad=value;}
		}
		public int Modelo{
			get{return modelo;}
			set{modelo=value;}
		}
		private int capacidad,modelo;
		public static int numero_de_unidad=0;
		public omnibus(){
				Console.WriteLine("Ingrese marca del omnibus:");
				marca=Console.ReadLine();
				Console.WriteLine("Ingrese modelo:");
			 	modelo=int.Parse(Console.ReadLine());
				Console.WriteLine("Ingrese la capacidad:");
				capacidad=int.Parse(Console.ReadLine());	
				Console.WriteLine("Ingrese tipo:");
				tipo=Console.ReadLine();
		}
	}
}
