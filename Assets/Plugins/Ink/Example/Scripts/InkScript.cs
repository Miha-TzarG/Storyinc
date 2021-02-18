using UnityEngine;
using UnityEngine.UI;
using System;
using Ink.Runtime;
using System.Collections;
using System.Collections.Generic;
// This is a super bare bones example of how to play and display a ink story in Unity.
public class InkScript : MonoBehaviour
{
	
	
	public static event Action<Story> OnCreateStory;
	//public string a;
	//public int b;
	

	public Camera cam;
	public GameObject garderobMenu;

	public bool GarderobSvernut;
	public GameObject PanelGarderob;
	public GameObject btnScernutGarderob;

	public GameObject PanelSettings;

	public GameObject personag;

	public string nm = "Mike";
	public Text txt;
	//public Text txtOnImage;
	public float a;
	public bool enableMousebtn;


	//****Staty
	public string mudr;
	public string voin;
	public string Jessi;
	public string Jackman;
	public string names;
	//*********************Zagtuzka image


	public List<NumLevel> numberLevel;


	public string url = "https://www.tzargor.ru/";
	public SpriteRenderer spLocation;
	public Sprite[] sprPersonazh;
	public string[] textPersonazh;
	public Sprite[] sprHeir;
	public string[] textHair;
	public Sprite[] sprDress;
	public string[] textDress;

	public string[] folder;

	public string[] texter;
	public Image img;
	public string atxt;
	//  [Obsolete]
	[Obsolete]
	WWW www;
	[Obsolete]
	WWW www2;

	public int zagruzka;

	public Text txtTime;
	//  public Slider slider;
	//  public Text progressText;
	public GameObject[] go;

	public GameObject canvasStartgame;

	public float izmenenieekrana;
	public Image panelZatemnenie;
	public GameObject ActivePanelZatemnenie;
	//public GameObject dwnloadImage;;
	/*mudr;
	voin;
	Jessi;
	Jackman;
	names;
	*/

	//public HistoryScript historyScript;
	void Awake()
	{
		//	dwnloadImage = GameObject.FindGameObjectWithTag("gameManager").GetComponent<DwnLoadpict>();
		StartCoroutine(LoadImages());

		


	}
	IEnumerator LoadImages()
	{

		for (int k = 0; k < 12; k++)
		{
			
			url = "https://www.tzargor.ru/Sprites/Location/0/Location/" + numberLevel[0].nameLevelLocation[k];
			// www2 = new WWW(url);
			www2 = new WWW(url);

			// Ожидаем загрузку ресурса
			yield return www2;
			var tex2 = www2.texture;

			// if (!www2.isDone)
			// {
			// Создаем спрайт из текстуры
			var mySprite2 = Sprite.Create(tex2, new Rect(0.0f, 0.0f, tex2.width, tex2.height), new Vector2(0.5f, 0.5f), 100.0f);
			// В подготовленный spriteRenderer вставляем спрайт
			numberLevel[0].spriteLevelLocation[k] = mySprite2;
			zagruzka = zagruzka + 4;
			txtTime.text = zagruzka.ToString();
			//}
		}
		/*    if (!www2.isDone)
			{
				//       zagruzka = Mathf.RoundToInt(www2.progress * 100);
				Debug.Log("DownLoad2: " + Mathf.RoundToInt(www2.progress * 100) + "%");

			}
			else Debug.Log("Download2 100%");*/
		//   }
		//   numberLevel[0].spriteLevelLocation[4]

		//******************************************
		for (int i = 0; i < 3; i++)
		{
			for (int j = 0; j < 4; j++)
			{

				if (i == 0)
				{
					atxt = textPersonazh[j];
					url = "https://www.tzargor.ru/Sprites/Personazh/" + folder[i] + "/" + atxt;
					www = new WWW(url);

					// Ожидаем загрузку ресурса
					yield return www;
					var tex = www.texture;
					// Создаем спрайт из текстуры
					var mySprite = Sprite.Create(tex, new Rect(0.0f, 0.0f, tex.width, tex.height), new Vector2(0.5f, 0.5f), 100.0f);
					// В подготовленный spriteRenderer вставляем спрайт
					sprPersonazh[j] = mySprite;
					zagruzka = zagruzka + 5;
					txtTime.text = zagruzka.ToString();
				}
				if (i == 1)
				{
					atxt = textHair[j];
					url = "https://www.tzargor.ru/Personazh/" + folder[i] + "/" + atxt;
					www = new WWW(url);

					// Ожидаем загрузку ресурса
					yield return www;
					var tex = www.texture;
					// Создаем спрайт из текстуры
					var mySprite = Sprite.Create(tex, new Rect(0.0f, 0.0f, tex.width, tex.height), new Vector2(0.5f, 0.5f), 100.0f);
					// В подготовленный spriteRenderer вставляем спрайт
					sprHeir[j] = mySprite;
					zagruzka = zagruzka + 5;
					txtTime.text = zagruzka.ToString();
				}
				if (i == 2)
				{
					atxt = textDress[j];
					url = "https://www.tzargor.ru/Personazh/" + folder[i] + "/" + atxt;
					www = new WWW(url);

					// Ожидаем загрузку ресурса
					yield return www;
					var tex = www.texture;
					// Создаем спрайт из текстуры
					var mySprite = Sprite.Create(tex, new Rect(0.0f, 0.0f, tex.width, tex.height), new Vector2(0.5f, 0.5f), 100.0f);
					// В подготовленный spriteRenderer вставляем спрайт
					sprDress[j] = mySprite;
					zagruzka = zagruzka + 5;
					txtTime.text = zagruzka.ToString();
					if (zagruzka >= 100)
					{
						zagruzka = 100;
						txtTime.text = zagruzka.ToString();
						canvasStartgame.SetActive(false);
						
					}
				}

				// Debug.Log(folder[i]+"  " + a);
			}
			// zagruzka = zagruzka + 6;
		}
		/*   while (!www.isDone)
		   {

			   float progress = Mathf.Clamp01(www.progress / 0.9f);
			   slider.value = progress;
			   progressText.text = (progress * 100f).ToString("F0") + "%";

			   yield return null;
		   }*/

		/* if (!www.isDone)
		 {

			 Debug.Log("DownLoad2: " + Mathf.RoundToInt(www.progress * 100) + "%");

		 }
		 else Debug.Log("Download2 100%");*/
		RemoveChildren();
		StartStory();
			if (story.canContinue)
		{

			string text = story.Continue();

			CreateContentView(text);


		}


		RefreshView();
	}


	public void Update()
	{
		//txt.text = zagruzka.ToString();
		if (enableMousebtn)
		{
			if (Input.GetMouseButtonUp(0))

			{
				if (story.currentChoices.Count == 0)
				{
					RemoveChildren();
				}

			
				if (story.canContinue)
				{
				

					string text = story.Continue();
				
					CreateContentView(text);
					//	

				}
				else
				{
					
				}

				RefreshView();
			}
		}
     
	}
	private void Start()
	{
		

	

	}

	void StartStory()
	{

		a = 0;
		story = new Story(inkJSONAsset.text);
		if (OnCreateStory != null) OnCreateStory(story);
	

	}

	void RefreshView()
	{
		
		a = 0;
		// Remove all the UI on screen
		//RemoveChildren();

		// Read all the content until we can't continue any more


		//	while (story.canContinue)
		/*	 if(story.canContinue)
			{

				string text = story.Continue();
					// This removes any white space from the text.
				//	text = text.Trim();
					// Display the text on screen!
					CreateContentView(text);

				// Continue gets the next line of the story

		}*/
		//Debug.Log(story.currentChoices.Count);
		// Display all the choices, if there are any!

		if (story.currentChoices.Count > 0)
		{

			enableMousebtn = false;
			ActivePanelZatemnenie.SetActive(false);
			if (story.variablesState["garderob"].ToString() == "1")
			{
				Debug.Log("garderob: " + story.variablesState["garderob"].ToString());

				garderobMenu.SetActive(true);
				enableMousebtn = false;
				personag.transform.position = new Vector2(personag.transform.position.x + 1.36f, personag.transform.position.y);
				RemoveChildren();

			}
			else
			{
				
				for (int i = 0; i < story.currentChoices.Count; i++)
				{

					Choice choice = story.currentChoices[i];
					Button button = CreateChoiceView(choice.text.Trim());
					//	Debug.Log(choice.text.Trim());
					//	RectTransform uitransform = button.GetComponent<RectTransform>();
					//		Rect rectContainer = button.GetComponent<RectTransform>().rect;
					//rectContainer.height = 'the size you want';
					//	new Vector2(65, 0);
					//	uitransform.sizeDelta = new Vector2(, 0);
					//	Debug.Log(rectContainer.height);
					button.transform.position = new Vector2(0, i - a - 2.4f);

					a = a + 1.8f;
					// Tell the button what to do when we press it
					button.onClick.AddListener(delegate
					{
						OnClickChoiceButton(choice);
					});

				}
			}
		}
		// If we've read all the content and there's no choices, the story is finished!
		else
		{

			
			if (story.variablesState["garderob"].ToString() == "1")
			{
				Debug.Log("garderob: " + story.variablesState["garderob"].ToString());

				garderobMenu.SetActive(true);
				enableMousebtn = false;
				personag.transform.position = new Vector2(personag.transform.position.x + 1.36f, personag.transform.position.y);
				RemoveChildren();

			}
            else
			{	
				enableMousebtn = true;
				ActivePanelZatemnenie.SetActive(true);

			}
			/*if (story.canContinue)
			{
				//	RemoveChildren();

				string text = story.Continue();
				// This removes any white space from the text.
				//	text = text.Trim();
				// Display the text on screen!
				CreateContentView(text);
				//	

			}*/
			//	Button choice = CreateChoiceView("End of story.\nRestart?");
			//choice.onClick.AddListener(delegate {
			//	StartStory();
			//	});
		}
		/*	int childCount = panel.transform.childCount;
			if (childCount == 0)
			{
				Button choice = CreateChoiceView("End of story.\nRestart?");
				choice.onClick.AddListener(delegate {
					StartStory();
				});
			}*/

	//	Debug.Log("Child: " + panel.transform.childCount);
	}

	// When we click the choice button, tell the story to choose that choice!
	void OnClickChoiceButton(Choice choice)
	{
		//	a = story.variablesState["mudr"].ToString();

		//	Debug.Log("a:" + a);
	
		a = 0;

		story.ChooseChoiceIndex(choice.index);

		RefreshView();

	}


	// Creates a textbox showing the the line of text
	public int numLocation;
	public int prevnumLocation;

	public int numMusic;
	public int previousnumMusic;
	void CreateContentView(string text)
	{
		izmenenieekrana = 0;
		//story.variablesState["name"] = "Mike";

		//txt.text = story.variablesState["name"].ToString();


		/*mudr = story.variablesState["mudr"].ToString();
		voin = story.variablesState["voin"].ToString();
		Jessi = story.variablesState["Jessi"].ToString();
		Jackman = story.variablesState["Jackman"].ToString();*/
		names = story.variablesState["name"].ToString();
		
		numLocation = int.Parse(story.variablesState["location"].ToString());
		numMusic = int.Parse(story.variablesState["music"].ToString());
		
		
		
		if (prevnumLocation != numLocation)
		{
			StartCoroutine(ZatemnenieEkrana());
		}
		else spLocation.GetComponent<SpriteRenderer>().sprite = numberLevel[0].spriteLevelLocation[numLocation];

		if (previousnumMusic != numMusic)
		{
			for (int i = 0; i < 14; i++)
			{
			//	numberLevel[0].audioSource[numMusic].enabled = false;
				if (numMusic == i)
				{
					StartCoroutine(Startmusic());
					Debug.Log("Music: " + i + "---" + numMusic);

					//numberLevel[0].audioSource[i].enabled = true;
					//previousnumMusic = numMusic;
				}
				if (numMusic != i)
				{
						numberLevel[0].audioSource[i].Stop();
					}
			}
			//numberLevel[0].audioSource[numMusic].enabled = true;
		
		}
		//else numberLevel[0].audioSource[numMusic].enabled = false;
		//StartCoroutine(ZatemnenieEkrana());
		//spLocation.GetComponent<SpriteRenderer>().sprite = numberLevel[0].spriteLevelLocation[numLocation];

		//Debug.Log("mudr: " + mudr + " -- " + "voin: " + voin + " -- " + "Jessi: " + Jessi + " -- " + "Jackman: " + mudr);
		//if (a == "Гвен")
		//{
		//	txt.text = nm;
		//	}
		//	else
		//	txt.text = a;
		//	Debug.Log("Name " + a);


		Text storyText = Instantiate(textPrefab) as Text;
		//txt = GameObject.FindGameObjectWithTag("tagWhoSay").GetComponent<Text>();

		storyText.text = text;
	
		storyText.transform.SetParent(panel.transform, false);
	
		StartCoroutine(tExtfind());
	}

	IEnumerator Startmusic()
	{
		yield return new WaitForSeconds(1f);
		//numberLevel[0].audioSource[numMusic].enabled = false;
	//for (int i = 0; i < 14; i++)
	//	{
		numberLevel[0].audioSource[numMusic].Play();
		//	if (numMusic == i)
		//	{
				//Debug.Log("Music: " + i + "---" + numMusic);
			
			//	numberLevel[0].audioSource[numMusic].enabled = true;
				//previousnumMusic = numMusic;
			//}
		//	else
			//{
		//		numberLevel[0].audioSource[numMusic].enabled = false;
		//	}
		//}
		previousnumMusic = numMusic;
	}
		IEnumerator ZatemnenieEkrana()
	{
		yield return new WaitForSeconds(0.01f);

		if(izmenenieekrana >= 0 && izmenenieekrana < 1)
		{
		
			panelZatemnenie.GetComponent<Image>().color = new Color(0f, 0f, 0f, izmenenieekrana);
			izmenenieekrana = izmenenieekrana + 0.02f;
			StartCoroutine(ZatemnenieEkrana());
		}
		if (izmenenieekrana >= 1)
		{
	
			StopCoroutine(ZatemnenieEkrana());
			panelZatemnenie.GetComponent<Image>().color = new Color(0f, 0f, 0f, 0f);
				
		
			prevnumLocation = numLocation;
		
			spLocation.GetComponent<SpriteRenderer>().sprite = numberLevel[0].spriteLevelLocation[numLocation];
		

		}


	}

	IEnumerator tExtfind()
    {
		yield return new WaitForSeconds(0.002f);
		
		txt = GameObject.FindGameObjectWithTag("tagWhoSay").GetComponent<Text>();
		txt.text = story.variablesState["name"].ToString(); 
	}
	public void Exitgarderob()
    {
		enableMousebtn = true;
		garderobMenu.SetActive(false);
		story.variablesState["garderob"] = 0;
		personag.transform.position = new Vector2(personag.transform.position.x - 1.36f, personag.transform.position.y);
		/*if (story.canContinue)
		{

			string text = story.Continue();

			CreateContentView(text);


		}
		

		RefreshView();*/
		//Start();
	}

	public void SvernutGarderob()
    {
		if (!GarderobSvernut)
		{
			PanelGarderob.transform.position = new Vector2(PanelGarderob.transform.position.x, PanelGarderob.transform.position.y - 1000);
			btnScernutGarderob.transform.position = new Vector2(btnScernutGarderob.transform.position.x, btnScernutGarderob.transform.position.y - 900);
			GarderobSvernut = true;
			btnScernutGarderob.transform.rotation = Quaternion.Euler(0, 0, -90);
			//btnScernutGarderob.transform.Rotate(0f, 0f, -90f);
		}
		else
		{
			PanelGarderob.transform.position = new Vector2(PanelGarderob.transform.position.x, PanelGarderob.transform.position.y + 1000);
			btnScernutGarderob.transform.position = new Vector2(btnScernutGarderob.transform.position.x, btnScernutGarderob.transform.position.y + 900);
			GarderobSvernut = false;
			btnScernutGarderob.transform.rotation = Quaternion.Euler(0, 0, 90);
			//btnScernutGarderob.transform.Rotate(0f, 0f, 90f);
		}
	}

	// Creates a button showing the choice text
	Button CreateChoiceView(string text)
	{

		// Creates the button from a prefab
		Button choice = Instantiate(buttonPrefab) as Button;
		choice.transform.SetParent(panel.transform, false);

		// Gets the text from the button prefab
		Text choiceText = choice.GetComponentInChildren<Text>();
		choiceText.text = text;

		// Make the button expand to fit the text
		HorizontalLayoutGroup layoutGroup = choice.GetComponent<HorizontalLayoutGroup>();
		layoutGroup.childForceExpandHeight = false;

		return choice;
	}

	// Destroys all the children of this gameobject (all the UI)
	void RemoveChildren()
	{
		int childCount = panel.transform.childCount;

		for (int i = 0; i < childCount; i++)
		//	for (int i = childCount-2; i >= 0; --i)
		{
			GameObject.Destroy(panel.transform.GetChild(i).gameObject);
		}
		txt = null;

	}

	public void OpenSettings()
    {
		enableMousebtn = false;
		PanelSettings.SetActive(true);


	}
	public void CloseSettings()
	{
		
		PanelSettings.SetActive(false);
		
		StartCoroutine(EnableMousebtnCouratina());
	}

	IEnumerator EnableMousebtnCouratina()
    {
		yield return new WaitForSeconds(0.1f);
		enableMousebtn = true;
	}

	[SerializeField]
	private TextAsset inkJSONAsset = null;
	public Story story;

	//[SerializeField]
	//private panel panel = null;
	[SerializeField]
	private GameObject panel = null;

	// UI Prefabs
	[SerializeField]
	private Text textPrefab = null;
	[SerializeField]
	private Button buttonPrefab = null;

	//[SerializeField]
//	public DwnLoadpict dwn;

}

[System.Serializable]
public struct NumLevel
{

	public Sprite[] spriteLevelLocation;
	public string[] nameLevelLocation;
	public AudioSource[] audioSource;
	public AudioClip[] audioClip;
}