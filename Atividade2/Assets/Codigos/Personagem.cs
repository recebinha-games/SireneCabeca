using System.Collections;
using UnityEditor;
using UnityEngine;

public class Personagem : MonoBehaviour
{
    [ SerializeField ]
    private string nome;
    [ SerializeField ]
    private int energia;
    [ SerializeField ]
    private float velocidade;
    [ SerializeField ]
    private float tamanho;

    public void AtribuirNome(string Nome)
    {
        this.nome = nome;
    }

    public string Nome()
    {
        return this.nome;
    }

    public void AtribuirEnergia(int energia)
    {
        this.energia = energia;
    }

    public int Energia()
    {
        return this.energia;
    }

    public void AtribuirVelocidade(float velocidade)
    {
        this.velocidade = velocidade;
    }

    public float Velocidade()
    {
        return this.velocidade;
    }

        public void AtribuirNome(float tamanho)
    {
        this.tamanho = tamanho;
    }

    public string tamanho()
    {
        return this.tamanho;
    }

    void Start()
    {
        
    }
    void Update()
    {
        
    }
}