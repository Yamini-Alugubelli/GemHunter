using System;

public class Position
{
    public int X { get; set; }
    public int Y { get; set; }

    public Position(int x, int y)
    {
        X = x;
        Y = y;
    }
}
public class Player
{
    public string Name { get; }
    public Position Position { get; set; }
    public int GemCount { get; set; }

    public Player(string name, Position position)
    {
        Name = name;
        Position = position;
        GemCount = 0;
    }

    public void Move(char direction)
    {
        switch (direction)
        {
            case 'U':
                Position.Y--;
                break;
            case 'D':
                Position.Y++;
                break;
            case 'L':
                Position.X--;
                break;
            case 'R':
                Position.X++;
                break;
        }
    }
}
public class Cell
{
    public string Occupant { get; set; }

    public Cell(string occupant)
    {
        Occupant = occupant;
    }
}

public class Board
{
    public Cell[,] Grid { get; }

    public Board()
    {
        Grid = new Cell[6, 6];
        // Initialize the board with empty spaces
        for (int i = 0; i < 6; i++)
        {
            for (int j = 0; j < 6; j++)
            {
                Grid[i, j] = new Cell("-");
            }
        }
        // Initialize players and obstacles
        Grid[0, 0].Occupant = "P1";
        Grid[5, 5].Occupant = "P2";
        // Initialize gems (you can randomize the positions)
        Grid[2, 2].Occupant = "G";
        Grid[4, 4].Occupant = "G";
        // Initialize obstacles (you can randomize the positions)
        Grid[1, 1].Occupant = "O";
        Grid[3, 3].Occupant = "O";
    }
}
    class Program
{
    static void Main()
    {
      
    }
}

