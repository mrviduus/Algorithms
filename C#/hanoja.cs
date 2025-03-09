using System;

namespace Hanoja
{
    class  Programm
    {
        static void hanoi(int x, char from, char to, char help){
            if(x > 0){
                hanoi(x- 1, from, help, to);
                move(x, from, to);
                hanoi(x -1, help, to, from);
            }
        }
        static void move(int x, char from, char to){
            System.Console.WriteLine(  "Берем диск " + x + " из " + from + " в " + to);
        }

        static void Main (string [] args){
            int x;
            char from = 'A', to = 'B', help = 'C';
            do{
                try{
                    System.Console.WriteLine( "Введите количество дисков: ");
                    x = Int32.Parse(Console.ReadLine());
                }
                catch (FormatException e){
                    x = -10;
                }
            }while (x == -10 || x > 10);
            System.Console.WriteLine( "\n откуда А, куда = В, вспомогательная колона = С \n");
            hanoi(x, from, to,help);
                
            
        }
    }
}