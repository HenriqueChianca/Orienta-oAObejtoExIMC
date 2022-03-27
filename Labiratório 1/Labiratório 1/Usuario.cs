using System;
using System.Collections.Generic;
using System.Text;

namespace Labiratório_1
{
    class Usuario
    {
        public String nome;
        public int idade;
        public double peso;
        public double altura;
        public double imc;
        public Usuario(string nome, int idade, double peso, double altura)
        {
            this.nome = nome;
            this.idade = idade;
            this.peso = peso;
            this.altura = altura;
        }

        //Situação
        public void Situacao()
        {
            
            if (imc > 40)
            {
                Console.WriteLine("O usuário está com obesidade grau 3 e 4");
            }

            if (imc >= 35 && imc <= 40)
            {
                Console.WriteLine("O usuário está com obesidade grau 2");
            }
            if (imc >= 30 && imc <= 34.9)
            {
                Console.WriteLine("O usuário está com obesidade grau 1");
            }
            if (imc >= 25 && imc <= 29.9)
            {
                Console.WriteLine("O usuário está com sobrepeso");
            }
            if (imc >= 18.5 && imc <= 24.0)
            {
                Console.WriteLine("Parabéns, o usuário está em seu peso ideal");
            }
        }

        //Método Calcular IMC
        public void CalcularIMC()
        {
            //imc = peso / (altura) * altura;

            double Alt = Math.Pow(altura,2);
            double IMC1 = peso / Alt;
            Console.WriteLine($"Seu IMC é: {IMC1}");
            imc = IMC1;
        }

       //Meta
       public void Meta()
        {
            if (imc > 24.9)
            {
                double IMCMeta = imc - 24.9d;
                double Altura2 = Math.Pow(altura, 2);
                double META = IMCMeta * Altura2;
                Console.WriteLine($"É necessario perder: {META} Kg para o usuário chegar em seu peso ideal.");
            }
            else
            {
                Console.WriteLine("O usuário já está em seu peso ideal!");
            }
        }

    }
}
