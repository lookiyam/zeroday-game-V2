using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class ChangeSprite : MonoBehaviour {

	private SpriteRenderer rend;
	private Sprite catSprite, monsterSprite;
	// Use this for initialization
	void Start () {
		rend = GetComponent<SpriteRenderer>();
		catSprite = Resources.Load<Sprite>("Cat");
		monsterSprite = Resources.Load<Sprite>("Monster");
		rend.sprite = catSprite;
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0)){
			if (rend.sprite == catSprite)
				rend.sprite = monsterSprite;
					else if (rend.sprite == monsterSprite)
						rend.sprite = catSprite;
		}
	}
}
