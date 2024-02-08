using System;

public class TicTacToe{
    public char[,] borad;

    public TicTacToe(){
        borad = new char[3,3];
        BoradInitialize();
    }

    void BoradInitialize(){
        for(int i=0; i<borad.GetLength(0); i++){
            for(int j = 0; j<borad.GetLength(1); j++){
                borad[i,j] = ' ';
            }
        }
    }

    public void PrintBorad(){
        for(int i=0; i<borad.GetLength(0); i++){ 
            Console.WriteLine("-------------");
            Console.Write("| ");
            for(int j = 0; j<borad.GetLength(1); j++){
                Console.Write(borad[i,j] + " | ");
            }
            Console.WriteLine();
        }
        Console.WriteLine("-------------");
    }

    //1 win, 2 draw, 0 gameEnded
    public int ContinueGame(){
        for(int row=0; row<borad.GetLength(0);row++){
            if(borad[row,0] != ' ' && borad[row,0] == borad[row,1] && borad[row,1]==borad[row,2])
                return 1; 
        }
        for(int col=0; col<borad.GetLength(1);col++){
            if(borad[0,col] != ' '  && borad[0,col] == borad[1,col] && borad[1,col]==borad[2,col])
                return 1;
        }

        for(int row=0; row<=0;row++){
            for(int col=0; col<=0;col++){
                if(borad[row,col]!= ' ' && row == col && 
                  borad[row,col]==borad[row+1,col+1] && borad[row+1,col+1] == borad[row+2,col+2])
                    return 1;
                }
        }

        for(int row=0; row<borad.GetLength(0);row++){
            for(int col=0; col<borad.GetLength(1);col++){
            if(borad[row,col]==' ')
                return 0;
            }
        }
        
        return 2;
    }

    // public static bool PlaceMark(char mark, int row, int col){
    //     if(row>=0 && row<borad.GetLength(0) && col>=0 && col<borad.GetLength(1)){
    //         borad[row,col] = mark;
    //         return true;
    //     } 
    //     return false;
    // }
}