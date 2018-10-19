/*
 * Created by SharpDevelop.
 * User: CAI
 * Date: 15/10/2018
 * Time: 08:08 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections;
using System.Collections.Generic;

namespace micritos
{
	/// <summary>
	/// Description of altaterminal.
	/// </summary>
	public class terminal
	{
		private string termi;
		private string ciu;
		public string Ciudad{
			get{return ciu;}
			set{ciu= value;}
		}
		public string Terminal{
			get{return termi;}
			set{termi=value;}
		}

		public terminal(){
			Console.WriteLine("Ingrese nombre de la terminal: ");
			 termi=Console.ReadLine();
			Console.WriteLine("Ingrese el nombre de la ciudad: ");
			 ciu=Console.ReadLine();
			Console.WriteLine("Se han dado de alta correctamente las terminales.");
		}
	}
}
