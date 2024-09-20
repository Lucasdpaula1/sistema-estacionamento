using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace estacionar.models
{
    public class Estacionamento
    {
    public double Income{get;set;}
     public double QntityPerHour{get;set;}
    private int Vaga {get; set;} = 20;
    private List<int> VagaOcupada{get;set;} 
    private  List<(string, string, string)> Carlist {get;set;}
    public Estacionamento(double income, double qntityPerHour){
        Income = income;
        QntityPerHour = qntityPerHour;
        VagaOcupada = new List<int>();
        Carlist = new List<(string, string, string)>();
        
        
   }
   
   
   public  List<(string,string,string)> AddCar(string model,string owner,string plate){
    if(Vaga == 100){
        Console.WriteLine("estacionamento lotado");   
    }
    Vaga++;

    int[] VagasDisponiveis = new int[Vaga];
   for(int index=0; index < Vaga; index++ ){
    VagasDisponiveis[index] = index+1;
   }
    int vagaAleatoria = new Random().Next(0,Vaga);
    Console.WriteLine(vagaAleatoria);

    bool verificar = true;
    
    while(verificar){
        
        if(VagaOcupada.Contains(vagaAleatoria)){
           vagaAleatoria = new Random().Next(0,Vaga);
        }else{
            VagaOcupada.Add(vagaAleatoria);
            verificar = false;
        }
    }

    
    

    Carlist.Add((model,owner,plate));
    foreach((string,string,string) tupla in Carlist){
        Console.WriteLine($"proprietários {tupla.Item2} que estão com o caro no estacionamento");

    }
    Console.WriteLine("carro adicionado na vaga: {0}",VagasDisponiveis[vagaAleatoria]);
    Console.WriteLine("proprietário {0}, modelo do veiculo {1} , placa do veiculo {2} ",owner,model,plate);
    foreach(int vaga in VagaOcupada)
     {Console.WriteLine("vagas {0}",vaga);}


   
   
    
    return Carlist;
    
   }
   public static void RemovingCar(){

   }

    }
}