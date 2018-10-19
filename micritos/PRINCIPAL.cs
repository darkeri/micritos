/*
 * Created by SharpDevelop.
 * User: CAI
 * Date: 17/10/2018
 * Time: 09:14 a.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections;
using System.Collections.Generic;

namespace micritos
{
	/// <summary>
	/// Description of PRINCIPAL.
	/// </summary>
	public class PRINCIPAL
	{
		List<terminal> lista_terminales;
		List<choferes> lista_choferes;
		List <omnibus> lista_omnibus;
		List<recorridos> lista_recorridos;
		public PRINCIPAL()
		{
			lista_terminales=new List<terminal>();
			lista_choferes=new List<choferes>();
			lista_recorridos=new List<recorridos>();
			lista_omnibus=new List<omnibus>();
		}
		public void seleccion(){
			Console.WriteLine("¿A que módulo desea ingresar?");
			Console.WriteLine("1)Armado de recorridos.");
			Console.WriteLine("2)Gestión de choferes.");
			Console.WriteLine("3)Venta de pasajes.");
			Console.WriteLine("4)Estadísticas.");
			Console.WriteLine("5)Salir del sistema.");
			int a=int.Parse(Console.ReadLine());
			switch (a){
					case 1:
					interface_terminales();
					break;
					case 2:
					interface_choferes();
					break;
			}
		}
		public void interface_terminales(){
			Console.WriteLine("1)Alta terminales.");
			Console.WriteLine("2)Alta omnibus.");
			Console.WriteLine("3)Alta recorridos.");
			Console.WriteLine("4)Volver.");
			int a=int.Parse(Console.ReadLine());
			switch(a){
				case 1:
					terminal nuv=new terminal();
					lista_terminales.Add(nuv);
					Console.ReadKey(true);
					Console.Clear();
					seleccion();
					break;
				case 2:
					omnibus nue=new omnibus();
					lista_omnibus.Add(nue);
					Console.ReadKey(true);
					Console.Clear();
					seleccion();
					break;
				case 3:
					recorridos n= new recorridos(lista_terminales);
					lista_recorridos.Add(n);
					Console.ReadKey(true);
					Console.Clear();
					break;
				default:
					Console.Clear();
					seleccion();
					break;
			}
		}
		public void interface_choferes(){
			Console.WriteLine("1)Alta choferes.");
			Console.WriteLine("2)Asignación de choferes.");
			Console.WriteLine("3)Volver.");
			int a=int.Parse(Console.ReadLine());
			
			switch (a){
				case 1:
					choferes nue=new choferes();
					lista_choferes.Add(nue);
					Console.ReadKey(true);
					Console.Clear();
					seleccion();
					break;
				case 2:
					break;
				default:
					Console.Clear();
					seleccion();
					break;
			}
		}
	}
}