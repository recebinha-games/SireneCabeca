using UnityEngine;

public class TesteDanoInimigo : MonoBehaviour
{
    private Inimigo inimigo;
    
    private void OnCollisionEnter(Collision colisao)
    {
        if (colisao.gameObject.CompareTag("AtaqueEspecial"))
        {
            int energia = inimigo.Energia() 
                                - colisao.gameObject.GetComponent<AtaqueEspecial>().AtaqueDoPersonagem();
           
            inimigo.AtribuirEnergia(energia);
           
            Debug.Log("O personagem " +inimigo.Nome()+" tem agora "+inimigo.Energia());
        }
    }

    void Start()
    {
        inimigo = GetComponent<Inimigo>();
    }

  
    void Update()
    {
        
    }
}