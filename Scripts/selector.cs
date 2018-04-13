using UnityEngine;
using System.Collections;

public class selector : MonoBehaviour {

    public int resposta = 0;
    // public Text text;
    public Transform rbSelector;
    public GameObject rbA;
    public GameObject rbB;
    public GameObject rbC;
    public GameObject rbD;


    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        /// <summary>
        /// Faz seleção das questoes
        /// </summary>
	    if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            if(resposta == 0)
            {
                resposta = 3;
                rbSelector.position = new Vector3(rbSelector.transform.position.x, rbD.transform.position.y, 0);
            }
            else {
                --resposta;
                switch (resposta)
                {
                    case 0:
                        rbSelector.position = new Vector3(rbSelector.transform.position.x, rbA.transform.position.y, 0);
                        break;

                    case 1:
                        rbSelector.position = new Vector3(rbSelector.transform.position.x, rbB.transform.position.y, 0);
                        break;

                    case 2:
                        rbSelector.position = new Vector3(rbSelector.transform.position.x, rbC.transform.position.y, 0);
                        break;
                    
                }
                
            }
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            if (resposta == 3)
            {
                resposta = 0;
                rbSelector.position = new Vector3(rbSelector.transform.position.x, rbA.transform.position.y, 0);
            }
            else
            {
                ++resposta;
                switch (resposta)
                {
                    case 3:
                        rbSelector.position = new Vector3(rbSelector.position.x, rbD.transform.position.y, 0);
                        break;

                    case 1:
                        rbSelector.position = new Vector3(rbSelector.position.x, rbB.transform.position.y, 0);
                        break;

                    case 2:
                        rbSelector.position = new Vector3(rbSelector.position.x, rbC.transform.position.y, 0);
                        break;

                }

            }
        }


        ///<summary>
        /// Confirma resposta
        /// </summary>
        if(Input.GetButton("Fire1"))
        {
            switch(resposta)
            {
                case 0:
//                    text = rbA.GetComponent<Text>();
//                    text.color = new Color(1.0f, 0, 0, 1.0f);
                    break;

                case 1:
                    break;

                case 2:
                    break;

                case 3:
                    break;
            }
        }






    }
}
