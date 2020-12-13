using System;

namespace AulaPOO_PolimorfismoSobrecarga.classes
{
    public class Funcionario
    {
        private string[] lista = {"1","2","3","4"};

        public void Mostrar(){
            foreach (var item in lista)
            {
                Console.WriteLine(lista[int.Parse(item)]);
            }
        }
        public void Mostrar(int indice){
            Console.WriteLine(lista[(indice)-1]);
        }
        public void Mostrar(string busca){
            for (var i = 0; i < lista.Length; i++){
                if(busca == lista[i]){
                    Console.WriteLine("Resultado encontrado, o funcionario foi o "+(i+1)+" a se inscrever");
                    break;
                }
                else if(i == lista.Length - 1){
                    Console.WriteLine("Não foi encontrado resultado");
                }
            }
        }}
}