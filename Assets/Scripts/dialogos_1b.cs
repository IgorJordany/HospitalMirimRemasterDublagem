using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class dialogos_1b : MonoBehaviour {

	/***********************************************************************/
	/*REGIÃO DE DECLARAÇÃO DE TODOS OS COMPONENTES DAS JANELAS DE DIÁLOGO (INICIAIS, PROCEDIMENTO E ERRO)*/

	//Objeto mãe de todos os diálogos iniciais
	public GameObject TodosDialogosDoInicio; 
	public int medicoS;
	public int pacienteS;

	public GameObject[] dialogosIniciais = new GameObject[5]; //vetor de todos os diálogos iniciais (Para ordem sequencial de execução);
	private int contadorDeJanelasIniciais = 0; //auto explicativo

	//objeto mãe de todos os diálogos de procedimento
	public GameObject todosDialogosDeProcedimento;
	public GameObject[] dialogosDeProcedimento = new GameObject[9];
	public int contadorDeProcedimento;

	//objeto mãe de todos os diálogos de mensagem de erro
	public GameObject TodasJanelasDeErro;
	public GameObject[] dialogosDeErro = new GameObject[4];
	private int contadorDeErro = 0;	
	
	/***********************************************************************/
	/*REGIÃO PARA DESATIVAÇÃO DOS OBJETOS DRAG AND DROP (PARA NÃO DAR ERRO DE CONFLITO NOS MOMENTOS DE DIÁLOGOS)*/

	//conferir a necessidade de ser public ou private
	private GameObject[] ObjetosArrastaveis = new GameObject[6];
 
	/***********************************************************************/
	/*REGIÃO DE DECLARAÇÃO DE TODOS OS BOTÕES UTILIZADOS NOS DIÁLOGOS*/

	//public GameObject botaoJanela6;
	public GameObject BotaoRetorno;
	//public GameObject botaoDePause;
	public GameObject botaoDePlacar;

	/***********************************************************************/
	/*ELEMENTOS REFERENTES AOS FATORES DO PLACAR FINAL DO PROCEDIMENTO*/	

	public GameObject dropurso;
	public placarfinal_2 referenciaDoPlacar;
	public GameObject placar;
	public GameObject painelDeDialogos;
	public GameObject pauseMenu;

	/***********************************************************************/
	/*OBJETOS TRIDIMENSIONAIS APLICADOS NO PACIENTE*/

	public GameObject seringaAplicadaNoUrso;
	public GameObject garroteAplicadoNoUrso;

	/***********************************************************************/
	/*OUTROS ELEMENTOS UTILIZADOS*/

	//referencia de conversa utilizada para ser resgatada futuramente
	//Quando ocorre uma substituição de dialogo de procedimento por diálogo de erro é salva uma referência para ser resgatada
	//quando a janela de erro for fechada;
	private GameObject referencia; 

	//caricatura do personagem utilizada (Importada do script acima);
	public Image Carica;

	public GameObject canvasDragDrop;

	//referencia ao script que contém todas as caricaturas;
	public caricaturas ReferenciaDaCaricatura;
	private int ProcedimentoErrado;

	public GameObject PainelDePontuacao;

	public AudioClip Acertou;
	public AudioClip Errou;

	public AudioClip mr1;
	public AudioClip mr2;
	public AudioClip mr3;
	public AudioClip mr4;
	public AudioClip mr5;

	public AudioClip fr1;
	public AudioClip fr2;
	public AudioClip fr3;
	public AudioClip fr4;
	public AudioClip fr5;

	public AudioClip mp1;
	public AudioClip mp2;
	public AudioClip mp3;
	public AudioClip mp4;
	public AudioClip mp5;
	public AudioClip mp6;
	public AudioClip mp7;
	public AudioClip mp8;
	public AudioClip mp9;

	public AudioClip fp1;
	public AudioClip fp2;
	public AudioClip fp3;
	public AudioClip fp4;
	public AudioClip fp5;
	public AudioClip fp6;
	public AudioClip fp7;
	public AudioClip fp8;
	public AudioClip fp9;

	void Start () {
		medicoS = PlayerPrefs.GetInt ("selecionadoMedico");
		pacienteS = PlayerPrefs.GetInt ("selecionadoPaciente");
		ProcedimentoErrado = 0;
		canvasDragDrop.SetActive(false);
		BotaoRetorno.SetActive(false);
		dropurso.SetActive(false);
		PainelDePontuacao.SetActive (false);
		if (medicoS == 0 || medicoS == 3 || medicoS == 5) {
			GetComponent<AudioSource> ().clip = fr1;
			GetComponent<AudioSource> ().Play();
		}
		if (medicoS == 1 || medicoS == 2 || medicoS == 4) {
			GetComponent<AudioSource> ().clip = mr1;
			GetComponent<AudioSource> ().Play();
		}		
	}
	
	void Update () {
		//ARRUMAR O GATO DE IMAGEM DE CARICATURA ABAIXO
		if(ProcedimentoErrado == 0){
			Carica.sprite = ReferenciaDaCaricatura.CaricaturaSelecionada[0];
		}else if(ProcedimentoErrado == 1){
			Carica.sprite = ReferenciaDaCaricatura.CaricaturaSelecionada[1];
		}

		if(contadorDeJanelasIniciais == 0){
			BotaoRetorno.SetActive(false);
		}
		else if(contadorDeJanelasIniciais != 0){
			BotaoRetorno.SetActive(true);
		}
	}

	public void PrimeirosDialogos(int contadorLocal){
		dialogosIniciais[contadorLocal].SetActive(true);
		if (contadorLocal == 0) {
			if (medicoS == 0 || medicoS == 3 || medicoS == 5) {
				print ("MUIE");
				GetComponent<AudioSource> ().clip = fr1;
				GetComponent<AudioSource> ().Play();
			}
			if (medicoS == 1 || medicoS == 2 || medicoS == 4) {
				print ("HOMI");
				GetComponent<AudioSource> ().clip = mr1;
				GetComponent<AudioSource> ().Play();
			}		
		}
		if (contadorLocal == 1) {
			if (medicoS == 0 || medicoS == 3 || medicoS == 5) {
				print ("MUIE");
				GetComponent<AudioSource> ().clip = fr2;
				GetComponent<AudioSource> ().Play();
			}
			if (medicoS == 1 || medicoS == 2 || medicoS == 4) {
				print ("HOMI");
				GetComponent<AudioSource> ().clip = mr2;
				GetComponent<AudioSource> ().Play();
			}		
		}
		if (contadorLocal == 2) {
			if (medicoS == 0 || medicoS == 3 || medicoS == 5) {
				print ("MUIE");
				GetComponent<AudioSource> ().clip = fr3;
				GetComponent<AudioSource> ().Play();
			}
			if (medicoS == 1 || medicoS == 2 || medicoS == 4) {
				print ("HOMI");
				GetComponent<AudioSource> ().clip = mr3;
				GetComponent<AudioSource> ().Play();
			}		
		}
		if (contadorLocal == 3) {
			if (medicoS == 0 || medicoS == 3 || medicoS == 5) {
				print ("MUIE");
				GetComponent<AudioSource> ().clip = fr4;
				GetComponent<AudioSource> ().Play();
			}
			if (medicoS == 1 || medicoS == 2 || medicoS == 4) {
				print ("HOMI");
				GetComponent<AudioSource> ().clip = mr4;
				GetComponent<AudioSource> ().Play();
			}		
		}
		if (contadorLocal == 4) {
			if (medicoS == 0 || medicoS == 3 || medicoS == 5) {
				print ("MUIE");
				GetComponent<AudioSource> ().clip = fr5;
				GetComponent<AudioSource> ().Play();
			}
			if (medicoS == 1 || medicoS == 2 || medicoS == 4) {
				print ("HOMI");
				GetComponent<AudioSource> ().clip = mr5;
				GetComponent<AudioSource> ().Play();
			}		
		}
	}

	public void BotaoDePular(){
		if(contadorDeJanelasIniciais == 4){
			TodosDialogosDoInicio.SetActive(false);
			canvasDragDrop.SetActive(true);
			dropurso.SetActive(true);
			PainelDePontuacao.SetActive (true);
			conversaDeProcedimentos(contadorDeProcedimento);
		}else{
			dialogosIniciais[contadorDeJanelasIniciais].SetActive(false);
			contadorDeJanelasIniciais++;
			PrimeirosDialogos(contadorDeJanelasIniciais);
		}
	}

	public void BotaoDeRetornar(){
		dialogosIniciais[contadorDeJanelasIniciais].SetActive(false);
		contadorDeJanelasIniciais--;
		PrimeirosDialogos(contadorDeJanelasIniciais);
	}

	public void conversaDeProcedimentos(int contadorLocal){
		dialogosDeProcedimento[contadorLocal].SetActive(true);
		if (contadorLocal == 0) {
			if (medicoS == 0 || medicoS == 3 || medicoS == 5) {
				print ("MUIE");
				GetComponent<AudioSource> ().clip = fp1;
				GetComponent<AudioSource> ().Play();
			}
			if (medicoS == 1 || medicoS == 2 || medicoS == 4) {
				print ("HOMI");
				GetComponent<AudioSource> ().clip = mp1;
				GetComponent<AudioSource> ().Play();
			}		
		}
		if (contadorLocal == 1) {
			if (medicoS == 0 || medicoS == 3 || medicoS == 5) {
				print ("MUIE");
				GetComponent<AudioSource> ().clip = fp2;
				GetComponent<AudioSource> ().Play();
			}
			if (medicoS == 1 || medicoS == 2 || medicoS == 4) {
				print ("HOMI");
				GetComponent<AudioSource> ().clip = mp2;
				GetComponent<AudioSource> ().Play();
			}		
		}
		if (contadorLocal == 2) {
			if (medicoS == 0 || medicoS == 3 || medicoS == 5) {
				print ("MUIE");
				GetComponent<AudioSource> ().clip = fp3;
				GetComponent<AudioSource> ().Play();
			}
			if (medicoS == 1 || medicoS == 2 || medicoS == 4) {
				print ("HOMI");
				GetComponent<AudioSource> ().clip = mp3;
				GetComponent<AudioSource> ().Play();
			}		
		}
		if (contadorLocal == 3) {
			if (medicoS == 0 || medicoS == 3 || medicoS == 5) {
				print ("MUIE");
				GetComponent<AudioSource> ().clip = fp4;
				GetComponent<AudioSource> ().Play();
			}
			if (medicoS == 1 || medicoS == 2 || medicoS == 4) {
				print ("HOMI");
				GetComponent<AudioSource> ().clip = mp4;
				GetComponent<AudioSource> ().Play();
			}		
		}
		if (contadorLocal == 4) {
			if (medicoS == 0 || medicoS == 3 || medicoS == 5) {
				print ("MUIE");
				GetComponent<AudioSource> ().clip = fp5;
				GetComponent<AudioSource> ().Play();
			}
			if (medicoS == 1 || medicoS == 2 || medicoS == 4) {
				print ("HOMI");
				GetComponent<AudioSource> ().clip = mp5;
				GetComponent<AudioSource> ().Play();
			}		
		}
		if (contadorLocal == 5) {
            if (medicoS == 0 || medicoS == 3 || medicoS == 5)
            {
                print("MUIE");
                GetComponent<AudioSource>().clip = fp7;
                GetComponent<AudioSource>().Play();
            }
            if (medicoS == 1 || medicoS == 2 || medicoS == 4)
            {
                print("HOMI");
                GetComponent<AudioSource>().clip = mp7;
                GetComponent<AudioSource>().Play();
            }
        }
		if (contadorLocal == 6) {
            if (medicoS == 0 || medicoS == 3 || medicoS == 5)
            {
                print("MUIE");
                GetComponent<AudioSource>().clip = fp6;
                GetComponent<AudioSource>().Play();
            }
            if (medicoS == 1 || medicoS == 2 || medicoS == 4)
            {
                print("HOMI");
                GetComponent<AudioSource>().clip = mp6;
                GetComponent<AudioSource>().Play();
            }
		}
		if (contadorLocal == 7) {
			if (medicoS == 0 || medicoS == 3 || medicoS == 5) {
				print ("MUIE");
				GetComponent<AudioSource> ().clip = fp8;
				GetComponent<AudioSource> ().Play();
			}
			if (medicoS == 1 || medicoS == 2 || medicoS == 4) {
				print ("HOMI");
				GetComponent<AudioSource> ().clip = mp8;
				GetComponent<AudioSource> ().Play();
			}		
		}
		if (contadorLocal == 8) {
			if (medicoS == 0 || medicoS == 3 || medicoS == 5) {
				print ("MUIE");
				GetComponent<AudioSource> ().clip = fp9;
				GetComponent<AudioSource> ().Play();
			}
			if (medicoS == 1 || medicoS == 2 || medicoS == 4) {
				print ("HOMI");
				GetComponent<AudioSource> ().clip = mp9;
				GetComponent<AudioSource> ().Play();
			}		
		}
	}

	public void ReferenciaParaPularDeDialogo(){
		if(contadorDeProcedimento == 10){
			Debug.Log("nada não");
		}else{
            controledesom.Instancia.PlayOneShot(Acertou);
			dialogosDeProcedimento[contadorDeProcedimento].SetActive(false);
			contadorDeProcedimento++;
			conversaDeProcedimentos(contadorDeProcedimento);
		}
	}

	public void JanelaDeConversa(GameObject dialogo){
		dialogo.SetActive(true);
		referencia = dialogo;
	}

	public IEnumerator JanelaDeErro(GameObject[] dialogoDeErro){
		ProcedimentoErrado = 1;
		Carica.sprite = ReferenciaDaCaricatura.CaricaturaSelecionada[1]; //caricatura 1 corresponde a caricatura de erro
		GetComponent<AudioSource>().PlayOneShot(Errou);
		yield return new WaitForSeconds(1/2);
		todosDialogosDeProcedimento.SetActive(false);
		canvasDragDrop.SetActive(false);
		TodasJanelasDeErro.SetActive(true);
		dialogoDeErro[contadorDeErro].SetActive(true);
		referencia = dialogoDeErro[contadorDeErro];
		contadorDeErro++;
		if(contadorDeErro == 4)
			contadorDeErro = 0;
	}

	public void fechaJanelaDeErro(){
		ProcedimentoErrado = 0;
		Carica.sprite = ReferenciaDaCaricatura.CaricaturaSelecionada[0];
		referencia.SetActive(false);
		TodasJanelasDeErro.SetActive(false);
		todosDialogosDeProcedimento.SetActive(true);
		canvasDragDrop.SetActive(true);
	}

	public void abrePlacarFinal(){
		StartCoroutine(mostraMenu());
	}

	public IEnumerator mostraMenu(){
		yield return new WaitForSeconds(1);
		placar.SetActive(true);
		canvasDragDrop.SetActive(false);
		painelDeDialogos.SetActive(false);
		pauseMenu.SetActive(false);
		referenciaDoPlacar.EscrevePontuacao();
		//botaoDePause.SetActive(false);
	}
}
