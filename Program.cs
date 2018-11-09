using System;

namespace Pruebas
{
    class Rectangulo
    {
		//Variables de un rectangulo
		double Alto;
		double Largo;

		public void DefinirVariables(){
			Alto = 4.5;
			Largo = 3.5;
		}

		public double SacarArea(){
			return Alto*Largo;
		}

		public void Mostrar(){
			Console.WriteLine("Alto: " + Alto);
			Console.WriteLine("Largo: " + Largo);
			Console.WriteLine("Area: " + SacarArea());
		}
		/*
		public void Leer(){
			Console.WriteLine("Escribe algo");
			String a = Console.ReadLine();
			Console.WriteLine(a);
		}*/
	}
	public class EjecucionRectangulo{
		public static void Main(string[] args){
			Rectangulo R = new Rectangulo();
			R.DefinirVariables();
			R.Mostrar();
			//R.Leer();
		}
	}
}
