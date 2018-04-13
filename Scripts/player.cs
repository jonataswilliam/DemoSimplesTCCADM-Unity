using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class player : MonoBehaviour {

	public Rigidbody2D rbPlayer;
	public float speed;
	public float movimentoX;
	public bool walk;
	public float movimentoY;
	public Animator playerAnime;
	public bool pertoLousa = false;


	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void FixedUpdate () {

		movimentoX = Input.GetAxisRaw ("Horizontal");
		movimentoY = Input.GetAxisRaw ("Vertical");


		if (movimentoX != 0 || movimentoY != 0) {
			if (movimentoX != 0) {
				movimentoY = 0;
			}

			if (movimentoY != 0) {
				movimentoX = 0;
			}

			walk = true;
		} else {
			walk = false;
		}

		// Setando Animação de Andar
		playerAnime.SetBool ("isWalk", walk);

		if (walk) {
			rbPlayer.velocity = new Vector2 (movimentoX * speed, movimentoY * speed);
			playerAnime.SetFloat ("idMovimentoX", movimentoX);
			playerAnime.SetFloat ("idMovimentoY", movimentoY);
		} else {
			rbPlayer.velocity = new Vector2 (movimentoX, movimentoY);
		}

		if(pertoLousa && Input.GetButton ("Fire1")) {
			Debug.Log ("Bora para as perguntas");
			SceneManager.LoadScene ("questions");
		}

		if(Input.GetButton("Cancel")) {
			Debug.Log (SceneManager.GetActiveScene().name);
		}

//		if(SceneManager.GetActiveScene().name == "question" && Input.GetButton ("Cancel")) {
//			SceneManager.LoadScene ("class1");
//		}

	}

	void OnTriggerEnter2D(Collider2D col) {
		switch (col.gameObject.name) {
		case "Faculdade":
			SceneManager.LoadScene ("school_scene");
			break;

		case "pisoEntrada":
			SceneManager.LoadScene ("main_scene");
			break;

		case "portaSala1":
			SceneManager.LoadScene("class1");
			break;	

		case "portaSala3":
			SceneManager.LoadScene("class2");
			break;

		case "lousa":
			pertoLousa = true;
			break;
		}

	}

	void OnTriggerExit2D(Collider2D col) {
		switch (col.gameObject.name) {
		case "lousa":
			pertoLousa = false;
			break;
		}
	}


}	

