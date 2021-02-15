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
	public GameObject garderob;

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

	/*mudr;
	voin;
	Jessi;
	Jackman;
	names;
	*/

	//public HistoryScript historyScript;
	void Awake()
	{
		//txt.text = "ggggggg \n dsadsad";
		// Remove the default message
		RemoveChildren();
		StartStory();
	}


	public void Update()
	{
		if (enableMousebtn)
		{
			if (Input.GetMouseButtonUp(0))

			{
				//	RemoveChildren();

				//RefreshView();
				//
				if (story.currentChoices.Count == 0)
				{
					RemoveChildren();
				}

				//RemoveChildren();
				if (story.canContinue)
				{
					//	RemoveChildren();

					string text = story.Continue();
					// This removes any white space from the text.
					//	text = text.Trim();
					// Display the text on screen!
					CreateContentView(text);
					//	

				}
				else
				{
					//RemoveChildren();
					//	RefreshView();

				}

				RefreshView();
			}
		}
        //if (garderob)
       // {
		//	enableMousebtn = false;

		//}
	}
	private void Start()
	{
		//RemoveChildren();
		if (story.canContinue)
		{

			string text = story.Continue();

			CreateContentView(text);


		}


		RefreshView();

	}
	// Creates a new Story object with the compiled story which we can then play!
	void StartStory()
	{

		//RemoveChildren();
		a = 0;
		story = new Story(inkJSONAsset.text);
		if (OnCreateStory != null) OnCreateStory(story);
		//story.variablesState["x"] = 0;
		//	story.variablesState["mudr"] = 0;

		//	
		//RemoveChildren();


	}

	// This is the main function called every time the story changes. It does a few things:
	// Destroys all the old content and choices.
	// Continues over all the lines of text, then displays all the choices. If there are no choices, the story is finished!
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
			for (int i = 0; i < story.currentChoices.Count; i++)
			{

				Choice choice = story.currentChoices[i];
				Button button = CreateChoiceView(choice.text.Trim());
				Debug.Log(choice.text.Trim());
				//	RectTransform uitransform = button.GetComponent<RectTransform>();
				//		Rect rectContainer = button.GetComponent<RectTransform>().rect;
				//rectContainer.height = 'the size you want';
				//	new Vector2(65, 0);
				//	uitransform.sizeDelta = new Vector2(, 0);
				//	Debug.Log(rectContainer.height);
				button.transform.position = new Vector2(0, i - a-2.4f);

				a = a + 1.8f;
				// Tell the button what to do when we press it
				button.onClick.AddListener(delegate
				{
					OnClickChoiceButton(choice);
				});

			}

		}
		// If we've read all the content and there's no choices, the story is finished!
		else
		{

		
			if (story.variablesState["gar"].ToString() == "1")
			{
				Debug.Log("garderob: " + story.variablesState["gar"].ToString());
				
				garderob.SetActive(true);
				enableMousebtn = false;
				personag.transform.position = new Vector2(personag.transform.position.x + 1.36f, personag.transform.position.y);
				RemoveChildren();

			}
            else
			{	
				enableMousebtn = true;
				
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
	void CreateContentView(string text)
	{
		//story.variablesState["name"] = "Mike";

		//txt.text = story.variablesState["name"].ToString();
		

		mudr = story.variablesState["mudr"].ToString();
		voin = story.variablesState["voin"].ToString();
		Jessi = story.variablesState["Jessi"].ToString();
		Jackman = story.variablesState["Jackman"].ToString();
		names = story.variablesState["name"].ToString();



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
		
	//	Debug.Log(GameObject.FindGameObjectWithTag("tagWhoSay").GetComponent<Text>());
		//	txt.text = story.variablesState["name"].ToString();
		/*if (story.variablesState["gar"].ToString() == "1")
		{
			Debug.Log("garderob: " + story.variablesState["gar"].ToString());
				
			garderob.SetActive(true);
			enableMousebtn = false;
		}*/
		//txtOnImage.text = storyText.text;
		//Debug.Log(storyText.text);
		StartCoroutine(tExtfind());
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
		garderob.SetActive(false);
		story.variablesState["gar"] = 0;
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

}
