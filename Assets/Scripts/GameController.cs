using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

	private Player _jugador = new Player();

	private Player _npc = new Player();

	private List<Card> _cartas = new List<Card>();  
 
	void Start()
	{ 
		RepartirCartas(_jugador);
		RepartirCartas(_npc);
	}

	public void RepartirCartas(Player player){
		LlenarBolsa();
		var _playerCards = new List<Card>();
		for (int i = 0; i < 6; i++)
		{ 
			int index = Random.Range(0,_cartas.Count);
			_playerCards.Add(_cartas[index]);
			_cartas.Remove(_cartas[index]);
		}		 
		player._cartas = _playerCards;
	}

	public void LlenarBolsa(){
		_cartas.Clear ();
		for (int i = 0; i < 3; i++)
		{
			_cartas.Add(new Card(CardsType.Piedra));
			_cartas.Add(new Card(CardsType.Papel));
			_cartas.Add(new Card(CardsType.Tijera));
		}
	}
}
