/*
 * Created by SharpDevelop.
 * User: CAI
 * Date: 16/10/2018
 * Time: 06:16 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections;
using System.Collections.Generic;

namespace micritos
{
	/// <summary>
	/// Description of choferes.
	/// </summary>
	public class choferes
	{
		private int DNI;
		public int dni{
			get{return  DNI;}
			set{DNI=value;}
		}
		private string nombre, apellido;
		public string Nombre{
			get{return nombre;}
			set{nombre=value;}
		}
		public string Apellido{
			get{return apellido;}
			set{apellido=value;}
		}
		public static int legajo=0;
		public choferes(){
				Console.WriteLine("Ingrese nombre:");
				nombre=Console.ReadLine();
				Console.WriteLine("Ingrese apellido:");
				apellido=Console.ReadLine();
				Console.WriteLine("Ingrese DNI:");
				DNI=int.Parse(Console.ReadLine());
				Console.WriteLine("El chofer fue dado de alta.Su numero de legajo es " + legajo++);

		}
	}
}
