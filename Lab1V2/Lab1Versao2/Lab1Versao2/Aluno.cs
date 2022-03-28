using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace Lab1Versao2
{
    class Aluno
    {
        public String nome;
        public int idade;
        public float peso;
        public float altura;

        public Aluno(string nome_, int idade_, float peso_, float altura_)
        {
            this.nome = nome_;
            this.idade = idade_;
            this.peso = peso_;
            this.altura = altura_;
        }
        //método calcularIMC
        public double CalcularIMC()
        {
            //semUsing static Ssytem.Math;
            //return peso / (altura) * altura;

            //using static System.Math;
            return peso / Pow(altura, 2);
        }

        //método DescreverSituação Corporal
        public String DescreverSituacaoCorporal()
        {
            string situacaocorporal = "Não foi possivel verificar a situação corporal";
            double imc = CalcularIMC();
            if ((18.5 <= imc) && (24.9 >= imc))
            {
                situacaocorporal = "Parabéns você está em seu peso normal";
            }
            if ((25.0 <= imc) && (29.9 >= imc))
            {
                situacaocorporal = "Você está acima do seu peso(sobrepeso)";
            }
            if ((30.0 <= imc) && (34.9 >= imc))
            {
                situacaocorporal = "Você está com obesidade grau 1";
            }
            if ((35.0 <= imc) && (40.0 >= imc))
            {
                situacaocorporal = "Você está com obesidade grau 2";
            }
            if (40.0 > imc)
            {
                situacaocorporal = "Você está com obesidade grau 3 e 4";
            }
            return situacaocorporal;


        }
        public float CalcularMetaPerdaPeso()
        {
            float imcMaxIdeal = 24.9f;
            float pesoIdeal = imcMaxIdeal * altura * altura;
            if (peso - pesoIdeal <= 0)
            {
                return 0;
            }
            else
            {
                return peso - pesoIdeal;
            }

            
        }
    }
}
