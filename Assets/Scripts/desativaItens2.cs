using UnityEngine;
using System.Collections;

public class desativaItens2 : MonoBehaviour {
	
	public GameObject dropurso;
	public GameObject Seringa;
	public GameObject garroteV,garroteA;
	public dropper_Estagio2 ReferenciaDropper;
    private BoxCollider colisorGarroteV, colisorGarroteA;


    public void Start()
    {
        Seringa.GetComponent<BoxCollider>().enabled = true;

        colisorGarroteV = garroteV.GetComponent<BoxCollider>();
        colisorGarroteA = garroteA.GetComponent<BoxCollider>();

        colisorGarroteV.enabled = false;
        colisorGarroteA.enabled = false;
    }

    public void OnMouseDown(){
		//PROCEDIMENDO DE TIRAR GARROTE!
		if (dropurso.GetComponent<dropper_Estagio2> ().procedimentoAtual == 5) {
            //PROCEDIMENTO DE REMOVER SERINGA APÓS ANIMAÇÃO DE MEDICAMENTO!
            dropurso.GetComponent<dropper_Estagio2>().procedimentoAtual++;
            ReferenciaDropper.RetornaPontuacaoPorEtapa();
            dropurso.GetComponent<dropper_Estagio2>().ReferenciaDialogos.ReferenciaParaPularDeDialogo();
            colisorGarroteV.enabled = true;
            colisorGarroteA.enabled = true;
            Seringa.SetActive(false);
        }
        else if (dropurso.GetComponent<dropper_Estagio2> ().procedimentoAtual == 6) {
            if (dropurso.GetComponent<dropper_Estagio2>().SpriteGarroteVerde)
            {
                ReferenciaDropper.SpriteGarroteVerde.enabled = true;
                ReferenciaDropper.SpriteGarroteAzul.enabled = true;
            }
            garroteV.GetComponent<SkinnedMeshRenderer>().enabled = false;
            garroteA.GetComponent<SkinnedMeshRenderer>().enabled = false;
            dropurso.GetComponent<dropper_Estagio2>().procedimentoAtual++;
            ReferenciaDropper.RetornaPontuacaoPorEtapa();
            dropurso.GetComponent<dropper_Estagio2>().ReferenciaDialogos.ReferenciaParaPularDeDialogo();
            ReferenciaDropper.animacao.SetTrigger("zoom_out");
        }
	}
}