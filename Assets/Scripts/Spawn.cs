using UnityEditor.Timeline;
using UnityEngine;

public class Spawn : MonoBehaviour
{

    public GameObject obstaclePrefab;
    public float spawnInterval = 2f;
    public Vector3 spawnPosition = new Vector3(14f, -2f, 0f);//Posição aonde ele vai ser spawnado
    private float timer;//Contador do intervalo

   //Dificuldade do game
   public float MaximoY = -0.1f;// Valor máximo do eixo Y para o spawn
    public float MínimoY = -3f;// Valor mínimo do eixo Y para o spawn

    

    private void Update()
    {
        if(PlayerController.Instance.gameStarted)
        {
            timer -= Time.deltaTime;//Contador do intervalo
            if (timer <= 0f)
            {
                {
                    SpawnObstacle();//Método logo abaixo
                    timer = spawnInterval;//Reseta o contador
                }
            }

        }
      

        
    }

    void SpawnObstacle()
    {

        Instantiate(obstaclePrefab, spawnPosition, Quaternion.identity);//Instancia o obstaculo
    }
}




