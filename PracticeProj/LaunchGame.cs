using System;
public class LaunchGame{
    public static void LaunchMyGame(){
        TicTacToe t = new TicTacToe();
            t.PrintBorad();
            Players p1 = new Players("Riddhi", 'X');
            Players p2 = new Players("Ritam", 'O');
            Players cP = p1;
            do{
                Console.WriteLine(cP.name + " turn");
                cP.MakeMove(t.borad);
                t.PrintBorad();
                if(t.ContinueGame()==1){
                    Console.WriteLine(cP.name + " Won!");
                }else if(t.ContinueGame()==2){
                    Console.WriteLine("Game Draw!");
                }
                else
                if(cP==p1){
                    cP=p2;
                }else{
                    cP=p1;
                }
                Console.WriteLine("retruned value = "+ t.ContinueGame());
            }while(t.ContinueGame()==0);
            
    }
}