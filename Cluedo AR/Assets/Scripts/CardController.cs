using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardController : MonoBehaviour {

	public Sprite newSprite;

	public Sprite oldSprite;

	public SpriteRenderer spriteRenderer;

	public int cambio=0;

	// Use this for initialization
	void Start ()
	{
		spriteRenderer=GetComponent<SpriteRenderer>();
		oldSprite=spriteRenderer.sprite;
	}

	void OnMouseDown()
	{
		if(cambio%2==0)
		{
			spriteRenderer.sprite=newSprite;
			cambio++;
		}
		else
		{
			spriteRenderer.sprite=oldSprite;
			cambio++;
		}
	}
}
