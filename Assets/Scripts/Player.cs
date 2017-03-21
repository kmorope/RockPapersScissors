using System.Collections;
using System.Collections.Generic;

public class Player
{
	public List<Card> _cartas = new List<Card>();

    public int puntos { get; set; }

    public Player(int p)
    {
        this.puntos = p;
    }

    public void IncrementPoints(int p)
    {
        this.puntos = this.puntos + p;
    }
     
}