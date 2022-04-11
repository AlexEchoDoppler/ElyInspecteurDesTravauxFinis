﻿using Tp2;

public static class Program
{

    public static void Main()
    {
        Client Nicolas = new Client("Nicolas");
        Client Jeremy = new Client("Jeremy");

        if(Nicolas != null && Jeremy != null)
        {
            Nicolas.compteCourant.debitMax = 2000;
            //Nicolas.compteEpargne.tauxEpargne = 2;
            Nicolas.compteCourant.Crediter(100);
            Nicolas.compteCourant.Debiter(50);
            Nicolas.compteCourant.Debiter(20,Nicolas.compteEpargne);
            Nicolas.compteCourant.Crediter(20);
            Nicolas.compteBenefFixe.Crediter(800);
            Nicolas.compteBenefFixe.Crediter(200);

            Jeremy.compteCourant.debitMax = 500;
            Jeremy.compteCourant.Debiter(500);
            Jeremy.compteCourant.Debiter(200,Nicolas.compteCourant); 
        
            Console.WriteLine($"Solde compte courant de {Nicolas.name} : {Nicolas.compteCourant.balance}");
            Console.WriteLine($"Solde compte épargne de {Nicolas.name} : {Nicolas.compteEpargne.balance}");
            Console.WriteLine($"Solde compte toutBenef de {Nicolas.name} : {Nicolas.compteBenefFixe.balance}");
            
        }
    }
}
