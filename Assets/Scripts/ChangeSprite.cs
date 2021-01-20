using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class ChangeSprite : MonoBehaviour {

	private SpriteRenderer rend;
	private Sprite P1, P2, P3, P4, P5, P6, P7, P8,P9, P10 ;
	// Use this for initialization
	void Start () {
		rend = GetComponent<SpriteRenderer>();

		P1 = Resources.Load<Sprite>("p1");
		P2 = Resources.Load<Sprite>("p2");
		P3 = Resources.Load<Sprite>("p3");
		P4 = Resources.Load<Sprite>("p4");
		P5 = Resources.Load<Sprite>("p5");
		P6 = Resources.Load<Sprite>("p6");
		P7 = Resources.Load<Sprite>("p7");
		P8 = Resources.Load<Sprite>("p8");
		P9 = Resources.Load<Sprite>("p9");
		P10 = Resources.Load<Sprite>("p10");
		rend.sprite = P1;
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0)){
			if (rend.sprite == P1)
				rend.sprite = P2;
					else if (rend.sprite == P2)
						rend.sprite = P3;

					else if (rend.sprite == P3)
						rend.sprite = P4;

					else if (rend.sprite == P4)
						rend.sprite = P5;

					else if (rend.sprite == P5)
						rend.sprite = P6;

					else if (rend.sprite == P6)
						rend.sprite = P7;

					else if (rend.sprite == P7)
						rend.sprite = P8;

					else if (rend.sprite == P8)
						rend.sprite = P9;

					else if (rend.sprite == P9)
						rend.sprite = P10;

					else if (rend.sprite == P10)
						rend.sprite = P1;
		}
	}
}
