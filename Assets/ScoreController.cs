using UnityEngine;
using System.Collections;


public class ScoreController : MonoBehaviour {
	

	private int AddScore ;

	//得点を表示するテキスト
	private GameObject ScoreText;


	// Use this for initialization
	void Start () {
		
		//シーン中のGameOverTextオブジェクトを取得
		this.ScoreText= GameObject.Find("ScoreText");

		// タグによってを得点変える
		if (tag == "SmallStarTag") {
			this.AddScore = 10;
		} else if (tag == "LargeStarTag") {
			this.AddScore = 20;
		}else if(tag == "SmallCloudTag" || tag == "LargeCloudTag") {
			this.AddScore = 5;
		}
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	//衝突時に呼ばれる関数
	void OnCollisionEnter(Collision other) {
		
		ScoreText.GetComponent<ScoreText>().score += AddScore;
		
	}


}

