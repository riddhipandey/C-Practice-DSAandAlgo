using System;

public class Players{
    public string name;
    public char mark;

    public Players(string name, char mark){
        this.name = name;
        this.mark = mark;
    }

    public void MakeMove(char[,] borad){
        int row; int col;
        do{
            Console.WriteLine("Please enter row and column value");
            row = Convert.ToInt32(Console.ReadLine());
            col = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("row = "+ row + " col = "+ col);
            if(IsValidMove(borad, row, col)){
                // PlaceMark(mark, row, col);
                borad[row,col] = mark;
            }
        }while(IsValidMove(borad, row, col)); 
    }
    
    public bool IsValidMove(char[,] borad, int row, int col){
        if(row>=0 && row < borad.GetLength(0) && col>=0 && col<borad.GetLength(1)){
            if(borad[row,col] == ' '){
                return true;
            }
        }
        return false;
    }

    // public char ChooseMark(){
    //     Console.WriteLine("Please choose your mark");
    //     char mark = Console.Read();
    // }
}