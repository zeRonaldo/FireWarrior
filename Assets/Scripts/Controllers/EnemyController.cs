using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {
	
	//public bool chefe;
	//public int tipoInimigo;

	public int vida = 2;

	//private int dano;


	void Start () {


		/*if (chefe) {
			//Define Vida e Dano do Chefe definidos pelo Inspector
			switch (tipoInimigo) {
			case 1:
				vida = 2;
				dano = 1;
				break;
			case 2:
				vida = 2;
				dano = 1;
				break;
			case 3:
				vida = 2;
				dano = 1;
				break;
			default:
				vida = 2;
				dano = 1;
				break;
			}
		} else {
			//Define Vida e Dano do Inimigo definidos pelo Inspector
			switch (tipoInimigo) {
			case 1:
				vida = 2;
				dano = 1;
				break;
			case 2:
				vida = 2;
				dano = 1;
				break;
			case 3:
				vida = 2;
				dano = 1;
				break;
			default:
				break;
			}
		}*/
	}

	void Update () {
		
	}

	public void RecebeDano(){//Metodo para receber dano
		//Animação de receber dano opcional
		this.vida -= 1;
	}

	/*public void Ataca(){//Metodo para ataque do inimigo
		//Animação de atacar opcional
	}*/

	public void Morre(){ //Metodo para morte do inimigo
		//Animação de morte opcional
		Destroy(this.gameObject);
	}
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("PlayerBullet"))
        {
            Destroy(other.gameObject);
            RecebeDano();
            if(vida <= 0)
            {
                Morre();
            }
        }
    }
}
